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
	/// PISecurityMapping
	/// </summary>
	[DataContract]

	public class PISecurityMapping
	{
		public PISecurityMapping(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string Account = null, string SecurityIdentityWebId = null, Dictionary<string, string> Links = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.Account = Account;
			this.SecurityIdentityWebId = SecurityIdentityWebId;
			this.Links = Links;
		}

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "Account", EmitDefaultValue = false)]
		public string Account { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "SecurityIdentityWebId", EmitDefaultValue = false)]
		public string SecurityIdentityWebId { get; set; }

		/// <summary>
		/// Gets or Sets PISecurityMapping
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public Dictionary<string, string> Links { get; set; }

	}
}
