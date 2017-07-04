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
	/// PIVersion
	/// </summary>
	[DataContract]

	public class PIVersion
	{
		public PIVersion(string FullVersion = null, string MajorMinorRevision = null, string Build = null)
		{
			this.FullVersion = FullVersion;
			this.MajorMinorRevision = MajorMinorRevision;
			this.Build = Build;
		}

		/// <summary>
		/// Gets or Sets PIVersion
		/// </summary>
		[DataMember(Name = "FullVersion", EmitDefaultValue = false)]
		public string FullVersion { get; set; }

		/// <summary>
		/// Gets or Sets PIVersion
		/// </summary>
		[DataMember(Name = "MajorMinorRevision", EmitDefaultValue = false)]
		public string MajorMinorRevision { get; set; }

		/// <summary>
		/// Gets or Sets PIVersion
		/// </summary>
		[DataMember(Name = "Build", EmitDefaultValue = false)]
		public string Build { get; set; }

	}
}
