// Licensed to Elasticsearch B.V under the Apache 2.0 License.
// Elasticsearch B.V licenses this file, including any modifications, to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// <copyright file="CommandExecuteNonQueryIntegration.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System;
using System.Data;
using Elastic.Apm.Api;
using Elastic.Apm.Profiler.Managed.CallTarget;
using Elastic.Apm.Profiler.Managed.Core;
using static Elastic.Apm.Profiler.Managed.Integrations.AdoNet.AdoNetTypeNames;

namespace Elastic.Apm.Profiler.Managed.Integrations.AdoNet
{
	/// <summary>
	/// CallTarget instrumentation for:
	/// int [Command].ExecuteNonQuery()
	/// </summary>
	[InstrumentMySqlAttribute(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentNpgsql(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentOracleManagedDataAccess(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentOracleManagedDataAccessCore(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentMicrosoftDataSqlite(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentSystemDataSqlite(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentSystemDataSql(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentSystemDataSqlClient(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	[InstrumentMicrosoftDataSqlClient(Method = ExecuteNonQuery, ReturnType = ClrTypeNames.Int32)]
	public class CommandExecuteNonQueryIntegration
	{
		/// <summary>
		/// OnMethodBegin callback
		/// </summary>
		/// <typeparam name="TTarget">Type of the target</typeparam>
		/// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
		/// <returns>Calltarget state value</returns>
		public static CallTargetState OnMethodBegin<TTarget>(TTarget instance)
		{
			var command = (IDbCommand)instance;
			return new CallTargetState(DbSpanFactory<TTarget>.CreateSpan(Agent.Instance, command), command);
		}

		/// <summary>
		/// OnMethodEnd callback
		/// </summary>
		/// <typeparam name="TTarget">Type of the target</typeparam>
		/// <typeparam name="TReturn">Type of the return value</typeparam>
		/// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
		/// <param name="returnValue">Task of HttpResponse message instance</param>
		/// <param name="exception">Exception instance in case the original code threw an exception.</param>
		/// <param name="state">Calltarget state value</param>
		/// <returns>A response value, in an async scenario will be T of Task of T</returns>
		public static CallTargetReturn<TReturn> OnMethodEnd<TTarget, TReturn>(TTarget instance, TReturn returnValue, Exception exception,
			CallTargetState state
		)
		{
			DbSpanFactory<TTarget>.EndSpan(Agent.Instance, (IDbCommand)instance, (ISpan)state.Segment, exception);
			return new CallTargetReturn<TReturn>(returnValue);
		}
	}
}
