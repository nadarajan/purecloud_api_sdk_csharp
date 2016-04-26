---
title: Group
---
## ININ.PureCloudApi.Model.Group

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Description** | **string** |  | [optional] |
| **DateModified** | **DateTime?** | Last modified date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **MemberCount** | **long?** | Number of members. | [optional] |
| **State** | **string** | Active, inactive, or deleted state. | [optional] |
| **Version** | **int?** | Current version for this resource. | [optional] |
| **Type** | **string** | Type of group. | |
| **Images** | [**List&lt;UserImage&gt;**](UserImage.html) |  | [optional] |
| **Addresses** | [**List&lt;Contact&gt;**](Contact.html) |  | [optional] |
| **RulesVisible** | **bool?** | Are membership rules visible to the person requesting to view the group | [default to false]|
| **Visibility** | **string** | Who can view this group | |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}

