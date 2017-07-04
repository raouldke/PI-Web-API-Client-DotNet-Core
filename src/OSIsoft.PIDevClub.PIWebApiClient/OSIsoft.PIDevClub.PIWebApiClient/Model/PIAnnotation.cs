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
	/// PIAnnotation
	/// </summary>
	[DataContract]

	public class PIAnnotation
	{
		public PIAnnotation(string Id = null, string Name = null, string Description = null, object Value = null, string Creator = null, string CreationDate = null, string Modifier = null, string ModifyDate = null, Dictionary<string, string> Links = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Value = Value;
			this.Creator = Creator;
			this.CreationDate = CreationDate;
			this.Modifier = Modifier;
			this.ModifyDate = ModifyDate;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public object Value { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "Creator", EmitDefaultValue = false)]
		public string Creator { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "CreationDate", EmitDefaultValue = false)]
		public string CreationDate { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "Modifier", EmitDefaultValue = false)]
		public string Modifier { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "ModifyDate", EmitDefaultValue = false)]
		public string ModifyDate { get; set; }

		/// <summary>
		/// Gets or Sets PIAnnotation
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
