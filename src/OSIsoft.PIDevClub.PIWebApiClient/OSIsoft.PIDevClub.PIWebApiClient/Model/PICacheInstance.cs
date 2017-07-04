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
	/// PICacheInstance
	/// </summary>
	[DataContract]

	public class PICacheInstance
	{
		public PICacheInstance(string Id = null, string LastRefreshTime = null, string WillRefreshAfter = null, string ScheduledExpirationTime = null, string User = null)
		{
			this.Id = Id;
			this.LastRefreshTime = LastRefreshTime;
			this.WillRefreshAfter = WillRefreshAfter;
			this.ScheduledExpirationTime = ScheduledExpirationTime;
			this.User = User;
		}

		/// <summary>
		/// Gets or Sets PICacheInstance
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PICacheInstance
		/// </summary>
		[DataMember(Name = "LastRefreshTime", EmitDefaultValue = false)]
		public string LastRefreshTime { get; set; }

		/// <summary>
		/// Gets or Sets PICacheInstance
		/// </summary>
		[DataMember(Name = "WillRefreshAfter", EmitDefaultValue = false)]
		public string WillRefreshAfter { get; set; }

		/// <summary>
		/// Gets or Sets PICacheInstance
		/// </summary>
		[DataMember(Name = "ScheduledExpirationTime", EmitDefaultValue = false)]
		public string ScheduledExpirationTime { get; set; }

		/// <summary>
		/// Gets or Sets PICacheInstance
		/// </summary>
		[DataMember(Name = "User", EmitDefaultValue = false)]
		public string User { get; set; }

	}
}
