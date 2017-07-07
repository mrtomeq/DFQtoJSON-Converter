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

			Assert.True(converter.Parts.Count == 1);
			Assert.True(converter.Characteristics.Count == 2);

			var characteristic = converter.Characteristics[0];

			Assert.True(characteristic.Number.Equals("M1-DM1-D"));
			Assert.True(characteristic.Description.Equals("Diameter"));
			Assert.True(characteristic.NominalValue == 20);
			Assert.True(characteristic.LowerSpecificationLimit == (float)19.6);
			Assert.True(characteristic.UpperSpecificationLimit == (float)20.4);
			Assert.True(characteristic.UnitDescription == "mm");

			characteristic = converter.Characteristics[1];

			Assert.True(characteristic.Number.Equals("M2-LM2-L"));
			Assert.True(characteristic.Description.Equals("Length"));
			Assert.True(characteristic.NominalValue == 50);
			Assert.True(characteristic.LowerSpecificationLimit == (float)49.5);
			Assert.True(characteristic.UpperSpecificationLimit == (float)50.5);
			Assert.True(characteristic.UnitDescription == "mm");
		}

		[Fact]
		public void ConvertTest()
		{
			var converter = new DfqConverter();
			converter.Convert(Path.Combine(Directory.GetCurrentDirectory(), "DfqFiles/features.dfq"));

			Assert.True(converter.Parts.Count == 1);
			Assert.True(converter.Characteristics.Count == 8);

			var characteristic = converter.Characteristics[0];

			Assert.True(characteristic.Number.Equals("DIA1"));
			Assert.True(characteristic.Description.Equals("point1 - Diameter"));
			Assert.True(characteristic.NominalValue == (float)8.1);
			Assert.True(characteristic.DecimalPlaces == 3);
			Assert.True(characteristic.LowerSpecificationLimit == (float)7.1);
			Assert.True(characteristic.LowerLimitType == 1);
			Assert.True(characteristic.UpperSpecificationLimit == (float)9.1);
			Assert.True(characteristic.UpperLimitType == 1);
			Assert.True(characteristic.UnitDescription == "mm");
			Assert.True(characteristic.GageDescription == "point1");

			characteristic = converter.Characteristics[1];

			Assert.True(characteristic.Number.Equals("X2"));
			Assert.True(characteristic.Description.Equals("point1 - X"));
			Assert.True(characteristic.NominalValue == (float)2083.652);
			Assert.True(characteristic.DecimalPlaces == 3);
			Assert.True(characteristic.LowerSpecificationLimit == (float)2082.652);
			Assert.True(characteristic.LowerLimitType == 1);
			Assert.True(characteristic.UpperSpecificationLimit == (float)2084.652);
			Assert.True(characteristic.UpperLimitType == 1);
			Assert.True(characteristic.UnitDescription == "mm");
			Assert.True(characteristic.GageDescription == "point1");

			characteristic = converter.Characteristics[7];

			Assert.True(characteristic.Number.Equals("Z8"));
			Assert.True(characteristic.Description.Equals("point2 - Z"));
			Assert.True(characteristic.NominalValue == (float)-60.617);
			Assert.True(characteristic.DecimalPlaces == 3);
			Assert.True(characteristic.LowerSpecificationLimit == (float)-61.617);
			Assert.True(characteristic.LowerLimitType == 1);
			Assert.True(characteristic.UpperSpecificationLimit == (float)-59.617);
			Assert.True(characteristic.UpperLimitType == 1);
			Assert.True(characteristic.UnitDescription == "mm");
			Assert.True(characteristic.GageDescription == "point2");

		}
	}
}
