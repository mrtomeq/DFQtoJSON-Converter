using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using DFQtoJSONConverter;
using Models;
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

		[Fact]
		public void StringKeySetterTest()
		{
			var keySetter = new KeySetter<Part>();

			string testValue = "test";
			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.Description));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			keySetter.SetProperty(key, testValue, part);
	
			Assert.Equal(testValue, part.Description);
		}

		[Fact]
		public void DateKeySetterTest()
		{
			var keySetter = new KeySetter<Part>();
			var testDate = "17.06.96/13:48:10";
			var expectedDate = new DateTime(1996, 6, 17, 13, 48, 10);

			var part = new Part();
			var prop = typeof(Part).GetProperty(nameof(part.TestBegin));
			var key = prop.GetCustomAttribute<DisplayAttribute>().Name;

			keySetter.SetProperty(key, testDate, part);

			Assert.Equal(expectedDate, part.TestBegin);
		}
	}
}
