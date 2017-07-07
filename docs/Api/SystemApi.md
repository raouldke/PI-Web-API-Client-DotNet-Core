# SystemApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**Landing**](SystemApi.md#landing) | **GET** /system | Get system links for this PI System Web API instance.
[**CacheInstances**](SystemApi.md#cacheinstances) | **GET** /system/cacheinstances | Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
[**Status**](SystemApi.md#status) | **GET** /system/status | Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.
[**UserInfo**](SystemApi.md#userinfo) | **GET** /system/userinfo | Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
[**Versions**](SystemApi.md#versions) | **GET** /system/versions | Get the current versions of the PI Web API instance and all external plugins.


# **Landing**
> Landing()

Get system links for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**PISystemLanding**](../Model/PISystemLanding.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CacheInstances**
> CacheInstances()

Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**PIItemsCacheInstance**](../Model/PIItemsCacheInstance.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Status**
> Status()

Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**PISystemStatus**](../Model/PISystemStatus.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **UserInfo**
> UserInfo()

Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**PIUserInfo**](../Model/PIUserInfo.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Versions**
> Versions()

Get the current versions of the PI Web API instance and all external plugins.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

Dictionary<string, PIVersion>

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
