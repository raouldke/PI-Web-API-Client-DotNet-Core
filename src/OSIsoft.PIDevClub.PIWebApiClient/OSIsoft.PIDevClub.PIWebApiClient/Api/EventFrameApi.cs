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
	/// Represents a collection of functions to interact with the PI Web API EventFrame controller.
	/// </summary>
	public interface IEventFrameApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIEventFrame</returns>
		PIEventFrame GetByPath(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIEventFrame></returns>
		ApiResponse<PIEventFrame> GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIEventFrame</returns>
		PIEventFrame Get(string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIEventFrame></returns>
		ApiResponse<PIEventFrame> GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>Object</returns>
		Object Update(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateWithHttpInfo(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>Object</returns>
		Object Delete(string webId);

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteWithHttpInfo(string webId);

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>Object</returns>
		Object Acknowledge(string webId);

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> AcknowledgeWithHttpInfo(string webId);

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsAnnotation</returns>
		PIItemsAnnotation GetAnnotations(string webId, string selectedFields = null);

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsAnnotation></returns>
		ApiResponse<PIItemsAnnotation> GetAnnotationsWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>Object</returns>
		Object CreateAnnotation(string webId, PIAnnotation annotation);

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAnnotationWithHttpInfo(string webId, PIAnnotation annotation);

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIAnnotation</returns>
		PIAnnotation GetAnnotationById(string id, string webId, string selectedFields = null);

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIAnnotation></returns>
		ApiResponse<PIAnnotation> GetAnnotationByIdWithHttpInfo(string id, string webId, string selectedFields = null);

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>Object</returns>
		Object UpdateAnnotation(string id, string webId, PIAnnotation annotation);

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateAnnotationWithHttpInfo(string id, string webId, PIAnnotation annotation);

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>Object</returns>
		Object DeleteAnnotation(string id, string webId);

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteAnnotationWithHttpInfo(string id, string webId);

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>PIItemsAttribute</returns>
		PIItemsAttribute GetAttributes(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null);

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		ApiResponse<PIItemsAttribute> GetAttributesWithHttpInfo(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null);

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>Object</returns>
		Object CreateAttribute(string webId, PIAttribute attribute);

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAttributeWithHttpInfo(string webId, PIAttribute attribute);

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>Object</returns>
		Object CaptureValues(string webId);

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CaptureValuesWithHttpInfo(string webId);

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsElementCategory</returns>
		PIItemsElementCategory GetCategories(string webId, string selectedFields = null);

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsElementCategory></returns>
		ApiResponse<PIItemsElementCategory> GetCategoriesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>Object</returns>
		Object CreateConfig(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateConfigWithHttpInfo(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>PIItemsAttribute</returns>
		PIItemsAttribute FindEventFrameAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		ApiResponse<PIItemsAttribute> FindEventFrameAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>PIItemsEventFrame</returns>
		PIItemsEventFrame GetEventFrames(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>ApiResponse<PIItemsEventFrame></returns>
		ApiResponse<PIItemsEventFrame> GetEventFramesWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>Object</returns>
		Object CreateEventFrame(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsElement</returns>
		PIItemsElement GetReferencedElements(string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		ApiResponse<PIItemsElement> GetReferencedElementsWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsSecurityRights</returns>
		PIItemsSecurityRights GetSecurity(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsSecurityRights></returns>
		ApiResponse<PIItemsSecurityRights> GetSecurityWithHttpInfo(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsSecurityEntry</returns>
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PISecurityEntry</returns>
		PISecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PISecurityEntry></returns>
		ApiResponse<PISecurityEntry> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>PIItemsItemEventFrame</returns>
		PIItemsItemEventFrame GetMultiple(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<PIItemsItemEventFrame></returns>
		ApiResponse<PIItemsItemEventFrame> GetMultipleWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Object</returns>
		Object CreateSearchByAttribute(PISearchByAttributeEventFrame search);

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSearchByAttributeWithHttpInfo(PISearchByAttributeEventFrame search);

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>Object</returns>
		Object ExecuteSearchByAttribute(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> ExecuteSearchByAttributeWithHttpInfo(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIEventFrame></returns>
		System.Threading.Tasks.Task<PIEventFrame> GetByPathAsync(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIEventFrame>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIEventFrame>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIEventFrame></returns>
		System.Threading.Tasks.Task<PIEventFrame> GetAsync(string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIEventFrame>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIEventFrame>> GetAsyncWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteAsync(string webId);

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId);

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> AcknowledgeAsync(string webId);

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> AcknowledgeAsyncWithHttpInfo(string webId);

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnnotation></returns>
		System.Threading.Tasks.Task<PIItemsAnnotation> GetAnnotationsAsync(string webId, string selectedFields = null);

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnnotation>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAnnotation>> GetAnnotationsAsyncWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAnnotationAsync(string webId, PIAnnotation annotation);

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnnotationAsyncWithHttpInfo(string webId, PIAnnotation annotation);

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIAnnotation></returns>
		System.Threading.Tasks.Task<PIAnnotation> GetAnnotationByIdAsync(string id, string webId, string selectedFields = null);

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAnnotation>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIAnnotation>> GetAnnotationByIdAsyncWithHttpInfo(string id, string webId, string selectedFields = null);

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateAnnotationAsync(string id, string webId, PIAnnotation annotation);

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAnnotationAsyncWithHttpInfo(string id, string webId, PIAnnotation annotation);

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteAnnotationAsync(string id, string webId);

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAnnotationAsyncWithHttpInfo(string id, string webId);

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		System.Threading.Tasks.Task<PIItemsAttribute> GetAttributesAsync(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null);

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> GetAttributesAsyncWithHttpInfo(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null);

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAttributeAsync(string webId, PIAttribute attribute);

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAttributeAsyncWithHttpInfo(string webId, PIAttribute attribute);

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CaptureValuesAsync(string webId);

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CaptureValuesAsyncWithHttpInfo(string webId);

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementCategory></returns>
		System.Threading.Tasks.Task<PIItemsElementCategory> GetCategoriesAsync(string webId, string selectedFields = null);

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>> GetCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateConfigAsync(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateConfigAsyncWithHttpInfo(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		System.Threading.Tasks.Task<PIItemsAttribute> FindEventFrameAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindEventFrameAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEventFrame></returns>
		System.Threading.Tasks.Task<PIItemsEventFrame> GetEventFramesAsync(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>> GetEventFramesAsyncWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateEventFrameAsync(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateEventFrameAsyncWithHttpInfo(string webId, PIEventFrame eventFrame);

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		System.Threading.Tasks.Task<PIItemsElement> GetReferencedElementsAsync(string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetReferencedElementsAsyncWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityRights></returns>
		System.Threading.Tasks.Task<PIItemsSecurityRights> GetSecurityAsync(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>> GetSecurityAsyncWithHttpInfo(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityEntryAsyncWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>> GetSecurityEntryByNameAsyncWithHttpInfo(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSecurityEntryAsyncWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSecurityEntryAsyncWithHttpInfo(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemEventFrame></returns>
		System.Threading.Tasks.Task<PIItemsItemEventFrame> GetMultipleAsync(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemEventFrame>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsItemEventFrame>> GetMultipleAsyncWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSearchByAttributeAsync(PISearchByAttributeEventFrame search);

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSearchByAttributeAsyncWithHttpInfo(PISearchByAttributeEventFrame search);

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> ExecuteSearchByAttributeAsync(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> ExecuteSearchByAttributeAsyncWithHttpInfo(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null);

		#endregion
	}

	public class EventFrameApi : IEventFrameApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public EventFrameApi(Configuration configuration = null)
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
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIEventFrame</returns>
		public PIEventFrame GetByPath(string path, string selectedFields = null)
		{
			ApiResponse<PIEventFrame> localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIEventFrame></returns>
		public ApiResponse<PIEventFrame> GetByPathWithHttpInfo(string path, string selectedFields = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/eventframes";
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

			if (path!= null) localVarQueryParams.Add("path", Configuration.ApiClient.ParameterToString(path));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIEventFrame)));
		}

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIEventFrame</returns>
		public PIEventFrame Get(string webId, string selectedFields = null)
		{
			ApiResponse<PIEventFrame> localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIEventFrame></returns>
		public ApiResponse<PIEventFrame> GetWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIEventFrame)));
		}

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>Object</returns>
		public Object Update(string webId, PIEventFrame eventFrame)
		{
			ApiResponse<Object> localVarResponse = UpdateWithHttpInfo(webId, eventFrame);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateWithHttpInfo(string webId, PIEventFrame eventFrame)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'eventFrame' is set
			if (eventFrame == null)
				throw new ApiException(400, "Missing required parameter 'eventFrame'");

			var localVarPath = "/eventframes/{webId}";
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
			if (eventFrame != null && eventFrame.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(eventFrame);
			}
			else
			{
				localVarPostBody = eventFrame;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>Object</returns>
		public Object Delete(string webId)
		{
			ApiResponse<Object> localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}";
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
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>Object</returns>
		public Object Acknowledge(string webId)
		{
			ApiResponse<Object> localVarResponse = AcknowledgeWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> AcknowledgeWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/acknowledge";
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
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("AcknowledgeWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsAnnotation</returns>
		public PIItemsAnnotation GetAnnotations(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsAnnotation> localVarResponse = GetAnnotationsWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsAnnotation></returns>
		public ApiResponse<PIItemsAnnotation> GetAnnotationsWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/annotations";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnnotationsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnnotation>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnnotation)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnnotation)));
		}

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>Object</returns>
		public Object CreateAnnotation(string webId, PIAnnotation annotation)
		{
			ApiResponse<Object> localVarResponse = CreateAnnotationWithHttpInfo(webId, annotation);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateAnnotationWithHttpInfo(string webId, PIAnnotation annotation)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'annotation' is set
			if (annotation == null)
				throw new ApiException(400, "Missing required parameter 'annotation'");

			var localVarPath = "/eventframes/{webId}/annotations";
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
			if (annotation != null && annotation.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(annotation);
			}
			else
			{
				localVarPostBody = annotation;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnnotationWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIAnnotation</returns>
		public PIAnnotation GetAnnotationById(string id, string webId, string selectedFields = null)
		{
			ApiResponse<PIAnnotation> localVarResponse = GetAnnotationByIdWithHttpInfo(id, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIAnnotation></returns>
		public ApiResponse<PIAnnotation> GetAnnotationByIdWithHttpInfo(string id, string webId, string selectedFields = null)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/annotations/{id}";
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

			if (id!= null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnnotationByIdWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAnnotation>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAnnotation)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAnnotation)));
		}

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>Object</returns>
		public Object UpdateAnnotation(string id, string webId, PIAnnotation annotation)
		{
			ApiResponse<Object> localVarResponse = UpdateAnnotationWithHttpInfo(id, webId, annotation);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateAnnotationWithHttpInfo(string id, string webId, PIAnnotation annotation)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'annotation' is set
			if (annotation == null)
				throw new ApiException(400, "Missing required parameter 'annotation'");

			var localVarPath = "/eventframes/{webId}/annotations/{id}";
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

			if (id!= null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (annotation != null && annotation.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(annotation);
			}
			else
			{
				localVarPostBody = annotation;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateAnnotationWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>Object</returns>
		public Object DeleteAnnotation(string id, string webId)
		{
			ApiResponse<Object> localVarResponse = DeleteAnnotationWithHttpInfo(id, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteAnnotationWithHttpInfo(string id, string webId)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/annotations/{id}";
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

			if (id!= null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteAnnotationWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>PIItemsAttribute</returns>
		public PIItemsAttribute GetAttributes(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = GetAttributesWithHttpInfo(webId, categoryName, maxCount, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startIndex, templateName, valueType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		public ApiResponse<PIItemsAttribute> GetAttributesWithHttpInfo(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/attributes";
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
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			if (showHidden!= null) localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			if (valueType!= null) localVarQueryParams.Add("valueType", Configuration.ApiClient.ParameterToString(valueType));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>Object</returns>
		public Object CreateAttribute(string webId, PIAttribute attribute)
		{
			ApiResponse<Object> localVarResponse = CreateAttributeWithHttpInfo(webId, attribute);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateAttributeWithHttpInfo(string webId, PIAttribute attribute)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'attribute' is set
			if (attribute == null)
				throw new ApiException(400, "Missing required parameter 'attribute'");

			var localVarPath = "/eventframes/{webId}/attributes";
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
			if (attribute != null && attribute.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(attribute);
			}
			else
			{
				localVarPostBody = attribute;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAttributeWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>Object</returns>
		public Object CaptureValues(string webId)
		{
			ApiResponse<Object> localVarResponse = CaptureValuesWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CaptureValuesWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/attributes/capture";
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
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CaptureValuesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsElementCategory</returns>
		public PIItemsElementCategory GetCategories(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsElementCategory> localVarResponse = GetCategoriesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsElementCategory></returns>
		public ApiResponse<PIItemsElementCategory> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/categories";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetCategoriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElementCategory>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElementCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementCategory)));
		}

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>Object</returns>
		public Object CreateConfig(string webId, bool? includeChildElements = null)
		{
			ApiResponse<Object> localVarResponse = CreateConfigWithHttpInfo(webId, includeChildElements);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateConfigWithHttpInfo(string webId, bool? includeChildElements = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/config";
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
			if (includeChildElements!= null) localVarQueryParams.Add("includeChildElements", Configuration.ApiClient.ParameterToString(includeChildElements));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateConfigWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>PIItemsAttribute</returns>
		public PIItemsAttribute FindEventFrameAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = FindEventFrameAttributesWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, endTime, eventFrameCategory, eventFrameDescriptionFilter, eventFrameNameFilter, eventFrameTemplate, maxCount, referencedElementNameFilter, searchFullHierarchy, searchMode, selectedFields, sortField, sortOrder, startIndex, startTime);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		public ApiResponse<PIItemsAttribute> FindEventFrameAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/eventframeattributes";
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
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", Configuration.ApiClient.ParameterToString(attributeCategory));
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", Configuration.ApiClient.ParameterToString(attributeDescriptionFilter));
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", Configuration.ApiClient.ParameterToString(attributeNameFilter));
			if (attributeType!= null) localVarQueryParams.Add("attributeType", Configuration.ApiClient.ParameterToString(attributeType));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (eventFrameCategory!= null) localVarQueryParams.Add("eventFrameCategory", Configuration.ApiClient.ParameterToString(eventFrameCategory));
			if (eventFrameDescriptionFilter!= null) localVarQueryParams.Add("eventFrameDescriptionFilter", Configuration.ApiClient.ParameterToString(eventFrameDescriptionFilter));
			if (eventFrameNameFilter!= null) localVarQueryParams.Add("eventFrameNameFilter", Configuration.ApiClient.ParameterToString(eventFrameNameFilter));
			if (eventFrameTemplate!= null) localVarQueryParams.Add("eventFrameTemplate", Configuration.ApiClient.ParameterToString(eventFrameTemplate));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindEventFrameAttributesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>PIItemsEventFrame</returns>
		public PIItemsEventFrame GetEventFrames(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			ApiResponse<PIItemsEventFrame> localVarResponse = GetEventFramesWithHttpInfo(webId, canBeAcknowledged, categoryName, endTime, isAcknowledged, maxCount, nameFilter, referencedElementNameFilter, referencedElementTemplateName, searchFullHierarchy, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>ApiResponse<PIItemsEventFrame></returns>
		public ApiResponse<PIItemsEventFrame> GetEventFramesWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/eventframes";
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
			if (canBeAcknowledged!= null) localVarQueryParams.Add("canBeAcknowledged", Configuration.ApiClient.ParameterToString(canBeAcknowledged));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (isAcknowledged!= null) localVarQueryParams.Add("isAcknowledged", Configuration.ApiClient.ParameterToString(isAcknowledged));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			if (referencedElementTemplateName!= null) localVarQueryParams.Add("referencedElementTemplateName", Configuration.ApiClient.ParameterToString(referencedElementTemplateName));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (severity!= null) localVarQueryParams.Add("severity", Configuration.ApiClient.ParameterToString(severity));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEventFramesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEventFrame)));
		}

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>Object</returns>
		public Object CreateEventFrame(string webId, PIEventFrame eventFrame)
		{
			ApiResponse<Object> localVarResponse = CreateEventFrameWithHttpInfo(webId, eventFrame);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'eventFrame' is set
			if (eventFrame == null)
				throw new ApiException(400, "Missing required parameter 'eventFrame'");

			var localVarPath = "/eventframes/{webId}/eventframes";
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
			if (eventFrame != null && eventFrame.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(eventFrame);
			}
			else
			{
				localVarPostBody = eventFrame;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEventFrameWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsElement</returns>
		public PIItemsElement GetReferencedElements(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = GetReferencedElementsWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		public ApiResponse<PIItemsElement> GetReferencedElementsWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/referencedelements";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetReferencedElementsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsSecurityRights</returns>
		public PIItemsSecurityRights GetSecurity(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)
		{
			ApiResponse<PIItemsSecurityRights> localVarResponse = GetSecurityWithHttpInfo(webId, userIdentity, forceRefresh, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsSecurityRights></returns>
		public ApiResponse<PIItemsSecurityRights> GetSecurityWithHttpInfo(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/eventframes/{webId}/security";
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
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", Configuration.ApiClient.ParameterToString(userIdentity));
			if (forceRefresh!= null) localVarQueryParams.Add("forceRefresh", Configuration.ApiClient.ParameterToString(forceRefresh));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityRights>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityRights)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityRights)));
		}

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsSecurityEntry</returns>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		public ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/securityentries";
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
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityEntry>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/eventframes/{webId}/securityentries";
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
			if (securityEntry != null && securityEntry.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			}
			else
			{
				localVarPostBody = securityEntry;
			}
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PISecurityEntry</returns>
		public PISecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null)
		{
			ApiResponse<PISecurityEntry> localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PISecurityEntry></returns>
		public ApiResponse<PISecurityEntry> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/securityentries/{name}";
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

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByNameWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISecurityEntry>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PISecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISecurityEntry)));
		}

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/eventframes/{webId}/securityentries/{name}";
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

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityEntry != null && securityEntry.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			}
			else
			{
				localVarPostBody = securityEntry;
			}
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		public Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/securityentries/{name}";
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

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>PIItemsItemEventFrame</returns>
		public PIItemsItemEventFrame GetMultiple(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{
			ApiResponse<PIItemsItemEventFrame> localVarResponse = GetMultipleWithHttpInfo(asParallel, includeMode, path, selectedFields, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<PIItemsItemEventFrame></returns>
		public ApiResponse<PIItemsItemEventFrame> GetMultipleWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{

			var localVarPath = "/eventframes/multiple";
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

			if (asParallel!= null) localVarQueryParams.Add("asParallel", Configuration.ApiClient.ParameterToString(asParallel));
			if (includeMode!= null) localVarQueryParams.Add("includeMode", Configuration.ApiClient.ParameterToString(includeMode));
			if (path!= null) localVarQueryParams.Add("path", Configuration.ApiClient.ParameterToString(path));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (webId!= null) localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetMultipleWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsItemEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemEventFrame)));
		}

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Object</returns>
		public Object CreateSearchByAttribute(PISearchByAttributeEventFrame search)
		{
			ApiResponse<Object> localVarResponse = CreateSearchByAttributeWithHttpInfo(search);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateSearchByAttributeWithHttpInfo(PISearchByAttributeEventFrame search)
		{
			// verify the required parameter 'search' is set
			if (search == null)
				throw new ApiException(400, "Missing required parameter 'search'");

			var localVarPath = "/eventframes/searchbyattribute";
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

			if (search != null && search.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(search);
			}
			else
			{
				localVarPostBody = search;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSearchByAttributeWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>Object</returns>
		public Object ExecuteSearchByAttribute(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			ApiResponse<Object> localVarResponse = ExecuteSearchByAttributeWithHttpInfo(searchId, canBeAcknowledged, endTime, isAcknowledged, maxCount, nameFilter, referencedElementNameFilter, searchFullHierarchy, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> ExecuteSearchByAttributeWithHttpInfo(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			// verify the required parameter 'searchId' is set
			if (searchId == null)
				throw new ApiException(400, "Missing required parameter 'searchId'");

			var localVarPath = "/eventframes/searchbyattribute/{searchId}";
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

			if (searchId!= null) localVarPathParams.Add("searchId", Configuration.ApiClient.ParameterToString(searchId));
			if (canBeAcknowledged!= null) localVarQueryParams.Add("canBeAcknowledged", Configuration.ApiClient.ParameterToString(canBeAcknowledged));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (isAcknowledged!= null) localVarQueryParams.Add("isAcknowledged", Configuration.ApiClient.ParameterToString(isAcknowledged));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (severity!= null) localVarQueryParams.Add("severity", Configuration.ApiClient.ParameterToString(severity));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ExecuteSearchByAttributeWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIEventFrame></returns>
		public async System.Threading.Tasks.Task<PIEventFrame> GetByPathAsync(string path, string selectedFields = null)
		{
			ApiResponse<PIEventFrame> localVarResponse = await GetByPathAsyncWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an event frame by path.
		/// </summary>
		/// <remarks>
		/// This method returns an event frame based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIEventFrame>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIEventFrame>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/eventframes";
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

			if (path!= null) localVarQueryParams.Add("path", Configuration.ApiClient.ParameterToString(path));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIEventFrame)));
		}

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIEventFrame></returns>
		public async System.Threading.Tasks.Task<PIEventFrame> GetAsync(string webId, string selectedFields = null)
		{
			ApiResponse<PIEventFrame> localVarResponse = await GetAsyncWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIEventFrame>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIEventFrame>> GetAsyncWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIEventFrame)));
		}

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIEventFrame eventFrame)
		{
			ApiResponse<Object> localVarResponse = await UpdateAsyncWithHttpInfo(webId, eventFrame);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to update.</param>
		/// <param name="eventFrame">A partial event frame containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIEventFrame eventFrame)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'eventFrame' is set
			if (eventFrame == null)
				throw new ApiException(400, "Missing required parameter 'eventFrame'");

			var localVarPath = "/eventframes/{webId}";
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
			if (eventFrame != null && eventFrame.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(eventFrame);
			}
			else
			{
				localVarPostBody = eventFrame;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteAsync(string webId)
		{
			ApiResponse<Object> localVarResponse = await DeleteAsyncWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}";
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
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> AcknowledgeAsync(string webId)
		{
			ApiResponse<Object> localVarResponse = await AcknowledgeAsyncWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Calls the EventFrame's Acknowledge method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> AcknowledgeAsyncWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/acknowledge";
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
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("AcknowledgeAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnnotation></returns>
		public async System.Threading.Tasks.Task<PIItemsAnnotation> GetAnnotationsAsync(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsAnnotation> localVarResponse = await GetAnnotationsAsyncWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get an event frame's annotations.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnnotation>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAnnotation>> GetAnnotationsAsyncWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/annotations";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnnotationsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnnotation>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnnotation)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnnotation)));
		}

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAnnotationAsync(string webId, PIAnnotation annotation)
		{
			ApiResponse<Object> localVarResponse = await CreateAnnotationAsyncWithHttpInfo(webId, annotation);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the owner event frame on which to create the annotation.</param>
		/// <param name="annotation">The new annotation definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnnotationAsyncWithHttpInfo(string webId, PIAnnotation annotation)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'annotation' is set
			if (annotation == null)
				throw new ApiException(400, "Missing required parameter 'annotation'");

			var localVarPath = "/eventframes/{webId}/annotations";
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
			if (annotation != null && annotation.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(annotation);
			}
			else
			{
				localVarPostBody = annotation;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnnotationAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIAnnotation></returns>
		public async System.Threading.Tasks.Task<PIAnnotation> GetAnnotationByIdAsync(string id, string webId, string selectedFields = null)
		{
			ApiResponse<PIAnnotation> localVarResponse = await GetAnnotationByIdAsyncWithHttpInfo(id, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get a specific annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the specific annotation.</param>
		/// <param name="webId">The ID of the owner event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAnnotation>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIAnnotation>> GetAnnotationByIdAsyncWithHttpInfo(string id, string webId, string selectedFields = null)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/annotations/{id}";
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

			if (id!= null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnnotationByIdAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAnnotation>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAnnotation)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAnnotation)));
		}

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateAnnotationAsync(string id, string webId, PIAnnotation annotation)
		{
			ApiResponse<Object> localVarResponse = await UpdateAnnotationAsyncWithHttpInfo(id, webId, annotation);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an annotation on an event frame by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be updated.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to update.</param>
		/// <param name="annotation">A partial annotation containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAnnotationAsyncWithHttpInfo(string id, string webId, PIAnnotation annotation)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'annotation' is set
			if (annotation == null)
				throw new ApiException(400, "Missing required parameter 'annotation'");

			var localVarPath = "/eventframes/{webId}/annotations/{id}";
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

			if (id!= null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (annotation != null && annotation.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(annotation);
			}
			else
			{
				localVarPostBody = annotation;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateAnnotationAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteAnnotationAsync(string id, string webId)
		{
			ApiResponse<Object> localVarResponse = await DeleteAnnotationAsyncWithHttpInfo(id, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an annotation on an event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Annotation identifier of the annotation to be deleted.</param>
		/// <param name="webId">The ID of the owner event frame of the annotation to delete.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAnnotationAsyncWithHttpInfo(string id, string webId)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400, "Missing required parameter 'id'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/annotations/{id}";
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

			if (id!= null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteAnnotationAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		public async System.Threading.Tasks.Task<PIItemsAttribute> GetAttributesAsync(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = await GetAttributesAsyncWithHttpInfo(webId, categoryName, maxCount, nameFilter, searchFullHierarchy, selectedFields, showExcluded, showHidden, sortField, sortOrder, startIndex, templateName, valueType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the attributes of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="categoryName">Specify that returned attributes must have this category. The default is no category filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding attributes. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="showExcluded">Specified if the search should include attributes with the Excluded property set. The default is 'false'.</param>
		/// <param name="showHidden">Specified if the search should include attributes with the Hidden property set. The default is 'false'.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned attributes must be members of this template. The default is no template filter.</param>
		/// <param name="valueType">Specify that returned attributes' value type must be the given value type. The default is no value type filter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> GetAttributesAsyncWithHttpInfo(string webId, string categoryName = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null, string valueType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/attributes";
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
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (showExcluded!= null) localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			if (showHidden!= null) localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			if (valueType!= null) localVarQueryParams.Add("valueType", Configuration.ApiClient.ParameterToString(valueType));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAttributeAsync(string webId, PIAttribute attribute)
		{
			ApiResponse<Object> localVarResponse = await CreateAttributeAsyncWithHttpInfo(webId, attribute);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a new attribute of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateAttributeAsyncWithHttpInfo(string webId, PIAttribute attribute)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'attribute' is set
			if (attribute == null)
				throw new ApiException(400, "Missing required parameter 'attribute'");

			var localVarPath = "/eventframes/{webId}/attributes";
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
			if (attribute != null && attribute.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(attribute);
			}
			else
			{
				localVarPostBody = attribute;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAttributeAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CaptureValuesAsync(string webId)
		{
			ApiResponse<Object> localVarResponse = await CaptureValuesAsyncWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Calls the EventFrame's CaptureValues method.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CaptureValuesAsyncWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/attributes/capture";
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
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CaptureValuesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementCategory></returns>
		public async System.Threading.Tasks.Task<PIItemsElementCategory> GetCategoriesAsync(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsElementCategory> localVarResponse = await GetCategoriesAsyncWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get an event frame's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>> GetCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/categories";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetCategoriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElementCategory>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElementCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementCategory)));
		}

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateConfigAsync(string webId, bool? includeChildElements = null)
		{
			ApiResponse<Object> localVarResponse = await CreateConfigAsyncWithHttpInfo(webId, includeChildElements);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="includeChildElements">If true, includes the child event frames of the specified event frame.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateConfigAsyncWithHttpInfo(string webId, bool? includeChildElements = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/config";
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
			if (includeChildElements!= null) localVarQueryParams.Add("includeChildElements", Configuration.ApiClient.ParameterToString(includeChildElements));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateConfigAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		public async System.Threading.Tasks.Task<PIItemsAttribute> FindEventFrameAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = await FindEventFrameAttributesAsyncWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, endTime, eventFrameCategory, eventFrameDescriptionFilter, eventFrameNameFilter, eventFrameTemplate, maxCount, referencedElementNameFilter, searchFullHierarchy, searchMode, selectedFields, sortField, sortOrder, startIndex, startTime);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="endTime">A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.</param>
		/// <param name="eventFrameCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="eventFrameDescriptionFilter">The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="eventFrameNameFilter">The event frame name filter string used for finding objects. The default is no filter.</param>
		/// <param name="eventFrameTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindEventFrameAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/eventframeattributes";
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
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", Configuration.ApiClient.ParameterToString(attributeCategory));
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", Configuration.ApiClient.ParameterToString(attributeDescriptionFilter));
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", Configuration.ApiClient.ParameterToString(attributeNameFilter));
			if (attributeType!= null) localVarQueryParams.Add("attributeType", Configuration.ApiClient.ParameterToString(attributeType));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (eventFrameCategory!= null) localVarQueryParams.Add("eventFrameCategory", Configuration.ApiClient.ParameterToString(eventFrameCategory));
			if (eventFrameDescriptionFilter!= null) localVarQueryParams.Add("eventFrameDescriptionFilter", Configuration.ApiClient.ParameterToString(eventFrameDescriptionFilter));
			if (eventFrameNameFilter!= null) localVarQueryParams.Add("eventFrameNameFilter", Configuration.ApiClient.ParameterToString(eventFrameNameFilter));
			if (eventFrameTemplate!= null) localVarQueryParams.Add("eventFrameTemplate", Configuration.ApiClient.ParameterToString(eventFrameTemplate));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindEventFrameAttributesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEventFrame></returns>
		public async System.Threading.Tasks.Task<PIItemsEventFrame> GetEventFramesAsync(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			ApiResponse<PIItemsEventFrame> localVarResponse = await GetEventFramesAsyncWithHttpInfo(webId, canBeAcknowledged, categoryName, endTime, isAcknowledged, maxCount, nameFilter, referencedElementNameFilter, referencedElementTemplateName, searchFullHierarchy, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame to use as the root of the search.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="referencedElementTemplateName">Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>> GetEventFramesAsyncWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/eventframes";
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
			if (canBeAcknowledged!= null) localVarQueryParams.Add("canBeAcknowledged", Configuration.ApiClient.ParameterToString(canBeAcknowledged));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (isAcknowledged!= null) localVarQueryParams.Add("isAcknowledged", Configuration.ApiClient.ParameterToString(isAcknowledged));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			if (referencedElementTemplateName!= null) localVarQueryParams.Add("referencedElementTemplateName", Configuration.ApiClient.ParameterToString(referencedElementTemplateName));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (severity!= null) localVarQueryParams.Add("severity", Configuration.ApiClient.ParameterToString(severity));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEventFramesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEventFrame)));
		}

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateEventFrameAsync(string webId, PIEventFrame eventFrame)
		{
			ApiResponse<Object> localVarResponse = await CreateEventFrameAsyncWithHttpInfo(webId, eventFrame);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an event frame as a child of the specified event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent event frame on which to create the event frame.</param>
		/// <param name="eventFrame">The new event frame definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateEventFrameAsyncWithHttpInfo(string webId, PIEventFrame eventFrame)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'eventFrame' is set
			if (eventFrame == null)
				throw new ApiException(400, "Missing required parameter 'eventFrame'");

			var localVarPath = "/eventframes/{webId}/eventframes";
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
			if (eventFrame != null && eventFrame.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(eventFrame);
			}
			else
			{
				localVarPostBody = eventFrame;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEventFrameAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		public async System.Threading.Tasks.Task<PIItemsElement> GetReferencedElementsAsync(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = await GetReferencedElementsAsyncWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the event frame's referenced elements.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame whose referenced elements should be retrieved.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetReferencedElementsAsyncWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/referencedelements";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetReferencedElementsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityRights></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityRights> GetSecurityAsync(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)
		{
			ApiResponse<PIItemsSecurityRights> localVarResponse = await GetSecurityAsyncWithHttpInfo(webId, userIdentity, forceRefresh, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the event frame for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>> GetSecurityAsyncWithHttpInfo(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/eventframes/{webId}/security";
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
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", Configuration.ApiClient.ParameterToString(userIdentity));
			if (forceRefresh!= null) localVarQueryParams.Add("forceRefresh", Configuration.ApiClient.ParameterToString(forceRefresh));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityRights>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityRights)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityRights)));
		}

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string selectedFields = null)
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = await GetSecurityEntriesAsyncWithHttpInfo(webId, nameFilter, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/securityentries";
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
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityEntry>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = await CreateSecurityEntryAsyncWithHttpInfo(webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the event frame where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityEntryAsyncWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/eventframes/{webId}/securityentries";
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
			if (securityEntry != null && securityEntry.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			}
			else
			{
				localVarPostBody = securityEntry;
			}
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		public async System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string selectedFields = null)
		{
			ApiResponse<PISecurityEntry> localVarResponse = await GetSecurityEntryByNameAsyncWithHttpInfo(name, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry associated with the event frame with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>> GetSecurityEntryByNameAsyncWithHttpInfo(string name, string webId, string selectedFields = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/securityentries/{name}";
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

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByNameAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISecurityEntry>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PISecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISecurityEntry)));
		}

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = await UpdateSecurityEntryAsyncWithHttpInfo(name, webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSecurityEntryAsyncWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/eventframes/{webId}/securityentries/{name}";
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

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityEntry != null && securityEntry.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			}
			else
			{
				localVarPostBody = securityEntry;
			}
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = await DeleteSecurityEntryAsyncWithHttpInfo(name, webId, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the event frame.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the event frame where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSecurityEntryAsyncWithHttpInfo(string name, string webId, bool? applyToChildren = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/eventframes/{webId}/securityentries/{name}";
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

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemEventFrame></returns>
		public async System.Threading.Tasks.Task<PIItemsItemEventFrame> GetMultipleAsync(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{
			ApiResponse<PIItemsItemEventFrame> localVarResponse = await GetMultipleAsyncWithHttpInfo(asParallel, includeMode, path, selectedFields, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve multiple event frames by web ids or paths.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemEventFrame>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsItemEventFrame>> GetMultipleAsyncWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{

			var localVarPath = "/eventframes/multiple";
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

			if (asParallel!= null) localVarQueryParams.Add("asParallel", Configuration.ApiClient.ParameterToString(asParallel));
			if (includeMode!= null) localVarQueryParams.Add("includeMode", Configuration.ApiClient.ParameterToString(includeMode));
			if (path!= null) localVarQueryParams.Add("path", Configuration.ApiClient.ParameterToString(path));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (webId!= null) localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetMultipleAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsItemEventFrame>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemEventFrame)));
		}

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSearchByAttributeAsync(PISearchByAttributeEventFrame search)
		{
			ApiResponse<Object> localVarResponse = await CreateSearchByAttributeAsyncWithHttpInfo(search);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSearchByAttributeAsyncWithHttpInfo(PISearchByAttributeEventFrame search)
		{
			// verify the required parameter 'search' is set
			if (search == null)
				throw new ApiException(400, "Missing required parameter 'search'");

			var localVarPath = "/eventframes/searchbyattribute";
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

			if (search != null && search.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(search);
			}
			else
			{
				localVarPostBody = search;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSearchByAttributeAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> ExecuteSearchByAttributeAsync(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			ApiResponse<Object> localVarResponse = await ExecuteSearchByAttributeAsyncWithHttpInfo(searchId, canBeAcknowledged, endTime, isAcknowledged, maxCount, nameFilter, referencedElementNameFilter, searchFullHierarchy, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Execute a "Search EventFrames By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search EventFrames By Attribute Value" operation.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="endTime">The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="referencedElementNameFilter">The name query string which must match the name of a referenced element. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> ExecuteSearchByAttributeAsyncWithHttpInfo(string searchId, bool? canBeAcknowledged = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)
		{
			// verify the required parameter 'searchId' is set
			if (searchId == null)
				throw new ApiException(400, "Missing required parameter 'searchId'");

			var localVarPath = "/eventframes/searchbyattribute/{searchId}";
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

			if (searchId!= null) localVarPathParams.Add("searchId", Configuration.ApiClient.ParameterToString(searchId));
			if (canBeAcknowledged!= null) localVarQueryParams.Add("canBeAcknowledged", Configuration.ApiClient.ParameterToString(canBeAcknowledged));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (isAcknowledged!= null) localVarQueryParams.Add("isAcknowledged", Configuration.ApiClient.ParameterToString(isAcknowledged));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (severity!= null) localVarQueryParams.Add("severity", Configuration.ApiClient.ParameterToString(severity));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ExecuteSearchByAttributeAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
	}
}
