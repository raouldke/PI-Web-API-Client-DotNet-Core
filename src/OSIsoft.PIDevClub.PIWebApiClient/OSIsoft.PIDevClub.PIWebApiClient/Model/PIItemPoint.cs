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
	/// PIItemPoint
	/// </summary>
	[DataContract]

	public class PIItemPoint
	{
		public PIItemPoint(string Identifier = null, string IdentifierType = null, PIPoint Object = null, PIErrors Exception = null)
		{
			this.Identifier = Identifier;
			this.IdentifierType = IdentifierType;
			this.Object = Object;
			this.Exception = Exception;
		}

		/// <summary>
		/// Gets or Sets PIItemPoint
		/// </summary>
		[DataMember(Name = "Identifier", EmitDefaultValue = false)]
		public string Identifier { get; set; }

		/// <summary>
		/// Gets or Sets PIItemPoint
		/// </summary>
		[DataMember(Name = "IdentifierType", EmitDefaultValue = false)]
		public string IdentifierType { get; set; }

		/// <summary>
		/// Gets or Sets PIItemPoint
		/// </summary>
		[DataMember(Name = "Object", EmitDefaultValue = false)]
		public PIPoint Object { get; set; }

		/// <summary>
		/// Gets or Sets PIItemPoint
		/// </summary>
		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
