# AttributeTemplateApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AttributeTemplateApi.md#getbypath) | **GET** /attributetemplates | Retrieve an attribute template by path.
[**Get**](AttributeTemplateApi.md#get) | **GET** /attributetemplates/{webId} | Retrieve an attribute template.
[**Update**](AttributeTemplateApi.md#update) | **PATCH** /attributetemplates/{webId} | Update an existing attribute template by replacing items in its definition.
[**Delete**](AttributeTemplateApi.md#delete) | **DELETE** /attributetemplates/{webId} | Delete an attribute template.
[**GetAttributeTemplates**](AttributeTemplateApi.md#getattributetemplates) | **GET** /attributetemplates/{webId}/attributetemplates | Retrieve an attribute template's child attribute templates.
[**CreateAttributeTemplate**](AttributeTemplateApi.md#createattributetemplate) | **POST** /attributetemplates/{webId}/attributetemplates | Create an attribute template as a child of another attribute template.
[**GetCategories**](AttributeTemplateApi.md#getcategories) | **GET** /attributetemplates/{webId}/categories | Get an attribute template's categories.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an attribute template by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the attribute template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAttributeTemplate>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an attribute template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAttributeTemplate>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIAttributeTemplate template)

Update an existing attribute template by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute template.. | [required]
 **template** | **PIAttributeTemplate**| A partial attribute template containing the desired changes.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an attribute template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute template.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributeTemplatesWithHttpInfo**
> GetAttributeTemplatesWithHttpInfo(string webId, string selectedFields = null)

Retrieve an attribute template's child attribute templates.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAttributeTemplate>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAttributeTemplateWithHttpInfo**
> CreateAttributeTemplateWithHttpInfo(string webId, PIAttributeTemplate template)

Create an attribute template as a child of another attribute template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent attribute template on which to create the attribute template.. | [required]
 **template** | **PIAttributeTemplate**| The attribute template definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCategoriesWithHttpInfo**
> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)

Get an attribute template's categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAttributeCategory>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
