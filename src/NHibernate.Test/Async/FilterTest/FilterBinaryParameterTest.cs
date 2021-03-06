﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections;
using NUnit.Framework;

namespace NHibernate.Test.FilterTest
{
	using System.Threading.Tasks;
	[TestFixture]
	public class FilterBinaryParameterTestAsync : TestCase
	{
		protected override IList Mappings
		{
			get { return new string[] {"FilterTest.BinaryFiltered.hbm.xml"}; }
		}

		protected override string MappingsAssembly
		{
			get { return "NHibernate.Test"; }
		}

		[Test]
		public async Task NH882Async()
		{
			using (ISession session = OpenSession())
			{
				byte[] binValue = {0xFF, 0xFF, 0xFF};
				session.EnableFilter("BinaryFilter").SetParameter("BinaryValue", binValue);
				IQuery query = session.CreateQuery("from BinaryFiltered");
				await (query.ListAsync());
			}
		}
	}
}