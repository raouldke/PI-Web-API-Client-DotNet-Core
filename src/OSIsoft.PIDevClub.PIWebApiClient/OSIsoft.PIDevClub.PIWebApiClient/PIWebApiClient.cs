using OSIsoft.PIDevClub.PIWebApiClient.Api;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIsoft.PIDevClub.PIWebApiClient
{


    public class PIWebApiClient
    {
        private ApiClient client = null;
        public string BaseUrl { get; private set; }
        public bool UseKerberos { get; private set; }
        public string UserName { get; private set; }

        private string Password;
        public bool CacheDisabled { get; set; }

        public PIWebApiClient(string baseUrl, bool useKerberos = true, string username = null, string password = null)
        {
            BaseUrl = baseUrl;
            UseKerberos = useKerberos;
            UserName = username;
            Password = password;
            CacheDisabled = true;
            client = new ApiClient(baseUrl);
        }

        private Configuration GetConfiguration(bool NoCacheHeaderCompatible)
        {
            Configuration config = null;
            if ((UseKerberos == false) && (UserName != null) && (Password != null))
            {
                config = new Configuration(client, null, UserName, Password);
            }
            else
            {
                config = new Configuration(client);
                client.RestClient.Authenticator = new DefaultAuthenticator();
            }

            if ((NoCacheHeaderCompatible == true) && (CacheDisabled==true))
            {
                config.DefaultHeader.Add("Cache-Control", "no-cache");
            }
            return config;
        }

    
        public class DefaultAuthenticator : IAuthenticator
        {
            public void Authenticate(IRestClient client, IRestRequest request)
            {
                request.UseDefaultCredentials = true;
            }
        }

        public IAnalysisApi Analysis
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisApi(config);
            }
        }

        public IAnalysisCategoryApi AnalysisCategory
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AnalysisCategoryApi(config);
            }
        }

        public IAnalysisRulePlugInApi AnalysisRulePlugIn
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AnalysisRulePlugInApi(config);
            }
        }

        public IAnalysisRuleApi AnalysisRule
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AnalysisRuleApi(config);
            }
        }

        public IAnalysisTemplateApi AnalysisTemplate
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AnalysisTemplateApi(config);
            }
        }

        public IAssetDatabaseApi AssetData
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AssetDatabaseApi(config);
            }
        }

        public IAssetServerApi AssetServer
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AssetServerApi(config);
            }
        }

        public IAttributeApi Attribute
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AttributeApi(config);
            }
        }

        public IAttributeCategoryApi AttributeCategory
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AttributeCategoryApi(config);
            }
        }

        public IAttributeTemplateApi AttributeTemplate
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AttributeTemplateApi(config);
            }
        }

        public IAttributeTraitApi AttributeTrait
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new AttributeTraitApi(config);
            }
        }

        public IBatchApi BatchApi
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new BatchApi(config);
            }
        }

        public ICalculationApi Calculation
        {
            get
            {
                Configuration config = GetConfiguration(false);
                return new CalculationApi(config);
            }
        }

        public IConfigurationApi Configuration
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new ConfigurationApi(config);
            }
        }

        public IDataServerApi DataServer
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new DataServerApi(config);
            }
        }

        public IElementApi Element
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new ElementApi(config);
            }
        }

        public IElementCategoryApi ElementCategory
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new ElementCategoryApi(config);
            }
        }



        public IElementTemplateApi ElementTemplate
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new ElementTemplateApi(config);
            }
        }


        public IEnumerationSetApi EnumerationSet
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new EnumerationSetApi(config);
            }
        }


        public IEnumerationValueApi EnumerationValue
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new EnumerationValueApi(config);
            }
        }

        public IEventFrameApi EventFrame
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new EventFrameApi(config);
            }
        }


        public IHomeApi Home
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new HomeApi(config);
            }
        }


        public IPointApi Point
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new PointApi(config);
            }
        }



        public ISecurityIdentityApi SecurityIdentity
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new SecurityIdentityApi(config);
            }
        }

        public ISecurityMappingApi SecurityMapping
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new SecurityMappingApi(config);
            }
        }

        public IStreamApi Stream
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new StreamApi(config);
            }
        }

        public IStreamSetApi StreamSet
        {
            get
            {
                Configuration config = GetConfiguration(false);
                return new StreamSetApi(config);
            }
        }


        public ISystemApi System
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new SystemApi(config);
            }
        }

        public ITableApi Table
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new TableApi(config);
            }
        }

        public ITableCategoryApi TableCategory
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new TableCategoryApi(config);
            }
        }

        public ITimeRuleApi TimeRule
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new TimeRuleApi(config);
            }
        }

        public ITimeRulePlugInApi TimeRulePlugIn
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new TimeRulePlugInApi(config);
            }
        }

        public IUnitApi Unit
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new UnitApi(config);
            }
        }
        public IUnitClassApi UnitClass
        {
            get
            {
                 Configuration config = GetConfiguration(true);
                return new UnitClassApi(config);
            }
        }
    }
}
