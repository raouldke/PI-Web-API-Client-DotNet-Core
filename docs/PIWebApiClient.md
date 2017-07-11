# PIWebApiClient

## **Constructor**
> PIWebApiClient(string baseUrl, bool useKerberos = true, string username = null, string password = null)

Creates an instance of the PI Web API client top level object.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
**baseUrl** | **string**| PI Web API base service url. | [required]
**useKerberos** | **bool**| Select true for Kerberos authentication and false for Basic authentication. The default value is true. | [required]
**username** | **string**| The username in case basic authentication was selected to authenticate against PI Web API.This parameter won't be used in case Kerberos authentication is used. | [optional]
**password** | **string**| The password in case basic authentication was selected to authenticate against PI Web API.This parameter won't be used in case Kerberos authentication is used. | [optional]

## **Properties**

Property | Controller
------------ | -------------
**BaseUrl** | **string**
**UserName** | **string**
**UseKerberos** | **bool**
**Home** | [**HomeApi**](/docs/Api/HomeApi.md)
**Analysis** | [**AnalysisApi**](/docs/Api/AnalysisApi.md)
**AnalysisCategory** | [**AnalysisCategoryApi**](/docs/Api/AnalysisCategoryApi.md)
**AnalysisRulePlugIn** | [**AnalysisRulePlugInApi**](/docs/Api/AnalysisRulePlugInApi.md)
**AnalysisRule** | [**AnalysisRuleApi**](/docs/Api/AnalysisRuleApi.md)
**AnalysisTemplate** | [**AnalysisTemplateApi**](/docs/Api/AnalysisTemplateApi.md)
**AssetDatabase** | [**AssetDatabaseApi**](/docs/Api/AssetDatabaseApi.md)
**AssetServer** | [**AssetServerApi**](/docs/Api/AssetServerApi.md)
**AttributeCategory** | [**AttributeCategoryApi**](/docs/Api/AttributeCategoryApi.md)
**Attribute** | [**AttributeApi**](/docs/Api/AttributeApi.md)
**AttributeTemplate** | [**AttributeTemplateApi**](/docs/Api/AttributeTemplateApi.md)
**AttributeTrait** | [**AttributeTraitApi**](/docs/Api/AttributeTraitApi.md)
**Batch** | [**BatchApi**](/docs/Api/BatchApi.md)
**Calculation** | [**CalculationApi**](/docs/Api/CalculationApi.md)
**Channel** | [**ChannelApi**](/docs/Api/ChannelApi.md)
**DataServer** | [**DataServerApi**](/docs/Api/DataServerApi.md)
**ElementCategory** | [**ElementCategoryApi**](/docs/Api/ElementCategoryApi.md)
**Element** | [**ElementApi**](/docs/Api/ElementApi.md)
**ElementTemplate** | [**ElementTemplateApi**](/docs/Api/ElementTemplateApi.md)
**EnumerationSet** | [**EnumerationSetApi**](/docs/Api/EnumerationSetApi.md)
**EnumerationValue** | [**EnumerationValueApi**](/docs/Api/EnumerationValueApi.md)
**EventFrame** | [**EventFrameApi**](/docs/Api/EventFrameApi.md)
**Point** | [**PointApi**](/docs/Api/PointApi.md)
**SecurityIdentity** | [**SecurityIdentityApi**](/docs/Api/SecurityIdentityApi.md)
**SecurityMapping** | [**SecurityMappingApi**](/docs/Api/SecurityMappingApi.md)
**Stream** | [**StreamApi**](/docs/Api/StreamApi.md)
**StreamSet** | [**StreamSetApi**](/docs/Api/StreamSetApi.md)
**System** | [**SystemApi**](/docs/Api/SystemApi.md)
**Configuration** | [**ConfigurationApi**](/docs/Api/ConfigurationApi.md)
**TableCategory** | [**TableCategoryApi**](/docs/Api/TableCategoryApi.md)
**Table** | [**TableApi**](/docs/Api/TableApi.md)
**TimeRulePlugIn** | [**TimeRulePlugInApi**](/docs/Api/TimeRulePlugInApi.md)
**TimeRule** | [**TimeRuleApi**](/docs/Api/TimeRuleApi.md)
**UnitClass** | [**UnitClassApi**](/docs/Api/UnitClassApi.md)
**Unit** | [**UnitApi**](/docs/Api/UnitApi.md)

[[Back to Model list]](../DOCUMENTATION.md#documentation-for-models) [[Back to API list]](../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to DOCUMENTATION]](../DOCUMENTATION.md)
