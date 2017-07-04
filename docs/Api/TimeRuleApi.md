# TimeRuleApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](TimeRuleApi.md#getbypath) | **GET** /timerules | Retrieve a Time Rule by path.
[**Get**](TimeRuleApi.md#get) | **GET** /timerules/{webId} | Retrieve a Time Rule.
[**Update**](TimeRuleApi.md#update) | **PATCH** /timerules/{webId} | Update a Time Rule by replacing items in its definition.
[**Delete**](TimeRuleApi.md#delete) | **DELETE** /timerules/{webId} | Delete a Time Rule.


# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve a Time Rule by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the Time Rule.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PITimeRule**](../Model/PITimeRule.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve a Time Rule.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Time Rule.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PITimeRule**](../Model/PITimeRule.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PITimeRule timeRule)

Update a Time Rule by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Time Rule.. | [required]
 **timeRule** | **PITimeRule**| A partial Time Rule containing the desired changes.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete a Time Rule.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Time Rule.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
