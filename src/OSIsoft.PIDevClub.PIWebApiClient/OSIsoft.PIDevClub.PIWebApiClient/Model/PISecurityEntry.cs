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
	/// PISecurityEntry
	/// </summary>
	[DataContract]

	public class PISecurityEntry
	{
		public PISecurityEntry(string Name = null, string SecurityIdentityName = null, List<string> AllowRights = null, List<string> DenyRights = null, Dictionary<string, string> Links = null)
		{
			this.Name = Name;
			this.SecurityIdentityName = SecurityIdentityName;
			this.AllowRights = AllowRights;
			this.DenyRights = DenyRights;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PISecurityEntry
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityEntry
		/// </summary>
		[DataMember(Name = "SecurityIdentityName", EmitDefaultValue = false)]
		public string SecurityIdentityName { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityEntry
		/// </summary>
		[DataMember(Name = "AllowRights", EmitDefaultValue = false)]
		public List<string> AllowRights { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityEntry
		/// </summary>
		[DataMember(Name = "DenyRights", EmitDefaultValue = false)]
		public List<string> DenyRights { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityEntry
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
