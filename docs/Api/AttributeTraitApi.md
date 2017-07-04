# AttributeTraitApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByCategory**](AttributeTraitApi.md#getbycategory) | **GET** /attributetraits | Retrieve all attribute traits of the specified category/categories.
[**Get**](AttributeTraitApi.md#get) | **GET** /attributetraits/{name} | Retrieve an attribute trait.


# **GetByCategoryWithHttpInfo**
> GetByCategoryWithHttpInfo(List<string> category, string selectedFields = null)

Retrieve all attribute traits of the specified category/categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **category** | **List<string>**| The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAttributeTrait>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string name, string selectedFields = null)

Retrieve an attribute trait.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name or abbreviation of the attribute trait.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAttributeTrait>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
