# UnitClassApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](UnitClassApi.md#getbypath) | **GET** /unitclasses | Retrieve a unit class by path.
[**Get**](UnitClassApi.md#get) | **GET** /unitclasses/{webId} | Retrieve a unit class.
[**Update**](UnitClassApi.md#update) | **PATCH** /unitclasses/{webId} | Update a unit class.
[**Delete**](UnitClassApi.md#delete) | **DELETE** /unitclasses/{webId} | Delete a unit class.
[**GetCanonicalUnit**](UnitClassApi.md#getcanonicalunit) | **GET** /unitclasses/{webId}/canonicalunit | Get the canonical unit of a unit class.
[**GetUnits**](UnitClassApi.md#getunits) | **GET** /unitclasses/{webId}/units | Get a list of all units belonging to the unit class.
[**CreateUnit**](UnitClassApi.md#createunit) | **POST** /unitclasses/{webId}/units | Create a unit in the specified Unit Class.


# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve a unit class by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the unit class.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIUnitClass**](../Model/PIUnitClass.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIUnitClass**](../Model/PIUnitClass.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Update**
> Update(string webId, PIUnitClass unitClassDTO)

Update a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. | [required]
 **unitClassDTO** | **PIUnitClass**| A partial unit class containing the desired changes.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Delete**
> Delete(string webId)

Delete a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit class.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetCanonicalUnit**
> GetCanonicalUnit(string webId, string selectedFields = null)

Get the canonical unit of a unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of unit class.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIUnit**](../Model/PIUnit.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetUnits**
> GetUnits(string webId, string selectedFields = null)

Get a list of all units belonging to the unit class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of unit class.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIUnit**](../Model/PIUnit.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CreateUnit**
> CreateUnit(string webId, PIUnit unitDTO)

Create a unit in the specified Unit Class.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **unitDTO** | **PIUnit**| The new unit definition.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
