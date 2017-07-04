# PointApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](PointApi.md#getbypath) | **GET** /points | Get a point by path.
[**Get**](PointApi.md#get) | **GET** /points/{webId} | Get a point.
[**Update**](PointApi.md#update) | **PATCH** /points/{webId} | Update a point.
[**Delete**](PointApi.md#delete) | **DELETE** /points/{webId} | Delete a point.
[**GetAttributes**](PointApi.md#getattributes) | **GET** /points/{webId}/attributes | Get point attributes.
[**GetAttributeByName**](PointApi.md#getattributebyname) | **GET** /points/{webId}/attributes/{name} | Get a point attribute by name.
[**UpdateAttributeValue**](PointApi.md#updateattributevalue) | **PUT** /points/{webId}/attributes/{name} | Update a point attribute value.
[**GetMultiple**](PointApi.md#getmultiple) | **GET** /points/multiple | Retrieve multiple points by web id or path.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Get a point by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the point.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIPoint>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Get a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIPoint>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIPoint pointDTO)

Update a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. | [required]
 **pointDTO** | **PIPoint**| A partial point containing the desired changes.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributesWithHttpInfo**
> GetAttributesWithHttpInfo(string webId, List<string> name = null, string nameFilter = null, string selectedFields = null)

Get point attributes.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. | [required]
 **name** | **List<string>**| The name of a point attribute to be returned. Multiple attributes may be specified with multiple instances of the parameter.. | [optional]
 **nameFilter** | **string**| The filter to the names of the list of point attributes to be returned. The default is no filter.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsPointAttribute>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributeByNameWithHttpInfo**
> GetAttributeByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Get a point attribute by name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the attribute.. | [required]
 **webId** | **string**| The ID of the point.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIPointAttribute>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateAttributeValueWithHttpInfo**
> UpdateAttributeValueWithHttpInfo(string webId, string name, Object value)

Update a point attribute value.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. | [required]
 **name** | **string**| The name of the attribute to be updated.. | [required]
 **value** | **Object**| The new value of the attribute to be updated.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetMultipleWithHttpInfo**
> GetMultipleWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)

Retrieve multiple points by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool?**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested points. The default is 'false'.. | [optional]
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. | [optional]
 **path** | **List<string>**| The path of a point. Multiple points may be specified with multiple instances of the parameter.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webId** | **List<string>**| The ID of a point. Multiple points may be specified with multiple instances of the parameter.. | [optional]


### Return type

ApiResponse<PIItemsItemPoint>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
