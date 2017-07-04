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
	/// Represents a collection of functions to interact with the PI Web API Element controller.
	/// </summary>
	public interface IElementApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIElement</returns>
		PIElement GetByPath(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIElement></returns>
		ApiResponse<PIElement> GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIElement</returns>
		PIElement Get(string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIElement></returns>
		ApiResponse<PIElement> GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>Object</returns>
		Object Update(string webId, PIElement element);

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateWithHttpInfo(string webId, PIElement element);

		/// <summary>
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>Object</returns>
		Object Delete(string webId);

		/// <summary>
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteWithHttpInfo(string webId);

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>PIItemsAnalysis</returns>
		PIItemsAnalysis GetAnalyses(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>ApiResponse<PIItemsAnalysis></returns>
		ApiResponse<PIItemsAnalysis> GetAnalysesWithHttpInfo(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>Object</returns>
		Object CreateAnalysis(string webId, PIAnalysis analysis);

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAnalysisWithHttpInfo(string webId, PIAnalysis analysis);

		/// <summary>
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>Object</returns>
		Object CreateAttribute(string webId, PIAttribute attribute);

		/// <summary>
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAttributeWithHttpInfo(string webId, PIAttribute attribute);

		/// <summary>
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsElementCategory</returns>
		PIItemsElementCategory GetCategories(string webId, string selectedFields = null);

		/// <summary>
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsElementCategory></returns>
		ApiResponse<PIItemsElementCategory> GetCategoriesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>Object</returns>
		Object CreateConfig(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateConfigWithHttpInfo(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>PIItemsAttribute</returns>
		PIItemsAttribute FindElementAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		ApiResponse<PIItemsAttribute> FindElementAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>PIItemsElement</returns>
		PIItemsElement GetElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		ApiResponse<PIItemsElement> GetElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>Object</returns>
		Object CreateElement(string webId, PIElement element);

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateElementWithHttpInfo(string webId, PIElement element);

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>PIItemsEventFrame</returns>
		PIItemsEventFrame GetEventFrames(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>ApiResponse<PIItemsEventFrame></returns>
		ApiResponse<PIItemsEventFrame> GetEventFramesWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>PIItemsElement</returns>
		PIItemsElement GetReferencedElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		ApiResponse<PIItemsElement> GetReferencedElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>Object</returns>
		Object AddReferencedElement(string webId, List<string> referencedElementWebId, string referenceType = null);

		/// <summary>
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> AddReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null);

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>Object</returns>
		Object RemoveReferencedElement(string webId, List<string> referencedElementWebId);

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> RemoveReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId);

		/// <summary>
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsSecurityRights</returns>
		PIItemsSecurityRights GetSecurity(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsSecurityRights></returns>
		ApiResponse<PIItemsSecurityRights> GetSecurityWithHttpInfo(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsSecurityEntry</returns>
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PISecurityEntry</returns>
		PISecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PISecurityEntry></returns>
		ApiResponse<PISecurityEntry> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>PIItemsItemElement</returns>
		PIItemsItemElement GetMultiple(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<PIItemsItemElement></returns>
		ApiResponse<PIItemsItemElement> GetMultipleWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Object</returns>
		Object CreateSearchByAttribute(PISearchByAttributeElement search);

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSearchByAttributeWithHttpInfo(PISearchByAttributeElement search);

		/// <summary>
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>Object</returns>
		Object ExecuteSearchByAttribute(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> ExecuteSearchByAttributeWithHttpInfo(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIElement></returns>
		System.Threading.Tasks.Task<PIElement> GetByPathAsync(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIElement>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null);

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIElement></returns>
		System.Threading.Tasks.Task<PIElement> GetAsync(string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIElement>> GetAsyncWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIElement element);

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIElement element);

		/// <summary>
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteAsync(string webId);

		/// <summary>
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId);

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysis></returns>
		System.Threading.Tasks.Task<PIItemsAnalysis> GetAnalysesAsync(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>> GetAnalysesAsyncWithHttpInfo(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAnalysisAsync(string webId, PIAnalysis analysis);

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnalysisAsyncWithHttpInfo(string webId, PIAnalysis analysis);

		/// <summary>
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAttributeAsync(string webId, PIAttribute attribute);

		/// <summary>
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAttributeAsyncWithHttpInfo(string webId, PIAttribute attribute);

		/// <summary>
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementCategory></returns>
		System.Threading.Tasks.Task<PIItemsElementCategory> GetCategoriesAsync(string webId, string selectedFields = null);

		/// <summary>
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>> GetCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateConfigAsync(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateConfigAsyncWithHttpInfo(string webId, bool? includeChildElements = null);

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		System.Threading.Tasks.Task<PIItemsAttribute> FindElementAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindElementAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		System.Threading.Tasks.Task<PIItemsElement> GetElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateElementAsync(string webId, PIElement element);

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementAsyncWithHttpInfo(string webId, PIElement element);

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEventFrame></returns>
		System.Threading.Tasks.Task<PIItemsEventFrame> GetEventFramesAsync(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>> GetEventFramesAsyncWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null);

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		System.Threading.Tasks.Task<PIItemsElement> GetReferencedElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetReferencedElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null);

		/// <summary>
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> AddReferencedElementAsync(string webId, List<string> referencedElementWebId, string referenceType = null);

		/// <summary>
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> AddReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null);

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> RemoveReferencedElementAsync(string webId, List<string> referencedElementWebId);

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId);

		/// <summary>
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityRights></returns>
		System.Threading.Tasks.Task<PIItemsSecurityRights> GetSecurityAsync(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>> GetSecurityAsyncWithHttpInfo(string webId, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityEntryAsyncWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>> GetSecurityEntryByNameAsyncWithHttpInfo(string name, string webId, string selectedFields = null);

		/// <summary>
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSecurityEntryAsyncWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSecurityEntryAsyncWithHttpInfo(string name, string webId, bool? applyToChildren = null);

		/// <summary>
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemElement></returns>
		System.Threading.Tasks.Task<PIItemsItemElement> GetMultipleAsync(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemElement>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsItemElement>> GetMultipleAsyncWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null);

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSearchByAttributeAsync(PISearchByAttributeElement search);

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSearchByAttributeAsyncWithHttpInfo(PISearchByAttributeElement search);

		/// <summary>
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> ExecuteSearchByAttributeAsync(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		/// <summary>
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> ExecuteSearchByAttributeAsyncWithHttpInfo(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null);

		#endregion
	}

	public class ElementApi : IElementApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public ElementApi(Configuration configuration = null)
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
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIElement</returns>
		public PIElement GetByPath(string path, string selectedFields = null)
		{
			ApiResponse<PIElement> localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIElement></returns>
		public ApiResponse<PIElement> GetByPathWithHttpInfo(string path, string selectedFields = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/elements";
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

			return new ApiResponse<PIElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIElement)));
		}

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIElement</returns>
		public PIElement Get(string webId, string selectedFields = null)
		{
			ApiResponse<PIElement> localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIElement></returns>
		public ApiResponse<PIElement> GetWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}";
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

			return new ApiResponse<PIElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIElement)));
		}

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>Object</returns>
		public Object Update(string webId, PIElement element)
		{
			ApiResponse<Object> localVarResponse = UpdateWithHttpInfo(webId, element);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateWithHttpInfo(string webId, PIElement element)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'element' is set
			if (element == null)
				throw new ApiException(400, "Missing required parameter 'element'");

			var localVarPath = "/elements/{webId}";
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
			if (element != null && element.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(element);
			}
			else
			{
				localVarPostBody = element;
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
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>Object</returns>
		public Object Delete(string webId)
		{
			ApiResponse<Object> localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}";
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
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>PIItemsAnalysis</returns>
		public PIItemsAnalysis GetAnalyses(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			ApiResponse<PIItemsAnalysis> localVarResponse = GetAnalysesWithHttpInfo(webId, maxCount, selectedFields, sortField, sortOrder, startIndex);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>ApiResponse<PIItemsAnalysis></returns>
		public ApiResponse<PIItemsAnalysis> GetAnalysesWithHttpInfo(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/analyses";
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
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysis>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysis)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysis)));
		}

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>Object</returns>
		public Object CreateAnalysis(string webId, PIAnalysis analysis)
		{
			ApiResponse<Object> localVarResponse = CreateAnalysisWithHttpInfo(webId, analysis);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateAnalysisWithHttpInfo(string webId, PIAnalysis analysis)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'analysis' is set
			if (analysis == null)
				throw new ApiException(400, "Missing required parameter 'analysis'");

			var localVarPath = "/elements/{webId}/analyses";
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
			if (analysis != null && analysis.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(analysis);
			}
			else
			{
				localVarPostBody = analysis;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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

			var localVarPath = "/elements/{webId}/attributes";
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
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>Object</returns>
		public Object CreateAttribute(string webId, PIAttribute attribute)
		{
			ApiResponse<Object> localVarResponse = CreateAttributeWithHttpInfo(webId, attribute);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
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

			var localVarPath = "/elements/{webId}/attributes";
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
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsElementCategory</returns>
		public PIItemsElementCategory GetCategories(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsElementCategory> localVarResponse = GetCategoriesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsElementCategory></returns>
		public ApiResponse<PIItemsElementCategory> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/categories";
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
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>Object</returns>
		public Object CreateConfig(string webId, bool? includeChildElements = null)
		{
			ApiResponse<Object> localVarResponse = CreateConfigWithHttpInfo(webId, includeChildElements);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateConfigWithHttpInfo(string webId, bool? includeChildElements = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/config";
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
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>PIItemsAttribute</returns>
		public PIItemsAttribute FindElementAttributes(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = FindElementAttributesWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, elementCategory, elementDescriptionFilter, elementNameFilter, elementTemplate, elementType, maxCount, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>ApiResponse<PIItemsAttribute></returns>
		public ApiResponse<PIItemsAttribute> FindElementAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/elementattributes";
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
			if (elementCategory!= null) localVarQueryParams.Add("elementCategory", Configuration.ApiClient.ParameterToString(elementCategory));
			if (elementDescriptionFilter!= null) localVarQueryParams.Add("elementDescriptionFilter", Configuration.ApiClient.ParameterToString(elementDescriptionFilter));
			if (elementNameFilter!= null) localVarQueryParams.Add("elementNameFilter", Configuration.ApiClient.ParameterToString(elementNameFilter));
			if (elementTemplate!= null) localVarQueryParams.Add("elementTemplate", Configuration.ApiClient.ParameterToString(elementTemplate));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindElementAttributesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>PIItemsElement</returns>
		public PIItemsElement GetElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = GetElementsWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		public ApiResponse<PIItemsElement> GetElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/elements";
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
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>Object</returns>
		public Object CreateElement(string webId, PIElement element)
		{
			ApiResponse<Object> localVarResponse = CreateElementWithHttpInfo(webId, element);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateElementWithHttpInfo(string webId, PIElement element)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'element' is set
			if (element == null)
				throw new ApiException(400, "Missing required parameter 'element'");

			var localVarPath = "/elements/{webId}/elements";
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
			if (element != null && element.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(element);
			}
			else
			{
				localVarPostBody = element;
			}
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>PIItemsEventFrame</returns>
		public PIItemsEventFrame GetEventFrames(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			ApiResponse<PIItemsEventFrame> localVarResponse = GetEventFramesWithHttpInfo(webId, canBeAcknowledged, categoryName, endTime, isAcknowledged, maxCount, nameFilter, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>ApiResponse<PIItemsEventFrame></returns>
		public ApiResponse<PIItemsEventFrame> GetEventFramesWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/eventframes";
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
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>PIItemsElement</returns>
		public PIItemsElement GetReferencedElements(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = GetReferencedElementsWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, selectedFields, sortField, sortOrder, startIndex, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>ApiResponse<PIItemsElement></returns>
		public ApiResponse<PIItemsElement> GetReferencedElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/referencedelements";
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
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>Object</returns>
		public Object AddReferencedElement(string webId, List<string> referencedElementWebId, string referenceType = null)
		{
			ApiResponse<Object> localVarResponse = AddReferencedElementWithHttpInfo(webId, referencedElementWebId, referenceType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> AddReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/elements/{webId}/referencedelements";
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
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", Configuration.ApiClient.ParameterToString(referencedElementWebId));
			if (referenceType!= null) localVarQueryParams.Add("referenceType", Configuration.ApiClient.ParameterToString(referenceType));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("AddReferencedElementWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>Object</returns>
		public Object RemoveReferencedElement(string webId, List<string> referencedElementWebId)
		{
			ApiResponse<Object> localVarResponse = RemoveReferencedElementWithHttpInfo(webId, referencedElementWebId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> RemoveReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/elements/{webId}/referencedelements";
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
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", Configuration.ApiClient.ParameterToString(referencedElementWebId));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("RemoveReferencedElementWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
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
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
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

			var localVarPath = "/elements/{webId}/security";
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
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsSecurityEntry</returns>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		public ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/securityentries";
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
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
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

			var localVarPath = "/elements/{webId}/securityentries";
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
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PISecurityEntry</returns>
		public PISecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null)
		{
			ApiResponse<PISecurityEntry> localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
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

			var localVarPath = "/elements/{webId}/securityentries/{name}";
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
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
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

			var localVarPath = "/elements/{webId}/securityentries/{name}";
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
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>Object</returns>
		public Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
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

			var localVarPath = "/elements/{webId}/securityentries/{name}";
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
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>PIItemsItemElement</returns>
		public PIItemsItemElement GetMultiple(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{
			ApiResponse<PIItemsItemElement> localVarResponse = GetMultipleWithHttpInfo(asParallel, includeMode, path, selectedFields, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>ApiResponse<PIItemsItemElement></returns>
		public ApiResponse<PIItemsItemElement> GetMultipleWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{

			var localVarPath = "/elements/multiple";
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

			return new ApiResponse<PIItemsItemElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemElement)));
		}

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>Object</returns>
		public Object CreateSearchByAttribute(PISearchByAttributeElement search)
		{
			ApiResponse<Object> localVarResponse = CreateSearchByAttributeWithHttpInfo(search);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateSearchByAttributeWithHttpInfo(PISearchByAttributeElement search)
		{
			// verify the required parameter 'search' is set
			if (search == null)
				throw new ApiException(400, "Missing required parameter 'search'");

			var localVarPath = "/elements/searchbyattribute";
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
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>Object</returns>
		public Object ExecuteSearchByAttribute(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			ApiResponse<Object> localVarResponse = ExecuteSearchByAttributeWithHttpInfo(searchId, categoryName, descriptionFilter, maxCount, nameFilter, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> ExecuteSearchByAttributeWithHttpInfo(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			// verify the required parameter 'searchId' is set
			if (searchId == null)
				throw new ApiException(400, "Missing required parameter 'searchId'");

			var localVarPath = "/elements/searchbyattribute/{searchId}";
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
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
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
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIElement></returns>
		public async System.Threading.Tasks.Task<PIElement> GetByPathAsync(string path, string selectedFields = null)
		{
			ApiResponse<PIElement> localVarResponse = await GetByPathAsyncWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an element by path.
		/// </summary>
		/// <remarks>
		/// This method returns an element based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIElement>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/elements";
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

			return new ApiResponse<PIElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIElement)));
		}

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIElement></returns>
		public async System.Threading.Tasks.Task<PIElement> GetAsync(string webId, string selectedFields = null)
		{
			ApiResponse<PIElement> localVarResponse = await GetAsyncWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIElement>> GetAsyncWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}";
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

			return new ApiResponse<PIElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIElement)));
		}

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIElement element)
		{
			ApiResponse<Object> localVarResponse = await UpdateAsyncWithHttpInfo(webId, element);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update an element by replacing items in its definition.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="element">A partial element containing the desired changes.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIElement element)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'element' is set
			if (element == null)
				throw new ApiException(400, "Missing required parameter 'element'");

			var localVarPath = "/elements/{webId}";
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
			if (element != null && element.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(element);
			}
			else
			{
				localVarPostBody = element;
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
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteAsync(string webId)
		{
			ApiResponse<Object> localVarResponse = await DeleteAsyncWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete an element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}";
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
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysis></returns>
		public async System.Threading.Tasks.Task<PIItemsAnalysis> GetAnalysesAsync(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			ApiResponse<PIItemsAnalysis> localVarResponse = await GetAnalysesAsyncWithHttpInfo(webId, maxCount, selectedFields, sortField, sortOrder, startIndex);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve analyses based on the specified conditions.
		/// </summary>
		/// <remarks>
		/// Users can search for the analyses based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the analyses that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element, which is the Target of the analyses.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysis>> GetAnalysesAsyncWithHttpInfo(string webId, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/analyses";
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
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysis>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysis)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysis)));
		}

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAnalysisAsync(string webId, PIAnalysis analysis)
		{
			ApiResponse<Object> localVarResponse = await CreateAnalysisAsyncWithHttpInfo(webId, analysis);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an Analysis.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the Analysis.</param>
		/// <param name="analysis">The new Analysis definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateAnalysisAsyncWithHttpInfo(string webId, PIAnalysis analysis)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'analysis' is set
			if (analysis == null)
				throw new ApiException(400, "Missing required parameter 'analysis'");

			var localVarPath = "/elements/{webId}/analyses";
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
			if (analysis != null && analysis.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(analysis);
			}
			else
			{
				localVarPostBody = analysis;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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
		/// Get the attributes of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
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

			var localVarPath = "/elements/{webId}/attributes";
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
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
		/// <param name="attribute">The definition of the new attribute.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAttributeAsync(string webId, PIAttribute attribute)
		{
			ApiResponse<Object> localVarResponse = await CreateAttributeAsyncWithHttpInfo(webId, attribute);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a new attribute of the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element on which to create the attribute.</param>
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

			var localVarPath = "/elements/{webId}/attributes";
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
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElementCategory></returns>
		public async System.Threading.Tasks.Task<PIItemsElementCategory> GetCategoriesAsync(string webId, string selectedFields = null)
		{
			ApiResponse<PIItemsElementCategory> localVarResponse = await GetCategoriesAsyncWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get an element's categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElementCategory>> GetCategoriesAsyncWithHttpInfo(string webId, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/categories";
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
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateConfigAsync(string webId, bool? includeChildElements = null)
		{
			ApiResponse<Object> localVarResponse = await CreateConfigAsyncWithHttpInfo(webId, includeChildElements);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="includeChildElements">If true, includes the child elements of the specified element.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateConfigAsyncWithHttpInfo(string webId, bool? includeChildElements = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/config";
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
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttribute></returns>
		public async System.Threading.Tasks.Task<PIItemsAttribute> FindElementAttributesAsync(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			ApiResponse<PIItemsAttribute> localVarResponse = await FindElementAttributesAsyncWithHttpInfo(webId, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, elementCategory, elementDescriptionFilter, elementNameFilter, elementTemplate, elementType, maxCount, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of element attributes matching the specified filters from the specified element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="attributeCategory">Specify that returned attributes must have this category. The default is no filter.</param>
		/// <param name="attributeDescriptionFilter">The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="attributeNameFilter">The attribute name filter string used for finding objects. The default is no filter.</param>
		/// <param name="attributeType">Specify that returned attributes' value type must be this value type. The default is no filter.</param>
		/// <param name="elementCategory">Specify that the owner of the returned attributes must have this category. The default is no filter.</param>
		/// <param name="elementDescriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="elementNameFilter">The element name filter string used for finding objects. The default is no filter.</param>
		/// <param name="elementTemplate">Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.</param>
		/// <param name="elementType">Specify that the element of the returned attributes must have this AFElementType. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned (the page size). The default is 1000.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAttribute>> FindElementAttributesAsyncWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/elementattributes";
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
			if (elementCategory!= null) localVarQueryParams.Add("elementCategory", Configuration.ApiClient.ParameterToString(elementCategory));
			if (elementDescriptionFilter!= null) localVarQueryParams.Add("elementDescriptionFilter", Configuration.ApiClient.ParameterToString(elementDescriptionFilter));
			if (elementNameFilter!= null) localVarQueryParams.Add("elementNameFilter", Configuration.ApiClient.ParameterToString(elementNameFilter));
			if (elementTemplate!= null) localVarQueryParams.Add("elementTemplate", Configuration.ApiClient.ParameterToString(elementTemplate));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindElementAttributesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttribute>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		public async System.Threading.Tasks.Task<PIItemsElement> GetElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = await GetElementsAsyncWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
		/// </summary>
		/// <remarks>
		/// Users can search for the elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/elements";
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
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateElementAsync(string webId, PIElement element)
		{
			ApiResponse<Object> localVarResponse = await CreateElementAsyncWithHttpInfo(webId, element);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a child element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the parent element on which to create the element.</param>
		/// <param name="element">The new element definition.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateElementAsyncWithHttpInfo(string webId, PIElement element)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'element' is set
			if (element == null)
				throw new ApiException(400, "Missing required parameter 'element'");

			var localVarPath = "/elements/{webId}/elements";
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
			if (element != null && element.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(element);
			}
			else
			{
				localVarPostBody = element;
			}
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsEventFrame></returns>
		public async System.Threading.Tasks.Task<PIItemsEventFrame> GetEventFramesAsync(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			ApiResponse<PIItemsEventFrame> localVarResponse = await GetEventFramesAsyncWithHttpInfo(webId, canBeAcknowledged, categoryName, endTime, isAcknowledged, maxCount, nameFilter, searchMode, selectedFields, severity, sortField, sortOrder, startIndex, startTime, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element whose related event frames are sought.</param>
		/// <param name="canBeAcknowledged">Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.</param>
		/// <param name="categoryName">Specify that returned event frames must have this category. The default is no category filter.</param>
		/// <param name="endTime">The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="isAcknowledged">Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding event frames. The default is no filter.</param>
		/// <param name="searchMode">Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="severity">Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="startTime">The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.</param>
		/// <param name="templateName">Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsEventFrame>> GetEventFramesAsyncWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/eventframes";
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
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsElement></returns>
		public async System.Threading.Tasks.Task<PIItemsElement> GetReferencedElementsAsync(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			ApiResponse<PIItemsElement> localVarResponse = await GetReferencedElementsAsyncWithHttpInfo(webId, categoryName, descriptionFilter, elementType, maxCount, nameFilter, selectedFields, sortField, sortOrder, startIndex, templateName);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
		/// </summary>
		/// <remarks>
		/// Users can search for the referenced elements based on specific search parameters. If no parameters are specified in the search, the default values for each parameter will be used and will return the elements that match the default search.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="categoryName">Specify that returned elements must have this category. The default is no category filter.</param>
		/// <param name="descriptionFilter">Specify that returned elements must have this description. The default is no description filter.</param>
		/// <param name="elementType">Specify that returned elements must have this type. The default type is 'Any'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="templateName">Specify that returned elements must have this template or a template derived from this template. The default is no template filter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsElement>> GetReferencedElementsAsyncWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/referencedelements";
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
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> AddReferencedElementAsync(string webId, List<string> referencedElementWebId, string referenceType = null)
		{
			ApiResponse<Object> localVarResponse = await AddReferencedElementAsyncWithHttpInfo(webId, referencedElementWebId, referenceType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Add a reference to an existing element to the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be added to.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <param name="referenceType">The name of the reference type between the parent and the referenced element. The default is "parent-child".</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/elements/{webId}/referencedelements";
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
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", Configuration.ApiClient.ParameterToString(referencedElementWebId));
			if (referenceType!= null) localVarQueryParams.Add("referenceType", Configuration.ApiClient.ParameterToString(referenceType));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("AddReferencedElementAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> RemoveReferencedElementAsync(string webId, List<string> referencedElementWebId)
		{
			ApiResponse<Object> localVarResponse = await RemoveReferencedElementAsyncWithHttpInfo(webId, referencedElementWebId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Remove a reference to an existing element from the child elements collection.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element which the referenced element will be removed from.</param>
		/// <param name="referencedElementWebId">The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveReferencedElementAsyncWithHttpInfo(string webId, List<string> referencedElementWebId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'referencedElementWebId' is set
			if (referencedElementWebId == null)
				throw new ApiException(400, "Missing required parameter 'referencedElementWebId'");

			var localVarPath = "/elements/{webId}/referencedelements";
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
			if (referencedElementWebId!= null) localVarQueryParams.Add("referencedElementWebId", Configuration.ApiClient.ParameterToString(referencedElementWebId));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("RemoveReferencedElementAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
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
		/// Get the security information of the specified security item associated with the element for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element for the security to be checked.</param>
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

			var localVarPath = "/elements/{webId}/security";
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
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string selectedFields = null)
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = await GetSecurityEntriesAsyncWithHttpInfo(webId, nameFilter, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elements/{webId}/securityentries";
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
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = await CreateSecurityEntryAsyncWithHttpInfo(webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the element where the security entry will be created.</param>
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

			var localVarPath = "/elements/{webId}/securityentries";
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
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		public async System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string selectedFields = null)
		{
			ApiResponse<PISecurityEntry> localVarResponse = await GetSecurityEntryByNameAsyncWithHttpInfo(name, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry associated with the element with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element.</param>
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

			var localVarPath = "/elements/{webId}/securityentries/{name}";
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
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = await UpdateSecurityEntryAsyncWithHttpInfo(name, webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the element where the security entry will be updated.</param>
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

			var localVarPath = "/elements/{webId}/securityentries/{name}";
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
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null)
		{
			ApiResponse<Object> localVarResponse = await DeleteSecurityEntryAsyncWithHttpInfo(name, webId, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the element.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the element where the security entry will be deleted.</param>
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

			var localVarPath = "/elements/{webId}/securityentries/{name}";
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
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsItemElement></returns>
		public async System.Threading.Tasks.Task<PIItemsItemElement> GetMultipleAsync(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{
			ApiResponse<PIItemsItemElement> localVarResponse = await GetMultipleAsyncWithHttpInfo(asParallel, includeMode, path, selectedFields, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve multiple elements by web id or path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="asParallel">Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.</param>
		/// <param name="includeMode">The include mode for the return list. The default is 'All'.</param>
		/// <param name="path">The path of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webId">The ID of an element. Multiple elements may be specified with multiple instances of the parameter.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsItemElement>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsItemElement>> GetMultipleAsyncWithHttpInfo(bool? asParallel = null, string includeMode = null, List<string> path = null, string selectedFields = null, List<string> webId = null)
		{

			var localVarPath = "/elements/multiple";
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

			return new ApiResponse<PIItemsItemElement>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemElement)));
		}

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSearchByAttributeAsync(PISearchByAttributeElement search)
		{
			ApiResponse<Object> localVarResponse = await CreateSearchByAttributeAsyncWithHttpInfo(search);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="search"></param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSearchByAttributeAsyncWithHttpInfo(PISearchByAttributeElement search)
		{
			// verify the required parameter 'search' is set
			if (search == null)
				throw new ApiException(400, "Missing required parameter 'search'");

			var localVarPath = "/elements/searchbyattribute";
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
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> ExecuteSearchByAttributeAsync(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			ApiResponse<Object> localVarResponse = await ExecuteSearchByAttributeAsyncWithHttpInfo(searchId, categoryName, descriptionFilter, maxCount, nameFilter, searchFullHierarchy, selectedFields, sortField, sortOrder, startIndex);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Execute a "Search Elements By Attribute Value" operation.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="searchId">The encoded search Id of the "Search Elements By Attribute Value" operation.</param>
		/// <param name="categoryName">Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="descriptionFilter">The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="nameFilter">The name query string used for finding objects. The default is no filter.</param>
		/// <param name="searchFullHierarchy">Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> ExecuteSearchByAttributeAsyncWithHttpInfo(string searchId, string categoryName = null, string descriptionFilter = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)
		{
			// verify the required parameter 'searchId' is set
			if (searchId == null)
				throw new ApiException(400, "Missing required parameter 'searchId'");

			var localVarPath = "/elements/searchbyattribute/{searchId}";
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
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (maxCount!= null) localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (searchFullHierarchy!= null) localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (startIndex!= null) localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
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
