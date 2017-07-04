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
	/// PIAnalysis
	/// </summary>
	[DataContract]

	public class PIAnalysis
	{
		public PIAnalysis(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string AnalysisRulePlugInName = null, bool? AutoCreated = null, List<string> CategoryNames = null, int? GroupId = null, bool? HasNotification = null, bool? HasTarget = null, bool? HasTemplate = null, bool? IsConfigured = null, bool? IsTimeRuleDefinedByTemplate = null, int? MaximumQueueSize = null, string OutputTime = null, string Priority = null, bool? PublishResults = null, string Status = null, string TargetWebId = null, string TemplateName = null, string TimeRulePlugInName = null, Dictionary<string, string> Links = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.AnalysisRulePlugInName = AnalysisRulePlugInName;
			this.AutoCreated = AutoCreated;
			this.CategoryNames = CategoryNames;
			this.GroupId = GroupId;
			this.HasNotification = HasNotification;
			this.HasTarget = HasTarget;
			this.HasTemplate = HasTemplate;
			this.IsConfigured = IsConfigured;
			this.IsTimeRuleDefinedByTemplate = IsTimeRuleDefinedByTemplate;
			this.MaximumQueueSize = MaximumQueueSize;
			this.OutputTime = OutputTime;
			this.Priority = Priority;
			this.PublishResults = PublishResults;
			this.Status = Status;
			this.TargetWebId = TargetWebId;
			this.TemplateName = TemplateName;
			this.TimeRulePlugInName = TimeRulePlugInName;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "AnalysisRulePlugInName", EmitDefaultValue = false)]
		public string AnalysisRulePlugInName { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "AutoCreated", EmitDefaultValue = false)]
		public bool? AutoCreated { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public List<string> CategoryNames { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "GroupId", EmitDefaultValue = false)]
		public int? GroupId { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "HasNotification", EmitDefaultValue = false)]
		public bool? HasNotification { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "HasTarget", EmitDefaultValue = false)]
		public bool? HasTarget { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "HasTemplate", EmitDefaultValue = false)]
		public bool? HasTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "IsConfigured", EmitDefaultValue = false)]
		public bool? IsConfigured { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "IsTimeRuleDefinedByTemplate", EmitDefaultValue = false)]
		public bool? IsTimeRuleDefinedByTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "MaximumQueueSize", EmitDefaultValue = false)]
		public int? MaximumQueueSize { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "OutputTime", EmitDefaultValue = false)]
		public string OutputTime { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "Priority", EmitDefaultValue = false)]
		public string Priority { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "PublishResults", EmitDefaultValue = false)]
		public bool? PublishResults { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "TargetWebId", EmitDefaultValue = false)]
		public string TargetWebId { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "TimeRulePlugInName", EmitDefaultValue = false)]
		public string TimeRulePlugInName { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysis
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
