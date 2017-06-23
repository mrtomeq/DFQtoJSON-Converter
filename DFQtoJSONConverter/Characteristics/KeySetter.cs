using System;
using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Characteristics
{
    public static class KeySetter
    {
	    public static void SetProperty(string key, string value, Characteristic characteristic)
	    {
		    Action<string, Characteristic> propertySetter;
		    if (KeySetter.KeyLookup.TryGetValue(key, out propertySetter))
		    {
			    propertySetter?.Invoke(value, characteristic);
		    }
	    }

		public static readonly Dictionary<string, Action<string, Models.Characteristic>> KeyLookup = new Dictionary<string, Action<string, Models.Characteristic>>
	    {
		    {"K1001", SetPartNumber },
		    {"K1002", SetDescription },
		    //{"K1003", SetAbbreviation },
		    //{"K1004", SetAmendmentStatus },
		    //{"K1005", SetProduct },
		    //{"K1007", SetNumberShort },
		    //{"K1008", SetType },


		    //{"K1022", SetManufacturerDescription },
		    //{"K1023", SetManufacturerNumber },
		    //{"K1044", SetDrawingNumber},
		    //{"K1311", SetProductionOrder},
		    //{"K1062", SetCustomerDescription},
		    //{"K1063", SetCustomerNumber},
		    //{"K8500", SubgroupSize},
		    //{"K8501", SubgroupType}
	    };

	    public static void SetPartNumber(string value, Models.Characteristic part)
	    {
		    part.Number = value;
	    }

	    public static void SetDescription(string value, Models.Characteristic part)
	    {
		    part.Description = value;
	    }
	}
}
