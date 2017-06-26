using System.IO;
using DFQtoJSONConverter;
using Xunit;

namespace XUnitTest
{
	public class CharacteristicUnitTest
	{
		[Fact]
		public void MixedStructureTest()
		{
			var converter = new DfqConverter();
			converter.Convert(Path.Combine(Directory.GetCurrentDirectory(), "DfqFiles/characteristics-mixed structure.dfq"));
			Assert.Collection(converter.Characteristics);
		}
	}
}
