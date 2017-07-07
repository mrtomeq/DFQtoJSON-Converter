using System;
using System.IO;
using DFQtoJSONConverter;
using Xunit;

namespace XUnitTest
{
	public class MeasurementUnitTest
	{
		[Fact]
		public void MixedStructureTest()
		{
			var converter = new DfqConverter();
			converter.Convert(Path.Combine(Directory.GetCurrentDirectory(), "DfqFiles/characteristics-mixed structure.dfq"));

			Assert.True(converter.Characteristics.Count == 2);

			var measurement = converter.Characteristics[0].Measurements[0];

			Assert.True(measurement.Value == (float) 20.5);
			Assert.True(measurement.Attribute == (float) 255);
			Assert.Equal(new DateTime(2017, 1, 1, 15, 8, 40), measurement.DateTime);
			Assert.True(measurement.BatchNumber.Equals("batch 1"));
			Assert.True(measurement.Text.Equals("piece 1"));
			Assert.True(measurement.OrderNumber.Equals("order number 1"));

			measurement = converter.Characteristics[1].Measurements[0];
			Assert.True(measurement.Value == (float) 50.1);
			Assert.True(measurement.Attribute == (float) 200);
			Assert.Equal(new DateTime(2017, 1, 1, 15, 8, 40), measurement.DateTime);
			Assert.True(measurement.BatchNumber.Equals("batch 1"));
			Assert.True(measurement.Text.Equals("piece 1"));
			Assert.True(measurement.OrderNumber.Equals("order number 1"));
		}
	}
}
