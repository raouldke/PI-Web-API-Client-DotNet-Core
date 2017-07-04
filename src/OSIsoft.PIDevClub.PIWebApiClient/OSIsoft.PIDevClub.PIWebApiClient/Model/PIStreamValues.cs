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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using System.Runtime.InteropServices;

namespace OSIsoft.PIDevClub.PIWebApiClient.Model
{

	/// <summary>
	/// PIStreamValues
	/// </summary>
	[DataContract]

	public class PIStreamValues
	{
		public PIStreamValues(string WebId = null, string Name = null, string Path = null, List<PITimedValue> Items = null, string UnitsAbbreviation = null, Dictionary<string, string> Links = null)
		{
			this.WebId = WebId;
			this.Name = Name;
			this.Path = Path;
			this.Items = Items;
			this.UnitsAbbreviation = UnitsAbbreviation;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PIStreamValues
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamValues
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamValues
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamValues
		/// </summary>
		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public List<PITimedValue> Items { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamValues
		/// </summary>
		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

		/// <summary>
		/// Gets or Sets PIStreamValues
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
