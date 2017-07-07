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

			Assert.True(converter.Parts.Count == 1);
			Assert.True(converter.Characteristics.Count == 8);
		}

		[Fact]
		public void ConvertToJsonTest()
		{
			var converter = new DfqConverter();
			converter.Convert(Path.Combine(Directory.GetCurrentDirectory(), "DfqFiles/features.dfq"));

			Assert.True(converter.Parts.Count == 1);
			Assert.True(converter.Characteristics.Count == 8);

			var json = converter.GetJson();
			Assert.True(!string.IsNullOrEmpty(json));
		}
	}
}
