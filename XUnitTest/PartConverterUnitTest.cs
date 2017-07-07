using System.IO;
using DFQtoJSONConverter;
using Xunit;

namespace XUnitTest
{
	public class PartConverterUnitTest
	{
		[Fact]
		public void ConvertTest()
		{
			var converter = new DfqConverter();
			converter.Convert(Path.Combine(Directory.GetCurrentDirectory(), "DfqFiles/features.dfq"));

			Assert.True(converter.Parts.Count == 1);
			Assert.True(converter.Characteristics.Count == 8);

			var part = converter.Parts[0];

			Assert.True(part.Number.Equals("partNumber1"));
			Assert.True(part.Description.Equals("partDescription1"));
			Assert.True(part.ManufacturerDescription.Equals("Company"));
			Assert.True(part.DrawingNumber == 123);
			Assert.True(part.CustomerDescription.Equals("department"));
			Assert.True(part.ProductionOrder.Equals("Model"));
		}
	}
}
