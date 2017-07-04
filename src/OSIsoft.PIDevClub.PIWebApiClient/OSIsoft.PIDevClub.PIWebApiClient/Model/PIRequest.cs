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
	/// PIRequest
	/// </summary>
	[DataContract]

	public class PIRequest
	{
		public PIRequest(string Method = null, string Resource = null, PIRequestTemplate RequestTemplate = null, List<string> Parameters = null, Dictionary<string, string> Headers = null, string Content = null, List<string> ParentIds = null)
		{
			this.Method = Method;
			this.Resource = Resource;
			this.RequestTemplate = RequestTemplate;
			this.Parameters = Parameters;
			this.Headers = Headers;
			this.Content = Content;
			this.ParentIds = ParentIds;
		}

		/// <summary>
		/// Gets or Sets PIRequest
		/// </summary>
		[DataMember(Name = "Method", EmitDefaultValue = false)]
		public string Method { get; set; }

		/// <summary>
		/// Gets or Sets PIRequest
		/// </summary>
		[DataMember(Name = "Resource", EmitDefaultValue = false)]
		public string Resource { get; set; }

		/// <summary>
		/// Gets or Sets PIRequest
		/// </summary>
		[DataMember(Name = "RequestTemplate", EmitDefaultValue = false)]
		public PIRequestTemplate RequestTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PIRequest
		/// </summary>
		[DataMember(Name = "Parameters", EmitDefaultValue = false)]
		public List<string> Parameters { get; set; }

		/// <summary>
		/// Gets or Sets PIRequest
		/// </summary>
		[DataMember(Name = "Headers", EmitDefaultValue = false)]
		public Dictionary<string, string> Headers { get; set; }

		/// <summary>
		/// Gets or Sets PIRequest
		/// </summary>
		[DataMember(Name = "Content", EmitDefaultValue = false)]
		public string Content { get; set; }

		/// <summary>
		/// Gets or Sets PIRequest
		/// </summary>
		[DataMember(Name = "ParentIds", EmitDefaultValue = false)]
		public List<string> ParentIds { get; set; }

	}
}
