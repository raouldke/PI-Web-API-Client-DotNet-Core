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
	/// PIAttributeTrait
	/// </summary>
	[DataContract]

	public class PIAttributeTrait
	{
		public PIAttributeTrait(string Name = null, string Abbreviation = null, bool? AllowChildAttributes = null, bool? AllowDuplicates = null, bool? IsAllowedOnRootAttribute = null, bool? IsTypeInherited = null, bool? IsUOMInherited = null, bool? RequireNumeric = null, bool? RequireString = null, Dictionary<string, string> Links = null)
		{
			this.Name = Name;
			this.Abbreviation = Abbreviation;
			this.AllowChildAttributes = AllowChildAttributes;
			this.AllowDuplicates = AllowDuplicates;
			this.IsAllowedOnRootAttribute = IsAllowedOnRootAttribute;
			this.IsTypeInherited = IsTypeInherited;
			this.IsUOMInherited = IsUOMInherited;
			this.RequireNumeric = RequireNumeric;
			this.RequireString = RequireString;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "Abbreviation", EmitDefaultValue = false)]
		public string Abbreviation { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "AllowChildAttributes", EmitDefaultValue = false)]
		public bool? AllowChildAttributes { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "AllowDuplicates", EmitDefaultValue = false)]
		public bool? AllowDuplicates { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "IsAllowedOnRootAttribute", EmitDefaultValue = false)]
		public bool? IsAllowedOnRootAttribute { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "IsTypeInherited", EmitDefaultValue = false)]
		public bool? IsTypeInherited { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "IsUOMInherited", EmitDefaultValue = false)]
		public bool? IsUOMInherited { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "RequireNumeric", EmitDefaultValue = false)]
		public bool? RequireNumeric { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "RequireString", EmitDefaultValue = false)]
		public bool? RequireString { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTrait
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
