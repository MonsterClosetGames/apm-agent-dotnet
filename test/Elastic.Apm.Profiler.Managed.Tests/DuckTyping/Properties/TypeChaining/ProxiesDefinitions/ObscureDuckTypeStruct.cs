﻿// Licensed to Elasticsearch B.V under
// one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
//
// <copyright file="ObscureDuckTypeStruct.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using Elastic.Apm.Profiler.Managed.DuckTyping;

namespace Elastic.Apm.Profiler.Managed.Tests.DuckTyping.Properties.TypeChaining.ProxiesDefinitions
{
#pragma warning disable 649

	[DuckCopy]
	public struct ObscureDuckTypeStruct
	{
		public DummyFieldStruct PublicStaticGetSelfType;
		public DummyFieldStruct InternalStaticGetSelfType;
		public DummyFieldStruct ProtectedStaticGetSelfType;
		public DummyFieldStruct PrivateStaticGetSelfType;

		public DummyFieldStruct PublicStaticGetSetSelfType;
		public DummyFieldStruct InternalStaticGetSetSelfType;
		public DummyFieldStruct ProtectedStaticGetSetSelfType;
		public DummyFieldStruct PrivateStaticGetSetSelfType;

		public DummyFieldStruct PublicGetSelfType;
		public DummyFieldStruct InternalGetSelfType;
		public DummyFieldStruct ProtectedGetSelfType;
		public DummyFieldStruct PrivateGetSelfType;

		public DummyFieldStruct PublicGetSetSelfType;
		public DummyFieldStruct InternalGetSetSelfType;
		public DummyFieldStruct ProtectedGetSetSelfType;
		public DummyFieldStruct PrivateGetSetSelfType;
	}
}
