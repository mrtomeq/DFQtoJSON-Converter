using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Measurements
{
	public static class MeasurementConverter
	{
		public static MeasuredValues Convert(IEnumerable<string> block)
		{
			var measured = new MeasuredValues();

			foreach (var line in block)
			{
				var spaceIndex = line.IndexOf(' ');
				var key = line.Substring(0, spaceIndex);
				var value = line.Substring(spaceIndex + 1);

				if (value.IndexOf((char)15) > 0)
				{
					//Field structure version 1
					//ProcessLineStructure1(key, value, characteristics);
				}
				else
				{
					//Field structure version 2
					//ProcessLineStructure2(key, value, characteristics);
				}
			}

			return measured;
		}

		public static void ProcessLineStructure1(string key, string valueLine, MeasuredValues[] characteristics)
		{
			var values = valueLine.Split((char)15);

			for (var index = 0; index < values.Length; index++)
			{
				KeySetter.SetProperty(key, values[index], characteristics[index]);
			}
		}

		public static void ProcessLineStructure2(string key, string valueLine, MeasuredValues[] characteristics)
		{
			var keyValues = key.Split('/');
			int characteristicNumber;

			if (!int.TryParse(keyValues[1], out characteristicNumber)) return;

			if (characteristicNumber == 0)
			{
				//assign the same value to all characteristics
				foreach (var characteristic in characteristics)
				{
					KeySetter.SetProperty(keyValues[0], valueLine, characteristic);
				}
			}
			else
			{
				KeySetter.SetProperty(keyValues[0], valueLine, characteristics[characteristicNumber - 1]);
			}
		}
	}
}
