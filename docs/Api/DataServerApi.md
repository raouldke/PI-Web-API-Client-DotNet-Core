# DataServerApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**List**](DataServerApi.md#list) | **GET** /dataservers | Retrieve a list of Data Servers known to this service.
[**GetByName**](DataServerApi.md#getbyname) | **GET** /dataservers#name | Retrieve a Data Server by name.
[**GetByPath**](DataServerApi.md#getbypath) | **GET** /dataservers#path | Retrieve a Data Server by path.
[**Get**](DataServerApi.md#get) | **GET** /dataservers/{webId} | Retrieve a Data Server.
[**GetEnumerationSets**](DataServerApi.md#getenumerationsets) | **GET** /dataservers/{webId}/enumerationsets | Retrieve enumeration sets for given Data Server.
[**CreateEnumerationSet**](DataServerApi.md#createenumerationset) | **POST** /dataservers/{webId}/enumerationsets | Create an enumeration set on the Data Server.
[**GetPoints**](DataServerApi.md#getpoints) | **GET** /dataservers/{webId}/points | Retrieve a list of points on a specified Data Server.
[**CreatePoint**](DataServerApi.md#createpoint) | **POST** /dataservers/{webId}/points | Create a point in the specified Data Server.


# **List**
> List(string selectedFields = null)

Retrieve a list of Data Servers known to this service.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIItemsDataServer**](../Model/PIItemsDataServer.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByName**
> GetByName(string name, string selectedFields = null)

Retrieve a Data Server by name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIDataServer**](../Model/PIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve a Data Server by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the server. Note that the path supplied to this method must be of the form '\\servername'.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIDataServer**](../Model/PIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve a Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIDataServer**](../Model/PIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetEnumerationSets**
> GetEnumerationSets(string webId, string selectedFields = null)

Retrieve enumeration sets for given Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIItemsEnumerationSet**](../Model/PIItemsEnumerationSet.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateEnumerationSet**
> CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet)

Create an enumeration set on the Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server on which to create the enumeration set.. | [required]
 **enumerationSet** | **PIEnumerationSet**| The new enumeration set definition.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetPoints**
> GetPoints(string webId, int? maxCount = null, string nameFilter = null, string selectedFields = null, int? startIndex = null)

Retrieve a list of points on a specified Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **nameFilter** | **string**| A query string for filtering by point name. The default is no filter.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is '0'.. | [optional]


### Return type

[**PIItemsPoint**](../Model/PIItemsPoint.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreatePoint**
> CreatePoint(string webId, PIPoint pointDTO)

Create a point in the specified Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **pointDTO** | **PIPoint**| The new point definition.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
