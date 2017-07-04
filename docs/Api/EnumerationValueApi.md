# EnumerationValueApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](EnumerationValueApi.md#getbypath) | **GET** /enumerationvalues | Retrieve an enumeration value by path.
[**Get**](EnumerationValueApi.md#get) | **GET** /enumerationvalues/{webId} | Retrieve an enumeration value mapping
[**UpdateEnumerationValue**](EnumerationValueApi.md#updateenumerationvalue) | **PATCH** /enumerationvalues/{webId} | Update an enumeration value by replacing items in its definition.
[**DeleteEnumerationValue**](EnumerationValueApi.md#deleteenumerationvalue) | **DELETE** /enumerationvalues/{webId} | Delete an enumeration value from an enumeration set.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an enumeration value by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the target enumeration value.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIEnumerationValue>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an enumeration value mapping

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIEnumerationValue>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateEnumerationValueWithHttpInfo**
> UpdateEnumerationValueWithHttpInfo(string webId, PIEnumerationValue enumerationValue)

Update an enumeration value by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value to update.. | [required]
 **enumerationValue** | **PIEnumerationValue**| A partial enumeration value containing the desired changes.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteEnumerationValueWithHttpInfo**
> DeleteEnumerationValueWithHttpInfo(string webId)

Delete an enumeration value from an enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
