using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Characteristics
{
	public static class CharacteristicConverter
	{
		public static KeySetter<Characteristic> CharacteristicKeySetter = new KeySetter<Characteristic>();

		public static void Convert(IEnumerable<string> block, Characteristic[] characteristics)
		{
			foreach (var line in block)
			{
				var spaceIndex = line.IndexOf(' ');
				var key = line.Substring(0, spaceIndex);
				var value = line.Substring(spaceIndex+1);

				if (value.IndexOf((char)15) > 0)
				{
					//Field structure version 1
					ProcessLineStructure1(key, value, characteristics);
				}
				else
				{
					//Field structure version 2
					ProcessLineStructure2(key, value, characteristics);
				}
			}
		}

		public static void ProcessLineStructure1(string key, string valueLine, Characteristic[] characteristics)
		{
			var values = valueLine.Split((char)15);

			for (var index = 0; index < values.Length; index++)
			{
				CharacteristicKeySetter.SetProperty(key, values[index], characteristics[index]);
			}
		}

		public static void ProcessLineStructure2(string key, string valueLine, Characteristic[] characteristics)
		{
			var keyValues = key.Split('/');
			int characteristicNumber;

			if (!int.TryParse(keyValues[1], out characteristicNumber)) return;

			if (characteristicNumber == 0)
			{
				//assign the same value to all characteristics
				foreach (var characteristic in characteristics)
				{
					CharacteristicKeySetter.SetProperty(keyValues[0], valueLine, characteristic);
				}
			}
			else
			{
				CharacteristicKeySetter.SetProperty(keyValues[0], valueLine, characteristics[characteristicNumber-1]);
			}
		}
	}
}
