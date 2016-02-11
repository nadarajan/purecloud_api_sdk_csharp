var wget = require('wget');
var mkdirp = require('mkdirp');
var fs = require('fs');
var Q = require('q');
var pclib = require('purecloud-api-sdk-common');
var pclibSwaggerVersion = pclib.swaggerVersioning();
var path = require('path');

var progressTracker = 0;
var oldSwaggerPath = 'lib/swagger-old.json';
var newSwaggerPath = 'lib/swagger.json';
var versionFilePath = 'buildScripts/version.json';

downloadFile(
	'http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.1.4/swagger-codegen-cli-2.1.4.jar',
	'bin/swagger-codegen-cli.jar')
	.then(function() {
		//TODO: allow this to proceed once the swagger file is fixed
		return;
		// Download the latest swagger
		return downloadFile('https://api.mypurecloud.com/api/v1/docs/swagger', newSwaggerPath);
	})
	.then(updateVersion)
	.then(writeConfig)
	.then(function() {
		console.log('prebuild script complete');
		// Have to explicitly exit because promises keep the node process running
		process.exit(0);
	})
	.catch(function(error) {
		console.log('Error encountered in prebuild script!');
		console.log(error.stack);
		process.exit(1);
	});


function downloadFile(url, output, append) {
	var deferred = Q.defer();

	if (append != true) {
		if (fileExists(output)) {
			console.log('Deleting ' + output);
			fs.unlinkSync(output);
		} else {
			console.log('file does not exist: ' + output)
		}
	}
	progressTracker = 0;
	var dirPath = '';
	if (output.indexOf('/') > -1)
		dirPath = output.substring(0, output.lastIndexOf("/"));
	else if (output.indexOf('\\') > -1)
		dirPath = output.substring(0, output.lastIndexOf("\\"));
	else
		console.log('output path does not contain a directory');

	mkdirp(dirPath, function(err) {
		if (err) {
			console.log('Fatal error making directory: ');
			console.log(err);
			deferred.reject(err);
			return;
		}
	});

	console.log('Downloading ' + url);
	var download = wget.download(url, output);
	download.on('error', function(err) {
		console.log('Fatal error downloading file: ');
	    console.log(err);
		deferred.reject(err);
		return;
	});
	download.on('end', function(output) {
		/*Jenkins doesn't support clearLine. Lame.
		process.stdout.clearLine();
		process.stdout.cursorTo(0);
		*/
	    console.log('File downloaded to : ' + output);
	    deferred.resolve();
		return;
	});
	download.on('progress', function(progress) {
		// Report progress at 5% intervals
		var p = Number((progress * 100).toFixed(0));
		var progressInterval = 5;
		if (p > progressTracker && p % progressInterval == 0) {
			progressTracker = p;
			console.log(progressTracker + '%');
			/* Jenkins doesn't support clearLine. Lame.
			process.stdout.clearLine();
			process.stdout.cursorTo(0);
			var completed = new Array((progressTracker / progressInterval) + 1).join("█");
			var left = new Array(((100 - progressTracker) / progressInterval) + 1).join(" ");
			process.stdout.write('Progress [' + completed + left + '] ' + progressTracker + '%');  // write text
			*/
		}
	});

	return deferred.promise;
}

function updateVersion() {
	var deferred = Q.defer();

	pclib.updateSwaggerAndVersion("swagger.json", "version.json", "mypurecloud.com", function(hasChanges){
        var version = pclibSwaggerVersion.getVersionString("version.json");

        if(hasChanges){
            console.log("has changes, new version: " + version)
            fs.writeFileSync("newVersion.md", version);

			versionJson = JSON.parse(fs.readFileSync("version.json", 'UTF-8'))

			var notes = pclibSwaggerVersion.getChangeReadmeText(versionJson.changelog[version]);
			fs.writeFileSync("RELEASENOTES", notes);
        }else{
            console.log("no changes, still version " + version)
        }

		 deferred.resolve();
    });

	return deferred.promise;
}

function writeConfig() {
	var deferred = Q.defer();

	var v = pclibSwaggerVersion.getVersionString("version.json");
	console.log('Package version: ' + v);
	fs.writeFileSync('bin/VERSION', v, 'UTF-8');
	var config = {
		"packageName":"ININ.PureCloudApi",
		"packageVersion":v,
		"packageTitle":"PureCloud Public API Library",
	    "packageProductName":"PureCloudPublicAPILibrary",
	    "packageDescription":"A .NET library to interface with the PureCloud Public API",
	    "packageCompany":"Interactive Intelligence, Inc.",
	    "packageCopyright":"Copyright © Interactive Intelligence, Inc. 2015"
	};

	fs.writeFile('bin/config-csharp.json', JSON.stringify(config), function(err) {
		if (err) {
			console.log('Failed to write config file!');
			console.log(err);
			deferred.reject(err);
			return;
		}

		console.log('Config file written');
	    deferred.resolve();
		return;
	});

	return deferred.promise;
}

function stringStartsWith(string, prefix) {
    return string.slice(0, prefix.length) == prefix;
}

function fileExists(filepath) {
	if (!filepath) return false

	try {
		return fs.statSync(filepath).isFile()
	} catch (e) {
		return false
	}
}
