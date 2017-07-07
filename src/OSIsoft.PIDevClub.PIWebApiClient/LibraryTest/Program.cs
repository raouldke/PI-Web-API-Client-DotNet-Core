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
            //Create an instance of the PI Web API top level object.
            PIWebApiClient client = new PIWebApiClient("https://marc-web-sql.marc.net/piwebapi", true);

            //Get the PI Data Archive object
            PIDataServer dataServer = client.DataServer.GetByPath("\\\\MARC-PI2016");

            //Get PI Point
            PIPoint createdPoint = client.Point.GetByPath("\\\\MARC-PI2016\\SINUSOIDR1259", null);

            //Change the description of the PI Point
            string webId = createdPoint.WebId;
            createdPoint.DigitalSetName = null;
            createdPoint.EngineeringUnits = null;
            createdPoint.Descriptor = "New description";
            createdPoint.Future = null;
            createdPoint.Id = null;
            createdPoint.Links = null;
            createdPoint.Name = null;
            createdPoint.Path = null;
            createdPoint.PointClass = null;
            createdPoint.PointType = null;
            createdPoint.WebId = null;

            //Update PI Point
            ApiResponse<Object> response = client.Point.UpdateWithHttpInfo(webId, createdPoint);

            //Check if the request was successful
            Console.WriteLine(response.StatusCode);

            //Get PI Points WebIds
            PIPoint point1 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoid");
            PIPoint point2 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoidu");
            PIPoint point3 = client.Point.GetByPath("\\\\marc-pi2016\\cdt158");
            List<string> webIds = new List<string>() { point1.WebId, point1.WebId, point1.WebId };

            //Get recorded values in bulk 
            PIItemsStreamValues piItemsStreamValues = client.StreamSet.GetRecordedAdHoc(webIds, startTime: "*-3d", endTime: "*");


            //Send values in bulk
            var streamValuesItems = new PIItemsStreamValues();
            var streamValue1 = new PIStreamValues();
            var streamValue2 = new PIStreamValues();
            var streamValue3 = new PIStreamValues();
            var value1 = new PITimedValue();
            var value2 = new PITimedValue();
            var value3 = new PITimedValue();
            var value4 = new PITimedValue();
            var value5 = new PITimedValue();
            var value6 = new PITimedValue();
            value1.Value = 2;
            value1.Timestamp = "*-1d";
            value2.Value = 3;
            value2.Timestamp = "*-2d";
            value3.Value = 4;
            value3.Timestamp = "*-1d";
            value4.Value = 5;
            value4.Timestamp = "*-2d";
            value5.Value = 6;
            value5.Timestamp = "*-1d";
            value6.Value = 7;
            value6.Timestamp = "*-2d";
            streamValue1.WebId = point1.WebId;
            streamValue1.Items = new List<PITimedValue>();
            streamValue1.Items.Add(value1);
            streamValue1.Items.Add(value2);
            streamValue2.WebId = point2.WebId;
            streamValue2.Items = new List<PITimedValue>();
            streamValue2.Items.Add(value3);
            streamValue2.Items.Add(value4);
            streamValue3.WebId = point2.WebId;
            streamValue3.Items = new List<PITimedValue>();
            streamValue3.Items.Add(value5);
            streamValue3.Items.Add(value6);
            ApiResponse<PIItemsItemsSubstatus> response2 = client.StreamSet.UpdateValuesAdHocWithHttpInfo(new List<PIStreamValues>() { streamValue1, streamValue2, streamValue3 });

            //Get an element given a path
            PIElement myElement = client.Element.GetByPath("\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm");

            //Get element's attributes
            PIItemsAttribute attributes = client.Element.GetAttributes(myElement.WebId, null, 1000, null, false);

            //Get an attribute given a path
            PIAttribute attribute = client.Attribute.GetByPath(string.Format("{0}|{1}", "\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm", attributes.Items[0].Name));

            //Get the attribute's end of the stream value
            PITimedValue value = client.Stream.GetEnd(attribute.WebId);

        }
    }
}
