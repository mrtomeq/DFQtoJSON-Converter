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

		public static void SetFromArray(string[] values, MeasuredValues measuredValues)
		{
			if (values.Length > 0)
			{
				//set measured value
				SetProperty("K0001", values[0], measuredValues);
			}
			if (values.Length >= 2)
			{
				//set Attribute,
				SetProperty("K0002", values[1], measuredValues);
			}
			if (values.Length >= 3)
			{
				//set Date / time,
				SetProperty("K0004", values[2], measuredValues);
			}
			if (values.Length >= 4)
			{
				//set Events,
				SetProperty("K0005", values[3], measuredValues);
			}
			if (values.Length >= 5)
			{
				//set Batch number,
				values[4] = values[4].Replace("#", "");
				SetProperty("K0006", values[4], measuredValues);
			}
			if (values.Length >= 6)
			{
				//set Nest number,
				SetProperty("K0007", values[5], measuredValues);
			}
			if (values.Length >= 7)
			{
				//set Operator number,
				SetProperty("K0008", values[6], measuredValues);
			}
			if (values.Length >= 8)
			{
				//set Machine number,
				SetProperty("K0010", values[7], measuredValues);
			}
			if (values.Length >= 9)
			{
				//set Process parameter,
				SetProperty("K0011", values[8], measuredValues);
			}
			if (values.Length == 10)
			{
				//set Gage number.
				SetProperty("K0012", values[9], measuredValues);
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
