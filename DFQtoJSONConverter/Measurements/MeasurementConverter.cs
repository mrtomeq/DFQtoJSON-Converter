using System.Collections.Generic;
using System.Linq;
using Models;

namespace DFQtoJSONConverter.Measurements
{
	public static class MeasurementConverter
	{
		public static void Convert(IEnumerable<string> block, Characteristic[] characteristics)
		{
			foreach (var line in block)
			{
				if (char.IsNumber(line[0]))
				{
					//todo either create ne measuredVaule here or link it to characteristic...
					//Field structure version 1
					ProcessLineStructure1(line, characteristics);
				}
				else
				{
					//Field structure version 2
					ProcessLineStructure2(line, characteristics);
				}
			}
		}

		public static void ProcessLineStructure1(string line, Characteristic[] characteristics)
		{
			//splits line into values for multiple characteristics
			var characteristicValues = line.Split((char)15);

			for (var index = 0; index < characteristicValues.Length; index++)
			{
				var measured = new MeasuredValues();
				var values = characteristicValues[index].Split((char) 20);
				KeySetter.SetFromArray(values, measured);

				if (characteristics.Length >= index + 1)
				{
					characteristics[index].Measurements.Add(measured);
				}
			}
		}

		public static void ProcessLineStructure2(string valueLine, Characteristic[] characteristics)
		{
			var keyValues = valueLine.Split('/');
			int characteristicNumber;

			if (!int.TryParse(keyValues[1], out characteristicNumber)) return;

			if (characteristicNumber == 0)
			{
				//assign the same value to all characteristics
				foreach (var characteristic in characteristics)
				{
					ProcessMeasurement(keyValues[0], keyValues[1], characteristic);
				}
			}
			else
			{
				ProcessMeasurement(keyValues[0], keyValues[1], characteristics[characteristicNumber - 1]);
			}
		}

		private static void ProcessMeasurement(string key, string value, Characteristic characteristic)
		{
			//value k0001 will start new measuremet, if it is already set we need to create new measValue object
			var lastMeasurement = characteristic.Measurements.Last();
			if (KeySetter.IsNewMeasurement(key, lastMeasurement))
			{
				lastMeasurement = new MeasuredValues();
				characteristic.Measurements.Add(lastMeasurement);
			}

			KeySetter.SetProperty(key, value, lastMeasurement);
		}
	}
}
