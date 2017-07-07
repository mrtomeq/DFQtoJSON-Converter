using System.Collections.Generic;
using System.Linq;
using Models;

namespace DFQtoJSONConverter.Measurements
{
	public static class MeasurementConverter
	{
		public static KeySetter<MeasuredValues> MeasurementKeySetter = new KeySetter<MeasuredValues>();

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
			var characteristicValues = line.Split((char) 15);

			for (var index = 0; index < characteristicValues.Length; index++)
			{
				var measured = new MeasuredValues();
				var values = characteristicValues[index].Split((char) 20);
				SetFromArray(values, measured);

				if (characteristics.Length >= index + 1)
				{
					characteristics[index].Measurements.Add(measured);
				}
			}
		}

		public static void ProcessLineStructure2(string valueLine, Characteristic[] characteristics)
		{
			var spaceIndex = valueLine.IndexOf(' ');
			var key = valueLine.Substring(0, spaceIndex);
			var value = valueLine.Substring(spaceIndex + 1);

			var keyValues = key.Split('/');
			int characteristicNumber;

			if (!int.TryParse(keyValues[1], out characteristicNumber)) return;

			if (characteristicNumber == 0)
			{
				//assign the same value to all characteristics
				foreach (var characteristic in characteristics)
				{
					ProcessMeasurement(keyValues[0], value, characteristic);
				}
			}
			else
			{
				ProcessMeasurement(keyValues[0], value, characteristics[characteristicNumber - 1]);
			}
		}

		private static void ProcessMeasurement(string key, string value, Characteristic characteristic)
		{
			//value k0001 will start new measuremet, if it is already set we need to create new measValue object
			var lastMeasurement = characteristic.Measurements.LastOrDefault();
			if (lastMeasurement == null || key.Equals(MeasurementKeys.Value) && lastMeasurement.Value.HasValue)
			{
				lastMeasurement = new MeasuredValues();
				characteristic.Measurements.Add(lastMeasurement);
			}

			MeasurementKeySetter.SetProperty(key, value, lastMeasurement);
		}

		public static void SetFromArray(string[] values, MeasuredValues measuredValues)
		{
			if (values.Length > 0)
			{
				//set measured value
				MeasurementKeySetter.SetProperty(MeasurementKeys.Value, values[0], measuredValues);
			}
			if (values.Length >= 2)
			{
				//set Attribute,
				MeasurementKeySetter.SetProperty(MeasurementKeys.Attribute, values[1], measuredValues);
			}
			if (values.Length >= 3)
			{
				//set Date / time,
				MeasurementKeySetter.SetProperty(MeasurementKeys.DateTime, values[2], measuredValues);
			}
			if (values.Length >= 4)
			{
				//set Events,
				MeasurementKeySetter.SetProperty(MeasurementKeys.Events, values[3], measuredValues);
			}
			if (values.Length >= 5)
			{
				//set Batch number,
				values[4] = values[4].Replace("#", "");
				MeasurementKeySetter.SetProperty(MeasurementKeys.BatchNumber, values[4], measuredValues);
			}
			if (values.Length >= 6)
			{
				//set spindle number,
				MeasurementKeySetter.SetProperty(MeasurementKeys.SpindleNumber, values[5], measuredValues);
			}
			if (values.Length >= 7)
			{
				//set Operator number,
				MeasurementKeySetter.SetProperty(MeasurementKeys.OperatorNumber, values[6], measuredValues);
			}
			if (values.Length >= 8)
			{
				//set Machine number,
				MeasurementKeySetter.SetProperty(MeasurementKeys.MachineNumber, values[7], measuredValues);
			}
			if (values.Length >= 9)
			{
				//set Process parameter,
				MeasurementKeySetter.SetProperty(MeasurementKeys.ProcessParameter, values[8], measuredValues);
			}
			if (values.Length == 10)
			{
				//set Gage number.
				MeasurementKeySetter.SetProperty(MeasurementKeys.GageNumber, values[9], measuredValues);
			}
		}
	}
}
