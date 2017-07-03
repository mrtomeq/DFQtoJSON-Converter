using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using DFQtoJSONConverter;
using Xunit;

namespace XUnitTest
{
	public class DateConverterUnitTest
	{
		[Fact]
		public void ConvertTestDate()
		{
			var testDate1 = "17.06.96/13:48:10";
			var testDate2 = "17.06.14";
			var testDate3 = "17.06.2017";
			var testDate4 = "6/15/96";
			var testDate5 = "1/30/1996";
			var testDate6 = "96-4-26";
			var testDate7 = "1996-10-23";

			var testDate1Result = DateConverter.Convert(testDate1);
			Assert.Equal(new DateTime(1996, 6, 17).Date, testDate1Result.Date);

			var testDate2Result = DateConverter.Convert(testDate2);
			Assert.Equal(new DateTime(2014, 6, 17).Date, testDate2Result.Date);

			var testDate3Result = DateConverter.Convert(testDate3);
			Assert.Equal(new DateTime(2017, 6, 17).Date, testDate3Result.Date);

			var testDate4Result = DateConverter.Convert(testDate4);
			Assert.Equal(new DateTime(1996, 6, 15).Date, testDate4Result.Date);

			var testDate5Result = DateConverter.Convert(testDate5);
			Assert.Equal(new DateTime(1996, 1, 30).Date, testDate5Result.Date);

			var testDate6Result = DateConverter.Convert(testDate6);
			Assert.Equal(new DateTime(1996, 4, 26).Date, testDate6Result.Date);

			var testDate7Result = DateConverter.Convert(testDate7);
			Assert.Equal(new DateTime(1996, 10, 23).Date, testDate7Result.Date);
		}

		[Fact]
		public void ConvertTestTime()
		{
			var testDate1 = "17.06.96/13:48:10";
			var testDate2 = "17.06.14/5:3:6";
			var testDate3 = "17.06.2017/5:23";
			var testDate4 = "6/15/96/5";
			var testDate5 = "1/30/1996/5:4:8am";
			var testDate6 = "96-4-26/5:4:8pm";
			var testDate7 = "1996-10-23/5:4:8a";
			var testDate8 = "1996-10-23/5:4:8p";

			var testDate1Result = DateConverter.Convert(testDate1);
			Assert.Equal(new DateTime(1996, 6, 17, 13, 48, 10), testDate1Result);

			var testDate2Result = DateConverter.Convert(testDate2);
			Assert.Equal(new DateTime(2014, 6, 17, 5, 3, 6), testDate2Result);

			var testDate3Result = DateConverter.Convert(testDate3);
			Assert.Equal(new DateTime(2017, 6, 17, 5, 23, 0), testDate3Result);

			var testDate4Result = DateConverter.Convert(testDate4);
			Assert.Equal(new DateTime(1996, 6, 15, 5, 0, 0), testDate4Result);

			var testDate5Result = DateConverter.Convert(testDate5);
			Assert.Equal(new DateTime(1996, 1, 30, 5, 4, 8), testDate5Result);

			var testDate6Result = DateConverter.Convert(testDate6);
			Assert.Equal(new DateTime(1996, 4, 26, 17, 4, 8), testDate6Result);

			var testDate7Result = DateConverter.Convert(testDate7);
			Assert.Equal(new DateTime(1996, 10, 23, 5, 4, 8), testDate7Result);

			var testDate8Result = DateConverter.Convert(testDate8);
			Assert.Equal(new DateTime(1996, 10, 23, 17, 4, 8), testDate8Result);
		}
	}
}
