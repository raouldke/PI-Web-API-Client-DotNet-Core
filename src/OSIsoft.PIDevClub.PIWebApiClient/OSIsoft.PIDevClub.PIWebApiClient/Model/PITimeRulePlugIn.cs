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
	/// PITimeRulePlugIn
	/// </summary>
	[DataContract]

	public class PITimeRulePlugIn
	{
		public PITimeRulePlugIn(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string AssemblyFileName = null, string AssemblyID = null, List<string> AssemblyLoadProperties = null, string AssemblyTime = null, int? CompatibilityVersion = null, bool? IsBrowsable = null, bool? IsNonEditableConfig = null, string LoadedAssemblyTime = null, string LoadedVersion = null, string Version = null, Dictionary<string, string> Links = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.AssemblyFileName = AssemblyFileName;
			this.AssemblyID = AssemblyID;
			this.AssemblyLoadProperties = AssemblyLoadProperties;
			this.AssemblyTime = AssemblyTime;
			this.CompatibilityVersion = CompatibilityVersion;
			this.IsBrowsable = IsBrowsable;
			this.IsNonEditableConfig = IsNonEditableConfig;
			this.LoadedAssemblyTime = LoadedAssemblyTime;
			this.LoadedVersion = LoadedVersion;
			this.Version = Version;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "AssemblyFileName", EmitDefaultValue = false)]
		public string AssemblyFileName { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "AssemblyID", EmitDefaultValue = false)]
		public string AssemblyID { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "AssemblyLoadProperties", EmitDefaultValue = false)]
		public List<string> AssemblyLoadProperties { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "AssemblyTime", EmitDefaultValue = false)]
		public string AssemblyTime { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "CompatibilityVersion", EmitDefaultValue = false)]
		public int? CompatibilityVersion { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "IsBrowsable", EmitDefaultValue = false)]
		public bool? IsBrowsable { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "IsNonEditableConfig", EmitDefaultValue = false)]
		public bool? IsNonEditableConfig { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "LoadedAssemblyTime", EmitDefaultValue = false)]
		public string LoadedAssemblyTime { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "LoadedVersion", EmitDefaultValue = false)]
		public string LoadedVersion { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "Version", EmitDefaultValue = false)]
		public string Version { get; set; }

		/// <summary>
		/// Gets or Sets PITimeRulePlugIn
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
