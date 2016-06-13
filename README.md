---
title: PureCloud API SDK - C&#35;
---

[![NuGet Badge](https://buildstats.info/nuget/PureCloudApiSdk)](https://www.nuget.org/packages/PureCloudApiSdk/)

Documentation can be found at [https://developer.mypurecloud.com/api/rest/client-libraries/csharp/latest/](https://developer.mypurecloud.com/api/rest/client-libraries/csharp/latest/)

## Install Using nuget

~~~
install-package PureCloudApiSdk
~~~

Package info can be found at [https://www.nuget.org/packages/PureCloudApiSdk/](https://www.nuget.org/packages/PureCloudApiSdk/)

## Using the Library

### Referencing the Library

If you've used the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) to install the package, there are no additional steps.

If you're building from source or otherwise not using nuget, reference your version of ININ.PureCloudApi.dll in your project and add references or install packages for [RestSharp](http://www.nuget.org/packages/RestSharp/) and [JSON.NET](http://www.nuget.org/packages/Newtonsoft.Json/).

### Authenticating

#### Implicit Grant

**Use when...** 

* The app is authenticating as a human
* The app is running locally on the user's computer
* The app has an embedded browser to use for OAuth

If the application will be authenticating as a human, the [Implicit Grant](http://developer.mypurecloud.com/api/rest/authorization/use-implicit-grant.html) OAuth 2 flow may be used from an embeddable browser. The access token can be retrieved from the querystring of the redirected URL in the browser control. This process is implemented in the [PureCloud API dotNET OAuth Control](https://github.com/MyPureCloud/purecloud_api_dotnet_oauth_control) project.

See the browser control implemented in a winforms project in the [C# OAuth With Implicit Grant](https://developer.mypurecloud.com/api/tutorials/oauth-implicit/#csharp) tutorial.

#### Authorization Code Grant

**Use when...**

* The app is authenticating as a human
* The app is served via a web server, such as IIS
* There is server-side code that will be making API requests

The [Authorization Code Grant](https://developer.mypurecloud.com/api/rest/authorization/use-authorization-code.html) will return the auth code in the querystring to allow the server-side code to make the request to get an access token with the auth code, and prevent the access token from being known by the client-side. The process for this is:

* Redirect user to OAuth login page
* When the user is redirected to your URL, retrieve the auth code from the querystring on the server side
* On the server side, exchange the auth code for an access token

##### ASP.NET tutorial

This is a tutorial of how to use an Authorization Code Grant without using the SDK: [https://developer.mypurecloud.com/api/tutorials/oauth-auth-code/#csharp](https://developer.mypurecloud.com/api/tutorials/oauth-auth-code/#csharp)

##### Example with the SDK

In addition to the process in the tutorial above, swap out the POST to "https://login." + host + "/oauth/token" with the following:

Use the following namespaces:

~~~
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Extensions;
~~~

Then call the _PostToken_ extension method of _ApiClient_, including the redirect URI and auth code:

~~~
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo",
  "http://redirecturi.com/",
  "6Zxcb0oASMBI55wQJ6bVmOmO57k8CxXBKgzDKtYXbtk");
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
~~~

#### Client Credentials Grant

**Use when...**

* The app is authenticating as a non-human (e.g. a service, scheduled task, or other non-UI application)

For headless and non-user applications, the [Client Credentials Grant](http://developer.mypurecloud.com/api/rest/authorization/use-client-credentials.html) can be used via the AuthExtensions extension methods.

First, use the following namespaces:

~~~
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Extensions;
~~~

Then call the _PostToken_ extension method of _ApiClient_, leaving the redirect URI and auth code blank:

~~~
var accessTokenInfo = Configuration.Default.ApiClient.PostToken("18a4c365-7ea3-4f0g-9fb7-884fb4d2e9c6",
  "M7FfdYQyL5TA6BdbEZ8M9-Wx4uZai1rNQ7jcuFdcJJo");
Console.WriteLine("Access token=" + accessTokenInfo.AccessToken);
~~~

### Making Requests

#### Setting the Environment

If the SDK should interact with an environment other than mypurecloud.com (mypurecloud.ie, for example), specify the environment before doing anything else with the SDK:

~~~
Configuration.Default.ApiClient.RestClient.BaseUrl = new Uri("https://api.mypurecloud.ie");
~~~

#### Setting the Access Token

Once an access token has been obtained from one of the OAuth methods, it must be set in the SDK's configuration.

~~~
ININ.PureCloudApi.Client.Configuration.Default.AccessToken = "BL4Cb3EQIQFlqIItaj-zf5eIhAiP96zk3333QImd24P99ojbFHtpgUTJdRIkuUYfXMy0afEnZcWnEQ";
~~~

#### Invoking the API

There are two steps to making requests:

1. Instantiate one of the API classes in the ININ.PureCloudApi.Api namespace
2. Call the methods on the API object

Example of getting the authenticated user's information:

~~~
// Instantiate instance of the Users API
var usersApi = new UsersApi();

// Get the logged in user
var me = usersApi.GetMe();
Console.WriteLine($"Hello, {me.DisplayName}");
~~~

## SDK Information

### REST Requests

The SDK library uses [RestSharp](http://restsharp.org/) to make the REST reqests. The majority of this work is done in [ApiClient.cs](https://github.com/MyPureCloud/purecloud_api_sdk_csharp/blob/master/build/src/main/csharp/ININ/PureCloudApi/Client/ApiClient.cs)

### Building from Source

#### The Quick Way

The quick way is great for compiling using a script or if you just prefer working from the command line.

1. Clone the repo
2. Run [compile.bat](https://github.com/MyPureCloud/purecloud_api_sdk_csharp/blob/master/build/compile.bat)

#### The Other Way

If you're working inside Visual Studio, adding the files to your project allows you to edit and build inside an IDE.

1. Clone the repo
2. Add all of the .cs files in the build directory to a project in Visual Studio
3. Add references for JSON.NET and RestSharp
4. Build the project in Visual Studio

### SDK Source Code Generation

The source code for the SDK is created using the [swagger-codegen](https://github.com/MyPureCloud/swagger-codegen) project.
