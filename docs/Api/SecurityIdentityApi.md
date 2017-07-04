# SecurityIdentityApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](SecurityIdentityApi.md#getbypath) | **GET** /securityidentities | Retrieve a security identity by path.
[**Get**](SecurityIdentityApi.md#get) | **GET** /securityidentities/{webId} | Retrieve a security identity.
[**Update**](SecurityIdentityApi.md#update) | **PATCH** /securityidentities/{webId} | Update a security identity by replacing items in its definition.
[**Delete**](SecurityIdentityApi.md#delete) | **DELETE** /securityidentities/{webId} | Delete a security identity.
[**GetSecurity**](SecurityIdentityApi.md#getsecurity) | **GET** /securityidentities/{webId}/security | Get the security information of the specified security item associated with the security identity for a specified user.
[**GetSecurityEntries**](SecurityIdentityApi.md#getsecurityentries) | **GET** /securityidentities/{webId}/securityentries | Retrieve the security entries associated with the security identity based on the specified criteria. By default, all security entries for this security identity are returned.
[**GetSecurityEntryByName**](SecurityIdentityApi.md#getsecurityentrybyname) | **GET** /securityidentities/{webId}/securityentries/{name} | Retrieve the security entry associated with the security identity with the specified name.
[**GetSecurityMappings**](SecurityIdentityApi.md#getsecuritymappings) | **GET** /securityidentities/{webId}/securitymappings | Get security mappings for the specified security identity.


# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve a security identity by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the security identity.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PISecurityIdentity**](../Model/PISecurityIdentity.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve a security identity.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security identity.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PISecurityIdentity**](../Model/PISecurityIdentity.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PISecurityIdentity securityIdentity)

Update a security identity by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security identity.. | [required]
 **securityIdentity** | **PISecurityIdentity**| A partial security identity containing the desired changes.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete a security identity.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security identity.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurity**
> GetSecurity(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)

Get the security information of the specified security item associated with the security identity for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security identity for the security to be checked.. | [required]
 **userIdentity** | **List<string>**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. | [required]
 **forceRefresh** | **bool?**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIItemsSecurityRights**](../Model/PIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntries**
> GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the security identity based on the specified criteria. By default, all security entries for this security identity are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security identity.. | [required]
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIItemsSecurityEntry**](../Model/PIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByName**
> GetSecurityEntryByName(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the security identity with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the security identity.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PISecurityEntry**](../Model/PISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityMappings**
> GetSecurityMappings(string webId, string selectedFields = null)

Get security mappings for the specified security identity.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security identity.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

[**PIItemsSecurityMapping**](../Model/PIItemsSecurityMapping.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
