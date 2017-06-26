using System.IO;
using DFQtoJSONConverter;
using Xunit;

namespace XUnitTest
{
	public class DfqConverterUnitTest
	{
		[Fact]
		public void ConvertTest()
		{
			var converter = new DfqConverter();
			converter.Convert(Path.Combine(Directory.GetCurrentDirectory(), "DfqFiles/features.dfq"));
		}
	}
}
