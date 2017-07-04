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
	/// PIAttributeTemplate
	/// </summary>
	[DataContract]

	public class PIAttributeTemplate
	{
		public PIAttributeTemplate(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string Type = null, string TypeQualifier = null, string DefaultUnitsName = null, object DefaultValue = null, string DataReferencePlugIn = null, string ConfigString = null, bool? IsConfigurationItem = null, bool? IsExcluded = null, bool? IsHidden = null, bool? IsManualDataEntry = null, bool? HasChildren = null, List<string> CategoryNames = null, string TraitName = null, Dictionary<string, string> Links = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.Type = Type;
			this.TypeQualifier = TypeQualifier;
			this.DefaultUnitsName = DefaultUnitsName;
			this.DefaultValue = DefaultValue;
			this.DataReferencePlugIn = DataReferencePlugIn;
			this.ConfigString = ConfigString;
			this.IsConfigurationItem = IsConfigurationItem;
			this.IsExcluded = IsExcluded;
			this.IsHidden = IsHidden;
			this.IsManualDataEntry = IsManualDataEntry;
			this.HasChildren = HasChildren;
			this.CategoryNames = CategoryNames;
			this.TraitName = TraitName;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "TypeQualifier", EmitDefaultValue = false)]
		public string TypeQualifier { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "DefaultUnitsName", EmitDefaultValue = false)]
		public string DefaultUnitsName { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "DefaultValue", EmitDefaultValue = false)]
		public object DefaultValue { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "DataReferencePlugIn", EmitDefaultValue = false)]
		public string DataReferencePlugIn { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "IsConfigurationItem", EmitDefaultValue = false)]
		public bool? IsConfigurationItem { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "IsExcluded", EmitDefaultValue = false)]
		public bool? IsExcluded { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "IsHidden", EmitDefaultValue = false)]
		public bool? IsHidden { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "IsManualDataEntry", EmitDefaultValue = false)]
		public bool? IsManualDataEntry { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool? HasChildren { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public List<string> CategoryNames { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "TraitName", EmitDefaultValue = false)]
		public string TraitName { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeTemplate
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
