var api = require('github-api-promise');
var dateFormat = require('dateformat');
var fs = require('fs');
var archiver = require('archiver');
var Q = require('q');

var dFormat = 'dddd, mmmm dS yyyy';
var tFormat = 'h:MM:ss TT';

api.config.owner = 'MyPureCloud';
api.config.repo = 'PureCloudApiLibrary_CSharp';

main();



function main() {
	var version = '0.0.0.0';

	// Parse args
	process.argv.forEach(function (val, index, array) {
		if (stringStartsWith(val, '/version=')) {
			version = val.substring(9);
		} else if (stringStartsWith(val, '/token=')) {
			api.config.token = val.substring(7);
		}
	});

	// Create zip for release
	var zipFileName = version + '.zip'
	var zipFilePath = './bin/' + zipFileName;
	zipReleaseFiles(zipFilePath)
		.then(function() {
			var createReleaseOptions = {
				"tag_name": version,
				"target_commitish": "master",
				"name": version,
				"body": "Jenkins build " + version,
				"draft": false,
				"prerelease": false
			};

			api.repos.releases.createRelease(createReleaseOptions)
				.then(function(res) {
					logRelease(res, 'Created ');

					api.repos.releases.uploadReleaseAsset(
						res.upload_url, 
						zipFileName, 
						'Release binaries', 
						zipFilePath, 
						'application/zip')
						.then(function(res) {
							logAsset(res, 'Uploaded ');
						}, 
						function(err) {
							console.log('Request failed: ' + err);
						});
				}, 
				function(err) {
					console.log('Request failed: ' + err);
					throw err;
				});
		});
}

function zipReleaseFiles(zipPath) {
	var deferred = Q.defer();

	var output = fs.createWriteStream(zipPath);
	var archive = archiver('zip');

	// Callback for file write ended
	output.on('close', function() {
		console.log(zipPath + ' written with ' + archive.pointer() + ' total bytes');
		deferred.resolve();
	});

	// Callback for file write error
	archive.on('error', function(err) {
		deferred.reject(err);
	});

	archive.pipe(output);

	// Add files to archive and write it
	archive
		.append(fs.createReadStream('./build/bin/ININ.PureCloudApi.dll'), { name: 'ININ.PureCloudApi.dll' })
		.append(fs.createReadStream('./build/bin/ININ.PureCloudApi.xml'), { name: 'ININ.PureCloudApi.xml' })
		.append(fs.createReadStream('./build/bin/Newtonsoft.Json.dll'), { name: 'Newtonsoft.Json.dll' })
		.append(fs.createReadStream('./build/bin/RestSharp.dll'), { name: 'RestSharp.dll' })
		.finalize();

	return deferred.promise;
}

// Log a single release
function logRelease(release, prefix) {
	if (prefix) {
		if (prefix.substring(prefix.length - 1) != ' ') {
			prefix += ' ';
		}
	} else {
		prefix = '';
	}
	console.log(prefix + 'release #' + release.id + ', "' + release.name + '", tag: ' + release.tag_name + ', published on ' + dateFormat(release.published_at, dFormat) + ' at ' + dateFormat(release.published_at, tFormat));
}

// Log a single asset
function logAsset(asset) {
	console.log('Asset "' + asset.name + '" (' + asset.label + ') #' + asset.id + ' uploaded by ' + asset.uploader.login + ' on ' + dateFormat(asset.updated_at, dFormat) + ' at ' + dateFormat(asset.updated_at, tFormat));
}

function stringStartsWith (string, prefix) {
    return string.slice(0, prefix.length) == prefix;
}