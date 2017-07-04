# ConfigurationApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**List**](ConfigurationApi.md#list) | **GET** /system/configuration | Get the current system configuration.
[**Get**](ConfigurationApi.md#get) | **GET** /system/configuration/{key} | Get the value of a configuration item.
[**Delete**](ConfigurationApi.md#delete) | **DELETE** /system/configuration/{key} | Delete a configuration item.
[**Put**](ConfigurationApi.md#put) | **PUT** /system/configuration/{key} | Create or update a configuration item.


# **List**
> List()

Get the current system configuration.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

Dictionary<string, Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string key)

Get the value of a configuration item.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the configuration item.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string key)

Delete a configuration item.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the configuration item to remove.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Put**
> Put(string key, Object value)

Create or update a configuration item.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the configuration item to create or update.. | [required]
 **value** | **Object**| The value of the configuration item.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
