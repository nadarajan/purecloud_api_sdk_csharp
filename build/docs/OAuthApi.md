# ININ.PureCloudApi.Api.OAuthApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteClientsClientId**](OAuthApi.md#deleteclientsclientid) | **DELETE** /api/v2/oauth/clients/{clientId} | Delete OAuth Client |
| [**DeleteOkta**](OAuthApi.md#deleteokta) | **DELETE** /api/v2/identityproviders/okta | Delete Okta Identity Provider |
| [**DeleteOnelogin**](OAuthApi.md#deleteonelogin) | **DELETE** /api/v2/identityproviders/onelogin | Delete OneLogin Identity Provider |
| [**DeleteProviderId**](OAuthApi.md#deleteproviderid) | **DELETE** /api/v2/identityproviders/{providerId} | Delete an identity provider |
| [**DeletePurecloud**](OAuthApi.md#deletepurecloud) | **DELETE** /api/v2/identityproviders/purecloud | Delete PureCloud Identity Provider |
| [**DeleteSalesforce**](OAuthApi.md#deletesalesforce) | **DELETE** /api/v2/identityproviders/salesforce | Delete Salesforce Identity Provider |
| [**GetClients**](OAuthApi.md#getclients) | **GET** /api/v2/oauth/clients | The list of OAuth clients |
| [**GetClientsClientId**](OAuthApi.md#getclientsclientid) | **GET** /api/v2/oauth/clients/{clientId} | Get OAuth Client |
| [**GetIdentityproviders**](OAuthApi.md#getidentityproviders) | **GET** /api/v2/identityproviders | The list of identity providers |
| [**GetOkta**](OAuthApi.md#getokta) | **GET** /api/v2/identityproviders/okta | Get Okta Identity Provider |
| [**GetOnelogin**](OAuthApi.md#getonelogin) | **GET** /api/v2/identityproviders/onelogin | Get OneLogin Identity Provider |
| [**GetProviderId**](OAuthApi.md#getproviderid) | **GET** /api/v2/identityproviders/{providerId} | Get an identity provider |
| [**GetPurecloud**](OAuthApi.md#getpurecloud) | **GET** /api/v2/identityproviders/purecloud | Get PureCloud Identity Provider |
| [**GetSalesforce**](OAuthApi.md#getsalesforce) | **GET** /api/v2/identityproviders/salesforce | Get Salesforce Identity Provider |
| [**PostClients**](OAuthApi.md#postclients) | **POST** /api/v2/oauth/clients | Create OAuth client |
| [**PostClientsClientIdSecret**](OAuthApi.md#postclientsclientidsecret) | **POST** /api/v2/oauth/clients/{clientId}/secret | Regenerate Client Secret |
| [**PutClientsClientId**](OAuthApi.md#putclientsclientid) | **PUT** /api/v2/oauth/clients/{clientId} | Update OAuth Client |
| [**PutOkta**](OAuthApi.md#putokta) | **PUT** /api/v2/identityproviders/okta | Update/Create Okta Identity Provider |
| [**PutOnelogin**](OAuthApi.md#putonelogin) | **PUT** /api/v2/identityproviders/onelogin | Update/Create OneLogin Identity Provider |
| [**PutProviderId**](OAuthApi.md#putproviderid) | **PUT** /api/v2/identityproviders/{providerId} | Update an identity provider |
| [**PutPurecloud**](OAuthApi.md#putpurecloud) | **PUT** /api/v2/identityproviders/purecloud | Update/Create PureCloud Identity Provider |
| [**PutSalesforce**](OAuthApi.md#putsalesforce) | **PUT** /api/v2/identityproviders/salesforce | Update/Create Salesforce Identity Provider |
{: class="table table-striped"}

<a name="DeleteClientsClientId"></a>
## void DeleteClientsClientId (string clientId)

Delete OAuth Client



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteClientsClientIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            {
                // Delete OAuth Client
                apiInstance.DeleteClientsClientId(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeleteClientsClientId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteOkta"></a>
## void DeleteOkta ()

Delete Okta Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteOktaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete Okta Identity Provider
                apiInstance.DeleteOkta();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeleteOkta: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteOnelogin"></a>
## void DeleteOnelogin ()

Delete OneLogin Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteOneloginExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete OneLogin Identity Provider
                apiInstance.DeleteOnelogin();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeleteOnelogin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteProviderId"></a>
## void DeleteProviderId ()

Delete an identity provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteProviderIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete an identity provider
                apiInstance.DeleteProviderId();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeleteProviderId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeletePurecloud"></a>
## void DeletePurecloud ()

Delete PureCloud Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeletePurecloudExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete PureCloud Identity Provider
                apiInstance.DeletePurecloud();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeletePurecloud: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="DeleteSalesforce"></a>
## void DeleteSalesforce ()

Delete Salesforce Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteSalesforceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Delete Salesforce Identity Provider
                apiInstance.DeleteSalesforce();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.DeleteSalesforce: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="GetClients"></a>
## [**OAuthClientEntityListing**](OAuthClientEntityListing.html) GetClients ()

The list of OAuth clients



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetClientsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // The list of OAuth clients
                OAuthClientEntityListing result = apiInstance.GetClients();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetClients: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthClientEntityListing**](OAuthClientEntityListing.md)

<a name="GetClientsClientId"></a>
## [**OAuthClient**](OAuthClient.html) GetClientsClientId (string clientId)

Get OAuth Client



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetClientsClientIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            {
                // Get OAuth Client
                OAuthClient result = apiInstance.GetClientsClientId(clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetClientsClientId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.md)

<a name="GetIdentityproviders"></a>
## [**OAuthProviderEntityListing**](OAuthProviderEntityListing.html) GetIdentityproviders ()

The list of identity providers



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetIdentityprovidersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // The list of identity providers
                OAuthProviderEntityListing result = apiInstance.GetIdentityproviders();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetIdentityproviders: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthProviderEntityListing**](OAuthProviderEntityListing.md)

<a name="GetOkta"></a>
## [**Okta**](Okta.html) GetOkta ()

Get Okta Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOktaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get Okta Identity Provider
                Okta result = apiInstance.GetOkta();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOkta: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Okta**](Okta.md)

<a name="GetOnelogin"></a>
## [**OneLogin**](OneLogin.html) GetOnelogin ()

Get OneLogin Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetOneloginExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get OneLogin Identity Provider
                OneLogin result = apiInstance.GetOnelogin();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetOnelogin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OneLogin**](OneLogin.md)

<a name="GetProviderId"></a>
## [**OAuthProvider**](OAuthProvider.html) GetProviderId ()

Get an identity provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetProviderIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get an identity provider
                OAuthProvider result = apiInstance.GetProviderId();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetProviderId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**OAuthProvider**](OAuthProvider.md)

<a name="GetPurecloud"></a>
## [**PureCloud**](PureCloud.html) GetPurecloud ()

Get PureCloud Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPurecloudExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get PureCloud Identity Provider
                PureCloud result = apiInstance.GetPurecloud();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetPurecloud: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**PureCloud**](PureCloud.md)

<a name="GetSalesforce"></a>
## [**Salesforce**](Salesforce.html) GetSalesforce ()

Get Salesforce Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetSalesforceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();

            try
            {
                // Get Salesforce Identity Provider
                Salesforce result = apiInstance.GetSalesforce();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.GetSalesforce: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**Salesforce**](Salesforce.md)

<a name="PostClients"></a>
## [**OAuthClient**](OAuthClient.html) PostClients (OAuthClient body = null)

Create OAuth client

The OAuth Grant/Client is required in order to create an authentication token and gain access to PureCloud. \nThe preferred authorizedGrantTypes is 'CODE' which requires applications to send a client ID and client secret. This is typically a web server. \nIf the client is unable to secure the client secret then the 'TOKEN' grant type aka IMPLICIT should be used. This is would be for browser or mobile apps. \nIf a client is to be used outside of the context of a user then the 'CLIENT-CREDENTIALS' grant may be used. In this case the client must be granted roles \nvia the 'roleIds' field.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostClientsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new OAuthClient(); // OAuthClient | Client (optional) 

            try
            {
                // Create OAuth client
                OAuthClient result = apiInstance.PostClients(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PostClients: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OAuthClient**](OAuthClient.md)| Client | [optional]  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.md)

<a name="PostClientsClientIdSecret"></a>
## void PostClientsClientIdSecret (string clientId)

Regenerate Client Secret

This operation will set the client secret to a randomly generated cryptographically random value. All clients must be updated with the new secret. This operation should be used with caution.

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostClientsClientIdSecretExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID

            try
            {
                // Regenerate Client Secret
                apiInstance.PostClientsClientIdSecret(clientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PostClientsClientIdSecret: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PutClientsClientId"></a>
## [**OAuthClient**](OAuthClient.html) PutClientsClientId (string clientId, OAuthClient body = null)

Update OAuth Client



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutClientsClientIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var clientId = clientId_example;  // string | Client ID
            var body = new OAuthClient(); // OAuthClient | Client (optional) 

            try
            {
                // Update OAuth Client
                OAuthClient result = apiInstance.PutClientsClientId(clientId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutClientsClientId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **clientId** | **string**| Client ID |  |
| **body** | [**OAuthClient**](OAuthClient.md)| Client | [optional]  |
{: class="table table-striped"}

### Return type

[**OAuthClient**](OAuthClient.md)

<a name="PutOkta"></a>
## void PutOkta (Okta body = null)

Update/Create Okta Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutOktaExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new Okta(); // Okta | Provider (optional) 

            try
            {
                // Update/Create Okta Identity Provider
                apiInstance.PutOkta(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutOkta: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Okta**](Okta.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PutOnelogin"></a>
## void PutOnelogin (OneLogin body = null)

Update/Create OneLogin Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutOneloginExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new OneLogin(); // OneLogin | Provider (optional) 

            try
            {
                // Update/Create OneLogin Identity Provider
                apiInstance.PutOnelogin(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutOnelogin: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OneLogin**](OneLogin.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PutProviderId"></a>
## void PutProviderId (OAuthProvider body = null)

Update an identity provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutProviderIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new OAuthProvider(); // OAuthProvider | Provider (optional) 

            try
            {
                // Update an identity provider
                apiInstance.PutProviderId(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutProviderId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**OAuthProvider**](OAuthProvider.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PutPurecloud"></a>
## void PutPurecloud (PureCloud body = null)

Update/Create PureCloud Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutPurecloudExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new PureCloud(); // PureCloud | Provider (optional) 

            try
            {
                // Update/Create PureCloud Identity Provider
                apiInstance.PutPurecloud(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutPurecloud: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**PureCloud**](PureCloud.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)

<a name="PutSalesforce"></a>
## void PutSalesforce (Salesforce body = null)

Update/Create Salesforce Identity Provider



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutSalesforceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new OAuthApi();
            var body = new Salesforce(); // Salesforce | Provider (optional) 

            try
            {
                // Update/Create Salesforce Identity Provider
                apiInstance.PutSalesforce(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OAuthApi.PutSalesforce: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Salesforce**](Salesforce.md)| Provider | [optional]  |
{: class="table table-striped"}

### Return type

void (empty response body)
