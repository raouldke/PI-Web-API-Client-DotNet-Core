# CalculationApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetAtIntervals**](CalculationApi.md#getatintervals) | **GET** /calculation/intervals | Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
[**GetAtRecorded**](CalculationApi.md#getatrecorded) | **GET** /calculation/recorded | Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
[**GetSummary**](CalculationApi.md#getsummary) | **GET** /calculation/summary | Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
[**GetAtTimes**](CalculationApi.md#getattimes) | **GET** /calculation/times | Returns the result of evaluating the expression at the specified timestamps.


# **GetAtIntervals**
> GetAtIntervals(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null)

Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **expression** | **string**| A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.. | [optional]
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **webId** | **string**| The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.. | [optional]


### Return type

[**PITimedValues**](../Model/PITimedValues.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAtRecorded**
> GetAtRecorded(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null)

Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **expression** | **string**| A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **webId** | **string**| The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.. | [optional]


### Return type

[**PITimedValues**](../Model/PITimedValues.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSummary**
> GetSummary(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null)

Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **expression** | **string**| A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.. | [optional]
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.. | [optional]
 **sampleType** | **string**| A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **summaryDuration** | **string**| The duration of each summary interval.. | [optional]
 **summaryType** | **List<string>**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. | [optional]
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. | [optional]
 **webId** | **string**| The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.. | [optional]


### Return type

[**PIItemsSummaryValue**](../Model/PIItemsSummaryValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAtTimes**
> GetAtTimes(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null)

Returns the result of evaluating the expression at the specified timestamps.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **expression** | **string**| A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **time** | **List<string>**| A list of timestamps at which to calculate the expression.. | [optional]
 **webId** | **string**| The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.. | [optional]


### Return type

[**PITimedValues**](../Model/PITimedValues.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
