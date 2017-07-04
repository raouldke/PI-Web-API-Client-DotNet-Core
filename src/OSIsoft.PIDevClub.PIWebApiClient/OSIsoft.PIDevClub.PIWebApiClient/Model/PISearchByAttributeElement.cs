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
	/// PISearchByAttributeElement
	/// </summary>
	[DataContract]

	public class PISearchByAttributeElement
	{
		public PISearchByAttributeElement(object SearchRoot = null, object ElementTemplate = null, List<PIAttributeValueQuery> ValueQueries = null)
		{
			this.SearchRoot = SearchRoot;
			this.ElementTemplate = ElementTemplate;
			this.ValueQueries = ValueQueries;
		}

		/// <summary>
		/// Gets or Sets PISearchByAttributeElement
		/// </summary>
		[DataMember(Name = "SearchRoot", EmitDefaultValue = false)]
		public object SearchRoot { get; set; }

		/// <summary>
		/// Gets or Sets PISearchByAttributeElement
		/// </summary>
		[DataMember(Name = "ElementTemplate", EmitDefaultValue = false)]
		public object ElementTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PISearchByAttributeElement
		/// </summary>
		[DataMember(Name = "ValueQueries", EmitDefaultValue = false)]
		public List<PIAttributeValueQuery> ValueQueries { get; set; }

	}
}
