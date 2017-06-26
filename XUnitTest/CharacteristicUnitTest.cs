using System.IO;
using System.Linq;
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
			Assert.True(converter.Characteristics.Any());
		}
	}
}
