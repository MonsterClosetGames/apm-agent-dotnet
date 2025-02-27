﻿// Licensed to Elasticsearch B.V under
// one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
//
// <copyright file="IObscureDuckType.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using Elastic.Apm.Profiler.Managed.DuckTyping;

namespace Elastic.Apm.Profiler.Managed.Tests.DuckTyping.Properties.ReferenceType.ProxiesDefinitions
{
	public interface IObscureDuckType
	{
		string PublicStaticGetReferenceType { get; }

		string InternalStaticGetReferenceType { get; }

		string ProtectedStaticGetReferenceType { get; }

		string PrivateStaticGetReferenceType { get; }

		// *

		string PublicStaticGetSetReferenceType { get; set; }

		string InternalStaticGetSetReferenceType { get; set; }

		string ProtectedStaticGetSetReferenceType { get; set; }

		string PrivateStaticGetSetReferenceType { get; set; }

		// *

		string PublicGetReferenceType { get; }

		string InternalGetReferenceType { get; }

		string ProtectedGetReferenceType { get; }

		string PrivateGetReferenceType { get; }

		// *

		string PublicGetSetReferenceType { get; set; }

		string InternalGetSetReferenceType { get; set; }

		string ProtectedGetSetReferenceType { get; set; }

		string PrivateGetSetReferenceType { get; set; }

		// *

		[Duck(Name = "PublicStaticGetSetReferenceType")]
		string PublicStaticOnlySet { set; }

		// *

		string this[string index] { get; set; }
	}
}
