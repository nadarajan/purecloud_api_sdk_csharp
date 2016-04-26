# ININ.PureCloudApi.Api.ConfigurationApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**GetRecordingkeys**](ConfigurationApi.md#getrecordingkeys) | **GET** /api/v2/recording/recordingkeys | Get encryption key list |
| [**GetRecordingkeysRotationschedule**](ConfigurationApi.md#getrecordingkeysrotationschedule) | **GET** /api/v2/recording/recordingkeys/rotationschedule | Get key rotation schedule |
| [**PostRecordingkeys**](ConfigurationApi.md#postrecordingkeys) | **POST** /api/v2/recording/recordingkeys | Create encryption key |
| [**PutRecordingkeysRotationschedule**](ConfigurationApi.md#putrecordingkeysrotationschedule) | **PUT** /api/v2/recording/recordingkeys/rotationschedule | Update key rotation schedule |
{: class="table table-striped"}

<a name="GetRecordingkeys"></a>
## [**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.html) GetRecordingkeys (int? pageSize = null, int? pageNumber = null)

Get encryption key list



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRecordingkeysExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get encryption key list
                EncryptionKeyEntityListing result = apiInstance.GetRecordingkeys(pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetRecordingkeys: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**EncryptionKeyEntityListing**](EncryptionKeyEntityListing.md)

<a name="GetRecordingkeysRotationschedule"></a>
## [**KeyRotationSchedule**](KeyRotationSchedule.html) GetRecordingkeysRotationschedule ()

Get key rotation schedule



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetRecordingkeysRotationscheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();

            try
            {
                // Get key rotation schedule
                KeyRotationSchedule result = apiInstance.GetRecordingkeysRotationschedule();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.GetRecordingkeysRotationschedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule.md)

<a name="PostRecordingkeys"></a>
## [**EncryptionKey**](EncryptionKey.html) PostRecordingkeys ()

Create encryption key



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostRecordingkeysExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();

            try
            {
                // Create encryption key
                EncryptionKey result = apiInstance.PostRecordingkeys();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.PostRecordingkeys: " + e.Message );
            }
        }
    }
}
~~~

### Parameters
This endpoint does require any parameters.
{: class="table table-striped"}

### Return type

[**EncryptionKey**](EncryptionKey.md)

<a name="PutRecordingkeysRotationschedule"></a>
## [**KeyRotationSchedule**](KeyRotationSchedule.html) PutRecordingkeysRotationschedule (KeyRotationSchedule body = null)

Update key rotation schedule



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutRecordingkeysRotationscheduleExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new ConfigurationApi();
            var body = new KeyRotationSchedule(); // KeyRotationSchedule | KeyRotationSchedule (optional) 

            try
            {
                // Update key rotation schedule
                KeyRotationSchedule result = apiInstance.PutRecordingkeysRotationschedule(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationApi.PutRecordingkeysRotationschedule: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**KeyRotationSchedule**](KeyRotationSchedule.md)| KeyRotationSchedule | [optional]  |
{: class="table table-striped"}

### Return type

[**KeyRotationSchedule**](KeyRotationSchedule.md)
