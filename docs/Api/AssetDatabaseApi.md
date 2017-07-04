# AssetDatabaseApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AssetDatabaseApi.md#getbypath) | **GET** /assetdatabases | Retrieve an Asset Database by path.
[**Get**](AssetDatabaseApi.md#get) | **GET** /assetdatabases/{webId} | Retrieve an Asset Database.
[**Update**](AssetDatabaseApi.md#update) | **PATCH** /assetdatabases/{webId} | Update an asset database by replacing items in its definition.
[**Delete**](AssetDatabaseApi.md#delete) | **DELETE** /assetdatabases/{webId} | Delete an asset database.
[**FindAnalyses**](AssetDatabaseApi.md#findanalyses) | **GET** /assetdatabases/{webId}/analyses | Retrieve analyses based on the specified conditions.
[**GetAnalysisCategories**](AssetDatabaseApi.md#getanalysiscategories) | **GET** /assetdatabases/{webId}/analysiscategories | Retrieve analysis categories for a given Asset Database.
[**CreateAnalysisCategory**](AssetDatabaseApi.md#createanalysiscategory) | **POST** /assetdatabases/{webId}/analysiscategories | Create an analysis category at the Asset Database root.
[**GetAnalysisTemplates**](AssetDatabaseApi.md#getanalysistemplates) | **GET** /assetdatabases/{webId}/analysistemplates | Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
[**CreateAnalysisTemplate**](AssetDatabaseApi.md#createanalysistemplate) | **POST** /assetdatabases/{webId}/analysistemplates | Create an analysis template at the Asset Database root.
[**GetAttributeCategories**](AssetDatabaseApi.md#getattributecategories) | **GET** /assetdatabases/{webId}/attributecategories | Retrieve attribute categories for a given Asset Database.
[**CreateAttributeCategory**](AssetDatabaseApi.md#createattributecategory) | **POST** /assetdatabases/{webId}/attributecategories | Create an attribute category at the Asset Database root.
[**FindElementAttributes**](AssetDatabaseApi.md#findelementattributes) | **GET** /assetdatabases/{webId}/elementattributes | Retrieves a list of element attributes matching the specified filters from the specified asset database.
[**GetElementCategories**](AssetDatabaseApi.md#getelementcategories) | **GET** /assetdatabases/{webId}/elementcategories | Retrieve element categories for a given Asset Database.
[**CreateElementCategory**](AssetDatabaseApi.md#createelementcategory) | **POST** /assetdatabases/{webId}/elementcategories | Create an element category at the Asset Database root.
[**GetElements**](AssetDatabaseApi.md#getelements) | **GET** /assetdatabases/{webId}/elements | Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
[**CreateElement**](AssetDatabaseApi.md#createelement) | **POST** /assetdatabases/{webId}/elements | Create a child element.
[**GetElementTemplates**](AssetDatabaseApi.md#getelementtemplates) | **GET** /assetdatabases/{webId}/elementtemplates | Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
[**CreateElementTemplate**](AssetDatabaseApi.md#createelementtemplate) | **POST** /assetdatabases/{webId}/elementtemplates | Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
[**GetEnumerationSets**](AssetDatabaseApi.md#getenumerationsets) | **GET** /assetdatabases/{webId}/enumerationsets | Retrieve enumeration sets for given asset database.
[**CreateEnumerationSet**](AssetDatabaseApi.md#createenumerationset) | **POST** /assetdatabases/{webId}/enumerationsets | Create an enumeration set at the Asset Database.
[**FindEventFrameAttributes**](AssetDatabaseApi.md#findeventframeattributes) | **GET** /assetdatabases/{webId}/eventframeattributes | Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
[**GetEventFrames**](AssetDatabaseApi.md#geteventframes) | **GET** /assetdatabases/{webId}/eventframes | Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.
[**CreateEventFrame**](AssetDatabaseApi.md#createeventframe) | **POST** /assetdatabases/{webId}/eventframes | Create an event frame.
[**Export**](AssetDatabaseApi.md#export) | **GET** /assetdatabases/{webId}/export | Export the asset database.
[**Import**](AssetDatabaseApi.md#import) | **POST** /assetdatabases/{webId}/import | Import an asset database.
[**GetReferencedElements**](AssetDatabaseApi.md#getreferencedelements) | **GET** /assetdatabases/{webId}/referencedelements | Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
[**AddReferencedElement**](AssetDatabaseApi.md#addreferencedelement) | **POST** /assetdatabases/{webId}/referencedelements | Add a reference to an existing element to the specified database.
[**RemoveReferencedElement**](AssetDatabaseApi.md#removereferencedelement) | **DELETE** /assetdatabases/{webId}/referencedelements | Remove a reference to an existing element from the specified database.
[**GetSecurity**](AssetDatabaseApi.md#getsecurity) | **GET** /assetdatabases/{webId}/security | Get the security information of the specified security item associated with the asset database for a specified user.
[**GetSecurityEntries**](AssetDatabaseApi.md#getsecurityentries) | **GET** /assetdatabases/{webId}/securityentries | Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
[**CreateSecurityEntry**](AssetDatabaseApi.md#createsecurityentry) | **POST** /assetdatabases/{webId}/securityentries | Create a security entry owned by the asset database.
[**GetSecurityEntryByName**](AssetDatabaseApi.md#getsecurityentrybyname) | **GET** /assetdatabases/{webId}/securityentries/{name} | Retrieve the security entry of the specified security item associated with the asset database with the specified name.
[**UpdateSecurityEntry**](AssetDatabaseApi.md#updatesecurityentry) | **PUT** /assetdatabases/{webId}/securityentries/{name} | Update a security entry owned by the asset database.
[**DeleteSecurityEntry**](AssetDatabaseApi.md#deletesecurityentry) | **DELETE** /assetdatabases/{webId}/securityentries/{name} | Delete a security entry owned by the asset database.
[**GetTableCategories**](AssetDatabaseApi.md#gettablecategories) | **GET** /assetdatabases/{webId}/tablecategories | Retrieve table categories for a given Asset Database.
[**CreateTableCategory**](AssetDatabaseApi.md#createtablecategory) | **POST** /assetdatabases/{webId}/tablecategories | Create a table category on the Asset Database.
[**GetTables**](AssetDatabaseApi.md#gettables) | **GET** /assetdatabases/{webId}/tables | Retrieve tables for given Asset Database.
[**CreateTable**](AssetDatabaseApi.md#createtable) | **POST** /assetdatabases/{webId}/tables | Create a table on the Asset Database.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an Asset Database by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAssetDatabase>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIAssetDatabase>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIAssetDatabase database)

Update an asset database by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **database** | **PIAssetDatabase**| A partial database containing the desired changes.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **FindAnalysesWithHttpInfo**
> FindAnalysesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)

Retrieve analyses based on the specified conditions.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database to search for the analyses.. | [required]
 **field** | **List<string>**| Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.. | [required]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **query** | **string**| The query string used for finding analyses. The default is null.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]


### Return type

ApiResponse<PIItemsAnalysis>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAnalysisCategoriesWithHttpInfo**
> GetAnalysisCategoriesWithHttpInfo(string webId, string selectedFields = null)

Retrieve analysis categories for a given Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAnalysisCategory>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAnalysisCategoryWithHttpInfo**
> CreateAnalysisCategoryWithHttpInfo(string webId, PIAnalysisCategory analysisCategory)

Create an analysis category at the Asset Database root.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the analysis category.. | [required]
 **analysisCategory** | **PIAnalysisCategory**| The new analysis category definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAnalysisTemplatesWithHttpInfo**
> GetAnalysisTemplatesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database to search.. | [required]
 **field** | **List<string>**| Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.. | [required]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **query** | **string**| The query string used for finding objects. The default is no query string.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]


### Return type

ApiResponse<PIItemsAnalysisTemplate>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAnalysisTemplateWithHttpInfo**
> CreateAnalysisTemplateWithHttpInfo(string webId, PIAnalysisTemplate template)

Create an analysis template at the Asset Database root.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the analysis template.. | [required]
 **template** | **PIAnalysisTemplate**| The new analysis template definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributeCategoriesWithHttpInfo**
> GetAttributeCategoriesWithHttpInfo(string webId, string selectedFields = null)

Retrieve attribute categories for a given Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsAttributeCategory>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAttributeCategoryWithHttpInfo**
> CreateAttributeCategoryWithHttpInfo(string webId, PIAttributeCategory attributeCategory)

Create an attribute category at the Asset Database root.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the attribute category.. | [required]
 **attributeCategory** | **PIAttributeCategory**| The new attribute category definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **FindElementAttributesWithHttpInfo**
> FindElementAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, int? maxCount = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null)

Retrieves a list of element attributes matching the specified filters from the specified asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database to use as the root of the search.. | [required]
 **attributeCategory** | **string**| Specify that returned attributes must have this category. The default is no filter.. | [optional]
 **attributeDescriptionFilter** | **string**| The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. | [optional]
 **attributeNameFilter** | **string**| The attribute name filter string used for finding objects. The default is no filter.. | [optional]
 **attributeType** | **string**| Specify that returned attributes' value type must be this value type. The default is no filter.. | [optional]
 **elementCategory** | **string**| Specify that the owner of the returned attributes must have this category. The default is no filter.. | [optional]
 **elementDescriptionFilter** | **string**| The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. | [optional]
 **elementNameFilter** | **string**| The element name filter string used for finding objects. The default is no filter.. | [optional]
 **elementTemplate** | **string**| Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.. | [optional]
 **elementType** | **string**| Specify that the element of the returned attributes must have this AFElementType. The default is no filter.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned (the page size). The default is 1000.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]


### Return type

ApiResponse<PIItemsAttribute>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetElementCategoriesWithHttpInfo**
> GetElementCategoriesWithHttpInfo(string webId, string selectedFields = null)

Retrieve element categories for a given Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsElementCategory>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateElementCategoryWithHttpInfo**
> CreateElementCategoryWithHttpInfo(string webId, PIElementCategory elementCategory)

Create an element category at the Asset Database root.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the element category.. | [required]
 **elementCategory** | **PIElementCategory**| The new element category definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetElementsWithHttpInfo**
> GetElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)

Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database to use as the root of the search.. | [required]
 **categoryName** | **string**| Specify that returned elements must have this category. The default is no category filter.. | [optional]
 **descriptionFilter** | **string**| Specify that returned elements must have this description. The default is no description filter.. | [optional]
 **elementType** | **string**| Specify that returned elements must have this type. The default type is 'Any'.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]
 **templateName** | **string**| Specify that returned elements must have this template or a template derived from this template. The default is no template filter.. | [optional]


### Return type

ApiResponse<PIItemsElement>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateElementWithHttpInfo**
> CreateElementWithHttpInfo(string webId, PIElement element)

Create a child element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database on which to create the element.. | [required]
 **element** | **PIElement**| The new element definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetElementTemplatesWithHttpInfo**
> GetElementTemplatesWithHttpInfo(string webId, List<string> field, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database to search.. | [required]
 **field** | **List<string>**| Specifies which of the object's properties are searched. Multiple search fields may be specified with multiple instances of the parameter. The default is 'Name'.. | [required]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **query** | **string**| The query string used for finding objects. The default is no query string.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]


### Return type

ApiResponse<PIItemsElementTemplate>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateElementTemplateWithHttpInfo**
> CreateElementTemplateWithHttpInfo(string webId, PIElementTemplate template)

Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the element template.. | [required]
 **template** | **PIElementTemplate**| The new element template definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetEnumerationSetsWithHttpInfo**
> GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null)

Retrieve enumeration sets for given asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsEnumerationSet>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateEnumerationSetWithHttpInfo**
> CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet)

Create an enumeration set at the Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the enumeration set.. | [required]
 **enumerationSet** | **PIEnumerationSet**| The new enumeration set definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **FindEventFrameAttributesWithHttpInfo**
> FindEventFrameAttributesWithHttpInfo(string webId, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, int? maxCount = null, string referencedElementNameFilter = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null)

Retrieves a list of event frame attributes matching the specified filters from the specified asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database to use as the root of the search.. | [required]
 **attributeCategory** | **string**| Specify that returned attributes must have this category. The default is no filter.. | [optional]
 **attributeDescriptionFilter** | **string**| The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. | [optional]
 **attributeNameFilter** | **string**| The attribute name filter string used for finding objects. The default is no filter.. | [optional]
 **attributeType** | **string**| Specify that returned attributes' value type must be this value type. The default is no filter.. | [optional]
 **endTime** | **string**| A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.. | [optional]
 **eventFrameCategory** | **string**| Specify that the owner of the returned attributes must have this category. The default is no filter.. | [optional]
 **eventFrameDescriptionFilter** | **string**| The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. | [optional]
 **eventFrameNameFilter** | **string**| The event frame name filter string used for finding objects. The default is no filter.. | [optional]
 **eventFrameTemplate** | **string**| Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned (the page size). The default is 1000.. | [optional]
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.. | [optional]
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]
 **startTime** | **string**| A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.. | [optional]


### Return type

ApiResponse<PIItemsAttribute>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetEventFramesWithHttpInfo**
> GetEventFramesWithHttpInfo(string webId, bool? canBeAcknowledged = null, string categoryName = null, string endTime = null, bool? isAcknowledged = null, int? maxCount = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, bool? searchFullHierarchy = null, string searchMode = null, string selectedFields = null, List<string> severity = null, string sortField = null, string sortOrder = null, int? startIndex = null, string startTime = null, string templateName = null)

Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database to use as the root of the search.. | [required]
 **canBeAcknowledged** | **bool?**| Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.. | [optional]
 **categoryName** | **string**| Specify that returned event frames must have this category. The default is no category filter.. | [optional]
 **endTime** | **string**| The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.. | [optional]
 **isAcknowledged** | **bool?**| Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **nameFilter** | **string**| The name query string used for finding event frames. The default is no filter.. | [optional]
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. | [optional]
 **referencedElementTemplateName** | **string**| Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.. | [optional]
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **severity** | **List<string>**| Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]
 **startTime** | **string**| The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.. | [optional]
 **templateName** | **string**| Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.. | [optional]


### Return type

ApiResponse<PIItemsEventFrame>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateEventFrameWithHttpInfo**
> CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame)

Create an event frame.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database on which to create the event frame.. | [required]
 **eventFrame** | **PIEventFrame**| The new event frame definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **ExportWithHttpInfo**
> ExportWithHttpInfo(string webId, string endTime = null, List<string> exportMode = null, string startTime = null)

Export the asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **endTime** | **string**| The latest ending time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*'.. | [optional]
 **exportMode** | **List<string>**| Indicates the type of export to perform. The default is 'StrongReferences'. Multiple export modes may be specified by using multiple instances of exportMode.. | [optional]
 **startTime** | **string**| The earliest starting time for AFEventFrame, AFTransfer, and AFCase objects that may be part of the export. The default is '*-30d'.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **ImportWithHttpInfo**
> ImportWithHttpInfo(string webId, List<string> importMode = null)

Import an asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database.. | [required]
 **importMode** | **List<string>**| Indicates the type of import to perform. The default is 'AllowCreate | AllowUpdate | AutoCheckIn'. Multiple import modes may be specified by using multiple instances of importMode.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetReferencedElementsWithHttpInfo**
> GetReferencedElementsWithHttpInfo(string webId, string categoryName = null, string descriptionFilter = null, string elementType = null, int? maxCount = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, int? startIndex = null, string templateName = null)

Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. | [required]
 **categoryName** | **string**| Specify that returned elements must have this category. The default is no category filter.. | [optional]
 **descriptionFilter** | **string**| Specify that returned elements must have this description. The default is no description filter.. | [optional]
 **elementType** | **string**| Specify that returned elements must have this type. The default type is 'Any'.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]
 **templateName** | **string**| Specify that returned elements must have this template or a template derived from this template. The default is no template filter.. | [optional]


### Return type

ApiResponse<PIItemsElement>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **AddReferencedElementWithHttpInfo**
> AddReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId, string referenceType = null)

Add a reference to an existing element to the specified database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database which the referenced element will be added to.. | [required]
 **referencedElementWebId** | **List<string>**| The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.. | [required]
 **referenceType** | **string**| The name of the reference type between the parent and the referenced element. This must be a "strong" reference type. The default is "parent-child".. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **RemoveReferencedElementWithHttpInfo**
> RemoveReferencedElementWithHttpInfo(string webId, List<string> referencedElementWebId)

Remove a reference to an existing element from the specified database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database which the referenced element will be removed from.. | [required]
 **referencedElementWebId** | **List<string>**| The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null)

Get the security information of the specified security item associated with the asset database for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database for the security to be checked.. | [required]
 **securityItem** | **List<string>**| The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.. | [required]
 **userIdentity** | **List<string>**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. | [required]
 **forceRefresh** | **bool?**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsSecurityRights>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null)

Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database.. | [required]
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsSecurityEntry>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)

Create a security entry owned by the asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the asset database where the security entry will be created.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null)

Retrieve the security entry of the specified security item associated with the asset database with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the asset database.. | [required]
 **securityItem** | **string**| The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PISecurityEntry>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)

Update a security entry owned by the asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. | [required]
 **webId** | **string**| The ID of the asset database where the security entry will be updated.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null)

Delete a security entry owned by the asset database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the asset database where the security entry will be deleted.. | [required]
 **applyToChildren** | **bool?**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [optional]
 **securityItem** | **string**| The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.. | [optional]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetTableCategoriesWithHttpInfo**
> GetTableCategoriesWithHttpInfo(string webId, string selectedFields = null)

Retrieve table categories for a given Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsTableCategory>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateTableCategoryWithHttpInfo**
> CreateTableCategoryWithHttpInfo(string webId, PITableCategory tableCategory)

Create a table category on the Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the table category.. | [required]
 **tableCategory** | **PITableCategory**| The new table category definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetTablesWithHttpInfo**
> GetTablesWithHttpInfo(string webId, string selectedFields = null)

Retrieve tables for given Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]


### Return type

ApiResponse<PIItemsTable>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateTableWithHttpInfo**
> CreateTableWithHttpInfo(string webId, PITable table)

Create a table on the Asset Database.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the database in which to create the table.. | [required]
 **table** | **PITable**| The new table definition.. | [required]


### Return type

ApiResponse<Object>

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
