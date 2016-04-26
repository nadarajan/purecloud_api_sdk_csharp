# ININ.PureCloudApi.Api.QualityApi

All URIs are relative to *https://api.mypurecloud.com*

| Method | HTTP request | Description |
| ------------- | ------------- | ------------- |
| [**DeleteCalibrationsCalibrationId**](QualityApi.md#deletecalibrationscalibrationid) | **DELETE** /api/v2/quality/calibrations/{calibrationId} | Delete a calibration by id. |
| [**DeleteConversationsConversationIdEvaluationsEvaluationId**](QualityApi.md#deleteconversationsconversationidevaluationsevaluationid) | **DELETE** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Delete an evaluation |
| [**DeleteFormsFormId**](QualityApi.md#deleteformsformid) | **DELETE** /api/v2/quality/forms/{formId} | Delete an evaluation form. |
| [**GetAgentsActivity**](QualityApi.md#getagentsactivity) | **GET** /api/v2/quality/agents/activity | Gets a list of Agent Activities |
| [**GetCalibrations**](QualityApi.md#getcalibrations) | **GET** /api/v2/quality/calibrations | Get the list of calibrations |
| [**GetCalibrationsCalibrationId**](QualityApi.md#getcalibrationscalibrationid) | **GET** /api/v2/quality/calibrations/{calibrationId} | Get a calibration by id. |
| [**GetConversationsConversationIdAudits**](QualityApi.md#getconversationsconversationidaudits) | **GET** /api/v2/quality/conversations/{conversationId}/audits | Get audits for conversation or recording |
| [**GetConversationsConversationIdEvaluationsEvaluationId**](QualityApi.md#getconversationsconversationidevaluationsevaluationid) | **GET** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Get an evaluation |
| [**GetEvaluationsQuery**](QualityApi.md#getevaluationsquery) | **GET** /api/v2/quality/evaluations/query | Queries Evaluations and returns a paged list |
| [**GetEvaluatorsActivity**](QualityApi.md#getevaluatorsactivity) | **GET** /api/v2/quality/evaluators/activity | Get an evaluator activity |
| [**GetForms**](QualityApi.md#getforms) | **GET** /api/v2/quality/forms | Get the list of evaluation forms |
| [**GetFormsFormId**](QualityApi.md#getformsformid) | **GET** /api/v2/quality/forms/{formId} | Get an evaluation form |
| [**GetFormsFormIdVersions**](QualityApi.md#getformsformidversions) | **GET** /api/v2/quality/forms/{formId}/versions | Gets all the revisions for a specific evaluation. |
| [**GetPublishedforms**](QualityApi.md#getpublishedforms) | **GET** /api/v2/quality/publishedforms | Get the published evaluation forms. |
| [**GetPublishedformsFormId**](QualityApi.md#getpublishedformsformid) | **GET** /api/v2/quality/publishedforms/{formId} | Get the published evaluation forms. |
| [**PostCalibrations**](QualityApi.md#postcalibrations) | **POST** /api/v2/quality/calibrations | Create a calibration |
| [**PostConversationsConversationIdEvaluations**](QualityApi.md#postconversationsconversationidevaluations) | **POST** /api/v2/quality/conversations/{conversationId}/evaluations | Create an evaluation |
| [**PostEvaluationsAggregatesQuery**](QualityApi.md#postevaluationsaggregatesquery) | **POST** /api/v2/analytics/evaluations/aggregates/query | Query for evaluation aggregates |
| [**PostEvaluationsScoring**](QualityApi.md#postevaluationsscoring) | **POST** /api/v2/quality/evaluations/scoring | Score evaluation |
| [**PostForms**](QualityApi.md#postforms) | **POST** /api/v2/quality/forms | Create an evaluation form. |
| [**PostPublishedforms**](QualityApi.md#postpublishedforms) | **POST** /api/v2/quality/publishedforms | Publish an evaluation form. |
| [**PutCalibrationsCalibrationId**](QualityApi.md#putcalibrationscalibrationid) | **PUT** /api/v2/quality/calibrations/{calibrationId} | Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex |
| [**PutConversationsConversationIdEvaluationsEvaluationId**](QualityApi.md#putconversationsconversationidevaluationsevaluationid) | **PUT** /api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId} | Update an evaluation |
| [**PutFormsFormId**](QualityApi.md#putformsformid) | **PUT** /api/v2/quality/forms/{formId} | Update an evaluation form. |
{: class="table table-striped"}

<a name="DeleteCalibrationsCalibrationId"></a>
## [**Calibration**](Calibration.html) DeleteCalibrationsCalibrationId (string calibrationId, string calibratorId)

Delete a calibration by id.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteCalibrationsCalibrationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var calibrationId = calibrationId_example;  // string | Calibration ID
            var calibratorId = calibratorId_example;  // string | calibratorId

            try
            {
                // Delete a calibration by id.
                Calibration result = apiInstance.DeleteCalibrationsCalibrationId(calibrationId, calibratorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteCalibrationsCalibrationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **calibratorId** | **string**| calibratorId |  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="DeleteConversationsConversationIdEvaluationsEvaluationId"></a>
## [**Evaluation**](Evaluation.html) DeleteConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null)

Delete an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteConversationsConversationIdEvaluationsEvaluationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var evaluationId = evaluationId_example;  // string | 
            var expand = expand_example;  // string | evaluatorId (optional) 

            try
            {
                // Delete an evaluation
                Evaluation result = apiInstance.DeleteConversationsConversationIdEvaluationsEvaluationId(conversationId, evaluationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteConversationsConversationIdEvaluationsEvaluationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **evaluationId** | **string**|  |  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="DeleteFormsFormId"></a>
## string** DeleteFormsFormId (string formId)

Delete an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class DeleteFormsFormIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            {
                // Delete an evaluation form.
                string result = apiInstance.DeleteFormsFormId(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.DeleteFormsFormId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

**string**

<a name="GetAgentsActivity"></a>
## [**AgentActivityEntityListing**](AgentActivityEntityListing.html) GetAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)

Gets a list of Agent Activities

Including the number of evaluations and average evaluation score

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetAgentsActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var agentUserId = new List<string>(); // List<string> | user id of agent requested (optional) 
            var evaluatorUserId = evaluatorUserId_example;  // string | user id of the evaluator (optional) 
            var name = name_example;  // string | name (optional) 
            var group = group_example;  // string | group id (optional) 

            try
            {
                // Gets a list of Agent Activities
                AgentActivityEntityListing result = apiInstance.GetAgentsActivity(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetAgentsActivity: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **agentUserId** | [**List<string>**](string.md)| user id of agent requested | [optional]  |
| **evaluatorUserId** | **string**| user id of the evaluator | [optional]  |
| **name** | **string**| name | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**AgentActivityEntityListing**](AgentActivityEntityListing.md)

<a name="GetCalibrations"></a>
## [**CalibrationEntityListing**](CalibrationEntityListing.html) GetCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)

Get the list of calibrations



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCalibrationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var calibratorId = calibratorId_example;  // string | user id of calibrator
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var conversationId = conversationId_example;  // string | conversation id (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 

            try
            {
                // Get the list of calibrations
                CalibrationEntityListing result = apiInstance.GetCalibrations(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetCalibrations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibratorId** | **string**| user id of calibrator |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversation id | [optional]  |
| **startTime** | **DateTime?**| Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
{: class="table table-striped"}

### Return type

[**CalibrationEntityListing**](CalibrationEntityListing.md)

<a name="GetCalibrationsCalibrationId"></a>
## [**Calibration**](Calibration.html) GetCalibrationsCalibrationId (string calibrationId, string calibratorId)

Get a calibration by id.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetCalibrationsCalibrationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var calibrationId = calibrationId_example;  // string | Calibration ID
            var calibratorId = calibratorId_example;  // string | calibratorId

            try
            {
                // Get a calibration by id.
                Calibration result = apiInstance.GetCalibrationsCalibrationId(calibrationId, calibratorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetCalibrationsCalibrationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **calibratorId** | **string**| calibratorId |  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="GetConversationsConversationIdAudits"></a>
## [**QualityAuditPage**](QualityAuditPage.html) GetConversationsConversationIdAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)

Get audits for conversation or recording



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationsConversationIdAuditsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | Conversation ID
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var recordingId = recordingId_example;  // string | id of the recording (optional) 
            var entityType = entityType_example;  // string | entity type options: Recording, Calibration, Evaluation, Annotation (optional)  (default to RECORDING)

            try
            {
                // Get audits for conversation or recording
                QualityAuditPage result = apiInstance.GetConversationsConversationIdAudits(conversationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, recordingId, entityType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetConversationsConversationIdAudits: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**| Conversation ID |  |
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **recordingId** | **string**| id of the recording | [optional]  |
| **entityType** | **string**| entity type options: Recording, Calibration, Evaluation, Annotation | [optional] [default to RECORDING] |
{: class="table table-striped"}

### Return type

[**QualityAuditPage**](QualityAuditPage.md)

<a name="GetConversationsConversationIdEvaluationsEvaluationId"></a>
## [**Evaluation**](Evaluation.html) GetConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null)

Get an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetConversationsConversationIdEvaluationsEvaluationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var evaluationId = evaluationId_example;  // string | 
            var expand = expand_example;  // string | agent, evaluator, evaluationForm (optional) 

            try
            {
                // Get an evaluation
                Evaluation result = apiInstance.GetConversationsConversationIdEvaluationsEvaluationId(conversationId, evaluationId, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetConversationsConversationIdEvaluationsEvaluationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **evaluationId** | **string**|  |  |
| **expand** | **string**| agent, evaluator, evaluationForm | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="GetEvaluationsQuery"></a>
## [**EvaluationEntityListing**](EvaluationEntityListing.html) GetEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)

Queries Evaluations and returns a paged list

Query params must include one of conversationId, evaluatorUserId, or agentUserId

### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEvaluationsQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var conversationId = conversationId_example;  // string | conversationId specified (optional) 
            var agentUserId = agentUserId_example;  // string | user id of the agent (optional) 
            var evaluatorUserId = evaluatorUserId_example;  // string | evaluator user id (optional) 
            var queueId = queueId_example;  // string | queue id (optional) 
            var startTime = startTime_example;  // string | start time of the evaluation query (optional) 
            var endTime = endTime_example;  // string | end time of the evaluation query (optional) 
            var evaluationState = new List<string>(); // List<string> | evaluation state options: Pending, InProgress, Finished (optional) 
            var isReleased = true;  // bool? | the evaluation has been released (optional) 
            var agentHasRead = true;  // bool? | agent has the evaluation (optional) 
            var expandAnswerTotalScores = true;  // bool? | get the total scores for evaluations (optional) 
            var maximum = 56;  // int? | maximum (optional) 

            try
            {
                // Queries Evaluations and returns a paged list
                EvaluationEntityListing result = apiInstance.GetEvaluationsQuery(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetEvaluationsQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **conversationId** | **string**| conversationId specified | [optional]  |
| **agentUserId** | **string**| user id of the agent | [optional]  |
| **evaluatorUserId** | **string**| evaluator user id | [optional]  |
| **queueId** | **string**| queue id | [optional]  |
| **startTime** | **string**| start time of the evaluation query | [optional]  |
| **endTime** | **string**| end time of the evaluation query | [optional]  |
| **evaluationState** | [**List<string>**](string.md)| evaluation state options: Pending, InProgress, Finished | [optional]  |
| **isReleased** | **bool?**| the evaluation has been released | [optional]  |
| **agentHasRead** | **bool?**| agent has the evaluation | [optional]  |
| **expandAnswerTotalScores** | **bool?**| get the total scores for evaluations | [optional]  |
| **maximum** | **int?**| maximum | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationEntityListing**](EvaluationEntityListing.md)

<a name="GetEvaluatorsActivity"></a>
## [**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.html) GetEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)

Get an evaluator activity



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetEvaluatorsActivityExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var expand = new List<string>(); // List<string> | variable name requested by expand list (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional) 
            var name = name_example;  // string | Evaluator name (optional) 
            var permission = new List<string>(); // List<string> | permission strings (optional) 
            var group = group_example;  // string | group id (optional) 

            try
            {
                // Get an evaluator activity
                EvaluatorActivityEntityListing result = apiInstance.GetEvaluatorsActivity(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetEvaluatorsActivity: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **expand** | [**List<string>**](string.md)| variable name requested by expand list | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **startTime** | **DateTime?**| The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **endTime** | **DateTime?**| The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional]  |
| **name** | **string**| Evaluator name | [optional]  |
| **permission** | [**List<string>**](string.md)| permission strings | [optional]  |
| **group** | **string**| group id | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluatorActivityEntityListing**](EvaluatorActivityEntityListing.md)

<a name="GetForms"></a>
## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)

Get the list of evaluation forms



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetFormsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | The total page size requested (optional)  (default to 25)
            var pageNumber = 56;  // int? | The page number requested (optional)  (default to 1)
            var sortBy = sortBy_example;  // string | variable name requested to sort by (optional) 
            var nextPage = nextPage_example;  // string | next page token (optional) 
            var previousPage = previousPage_example;  // string | Previous page token (optional) 
            var expand = expand_example;  // string | Expand (optional) 
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get the list of evaluation forms
                EvaluationFormEntityListing result = apiInstance.GetForms(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetForms: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **pageSize** | **int?**| The total page size requested | [optional] [default to 25] |
| **pageNumber** | **int?**| The page number requested | [optional] [default to 1] |
| **sortBy** | **string**| variable name requested to sort by | [optional]  |
| **nextPage** | **string**| next page token | [optional]  |
| **previousPage** | **string**| Previous page token | [optional]  |
| **expand** | **string**| Expand | [optional]  |
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.md)

<a name="GetFormsFormId"></a>
## [**EvaluationForm**](EvaluationForm.html) GetFormsFormId (string formId)

Get an evaluation form



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetFormsFormIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            {
                // Get an evaluation form
                EvaluationForm result = apiInstance.GetFormsFormId(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetFormsFormId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="GetFormsFormIdVersions"></a>
## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetFormsFormIdVersions (string formId, int? pageSize = null, int? pageNumber = null)

Gets all the revisions for a specific evaluation.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetFormsFormIdVersionsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Gets all the revisions for a specific evaluation.
                EvaluationFormEntityListing result = apiInstance.GetFormsFormIdVersions(formId, pageSize, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetFormsFormIdVersions: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **pageSize** | **int?**| Page size | [optional] [default to 25] |
| **pageNumber** | **int?**| Page number | [optional] [default to 1] |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.md)

<a name="GetPublishedforms"></a>
## [**EvaluationFormEntityListing**](EvaluationFormEntityListing.html) GetPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null)

Get the published evaluation forms.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPublishedformsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var pageSize = 56;  // int? | Page size (optional)  (default to 25)
            var pageNumber = 56;  // int? | Page number (optional)  (default to 1)
            var name = name_example;  // string | Name (optional) 

            try
            {
                // Get the published evaluation forms.
                EvaluationFormEntityListing result = apiInstance.GetPublishedforms(pageSize, pageNumber, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetPublishedforms: " + e.Message );
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
| **name** | **string**| Name | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationFormEntityListing**](EvaluationFormEntityListing.md)

<a name="GetPublishedformsFormId"></a>
## [**EvaluationForm**](EvaluationForm.html) GetPublishedformsFormId (string formId)

Get the published evaluation forms.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class GetPublishedformsFormIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID

            try
            {
                // Get the published evaluation forms.
                EvaluationForm result = apiInstance.GetPublishedformsFormId(formId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.GetPublishedformsFormId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="PostCalibrations"></a>
## [**Calibration**](Calibration.html) PostCalibrations (Calibration body = null, string expand = null)

Create a calibration



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostCalibrationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new Calibration(); // Calibration | calibration (optional) 
            var expand = expand_example;  // string | calibratorId (optional) 

            try
            {
                // Create a calibration
                Calibration result = apiInstance.PostCalibrations(body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostCalibrations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**Calibration**](Calibration.md)| calibration | [optional]  |
| **expand** | **string**| calibratorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="PostConversationsConversationIdEvaluations"></a>
## [**Evaluation**](Evaluation.html) PostConversationsConversationIdEvaluations (string conversationId, Evaluation body = null, string expand = null)

Create an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostConversationsConversationIdEvaluationsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var body = new Evaluation(); // Evaluation | evaluation (optional) 
            var expand = expand_example;  // string | evaluatorId (optional) 

            try
            {
                // Create an evaluation
                Evaluation result = apiInstance.PostConversationsConversationIdEvaluations(conversationId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostConversationsConversationIdEvaluations: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **body** | [**Evaluation**](Evaluation.md)| evaluation | [optional]  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="PostEvaluationsAggregatesQuery"></a>
## [**AggregateQueryResponse**](AggregateQueryResponse.html) PostEvaluationsAggregatesQuery (AggregationQuery body = null)

Query for evaluation aggregates



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostEvaluationsAggregatesQueryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new AggregationQuery(); // AggregationQuery | query (optional) 

            try
            {
                // Query for evaluation aggregates
                AggregateQueryResponse result = apiInstance.PostEvaluationsAggregatesQuery(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostEvaluationsAggregatesQuery: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**AggregationQuery**](AggregationQuery.md)| query | [optional]  |
{: class="table table-striped"}

### Return type

[**AggregateQueryResponse**](AggregateQueryResponse.md)

<a name="PostEvaluationsScoring"></a>
## [**EvaluationScoringSet**](EvaluationScoringSet.html) PostEvaluationsScoring (EvaluationFormAndScoringSet body = null)

Score evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostEvaluationsScoringExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new EvaluationFormAndScoringSet(); // EvaluationFormAndScoringSet | evaluationAndScoringSet (optional) 

            try
            {
                // Score evaluation
                EvaluationScoringSet result = apiInstance.PostEvaluationsScoring(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostEvaluationsScoring: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationFormAndScoringSet**](EvaluationFormAndScoringSet.md)| evaluationAndScoringSet | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationScoringSet**](EvaluationScoringSet.md)

<a name="PostForms"></a>
## [**EvaluationForm**](EvaluationForm.html) PostForms (EvaluationForm body = null)

Create an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostFormsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new EvaluationForm(); // EvaluationForm |  (optional) 

            try
            {
                // Create an evaluation form.
                EvaluationForm result = apiInstance.PostForms(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostForms: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="PostPublishedforms"></a>
## [**EvaluationForm**](EvaluationForm.html) PostPublishedforms (EvaluationForm body = null)

Publish an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PostPublishedformsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var body = new EvaluationForm(); // EvaluationForm |  (optional) 

            try
            {
                // Publish an evaluation form.
                EvaluationForm result = apiInstance.PostPublishedforms(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PostPublishedforms: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **body** | [**EvaluationForm**](EvaluationForm.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)

<a name="PutCalibrationsCalibrationId"></a>
## [**Calibration**](Calibration.html) PutCalibrationsCalibrationId (string calibrationId, Calibration body = null)

Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutCalibrationsCalibrationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var calibrationId = calibrationId_example;  // string | Calibration ID
            var body = new Calibration(); // Calibration | Calibration (optional) 

            try
            {
                // Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
                Calibration result = apiInstance.PutCalibrationsCalibrationId(calibrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutCalibrationsCalibrationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **calibrationId** | **string**| Calibration ID |  |
| **body** | [**Calibration**](Calibration.md)| Calibration | [optional]  |
{: class="table table-striped"}

### Return type

[**Calibration**](Calibration.md)

<a name="PutConversationsConversationIdEvaluationsEvaluationId"></a>
## [**Evaluation**](Evaluation.html) PutConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, Evaluation body = null, string expand = null)

Update an evaluation



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutConversationsConversationIdEvaluationsEvaluationIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var conversationId = conversationId_example;  // string | 
            var evaluationId = evaluationId_example;  // string | 
            var body = new Evaluation(); // Evaluation | evaluation (optional) 
            var expand = expand_example;  // string | evaluatorId (optional) 

            try
            {
                // Update an evaluation
                Evaluation result = apiInstance.PutConversationsConversationIdEvaluationsEvaluationId(conversationId, evaluationId, body, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutConversationsConversationIdEvaluationsEvaluationId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **conversationId** | **string**|  |  |
| **evaluationId** | **string**|  |  |
| **body** | [**Evaluation**](Evaluation.md)| evaluation | [optional]  |
| **expand** | **string**| evaluatorId | [optional]  |
{: class="table table-striped"}

### Return type

[**Evaluation**](Evaluation.md)

<a name="PutFormsFormId"></a>
## [**EvaluationForm**](EvaluationForm.html) PutFormsFormId (string formId, EvaluationForm body = null)

Update an evaluation form.



### Example
~~~csharp
using System;
using System.Diagnostics;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace Example
{
    public class PutFormsFormIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PureCloud Auth
            Configuration.Default.AccessToken = 'YOUR_ACCESS_TOKEN';

            var apiInstance = new QualityApi();
            var formId = formId_example;  // string | Form ID
            var body = new EvaluationForm(); // EvaluationForm |  (optional) 

            try
            {
                // Update an evaluation form.
                EvaluationForm result = apiInstance.PutFormsFormId(formId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QualityApi.PutFormsFormId: " + e.Message );
            }
        }
    }
}
~~~

### Parameters


|Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **formId** | **string**| Form ID |  |
| **body** | [**EvaluationForm**](EvaluationForm.md)|  | [optional]  |
{: class="table table-striped"}

### Return type

[**EvaluationForm**](EvaluationForm.md)
