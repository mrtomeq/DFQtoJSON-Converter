using System;
using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Measurements
{
	public static class KeySetter
	{
		public static void SetProperty(string key, string value, MeasuredValues part)
		{
			Action<string, MeasuredValues> propertySetter;
			if (KeyLookup.TryGetValue(key, out propertySetter))
			{
				propertySetter?.Invoke(value, part);
			}
		}

		public static readonly Dictionary<string, Action<string, MeasuredValues>> KeyLookup =
			new Dictionary<string, Action<string, MeasuredValues>>
			{
				{"K1001", SetPartNumber},
				{"K1002", SetDescription},
				//{"K1003", SetAbbreviation},
				//{"K1004", SetAmendmentStatus},
				//{"K1005", SetProduct},
				//{"K1007", SetNumberShort},
				//{"K1008", SetType},


				//{"K1022", SetManufacturerDescription},
				//{"K1023", SetManufacturerNumber},
				//{"K1044", SetDrawingNumber},
				//{"K1311", SetProductionOrder},
				//{"K1062", SetCustomerDescription},
				//{"K1063", SetCustomerNumber},
				//{"K8500", SubgroupSize},
				//{"K8501", SubgroupType}
			};

		public static void SetPartNumber(string value, MeasuredValues measured)
		{
			//part.Number = value;
		}

		public static void SetDescription(string value, MeasuredValues measured)
		{
			//part.Description = value;
		}


		/*
		 * 
		 *    I3 = Integer (1 Byte)
			o I5 = Integer (2 Byte)
			o I10 = Integer (4 Byte)
			o F = Float
			o D = Date/Time format
			o A = Alpha numerical
			o S = special coding
		 * 
		 */
	}
}
