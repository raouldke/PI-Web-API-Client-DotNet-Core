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
	/// PIAnalysisTemplate
	/// </summary>
	[DataContract]

	public class PIAnalysisTemplate
	{
		public PIAnalysisTemplate(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string AnalysisRulePlugInName = null, List<string> CategoryNames = null, bool? CreateEnabled = null, int? GroupId = null, bool? HasNotificationTemplate = null, bool? HasTarget = null, string OutputTime = null, string TargetName = null, string TimeRulePlugInName = null, Dictionary<string, string> Links = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.AnalysisRulePlugInName = AnalysisRulePlugInName;
			this.CategoryNames = CategoryNames;
			this.CreateEnabled = CreateEnabled;
			this.GroupId = GroupId;
			this.HasNotificationTemplate = HasNotificationTemplate;
			this.HasTarget = HasTarget;
			this.OutputTime = OutputTime;
			this.TargetName = TargetName;
			this.TimeRulePlugInName = TimeRulePlugInName;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "AnalysisRulePlugInName", EmitDefaultValue = false)]
		public string AnalysisRulePlugInName { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public List<string> CategoryNames { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "CreateEnabled", EmitDefaultValue = false)]
		public bool? CreateEnabled { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "GroupId", EmitDefaultValue = false)]
		public int? GroupId { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "HasNotificationTemplate", EmitDefaultValue = false)]
		public bool? HasNotificationTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "HasTarget", EmitDefaultValue = false)]
		public bool? HasTarget { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "OutputTime", EmitDefaultValue = false)]
		public string OutputTime { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "TargetName", EmitDefaultValue = false)]
		public string TargetName { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "TimeRulePlugInName", EmitDefaultValue = false)]
		public string TimeRulePlugInName { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplate
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
