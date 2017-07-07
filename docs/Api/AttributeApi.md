# AttributeApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AttributeApi.md#getbypath) | **GET** /attributes | Retrieve an attribute by path.
[**Get**](AttributeApi.md#get) | **GET** /attributes/{webId} | Retrieve an attribute.
[**Update**](AttributeApi.md#update) | **PATCH** /attributes/{webId} | Update an attribute by replacing items in its definition.
[**Delete**](AttributeApi.md#delete) | **DELETE** /attributes/{webId} | Delete an attribute.
[**GetAttributes**](AttributeApi.md#getattributes) | **GET** /attributes/{webId}/attributes | Get the child attributes of the specified attribute.
[**CreateAttribute**](AttributeApi.md#createattribute) | **POST** /attributes/{webId}/attributes | Create a new attribute as a child of the specified attribute.
[**GetCategories**](AttributeApi.md#getcategories) | **GET** /attributes/{webId}/categories | Get an attribute's categories.
[**CreateConfig**](AttributeApi.md#createconfig) | **POST** /attributes/{webId}/config | Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).
[**GetValue**](AttributeApi.md#getvalue) | **GET** /attributes/{webId}/value | Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.
[**SetValue**](AttributeApi.md#setvalue) | **PUT** /attributes/{webId}/value | Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.
[**GetMultiple**](AttributeApi.md#getmultiple) | **GET** /attributes/multiple | Retrieve multiple attributes by web id or path.


# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an attribute by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the attribute.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIAttribute**](../Model/PIAttribute.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIAttribute**](../Model/PIAttribute.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Update**
> Update(string webId, PIAttribute attribute)

Update an attribute by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. | [required]
 **attribute** | **PIAttribute**| A partial attribute containing the desired changes.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Delete**
> Delete(string webId)

Delete an attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetAttributes**
> GetAttributes(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null)

Get the child attributes of the specified attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent attribute.. | [required]
 **categoryName** | **string**| Specify that returned attributes must have this category. The default is no category filter.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **nameFilter** | **string**| The name query string used for finding attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]
 **templateName** | **string**| Specify that returned attributes must be members of this template. The default is no template filter.. | [optional]
 **valueType** | **string**| Specify that returned attributes' value type must be the given value type. The default is no value type filter.. | [optional]


### Return type

[**PIItemsAttribute**](../Model/PIItemsAttribute.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CreateAttribute**
> CreateAttribute(string webId, PIAttribute attribute)

Create a new attribute as a child of the specified attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent attribute on which to create the attribute.. | [required]
 **attribute** | **PIAttribute**| The definition of the new attribute.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetCategories**
> GetCategories(string webId, string selectedFields = null)

Get an attribute's categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIItemsAttributeCategory**](../Model/PIItemsAttributeCategory.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CreateConfig**
> CreateConfig(string webId)

Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetValue**
> GetValue(string webId, string selectedFields = null)

Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PITimedValue**](../Model/PITimedValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **SetValue**
> SetValue(string webId, PITimedValue value)

Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. | [required]
 **value** | **PITimedValue**| The value to write.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetMultiple**
> GetMultiple(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)

Retrieve multiple attributes by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool?**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.. | [optional]
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. | [optional]
 **path** | **List<string>**| The path of an attribute. Multiple attributes may be specified with multiple instances of the parameter.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webId** | **List<string>**| The ID of an attribute. Multiple attributes may be specified with multiple instances of the parameter.. | [optional]


### Return type

[**PIItemsItemAttribute**](../Model/PIItemsItemAttribute.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
