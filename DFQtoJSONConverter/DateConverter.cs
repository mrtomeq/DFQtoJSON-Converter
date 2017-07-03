using System;
using System.Linq;

namespace DFQtoJSONConverter
{
	public static class DateConverter
	{
		public static DateTime Convert(string date)
		{
			var dateFormat = GetDateFormat(date);

			if (string.IsNullOrEmpty(dateFormat)) return DateTime.MinValue;

			var timeFormat = GetTimeFormat(date);

			var dateTimeFormat = string.IsNullOrEmpty(timeFormat) ? $"{dateFormat}" : $"{dateFormat}/{timeFormat}";

			return DateTime.ParseExact(date.ToUpper(), dateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
		}

		public static string GetDateFormat(string date)
		{
			var dateTimeStr = date.Split('/');
			if (dateTimeStr[0].Contains("."))
			{
				//DD.MM.YY or DD.MM.YYYY
				var timeStr = dateTimeStr[0].Split('.');
				return string.Format("{0}.{1}.{2}",
					timeStr[0].Length == 2 ? "dd" : "d",
					timeStr[1].Length == 2 ? "MM" : "M",
					timeStr[2].Length == 4 ? "yyyy" : "yy"
				);
			}

			if (dateTimeStr[0].Contains("-"))
			{
				//YY.MM.DD or YYYY.MM.DD
				var timeStr = dateTimeStr[0].Split('-');
				return string.Format("{0}-{1}-{2}",
					timeStr[0].Length == 4 ? "yyyy" : "yy",
					timeStr[1].Length == 2 ? "MM" : "M",
					timeStr[2].Length == 2 ? "dd" : "d"
				);
			}

			if (dateTimeStr.Length >= 3)
			{
				//MM/DD/YY and MM/DD/YYYY
				return string.Format("{0}/{1}/{2}",
					dateTimeStr[0].Length == 2 ? "MM" : "M",
					dateTimeStr[1].Length == 2 ? "dd" : "d",
					dateTimeStr[2].Length == 4 ? "yyyy" : "yy"
				);
			}

			return null;
		}

		public static string GetTimeFormat(string date)
		{
			var dateTimeStr = date.Split('/');

			if (dateTimeStr.Length == 3)
				return null;

			dateTimeStr = dateTimeStr.Last().Split(':');

			if (dateTimeStr.Length == 1 && dateTimeStr[0].Length <= 2)
				return string.Format("{0}", dateTimeStr[0].Length == 2 ? "HH" : "H"
				);

			if (dateTimeStr.Length == 2)
				return string.Format("{0}:{1}",
					dateTimeStr[0].Length == 2 ? "HH" : "H",
					dateTimeStr[1].Length == 2 ? "mm" : "m"
				);

			if (dateTimeStr.Last().EndsWith("m"))
				return string.Format("{0}:{1}:{2}",
					dateTimeStr[0].Length == 2 ? "hh" : "h",
					dateTimeStr[1].Length == 2 ? "mm" : "m",
					dateTimeStr[2].Length == 4 ? "sstt" : "stt"
				);

			if (dateTimeStr.Last().EndsWith("a") || dateTimeStr.Last().EndsWith("p"))
				return string.Format("{0}:{1}:{2}",
					dateTimeStr[0].Length == 2 ? "hh" : "h",
					dateTimeStr[1].Length == 2 ? "mm" : "m",
					dateTimeStr[2].Length == 3 ? "sst" : "st"
				);

			if (dateTimeStr.Length == 3)
				return string.Format("{0}:{1}:{2}",
					dateTimeStr[0].Length == 2 ? "HH" : "H",
					dateTimeStr[1].Length == 2 ? "mm" : "m",
					dateTimeStr[2].Length == 2 ? "ss" : "s"
				);

			return null;
		}
	}
}
