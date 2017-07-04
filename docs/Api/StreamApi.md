# StreamApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetChannel**](StreamApi.md#getchannel) | **GET** /streams/{webId}/channel | Opens a channel that will send messages about any value changes for the specified stream.
[**GetEnd**](StreamApi.md#getend) | **GET** /streams/{webId}/end | Returns the end-of-stream value of the stream.
[**GetInterpolated**](StreamApi.md#getinterpolated) | **GET** /streams/{webId}/interpolated | Retrieves interpolated values over the specified time range at the specified sampling interval.
[**GetInterpolatedAtTimes**](StreamApi.md#getinterpolatedattimes) | **GET** /streams/{webId}/interpolatedattimes | Retrieves interpolated values over the specified time range at the specified sampling interval.
[**GetPlot**](StreamApi.md#getplot) | **GET** /streams/{webId}/plot | Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
[**GetRecorded**](StreamApi.md#getrecorded) | **GET** /streams/{webId}/recorded | Returns a list of compressed values for the requested time range from the source provider.
[**UpdateValues**](StreamApi.md#updatevalues) | **POST** /streams/{webId}/recorded | Updates multiple values for the specified stream.
[**GetRecordedAtTime**](StreamApi.md#getrecordedattime) | **GET** /streams/{webId}/recordedattime | Returns a single recorded value based on the passed time and retrieval mode from the stream.
[**GetRecordedAtTimes**](StreamApi.md#getrecordedattimes) | **GET** /streams/{webId}/recordedattimes | Retrieves recorded values at the specified times.
[**GetSummary**](StreamApi.md#getsummary) | **GET** /streams/{webId}/summary | Returns a summary over the specified time range for the stream.
[**GetValue**](StreamApi.md#getvalue) | **GET** /streams/{webId}/value | Returns the value of the stream at the specified time. By default, this is usually the current value.
[**UpdateValue**](StreamApi.md#updatevalue) | **POST** /streams/{webId}/value | Updates a value for the specified stream.


# **GetChannelWithHttpInfo**
> GetChannelWithHttpInfo(string webId, bool? includeInitialValues = null)

Opens a channel that will send messages about any value changes for the specified stream.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **includeInitialValues** | **bool?**| Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.. | [optional]


### Return type

ApiResponse<PIItemsStreamValues>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetEndWithHttpInfo**
> GetEndWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null)

Returns the end-of-stream value of the stream.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PITimedValue>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetInterpolatedWithHttpInfo**
> GetInterpolatedWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)

Retrieves interpolated values over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **interval** | **string**| The sampling interval, in AFTimeSpan format.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PITimedValues>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetInterpolatedAtTimesWithHttpInfo**
> GetInterpolatedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)

Retrieves interpolated values over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **time** | **List<string>**| The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PITimedValues>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetPlotWithHttpInfo**
> GetPlotWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null)

Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **intervals** | **int?**| The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PITimedValues>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetRecordedWithHttpInfo**
> GetRecordedWithHttpInfo(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null)

Returns a list of compressed values for the requested time range from the source provider.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **boundaryType** | **string**| An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.. | [optional]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **maxCount** | **int?**| The maximum number of values to be returned. The default is 1000.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PITimedValues>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateValuesWithHttpInfo**
> UpdateValuesWithHttpInfo(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null)

Updates multiple values for the specified stream.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **values** | **List<PITimedValue>**| The values to add or update.. | [required]
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. | [optional]
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. | [optional]


### Return type

ApiResponse<PIItemsSubstatus>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetRecordedAtTimeWithHttpInfo**
> GetRecordedAtTimeWithHttpInfo(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null)

Returns a single recorded value based on the passed time and retrieval mode from the stream.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **time** | **string**| The timestamp at which the value is desired.. | [required]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **retrievalMode** | **string**| An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PITimedValue>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetRecordedAtTimesWithHttpInfo**
> GetRecordedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)

Retrieves recorded values at the specified times.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **retrievalMode** | **string**| An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **time** | **List<string>**| The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PITimedValues>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSummaryWithHttpInfo**
> GetSummaryWithHttpInfo(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null)

Returns a summary over the specified time range for the stream.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.. | [optional]
 **sampleInterval** | **string**| When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.. | [optional]
 **sampleType** | **string**| Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **summaryDuration** | **string**| The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.. | [optional]
 **summaryType** | **List<string>**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. | [optional]
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PIItemsSummaryValue>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetValueWithHttpInfo**
> GetValueWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null)

Returns the value of the stream at the specified time. By default, this is usually the current value.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **desiredUnits** | **string**| The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **time** | **string**| An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]


### Return type

ApiResponse<PITimedValue>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateValueWithHttpInfo**
> UpdateValueWithHttpInfo(string webId, PITimedValue value, string bufferOption = null, string updateOption = null)

Updates a value for the specified stream.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the stream.. | [required]
 **value** | **PITimedValue**| The value to add or update.. | [required]
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. | [optional]
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
