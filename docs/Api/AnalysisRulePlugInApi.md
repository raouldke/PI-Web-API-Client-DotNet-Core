# AnalysisRulePlugInApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AnalysisRulePlugInApi.md#getbypath) | **GET** /analysisruleplugins | Retrieve an Analysis Rule Plug-in by path.
[**Get**](AnalysisRulePlugInApi.md#get) | **GET** /analysisruleplugins/{webId} | Retrieve an Analysis Rule Plug-in.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an Analysis Rule Plug-in by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the Analysis Rule Plug-in.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAnalysisRulePlugIn>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an Analysis Rule Plug-in.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis Rule Plug-in.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAnalysisRulePlugIn>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
