using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Measurements
{
	public static class MeasurementConverter
	{
		public static IEnumerable<MeasuredValues> Convert(IEnumerable<string> block, Characteristic[] characteristics)
		{
			var measured = new List<MeasuredValues>();

			foreach (var line in block)
			{
				if (char.IsNumber(line[0]))
				{
					//todo either create ne measuredVaule here or link it to characteristic...
					//Field structure version 1
					//ProcessLineStructure1(line, characteristics);
				}
				else if (line.StartsWith("K00"))
				{
					//Field structure version 2
					//ProcessLineStructure2(key, value, characteristics);
				}
			}

			return measured;
		}

		public static void ProcessLineStructure1(string line, MeasuredValues[] measuredValues)
		{
			//splits line into values for multiple characteristics
			var characteristicValues = line.Split((char)15);

			for (var index = 0; index < characteristicValues.Length; index++)
			{
				var values = characteristicValues[index].Split((char) 20);
				KeySetter.SetFromArray(values, measuredValues[index]);
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
