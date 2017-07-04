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
	/// PIEnumerationValue
	/// </summary>
	[DataContract]

	public class PIEnumerationValue
	{
		public PIEnumerationValue(string WebId = null, string Id = null, string Name = null, string Description = null, int? Value = null, string Path = null, Dictionary<string, string> Links = null, bool? SerializeWebId = null, bool? SerializeId = null, bool? SerializeDescription = null, bool? SerializePath = null, bool? SerializeLinks = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Value = Value;
			this.Path = Path;
			this.Links = Links;
			this.SerializeWebId = SerializeWebId;
			this.SerializeId = SerializeId;
			this.SerializeDescription = SerializeDescription;
			this.SerializePath = SerializePath;
			this.SerializeLinks = SerializeLinks;
		}

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public int? Value { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "SerializeWebId", EmitDefaultValue = false)]
		public bool? SerializeWebId { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "SerializeId", EmitDefaultValue = false)]
		public bool? SerializeId { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "SerializeDescription", EmitDefaultValue = false)]
		public bool? SerializeDescription { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "SerializePath", EmitDefaultValue = false)]
		public bool? SerializePath { get; set; }

		/// <summary>
		/// Gets or Sets PIEnumerationValue
		/// </summary>
		[DataMember(Name = "SerializeLinks", EmitDefaultValue = false)]
		public bool? SerializeLinks { get; set; }

	}
}
