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
	/// PIEventFrame
	/// </summary>
	[DataContract]

	public class PIEventFrame
	{
		public PIEventFrame(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string TemplateName = null, bool? HasChildren = null, List<string> CategoryNames = null, Dictionary<string, PIValue> ExtendedProperties = null, string StartTime = null, string EndTime = null, string Severity = null, string AcknowledgedBy = null, string AcknowledgedDate = null, bool? CanBeAcknowledged = null, bool? IsAcknowledged = null, bool? IsAnnotated = null, bool? IsLocked = null, bool? AreValuesCaptured = null, List<string> RefElementWebIds = null, PISecurity Security = null, Dictionary<string, string> Links = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.TemplateName = TemplateName;
			this.HasChildren = HasChildren;
			this.CategoryNames = CategoryNames;
			this.ExtendedProperties = ExtendedProperties;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.Severity = Severity;
			this.AcknowledgedBy = AcknowledgedBy;
			this.AcknowledgedDate = AcknowledgedDate;
			this.CanBeAcknowledged = CanBeAcknowledged;
			this.IsAcknowledged = IsAcknowledged;
			this.IsAnnotated = IsAnnotated;
			this.IsLocked = IsLocked;
			this.AreValuesCaptured = AreValuesCaptured;
			this.RefElementWebIds = RefElementWebIds;
			this.Security = Security;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool? HasChildren { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public List<string> CategoryNames { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "ExtendedProperties", EmitDefaultValue = false)]
		public Dictionary<string, PIValue> ExtendedProperties { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "StartTime", EmitDefaultValue = false)]
		public string StartTime { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "EndTime", EmitDefaultValue = false)]
		public string EndTime { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "Severity", EmitDefaultValue = false)]
		public string Severity { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "AcknowledgedBy", EmitDefaultValue = false)]
		public string AcknowledgedBy { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "AcknowledgedDate", EmitDefaultValue = false)]
		public string AcknowledgedDate { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "CanBeAcknowledged", EmitDefaultValue = false)]
		public bool? CanBeAcknowledged { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "IsAcknowledged", EmitDefaultValue = false)]
		public bool? IsAcknowledged { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "IsAnnotated", EmitDefaultValue = false)]
		public bool? IsAnnotated { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "IsLocked", EmitDefaultValue = false)]
		public bool? IsLocked { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "AreValuesCaptured", EmitDefaultValue = false)]
		public bool? AreValuesCaptured { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "RefElementWebIds", EmitDefaultValue = false)]
		public List<string> RefElementWebIds { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public PISecurity Security { get; set; }

		/// <summary>
		/// Gets or Sets PIEventFrame
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
