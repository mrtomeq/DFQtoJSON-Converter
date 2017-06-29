using System;

namespace DFQtoJSONConverter
{
	public static class DateConverter
	{
		public static DateTime Convert(string date)
		{
			DateTime returnDate = DateTime.MinValue;
			var dateTimeStr = date.Split('/');
			
			if (dateTimeStr[0].Contains("."))
			{
				//DD.MM.YY or DD.MM.YYYY
				returnDate = ParseDotFormat(dateTimeStr[0]);
			}
			else if (dateTimeStr[0].Contains("-"))
			{
				//YY.MM.DD or YYYY.MM.DD
				returnDate = ParseDashFormat(dateTimeStr[0]);
			}
			else if (dateTimeStr.Length >= 3)
			{
				//MM/DD/YY and MM/DD/YYYY
				returnDate = ParseSlashFormat(date);
			}

			//todo parse time

			return returnDate;
		}

		private static DateTime ParseDotFormat(string date)
		{
			var dateStr = date.Split('.');

			if (dateStr.Length != 3) return DateTime.MinValue;

			if (int.TryParse(dateStr[2], out int year))
			{
				if (year < 100)
				{
					year += 2000;
				}
			}

			int.TryParse(dateStr[1], out int month);
			int.TryParse(dateStr[0], out int day);

			return new DateTime(
				year,
				month == 0 ? 1 : month,
				day == 0 ? 1 : day
			);
		}

		private static DateTime ParseDashFormat(string date)
		{
			var dateStr = date.Split('-');

			if (dateStr.Length != 3) return DateTime.MinValue;

			if (int.TryParse(dateStr[0], out int year))
			{
				if (year < 100)
				{
					year += 2000;
				}
			}

			int.TryParse(dateStr[1], out int month);
			int.TryParse(dateStr[2], out int day);

			return new DateTime(
				year,
				month == 0 ? 1 : month,
				day == 0 ? 1 : day
			);
		}

		private static DateTime ParseSlashFormat(string date)
		{
			var dateTimeStr = date.Split('/');

			if (dateTimeStr.Length < 3) return DateTime.MinValue;

			if (int.TryParse(dateTimeStr[2], out int year))
			{
				if (year < 100)
				{
					year += 2000;
				}
			}

			int.TryParse(dateTimeStr[0], out int month);
			int.TryParse(dateTimeStr[1], out int day);

			return new DateTime(
				year,
				month == 0 ? 1 : month,
				day == 0 ? 1 : day
			);
		}
	}
}
