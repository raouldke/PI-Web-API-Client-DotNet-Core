# AnalysisTemplateApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AnalysisTemplateApi.md#getbypath) | **GET** /analysistemplates | Retrieve an analysis template by path.
[**CreateFromAnalysis**](AnalysisTemplateApi.md#createfromanalysis) | **POST** /analysistemplates | Create an Analysis template based upon a specified Analysis.
[**Get**](AnalysisTemplateApi.md#get) | **GET** /analysistemplates/{webId} | Retrieve an analysis template.
[**Update**](AnalysisTemplateApi.md#update) | **PATCH** /analysistemplates/{webId} | Update an analysis template by replacing items in its definition.
[**Delete**](AnalysisTemplateApi.md#delete) | **DELETE** /analysistemplates/{webId} | Delete an analysis template.
[**GetCategories**](AnalysisTemplateApi.md#getcategories) | **GET** /analysistemplates/{webId}/categories | Get an analysis template's categories.
[**GetSecurity**](AnalysisTemplateApi.md#getsecurity) | **GET** /analysistemplates/{webId}/security | Get the security information of the specified security item associated with the analysis template for a specified user.
[**GetSecurityEntries**](AnalysisTemplateApi.md#getsecurityentries) | **GET** /analysistemplates/{webId}/securityentries | Retrieve the security entries associated with the analysis template based on the specified criteria. By default, all security entries for this analysis template are returned.
[**CreateSecurityEntry**](AnalysisTemplateApi.md#createsecurityentry) | **POST** /analysistemplates/{webId}/securityentries | Create a security entry owned by the analysis template.
[**GetSecurityEntryByName**](AnalysisTemplateApi.md#getsecurityentrybyname) | **GET** /analysistemplates/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis template with the specified name.
[**UpdateSecurityEntry**](AnalysisTemplateApi.md#updatesecurityentry) | **PUT** /analysistemplates/{webId}/securityentries/{name} | Update a security entry owned by the analysis template.
[**DeleteSecurityEntry**](AnalysisTemplateApi.md#deletesecurityentry) | **DELETE** /analysistemplates/{webId}/securityentries/{name} | Delete a security entry owned by the analysis template.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an analysis template by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the analysis template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAnalysisTemplate>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateFromAnalysisWithHttpInfo**
> CreateFromAnalysisWithHttpInfo(string analysisWebId, string name = null)

Create an Analysis template based upon a specified Analysis.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **analysisWebId** | **string**| The ID of the Analysis, on which the template is created.. | [required]
 **name** | **string**| The name for the created template, which must be unique within the database's AnalysisTemplate collection. If the name ends with an asterisk (*), then a unique name will be generated based on the supplied name. The default is the specified Analysis' name suffixed with an asterisk (*).. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an analysis template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAnalysisTemplate>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIAnalysisTemplate template)

Update an analysis template by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis template to update.. | [required]
 **template** | **PIAnalysisTemplate**| A partial analysis template containing the desired changes.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an analysis template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis template to update.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCategoriesWithHttpInfo**
> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)

Get an analysis template's categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAnalysisCategory>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)

Get the security information of the specified security item associated with the analysis template for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis template for the security to be checked.. | [required]
 **userIdentity** | **List<string>**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. | [required]
 **forceRefresh** | **bool?**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsSecurityRights>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the analysis template based on the specified criteria. By default, all security entries for this analysis template are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis template.. | [required]
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsSecurityEntry>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)

Create a security entry owned by the analysis template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis template, where the security entry will be created.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the analysis template with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the analysis template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PISecurityEntry>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)

Update a security entry owned by the analysis template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. | [required]
 **webId** | **string**| The ID of the analysis template, where the security entry will be updated.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null)

Delete a security entry owned by the analysis template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the analysis template, where the security entry will be deleted.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
