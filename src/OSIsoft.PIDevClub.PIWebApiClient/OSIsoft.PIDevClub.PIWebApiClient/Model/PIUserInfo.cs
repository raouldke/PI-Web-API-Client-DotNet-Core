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
	/// PIUserInfo
	/// </summary>
	[DataContract]

	public class PIUserInfo
	{
		public PIUserInfo(string IdentityType = null, string Name = null, bool? IsAuthenticated = null, string SID = null, string ImpersonationLevel = null)
		{
			this.IdentityType = IdentityType;
			this.Name = Name;
			this.IsAuthenticated = IsAuthenticated;
			this.SID = SID;
			this.ImpersonationLevel = ImpersonationLevel;
		}

		/// <summary>
		/// Gets or Sets PIUserInfo
		/// </summary>
		[DataMember(Name = "IdentityType", EmitDefaultValue = false)]
		public string IdentityType { get; set; }

		/// <summary>
		/// Gets or Sets PIUserInfo
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIUserInfo
		/// </summary>
		[DataMember(Name = "IsAuthenticated", EmitDefaultValue = false)]
		public bool? IsAuthenticated { get; set; }

		/// <summary>
		/// Gets or Sets PIUserInfo
		/// </summary>
		[DataMember(Name = "SID", EmitDefaultValue = false)]
		public string SID { get; set; }

		/// <summary>
		/// Gets or Sets PIUserInfo
		/// </summary>
		[DataMember(Name = "ImpersonationLevel", EmitDefaultValue = false)]
		public string ImpersonationLevel { get; set; }

	}
}
