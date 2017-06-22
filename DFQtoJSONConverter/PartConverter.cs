using System;
using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter
{
	public class PartConverter
	{
		public Part ConvertPart(IEnumerable<string> block)
		{
			var part = new Part();

			foreach (var line in block)
			{
				var values = line.Split(' ');

				SetProperty(values[0], part, values[1]);
			}

			return part;
		}

		public static void SetProperty(string key, Part part, string value)
		{
			var propertySetter = KeyLookup[key];

			propertySetter?.Invoke(value, part);
		}

		public static readonly Dictionary<string, Action<string, Part>> KeyLookup = new Dictionary<string, Action<string, Part>>
		{
			{"K1001", SetPartNumber },
			{"K1002", SetDescription },
			{"K1003", SetAbbreviation },
			{"K1022", SetManufacturerDescription },
			{"K1023", SetManufacturerNumber },
			{"K1044", SetDrawingNumber},
			{"K1311", SetProductionOrder},
			{"K1062", SetCustomerDescription},
			{"K1063", SetCustomerNumber},
			//{"K8500", SubgroupSize},
			//{"K8501", SubgroupType}
		};

		public static void SetPartNumber(string value, Part part)
		{
			part.Number = value;
		}

		public static void SetDescription(string value, Part part)
		{
			part.Description = value;
		}

		public static void SetAbbreviation(string value, Part part)
		{
			part.Abbreviation = value;
		}

		public static void SetManufacturerDescription(string value, Part part)
		{
			part.ManufacturerDescription = value;
		}

		public static void SetManufacturerNumber(string value, Part part)
		{
			part.ManufacturerNumber = value;
		}

		public static void SetDrawingNumber(string value, Part part)
		{
			part.DrawingNumber = value;
		}

		public static void SetProductionOrder(string value, Part part)
		{
			part.Description = value;
		}

		public static void SetCustomerDescription(string value, Part part)
		{
			part.CustomerDescription = value;
		}

		public static void SetCustomerNumber(string value, Part part)
		{
			part.CustomerNumber = value;
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
