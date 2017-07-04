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
	/// PITimedValues
	/// </summary>
	[DataContract]

	public class PITimedValues
	{
		public PITimedValues(List<PITimedValue> Items = null, string UnitsAbbreviation = null)
		{
			this.Items = Items;
			this.UnitsAbbreviation = UnitsAbbreviation;
		}

		/// <summary>
		/// Gets or Sets PITimedValues
		/// </summary>
		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public List<PITimedValue> Items { get; set; }

		/// <summary>
		/// Gets or Sets PITimedValues
		/// </summary>
		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

	}
}
