// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;

namespace OSIsoft.PIDevClub.PIWebApiClient.Api
{


	/// <summary>
	/// Represents a collection of functions to interact with the PI Web API Stream controller.
	/// </summary>
	public interface IStreamApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>PIItemsStreamValues</returns>
		PIItemsStreamValues GetChannel(string webId, bool? includeInitialValues = null);

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		ApiResponse<PIItemsStreamValues> GetChannelWithHttpInfo(string webId, bool? includeInitialValues = null);

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PITimedValue</returns>
		PITimedValue GetEnd(string webId, string desiredUnits = null, string selectedFields = null);

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PITimedValue></returns>
		ApiResponse<PITimedValue> GetEndWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetInterpolated(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetInterpolatedWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetInterpolatedAtTimes(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetInterpolatedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetPlot(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetPlotWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetRecorded(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetRecordedWithHttpInfo(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsSubstatus</returns>
		PIItemsSubstatus UpdateValues(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsSubstatus></returns>
		ApiResponse<PIItemsSubstatus> UpdateValuesWithHttpInfo(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValue</returns>
		PITimedValue GetRecordedAtTime(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValue></returns>
		ApiResponse<PITimedValue> GetRecordedAtTimeWithHttpInfo(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetRecordedAtTimes(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetRecordedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PIItemsSummaryValue</returns>
		PIItemsSummaryValue GetSummary(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null);

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PIItemsSummaryValue></returns>
		ApiResponse<PIItemsSummaryValue> GetSummaryWithHttpInfo(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null);

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValue</returns>
		PITimedValue GetValue(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValue></returns>
		ApiResponse<PITimedValue> GetValueWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>Object</returns>
		Object UpdateValue(string webId, PITimedValue value, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateValueWithHttpInfo(string webId, PITimedValue value, string bufferOption = null, string updateOption = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		System.Threading.Tasks.Task<PIItemsStreamValues> GetChannelAsync(string webId, bool? includeInitialValues = null);

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetChannelAsyncWithHttpInfo(string webId, bool? includeInitialValues = null);

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValue></returns>
		System.Threading.Tasks.Task<PITimedValue> GetEndAsync(string webId, string desiredUnits = null, string selectedFields = null);

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValue>> GetEndAsyncWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetInterpolatedAsync(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetInterpolatedAsyncWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetInterpolatedAtTimesAsync(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetInterpolatedAtTimesAsyncWithHttpInfo(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetPlotAsync(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetPlotAsyncWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetRecordedAsync(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetRecordedAsyncWithHttpInfo(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSubstatus></returns>
		System.Threading.Tasks.Task<PIItemsSubstatus> UpdateValuesAsync(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>> UpdateValuesAsyncWithHttpInfo(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValue></returns>
		System.Threading.Tasks.Task<PITimedValue> GetRecordedAtTimeAsync(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValue>> GetRecordedAtTimeAsyncWithHttpInfo(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetRecordedAtTimesAsync(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetRecordedAtTimesAsyncWithHttpInfo(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null);

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSummaryValue></returns>
		System.Threading.Tasks.Task<PIItemsSummaryValue> GetSummaryAsync(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null);

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>> GetSummaryAsyncWithHttpInfo(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null);

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValue></returns>
		System.Threading.Tasks.Task<PITimedValue> GetValueAsync(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValue>> GetValueAsyncWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateValueAsync(string webId, PITimedValue value, string bufferOption = null, string updateOption = null);

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateValueAsyncWithHttpInfo(string webId, PITimedValue value, string bufferOption = null, string updateOption = null);

		#endregion
	}

	public class StreamApi : IStreamApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public StreamApi(Configuration configuration = null)
		{
			if (configuration == null)
				this.Configuration = Configuration.Default;
			else
				this.Configuration = configuration;

			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		#region Synchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>PIItemsStreamValues</returns>
		public PIItemsStreamValues GetChannel(string webId, bool? includeInitialValues = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = GetChannelWithHttpInfo(webId, includeInitialValues);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>ApiResponse<PIItemsStreamValues></returns>
		public ApiResponse<PIItemsStreamValues> GetChannelWithHttpInfo(string webId, bool? includeInitialValues = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/channel";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (includeInitialValues!= null) localVarQueryParams.Add("includeInitialValues", Configuration.ApiClient.ParameterToString(includeInitialValues));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannelWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PITimedValue</returns>
		public PITimedValue GetEnd(string webId, string desiredUnits = null, string selectedFields = null)
		{
			ApiResponse<PITimedValue> localVarResponse = GetEndWithHttpInfo(webId, desiredUnits, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PITimedValue></returns>
		public ApiResponse<PITimedValue> GetEndWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/end";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEndWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetInterpolated(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetInterpolatedWithHttpInfo(webId, desiredUnits, endTime, filterExpression, includeFilteredValues, interval, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetInterpolatedWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/interpolated";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (interval!= null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetInterpolatedAtTimes(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetInterpolatedAtTimesWithHttpInfo(webId, desiredUnits, filterExpression, includeFilteredValues, selectedFields, sortOrder, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetInterpolatedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/interpolatedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetPlot(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetPlotWithHttpInfo(webId, desiredUnits, endTime, intervals, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetPlotWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/plot";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (intervals!= null) localVarQueryParams.Add("intervals", Configuration.ApiClient.ParameterToString(intervals));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPlotWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetRecorded(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetRecordedWithHttpInfo(webId, boundaryType, desiredUnits, endTime, filterExpression, includeFilteredValues, maxCount, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetRecordedWithHttpInfo(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", Configuration.ApiClient.ParameterToString(boundaryType));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>PIItemsSubstatus</returns>
		public PIItemsSubstatus UpdateValues(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<PIItemsSubstatus> localVarResponse = UpdateValuesWithHttpInfo(webId, values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>ApiResponse<PIItemsSubstatus></returns>
		public ApiResponse<PIItemsSubstatus> UpdateValuesWithHttpInfo(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streams/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (values != null && values.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(values);
			}
			else
			{
				localVarPostBody = values;
			}
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", Configuration.ApiClient.ParameterToString(bufferOption));
			if (updateOption!= null) localVarQueryParams.Add("updateOption", Configuration.ApiClient.ParameterToString(updateOption));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValuesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValue</returns>
		public PITimedValue GetRecordedAtTime(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			ApiResponse<PITimedValue> localVarResponse = GetRecordedAtTimeWithHttpInfo(webId, time, desiredUnits, retrievalMode, selectedFields, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValue></returns>
		public ApiResponse<PITimedValue> GetRecordedAtTimeWithHttpInfo(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streams/{webId}/recordedattime";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimeWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetRecordedAtTimes(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetRecordedAtTimesWithHttpInfo(webId, desiredUnits, retrievalMode, selectedFields, sortOrder, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetRecordedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/recordedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PIItemsSummaryValue</returns>
		public PIItemsSummaryValue GetSummary(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null)
		{
			ApiResponse<PIItemsSummaryValue> localVarResponse = GetSummaryWithHttpInfo(webId, calculationBasis, endTime, filterExpression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryType, timeType, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PIItemsSummaryValue></returns>
		public ApiResponse<PIItemsSummaryValue> GetSummaryWithHttpInfo(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", Configuration.ApiClient.ParameterToString(calculationBasis));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", Configuration.ApiClient.ParameterToString(sampleInterval));
			if (sampleType!= null) localVarQueryParams.Add("sampleType", Configuration.ApiClient.ParameterToString(sampleType));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", Configuration.ApiClient.ParameterToString(summaryDuration));
			if (summaryType!= null) localVarQueryParams.Add("summaryType", Configuration.ApiClient.ParameterToString(summaryType));
			if (timeType!= null) localVarQueryParams.Add("timeType", Configuration.ApiClient.ParameterToString(timeType));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummaryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSummaryValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSummaryValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSummaryValue)));
		}

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>PITimedValue</returns>
		public PITimedValue GetValue(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null)
		{
			ApiResponse<PITimedValue> localVarResponse = GetValueWithHttpInfo(webId, desiredUnits, selectedFields, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>ApiResponse<PITimedValue></returns>
		public ApiResponse<PITimedValue> GetValueWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValueWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>Object</returns>
		public Object UpdateValue(string webId, PITimedValue value, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<Object> localVarResponse = UpdateValueWithHttpInfo(webId, value, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateValueWithHttpInfo(string webId, PITimedValue value, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'value' is set
			if (value == null)
				throw new ApiException(400, "Missing required parameter 'value'");

			var localVarPath = "/streams/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (value != null && value.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(value);
			}
			else
			{
				localVarPostBody = value;
			}
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", Configuration.ApiClient.ParameterToString(bufferOption));
			if (updateOption!= null) localVarQueryParams.Add("updateOption", Configuration.ApiClient.ParameterToString(updateOption));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValueWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsStreamValues></returns>
		public async System.Threading.Tasks.Task<PIItemsStreamValues> GetChannelAsync(string webId, bool? includeInitialValues = null)
		{
			ApiResponse<PIItemsStreamValues> localVarResponse = await GetChannelAsyncWithHttpInfo(webId, includeInitialValues);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Opens a channel that will send messages about any value changes for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="includeInitialValues">Specified if the channel should send a message with the current value of the stream after the connection is opened. The default is 'false'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsStreamValues>> GetChannelAsyncWithHttpInfo(string webId, bool? includeInitialValues = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/channel";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (includeInitialValues!= null) localVarQueryParams.Add("includeInitialValues", Configuration.ApiClient.ParameterToString(includeInitialValues));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannelAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsStreamValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValue></returns>
		public async System.Threading.Tasks.Task<PITimedValue> GetEndAsync(string webId, string desiredUnits = null, string selectedFields = null)
		{
			ApiResponse<PITimedValue> localVarResponse = await GetEndAsyncWithHttpInfo(webId, desiredUnits, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the end-of-stream value of the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValue>> GetEndAsyncWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/end";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEndAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetInterpolatedAsync(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetInterpolatedAsyncWithHttpInfo(webId, desiredUnits, endTime, filterExpression, includeFilteredValues, interval, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="interval">The sampling interval, in AFTimeSpan format.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetInterpolatedAsyncWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/interpolated";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (interval!= null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetInterpolatedAtTimesAsync(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetInterpolatedAtTimesAsyncWithHttpInfo(webId, desiredUnits, filterExpression, includeFilteredValues, selectedFields, sortOrder, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves interpolated values over the specified time range at the specified sampling interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve an interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetInterpolatedAtTimesAsyncWithHttpInfo(string webId, string desiredUnits = null, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/interpolatedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetPlotAsync(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetPlotAsyncWithHttpInfo(webId, desiredUnits, endTime, intervals, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
		/// </summary>
		/// <remarks>
		/// For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="intervals">The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetPlotAsyncWithHttpInfo(string webId, string desiredUnits = null, string endTime = null, int? intervals = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/plot";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (intervals!= null) localVarQueryParams.Add("intervals", Configuration.ApiClient.ParameterToString(intervals));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPlotAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetRecordedAsync(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetRecordedAsyncWithHttpInfo(webId, boundaryType, desiredUnits, endTime, filterExpression, includeFilteredValues, maxCount, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns a list of compressed values for the requested time range from the source provider.
		/// </summary>
		/// <remarks>
		/// Returned times are affected by the specified boundary type. If no values are found for the time range and conditions specified then the HTTP response will be success, with a body containing an empty array of Items. When specifying true for the includeFilteredValues parameter, consecutive filtered events are not returned. The first value that would be filtered out is returned with its time and the enumeration value "Filtered". The next value in the collection will be the next compressed value in the specified direction that passes the filter criteria - if any. When both boundaryType and a filterExpression are specified, the events returned for the boundary condition specified are passed through the filter. If the includeFilteredValues parameter is true, the boundary values will be reported at the proper timestamps with the enumeration value "Filtered" when the filter conditions are not met at the boundary time. If the includeFilteredValues parameter is false for this case, no event is returned for the boundary time.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="boundaryType">An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.</param>
		/// <param name="includeFilteredValues">Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.</param>
		/// <param name="maxCount">The maximum number of values to be returned. The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetRecordedAsyncWithHttpInfo(string webId, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", Configuration.ApiClient.ParameterToString(boundaryType));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (includeFilteredValues!= null) localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSubstatus></returns>
		public async System.Threading.Tasks.Task<PIItemsSubstatus> UpdateValuesAsync(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<PIItemsSubstatus> localVarResponse = await UpdateValuesAsyncWithHttpInfo(webId, values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates multiple values for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="values">The values to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSubstatus>> UpdateValuesAsyncWithHttpInfo(string webId, List<PITimedValue> values, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'values' is set
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streams/{webId}/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (values != null && values.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(values);
			}
			else
			{
				localVarPostBody = values;
			}
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", Configuration.ApiClient.ParameterToString(bufferOption));
			if (updateOption!= null) localVarQueryParams.Add("updateOption", Configuration.ApiClient.ParameterToString(updateOption));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValuesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSubstatus>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValue></returns>
		public async System.Threading.Tasks.Task<PITimedValue> GetRecordedAtTimeAsync(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			ApiResponse<PITimedValue> localVarResponse = await GetRecordedAtTimeAsyncWithHttpInfo(webId, time, desiredUnits, retrievalMode, selectedFields, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns a single recorded value based on the passed time and retrieval mode from the stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="time">The timestamp at which the value is desired.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValue>> GetRecordedAtTimeAsyncWithHttpInfo(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'time' is set
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streams/{webId}/recordedattime";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimeAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetRecordedAtTimesAsync(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetRecordedAtTimesAsyncWithHttpInfo(webId, desiredUnits, retrievalMode, selectedFields, sortOrder, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves recorded values at the specified times.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="retrievalMode">An optional value that determines the value to return when a value doesn't exist at the exact time specified. The default is 'Auto'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetRecordedAtTimesAsyncWithHttpInfo(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/recordedattimes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSummaryValue></returns>
		public async System.Threading.Tasks.Task<PIItemsSummaryValue> GetSummaryAsync(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null)
		{
			ApiResponse<PIItemsSummaryValue> localVarResponse = await GetSummaryAsyncWithHttpInfo(webId, calculationBasis, endTime, filterExpression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryType, timeType, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns a summary over the specified time range for the stream.
		/// </summary>
		/// <remarks>
		/// Count is the only summary type supported on non-numeric streams. Requesting a summary for any other type will generate an error. Time-weighted totals are computed by integrating the rate tag values over the requested time range. If some of the data are bad in the time range, the calculated total is divided by the fraction of the time period for which there are good values. This approach is equivalent to assuming that during the period of bad data, the tag takes on the average values for the entire calculation time range. The PercentGood summary may be used to determine if the calculation results are suitable for the application's purposes. For time-weighted totals, if the time unit rate of the stream cannot be determined, then the value will be totaled assuming a unit of "per day" and no unit of measure will be assigned to the value. If the measured time component of the tag is not based on a day, the user of the data must convert the totalized value to the correct units.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="filterExpression">A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute.</param>
		/// <param name="sampleInterval">When the sampleType is Interval, sampleInterval specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="sampleType">Defines the evaluation of an expression over a time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval. If specified in hours, minutes, seconds, or milliseconds, the summary durations will be evenly spaced UTC time intervals. Longer interval types are interpreted using wall clock rules and are time zone dependent.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>> GetSummaryAsyncWithHttpInfo(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", Configuration.ApiClient.ParameterToString(calculationBasis));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", Configuration.ApiClient.ParameterToString(sampleInterval));
			if (sampleType!= null) localVarQueryParams.Add("sampleType", Configuration.ApiClient.ParameterToString(sampleType));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", Configuration.ApiClient.ParameterToString(summaryDuration));
			if (summaryType!= null) localVarQueryParams.Add("summaryType", Configuration.ApiClient.ParameterToString(summaryType));
			if (timeType!= null) localVarQueryParams.Add("timeType", Configuration.ApiClient.ParameterToString(timeType));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummaryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSummaryValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSummaryValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSummaryValue)));
		}

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValue></returns>
		public async System.Threading.Tasks.Task<PITimedValue> GetValueAsync(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null)
		{
			ApiResponse<PITimedValue> localVarResponse = await GetValueAsyncWithHttpInfo(webId, desiredUnits, selectedFields, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the value of the stream at the specified time. By default, this is usually the current value.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="desiredUnits">The name or abbreviation of the desired units of measure for the returned value, as found in the UOM database associated with the attribute. If not specified for an attribute, the attribute's default unit of measure is used. If the underlying stream is a point, this value may not be specified, as points are not associated with a unit of measure.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="time">An optional time. The default time context is determined from the owning object - for example, the time range of the event frame or transfer which holds this attribute. Otherwise, the implementation of the Data Reference determines the meaning of no context. For Points or simply configured PI Point Data References, this means the snapshot value of the PI Point on the Data Server.</param>
		/// <param name="timeZone">The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValue>> GetValueAsyncWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValueAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValue>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateValueAsync(string webId, PITimedValue value, string bufferOption = null, string updateOption = null)
		{
			ApiResponse<Object> localVarResponse = await UpdateValueAsyncWithHttpInfo(webId, value, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Updates a value for the specified stream.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the stream.</param>
		/// <param name="value">The value to add or update.</param>
		/// <param name="bufferOption">The desired AFBufferOption. The default is 'BufferIfPossible'.</param>
		/// <param name="updateOption">The desired AFUpdateOption. The default is 'Replace'. This parameter is ignored if the attribute is a configuration item.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateValueAsyncWithHttpInfo(string webId, PITimedValue value, string bufferOption = null, string updateOption = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'value' is set
			if (value == null)
				throw new ApiException(400, "Missing required parameter 'value'");

			var localVarPath = "/streams/{webId}/value";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (value != null && value.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(value);
			}
			else
			{
				localVarPostBody = value;
			}
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", Configuration.ApiClient.ParameterToString(bufferOption));
			if (updateOption!= null) localVarQueryParams.Add("updateOption", Configuration.ApiClient.ParameterToString(updateOption));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValueAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
	}
}
