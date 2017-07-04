# SystemApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**Landing**](SystemApi.md#landing) | **GET** /system | Get system links for this PI System Web API instance.
[**CacheInstances**](SystemApi.md#cacheinstances) | **GET** /system/cacheinstances | Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
[**Status**](SystemApi.md#status) | **GET** /system/status | Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.
[**UserInfo**](SystemApi.md#userinfo) | **GET** /system/userinfo | Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
[**Versions**](SystemApi.md#versions) | **GET** /system/versions | Get the current versions of the PI Web API instance and all external plugins.


# **LandingWithHttpInfo**
> LandingWithHttpInfo()

Get system links for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

ApiResponse<PISystemLanding>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CacheInstancesWithHttpInfo**
> CacheInstancesWithHttpInfo()

Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

ApiResponse<PIItemsCacheInstance>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **StatusWithHttpInfo**
> StatusWithHttpInfo()

Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

ApiResponse<PISystemStatus>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UserInfoWithHttpInfo**
> UserInfoWithHttpInfo()

Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

ApiResponse<PIUserInfo>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **VersionsWithHttpInfo**
> VersionsWithHttpInfo()

Get the current versions of the PI Web API instance and all external plugins.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

ApiResponse<Dictionary<string, PIVersion>>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
