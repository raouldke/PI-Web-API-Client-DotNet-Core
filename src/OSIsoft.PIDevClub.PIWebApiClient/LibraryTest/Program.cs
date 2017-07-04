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


using OSIsoft.PIDevClub.PIWebApiClient;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PIWebApiClient client = new PIWebApiClient("https://marc-web-sql.marc.net/piwebapi", true);

            PIDataServer dataServer = client.DataServer.GetByPath("\\\\MARC-PI2016");
            PIPoint createdPoint = client.Point.GetByPath("\\\\MARC-PI2016\\SINUSOIDR1259", null);
            string webId = createdPoint.WebId;
            createdPoint.DigitalSetName = null;
            createdPoint.EngineeringUnits = null;
            createdPoint.Descriptor = "16 Hour Sine Waveeeeee";
            createdPoint.Future = null;
            createdPoint.Id = null;
            createdPoint.Links = null;
            createdPoint.Name = null;
            createdPoint.Path = null;
            createdPoint.PointClass = null;
            createdPoint.PointType = null;
            createdPoint.WebId = null;
            ApiResponse<Object> response = client.Point.UpdateWithHttpInfo(webId, createdPoint);
            Console.WriteLine(response.StatusCode);

            PIPoint point1 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoid");
            PIPoint point2 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoidu");
            PIPoint point3 = client.Point.GetByPath("\\\\marc-pi2016\\cdt158");
            List<string> webIds = new List<string>() { point1.WebId, point1.WebId, point1.WebId };
            PIItemsStreamValues piItemsStreamValues = client.StreamSet.GetRecordedAdHoc(webIds, startTime: "*-3d", endTime: "*");

            PIElement myElement = client.Element.GetByPath("\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm");
            PIItemsAttribute attributes = client.Element.GetAttributes(myElement.WebId, null, 1000, null, false);
            PIAttribute attribute = client.Attribute.GetByPath(string.Format("{0}|{1}", "\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm", attributes.Items[0].Name));
            PITimedValue value = client.Stream.GetEnd(attribute.WebId);

        }
    }
}
