using System;
using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Measurements
{
	public static class KeySetter
	{
		public static void SetProperty(string key, string value, MeasuredValues part)
		{
			if (KeyLookup.TryGetValue(key, out Action<string, MeasuredValues> propertySetter))
			{
				propertySetter?.Invoke(value, part);
			}
		}

		public static bool IsNewMeasurement(string key, MeasuredValues measuredValues)
		{
			return measuredValues == null || key.Equals("K0001") && measuredValues.Value.HasValue;
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

		public static readonly Dictionary<string, Action<string, MeasuredValues>> KeyLookup = new Dictionary<string, Action<string, MeasuredValues>>
			{
				{"K0001", SetValue},
				{"K0002", SetAttribute},
				{"K0004", SetDateTime},
				{"K0005", SetEvents},
				{"K0006", SetBatchNumber},
				{"K0007", SetSpindleNumber},
				{"K0008", SetOperatorNumber},
				{"K0009", SetText},
				{"K0010", SetMachineNumber},
				{"K0011", SetProcessParameter},
				{"K0012", SetGageNumber},
				{"K0014", SetPartIdent},
				{"K0015", SetReasonForTest},
				{"K0016", SetProductionNumber},
				{"K0017", SetWorkPieceFixtureNumber},
				{"K0020", SetSubgroupSize},
				{"K0021", SetNumberOfErrors},
				{"K0053", SetOrderNumber},
				{"K0097", SetValuesGuid}
			};

		public static void SetValue(string value, MeasuredValues measured)
		{
			if (float.TryParse(value, out float result))
			{
				measured.Value = result;
			}
		}

		public static void SetAttribute(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.Attribute = result;
			}
		}

		public static void SetDateTime(string value, MeasuredValues measured)
		{
			if (DateTime.TryParse(value, out DateTime result))
			{
				measured.DateTime = result;
			}
		}

		public static void SetEvents(string value, MeasuredValues measured)
		{
			measured.Events = value;
		}

		public static void SetBatchNumber(string value, MeasuredValues measured)
		{
			measured.BatchNumber = value;
		}

		public static void SetSpindleNumber(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.SpindleNumber = result;
			}
		}

		public static void SetOperatorNumber(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.OperatorNumber = result;
			}
		}

		public static void SetText(string value, MeasuredValues measured)
		{
			measured.Text = value;
		}

		public static void SetMachineNumber(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.MachineNumber = result;
			}
		}

		public static void SetProcessParameter(string value, MeasuredValues measured)
		{
			measured.Text = value;
		}

		public static void SetGageNumber(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.GageNumber = result;
			}
		}

		public static void SetPartIdent(string value, MeasuredValues measured)
		{
			measured.PartIdent = value;
		}

		public static void SetReasonForTest(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.ReasonForTest = result;
			}
		}

		public static void SetProductionNumber(string value, MeasuredValues measured)
		{
			measured.ProductionNumber = value;
		}

		public static void SetWorkPieceFixtureNumber(string value, MeasuredValues measured)
		{
			measured.WorkPieceFixtureNumber = value;
		}

		public static void SetSubgroupSize(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.SubgroupSize = result;
			}
		}

		public static void SetNumberOfErrors(string value, MeasuredValues measured)
		{
			if (int.TryParse(value, out int result))
			{
				measured.NumberOfErrors = result;
			}
		}

		public static void SetOrderNumber(string value, MeasuredValues measured)
		{
			measured.OrderNumber = value;
		}

		public static void SetValuesGuid(string value, MeasuredValues measured)
		{
			if (Guid.TryParse(value, out Guid result))
			{
				measured.ValuesGuid = result;
			}
		}
	}
}
