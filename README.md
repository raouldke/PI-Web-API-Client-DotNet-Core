PI Web API Client libraries for .NET Core
===


## Organization
This repository has the source code package of the PI Web API Client libraries for .NET Core.

## Requirements

 - PI Web API 2017 installed within your domain using Kerberos or Basic Authentication.
 - .NET Core 1.1

## Documentation

All classes and methods are described on the [DOCUMENTATION.md](DOCUMENTATION.md).


## Examples

Please check the [Program.cs](/src/OSIsoft.PIDevClub.PIWebApiClient/LibraryTest/Program.cs) from the LibraryTest project from the Visual Studio solution of this repository. Below there are also code snippets written in C# for you to get started using this library:


### Create an instance of the PI Web API top level object.

```cs
	PIWebApiClient client = new PIWebApiClient("https://marc-web-sql.marc.net/piwebapi", true);  
``` 

If you want to use basic authentication instead of Kerberos, set useKerberos to false and set the username and password accordingly.


### Get the PI Data Archive WebId

```cs
    PIDataServer dataServer = client.DataServer.GetByPath("\\\\MARC-PI2016");
```

### Create a new PI Point

```cs
    PIPoint newPIPoint = new PIPoint();
    newPIPoint.Name = "MyNewPIPoint"
    newPIPoint.Descriptor = "Point created for wrapper test"
    newPIPoint.PointClass = "classic"
    newPIPoint.PointType = "Float32"
    ApiResponseObject response = client.dataServer.CreatePointWithHttpInfo(dataServer.webId, newPIPoint)
```

### Get PI Points WebIds

```cs
    PIPoint point1 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoid");
    PIPoint point2 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoidu");
    PIPoint point3 = client.Point.GetByPath("\\\\marc-pi2016\\cdt158");
```

### Get recorded values in bulk using the StreamSet/GetRecordedAdHoc

```cs
    List<string> webIds = new List<string>() { point1.WebId, point1.WebId, point1.WebId };
    PIItemsStreamValues piItemsStreamValues = client.StreamSet.GetRecordedAdHoc(webIds, startTime: "*-3d", endTime: "*");
```

### Send values in bulk using the StreamSet/UpdateValuesAdHoc

```cs
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
```


### Get element and its attributes given an AF Element path

```cs
	PIElement myElement = client.Element.GetByPath("\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm");
	PIItemsAttribute attributes = client.Element.GetAttributes(myElement.WebId, null, 1000, null, false);
```


### Get current value given an AF Attribute path

```cs
	PIAttribute attribute = client.Attribute.GetByPath(string.Format("{0}|{1}", "\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm", attributes.Items[0].Name));
	PITimedValue value = client.Stream.GetEnd(attribute.WebId);
```

### Get Event Frames given an AF Database path

```cs
    PIAssetDatabase db = client.AssetData.GetByPath(path);
    PIItemsEventFrame efs = client.AssetData.GetEventFrames(db.WebId, referencedElementNameFilter: "myElement", referencedElementTemplateName: "user", startTime: "*-1d", endTime: "*");
```



## Licensing
Copyright 2017 OSIsoft, LLC.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   
Please see the file named [LICENSE.md](LICENSE.md).
