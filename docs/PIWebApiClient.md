# PIWebApiClient

## **Constructor**
> PIWebApiClient(string baseUrl, bool useKerberos = true, string username = null, string password = null)

Creates an intance of the PI Web API client top level object.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
**baseUrl * * | **string **| PI Web API base service url. | [required]
**useKerberos** | **bool **| Select true for Kerberos authentication and false for Basic authentication. The default value is true. | [required]
**username** | **string**| The username in case basic authentication was selected to authenticate against PI Web API.This parameter won't be used in case Kerberos authentication is used. | [optional]
**password** | **string**| The password in case basic authentication was selected to authenticate against PI Web API.This parameter won't be used in case Kerberos authentication is used. | [optional]

## **Properties**

Property | Controller
------------ | -------------
**BaseUrl** | **string**
**UserName** | **string**
**UseKerberos** | **bool**
**Home** | [**HomeApi**](/Api/HomeApi.md)
**Analysis** | [**AnalysisApi**](/Api/AnalysisApi.md)
**AnalysisCategory** | [**AnalysisCategoryApi**](/Api/AnalysisCategoryApi.md)
**AnalysisRulePlugIn** | [**AnalysisRulePlugInApi**](/Api/AnalysisRulePlugInApi.md)
**AnalysisRule** | [**AnalysisRuleApi**](/Api/AnalysisRuleApi.md)
**AnalysisTemplate** | [**AnalysisTemplateApi**](/Api/AnalysisTemplateApi.md)
**AssetDatabase** | [**AssetDatabaseApi**](/Api/AssetDatabaseApi.md)
**AssetServer** | [**AssetServerApi**](/Api/AssetServerApi.md)
**AttributeCategory** | [**AttributeCategoryApi**](/Api/AttributeCategoryApi.md)
**Attribute** | [**AttributeApi**](/Api/AttributeApi.md)
**AttributeTemplate** | [**AttributeTemplateApi**](/Api/AttributeTemplateApi.md)
**AttributeTrait** | [**AttributeTraitApi**](/Api/AttributeTraitApi.md)
**Batch** | [**BatchApi**](/Api/BatchApi.md)
**Calculation** | [**CalculationApi**](/Api/CalculationApi.md)
**Channel** | [**ChannelApi**](/Api/ChannelApi.md)
**DataServer** | [**DataServerApi**](/Api/DataServerApi.md)
**ElementCategory** | [**ElementCategoryApi**](/Api/ElementCategoryApi.md)
**Element** | [**ElementApi**](/Api/ElementApi.md)
**ElementTemplate** | [**ElementTemplateApi**](/Api/ElementTemplateApi.md)
**EnumerationSet** | [**EnumerationSetApi**](/Api/EnumerationSetApi.md)
**EnumerationValue** | [**EnumerationValueApi**](/Api/EnumerationValueApi.md)
**EventFrame** | [**EventFrameApi**](/Api/EventFrameApi.md)
**Point** | [**PointApi**](/Api/PointApi.md)
**SecurityIdentity** | [**SecurityIdentityApi**](/Api/SecurityIdentityApi.md)
**SecurityMapping** | [**SecurityMappingApi**](/Api/SecurityMappingApi.md)
**Stream** | [**StreamApi**](/Api/StreamApi.md)
**StreamSet** | [**StreamSetApi**](/Api/StreamSetApi.md)
**System** | [**SystemApi**](/Api/SystemApi.md)
**Configuration** | [**ConfigurationApi**](/Api/ConfigurationApi.md)
**TableCategory** | [**TableCategoryApi**](/Api/TableCategoryApi.md)
**Table** | [**TableApi**](/Api/TableApi.md)
**TimeRulePlugIn** | [**TimeRulePlugInApi**](/Api/TimeRulePlugInApi.md)
**TimeRule** | [**TimeRuleApi**](/Api/TimeRuleApi.md)
**UnitClass** | [**UnitClassApi**](/Api/UnitClassApi.md)
**Unit** | [**UnitApi**](/Api/UnitApi.md)

[[Back to Model list]](../DOCUMENTATION.md#documentation-for-models) [[Back to API list]](../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to DOCUMENTATION]](../DOCUMENTATION.md)
