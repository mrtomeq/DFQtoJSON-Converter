using System;
using System.IO;
using DFQtoJSONConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class DfqConverterUnitTest
	{
		[TestMethod]
		public void ConvertTest()
		{
			var converter = new DfqConverter();
			converter.Convert(Path.Combine(Directory.GetCurrentDirectory(), "DfqFiles/features.dfq"));
		}
	}
}
