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
	/// PIResponse
	/// </summary>
	[DataContract]

	public class PIResponse
	{
		public PIResponse(int? Status = null, Dictionary<string, string> Headers = null, object Content = null)
		{
			this.Status = Status;
			this.Headers = Headers;
			this.Content = Content;
		}

		/// <summary>
		/// Gets or Sets PIResponse
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets PIResponse
		/// </summary>
		[DataMember(Name = "Headers", EmitDefaultValue = false)]
		public Dictionary<string, string> Headers { get; set; }

		/// <summary>
		/// Gets or Sets PIResponse
		/// </summary>
		[DataMember(Name = "Content", EmitDefaultValue = false)]
		public object Content { get; set; }

	}
}
