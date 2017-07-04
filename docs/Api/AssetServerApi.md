# AssetServerApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**List**](AssetServerApi.md#list) | **GET** /assetservers | Retrieve a list of all Asset Servers known to this service.
[**GetByName**](AssetServerApi.md#getbyname) | **GET** /assetservers#name | Retrieve an Asset Server by name.
[**GetByPath**](AssetServerApi.md#getbypath) | **GET** /assetservers#path | Retrieve an Asset Server by path.
[**Get**](AssetServerApi.md#get) | **GET** /assetservers/{webId} | Retrieve an Asset Server.
[**GetAnalysisRulePlugIns**](AssetServerApi.md#getanalysisruleplugins) | **GET** /assetservers/{webId}/analysisruleplugins | Retrieve a list of all Analysis Rule Plug-in's.
[**GetDatabases**](AssetServerApi.md#getdatabases) | **GET** /assetservers/{webId}/assetdatabases | Retrieve a list of all Asset Databases on the specified Asset Server.
[**CreateAssetDatabase**](AssetServerApi.md#createassetdatabase) | **POST** /assetservers/{webId}/assetdatabases | Create an asset database.
[**GetSecurity**](AssetServerApi.md#getsecurity) | **GET** /assetservers/{webId}/security | Get the security information of the specified security item associated with the asset server for a specified user.
[**GetSecurityEntries**](AssetServerApi.md#getsecurityentries) | **GET** /assetservers/{webId}/securityentries | Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
[**CreateSecurityEntry**](AssetServerApi.md#createsecurityentry) | **POST** /assetservers/{webId}/securityentries | Create a security entry owned by the asset server.
[**GetSecurityEntryByName**](AssetServerApi.md#getsecurityentrybyname) | **GET** /assetservers/{webId}/securityentries/{name} | Retrieve the security entry of the specified security item associated with the asset server with the specified name.
[**UpdateSecurityEntry**](AssetServerApi.md#updatesecurityentry) | **PUT** /assetservers/{webId}/securityentries/{name} | Update a security entry owned by the asset server.
[**DeleteSecurityEntry**](AssetServerApi.md#deletesecurityentry) | **DELETE** /assetservers/{webId}/securityentries/{name} | Delete a security entry owned by the asset server.
[**GetSecurityIdentities**](AssetServerApi.md#getsecurityidentities) | **GET** /assetservers/{webId}/securityidentities | Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
[**CreateSecurityIdentity**](AssetServerApi.md#createsecurityidentity) | **POST** /assetservers/{webId}/securityidentities | Create a security identity.
[**GetSecurityIdentitiesForUser**](AssetServerApi.md#getsecurityidentitiesforuser) | **GET** /assetservers/{webId}/securityidentities#userIdentity | Retrieve security identities for a specific user.
[**GetSecurityMappings**](AssetServerApi.md#getsecuritymappings) | **GET** /assetservers/{webId}/securitymappings | Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
[**CreateSecurityMapping**](AssetServerApi.md#createsecuritymapping) | **POST** /assetservers/{webId}/securitymappings | Create a security mapping.
[**GetTimeRulePlugIns**](AssetServerApi.md#gettimeruleplugins) | **GET** /assetservers/{webId}/timeruleplugins | Retrieve a list of all Time Rule Plug-in's.
[**GetUnitClasses**](AssetServerApi.md#getunitclasses) | **GET** /assetservers/{webId}/unitclasses | Retrieve a list of all unit classes on the specified Asset Server.
[**CreateUnitClass**](AssetServerApi.md#createunitclass) | **POST** /assetservers/{webId}/unitclasses | Create a unit class in the specified Asset Server.


# **ListWithHttpInfo**
> ListWithHttpInfo(string selectedFields = null)

Retrieve a list of all Asset Servers known to this service.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAssetServer>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByNameWithHttpInfo**
> GetByNameWithHttpInfo(string name, string selectedFields = null)

Retrieve an Asset Server by name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAssetServer>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an Asset Server by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAssetServer>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an Asset Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAssetServer>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAnalysisRulePlugInsWithHttpInfo**
> GetAnalysisRulePlugInsWithHttpInfo(string webId, string selectedFields = null)

Retrieve a list of all Analysis Rule Plug-in's.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server, where the Analysis Rule Plug-in's are installed.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAnalysisRulePlugIn>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetDatabasesWithHttpInfo**
> GetDatabasesWithHttpInfo(string webId, string selectedFields = null)

Retrieve a list of all Asset Databases on the specified Asset Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAssetDatabase>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAssetDatabaseWithHttpInfo**
> CreateAssetDatabaseWithHttpInfo(string webId, PIAssetDatabase database)

Create an asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server on which to create the database.. | [required]
 **database** | **PIAssetDatabase**| The new database definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)

Get the security information of the specified security item associated with the asset server for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server for the security to be checked.. | [required]
 **securityItem** | **List<string>**| The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.. | [required]
 **userIdentity** | **List<string>**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. | [required]
 **forceRefresh** | **bool?**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsSecurityRights>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null)

Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server.. | [required]
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsSecurityEntry>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)

Create a security entry owned by the asset server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server where the security entry will be created.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null)

Retrieve the security entry of the specified security item associated with the asset server with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the asset server.. | [required]
 **securityItem** | **string**| The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PISecurityEntry>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)

Update a security entry owned by the asset server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. | [required]
 **webId** | **string**| The ID of the asset server where the security entry will be updated.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null)

Delete a security entry owned by the asset server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the asset server where the security entry will be deleted.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityIdentitiesWithHttpInfo**
> GetSecurityIdentitiesWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server to search.. | [required]
 **field** | **string**| Specifies which of the object's properties are searched. The default is 'Name'.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned. The default is 1000.. | [optional]
 **query** | **string**| The query string used for finding objects. The default is no query string.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]


### Return type

ApiResponse<PIItemsSecurityIdentity>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityIdentityWithHttpInfo**
> CreateSecurityIdentityWithHttpInfo(string webId, PISecurityIdentity securityIdentity)

Create a security identity.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server on which to create the security identity.. | [required]
 **securityIdentity** | **PISecurityIdentity**| The new security identity definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityIdentitiesForUserWithHttpInfo**
> GetSecurityIdentitiesForUserWithHttpInfo(string webId, string userIdentity, string selectedFields = null)

Retrieve security identities for a specific user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **userIdentity** | **string**| The user identity to search for.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsSecurityIdentity>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityMappingsWithHttpInfo**
> GetSecurityMappingsWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server to search.. | [required]
 **field** | **string**| Specifies which of the object's properties are searched. The default is 'Name'.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned. The default is 1000.. | [optional]
 **query** | **string**| The query string used for finding objects. The default is no query string.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]


### Return type

ApiResponse<PIItemsSecurityMapping>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityMappingWithHttpInfo**
> CreateSecurityMappingWithHttpInfo(string webId, PISecurityMapping securityMapping)

Create a security mapping.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server on which to create the security mapping.. | [required]
 **securityMapping** | **PISecurityMapping**| The new security mapping definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetTimeRulePlugInsWithHttpInfo**
> GetTimeRulePlugInsWithHttpInfo(string webId, string selectedFields = null)

Retrieve a list of all Time Rule Plug-in's.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset server, where the Time Rule Plug-in's are installed.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsTimeRulePlugIn>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetUnitClassesWithHttpInfo**
> GetUnitClassesWithHttpInfo(string webId, string selectedFields = null)

Retrieve a list of all unit classes on the specified Asset Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsUnitClass>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateUnitClassWithHttpInfo**
> CreateUnitClassWithHttpInfo(string webId, PIUnitClass unitClass)

Create a unit class in the specified Asset Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **unitClass** | **PIUnitClass**| The new unit class definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
