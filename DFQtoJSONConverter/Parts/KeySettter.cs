using System;
using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Parts
{
	public static class KeySettter
	{
		public static void SetProperty(string key, string value, Part part)
		{
			if (KeyLookup.TryGetValue(key, out Action<string, Part> propertySetter))
			{
				propertySetter?.Invoke(value, part);
			}
		}

		public static readonly Dictionary<string, Action<string, Part>> KeyLookup =
			new Dictionary<string, Action<string, Part>>
			{
				{"K1001", SetPartNumber},
				{"K1002", SetDescription},
				{"K1003", SetAbbreviation},
				{"K1004", SetAmendmentStatus},
				{"K1005", SetProduct},
				{"K1007", SetNumberShort},
				{"K1008", SetType},
				{"K1009", SetCode},
				{"K1010", SetControlItem},
				{"K1011", SetVersion},
				{"K1012", SetAnnexId},
				{"K1013", SetIndexId},
				{"K1014", SetIdent},
				{"K1015", SetTypeOfTest},
				{"K1016", SetAssemblyPart},
				{"K1017", SetTestPlanStatus},
				{"K1020", SetManufacturerCatalogue},
				{"K1021", SetManufacturerNumberText},
				{"K1022", SetManufacturerDescription},
				{"K1023", SetManufacturerNumber},
				{"K1030", SetMaterialCatalogue},
				{"K1031", SetMaterialNumberText},
				{"K1032", SetMaterialDescription},
				{"K1033", SetMaterialNumber},
				{"K1040", SetDrawingCatalogue},
				{"K1041", SetDrawingNumberText},
				{"K1042", SetDrawingAmendment},
				{"K1043", SetDrawingIndex},
				{"K1044", SetDrawingNumber},
				{"K1045", SetDrawingValidityDate},
				{"K1046", SetDrawingDescription},
				{"K1047", SetBasicDrawingNumber},
				{"K1048", SetCadDrawingFileName},
				{"K1050", SetContractorCatalogue},
				{"K1051", SetContractorNumberText},
				{"K1052", SetContractorDescription},
				{"K1053", SetContract},
				{"K1054", SetContractorNumber},
				{"K1060", SetCustomerCatalogue},
				{"K1061", SetCustomerNumberText},
				{"K1062", SetCustomerDescription},
				{"K1063", SetCustomerNumber},
				{"K1070", SetSupplierCatalogue},
				{"K1071", SetSupplierNumberText},
				{"K1072", SetSupplierDescription},
				{"K1073", SetSupplierNumber},
				{"K1080", SetMachineCatalogue},
				{"K1081", SetMachineNumberText},
				{"K1082", SetMachineDescription},
				{"K1083", SetMachineNumber},
				{"K1085", SetMachineLocation},
				{"K1086", SetWorkCycleOperation},
				{"K1087", SetWorkCycleDescription},
				{"K1091", SetLineNumber},
				{"K1092", SetLineDescription},
				{"K1100", SetAreaPlantSector},
				{"K1101", SetDepartment},
				{"K1102", SetWorkshop},
				{"K1103", SetCostCentre},
				{"K1104", SetShift},
				{"K1105", SetDivisionNumber},
				{"K1106", SetDepartmentNumber},
				{"K1107", SetWorkshopNumber},
				{"K1108", SetCostCentreNumber},
				{"K1110", SetOrderNumber},
				{"K1111", SetGoodsReceivedNumber},
				{"K1112", SetCube},
				{"K1113", SetLocation},
				{"K1114", SetDevice},
				{"K1115", SetProductionDate},
				{"K1201", SetTestFacilityNumberText},
				{"K1202", SetTestFacilityDescription},
				{"K1203", SetReasonForTest},
				{"K1204", SetTestBegin},
				{"K1205", SetTestEnd},
				{"K1206", SetTestLocation},
				{"K1207", SetTestPlanDeveloper},
				{"K1208", SetTestFacilityNumber},
				{"K1209", SetInspectionType},
				{"K1210", SetMeasurementType},
				{"K1211", SetStandardMasterNumberText},
				{"K1212", SetStandardMasterDescription},
				{"K1215", SetStandardMasterNumber},
				{"K1221", SetInspectorNumberText},
				{"K1222", SetInspectorName},
				{"K1223", SetInspectorNumber},
				{"K1230", SetGageRoom},
				{"K1231", SetMeasurementProgramNumber},
				{"K1301", SetClient},
				{"K1302", SetTestBatch},
				{"K1303", SetPlant},
				{"K1304", SetPlantNumber},
				{"K1311", SetProductionOrder},
				{"K1341", SetTestPlanNumberText},
				{"K1342", SetTestPlanName},
				{"K1343", SetTestPlanCreationDate},
				{"K1344", SetTestPlanCreator},
				{"K1350", SetOutputReportFile},
				{"K1800", SetUserFieldDescription1},
				{"K1801", SetUserFieldType1},
				{"K1802", SetUserFieldContent1},
				{"K1810", SetUserFieldDescription2},
				{"K1811", SetUserFieldType2},
				{"K1812", SetUserFieldContent2},
				{"K1820", SetUserFieldDescription3},
				{"K1821", SetUserFieldType3},
				{"K1822", SetUserFieldContent3},
				{"K1830", SetUserFieldDescription4},
				{"K1831", SetUserFieldType4},
				{"K1832", SetUserFieldContent4},
				{"K1840", SetUserFieldDescription5},
				{"K1841", SetUserFieldType5},
				{"K1842", SetUserFieldContent5},
				{"K1850", SetUserFieldDescription6},
				{"K1851", SetUserFieldType6},
				{"K1852", SetUserFieldContent6},
				{"K1860", SetUserFieldDescription7},
				{"K1861", SetUserFieldType7},
				{"K1862", SetUserFieldContent7},
				{"K1870", SetUserFieldDescription8},
				{"K1871", SetUserFieldType8},
				{"K1872", SetUserFieldContent8},
				{"K1880", SetUserFieldDescription9},
				{"K1881", SetUserFieldType9},
				{"K1882", SetUserFieldContent9},
				{"K1890", SetUserFieldDescription10},
				{"K1891", SetUserFieldType10},
				{"K1892", SetUserFieldContent10}

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

		public static void SetAmendmentStatus(string value, Part part)
		{
			part.AmendmentStatus = value;
		}

		public static void SetProduct(string value, Part part)
		{
			part.Product = value;
		}

		public static void SetNumberShort(string value, Part part)
		{
			part.NumberShort = value;
		}

		public static void SetType(string value, Part part)
		{
			part.Type = value;
		}

		public static void SetCode(string value, Part part)
		{
			part.Code = value;
		}

		public static void SetControlItem(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.ControlItem = result;
			}
		}

		public static void SetVersion(string value, Part part)
		{
			part.Version = value;
		}

		public static void SetAnnexId(string value, Part part)
		{
			part.AnnexId = value;
		}

		public static void SetIndexId(string value, Part part)
		{
			part.IndexId = value;
		}

		public static void SetIdent(string value, Part part)
		{
			part.Ident = value;
		}

		public static void SetTypeOfTest(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.TypeOfTest = result;
			}
		}

		public static void SetAssemblyPart(string value, Part part)
		{
			part.AssemblyPart = value;
		}

		public static void SetTestPlanStatus(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.TestPlanStatus = result;
			}
		}

		public static void SetManufacturerCatalogue(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.ManufacturerCatalogue = result;
			}
		}

		public static void SetManufacturerNumberText(string value, Part part)
		{
			part.ManufacturerNumberText = value;
		}

		public static void SetManufacturerDescription(string value, Part part)
		{
			part.ManufacturerDescription = value;
		}

		public static void SetManufacturerNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.ManufacturerNumber = result;
			}
		}

		public static void SetMaterialCatalogue(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.MaterialCatalogue = result;
			}
		}

		public static void SetMaterialNumberText(string value, Part part)
		{
			part.MaterialNumberText = value;
		}

		public static void SetMaterialDescription(string value, Part part)
		{
			part.MaterialDescription = value;
		}

		public static void SetMaterialNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.MaterialNumber = result;
			}
		}

		public static void SetDrawingCatalogue(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.DrawingCatalogue = result;
			}
		}

		public static void SetDrawingNumberText(string value, Part part)
		{
			part.DrawingNumberText = value;
		}

		public static void SetDrawingAmendment(string value, Part part)
		{
			part.DrawingAmendment = value;
		}

		public static void SetDrawingIndex(string value, Part part)
		{
			part.DrawingIndex = value;
		}

		public static void SetDrawingNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.DrawingNumber = result;
			}
		}

		public static void SetDrawingValidityDate(string value, Part part)
		{
			var date = DateConverter.Convert(value);

			if (date != DateTime.MinValue)
			{
				part.DrawingValidityDate = date;
			}
		}

		public static void SetDrawingDescription(string value, Part part)
		{
			part.DrawingDescription = value;
		}

		public static void SetBasicDrawingNumber(string value, Part part)
		{
			part.BasicDrawingNumber = value;
		}

		public static void SetCadDrawingFileName(string value, Part part)
		{
			part.CadDrawingFileName = value;
		}

		public static void SetContractorCatalogue(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.ContractorCatalogue = result;
			}
		}

		public static void SetContractorNumberText(string value, Part part)
		{
			part.ContractorNumberText = value;
		}

		public static void SetContractorDescription(string value, Part part)
		{
			part.ContractorDescription = value;
		}

		public static void SetContract(string value, Part part)
		{
			part.Contract = value;
		}

		public static void SetContractorNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.ContractorNumber = result;
			}
		}

		public static void SetCustomerCatalogue(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.CustomerCatalogue = result;
			}
		}

		public static void SetCustomerNumberText(string value, Part part)
		{
			part.CustomerNumberText = value;
		}

		public static void SetCustomerDescription(string value, Part part)
		{
			part.CustomerDescription = value;
		}

		public static void SetCustomerNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.CustomerNumber = result;
			}
		}

		public static void SetSupplierCatalogue(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.SupplierCatalogue = result;
			}
		}

		public static void SetSupplierNumberText(string value, Part part)
		{
			part.SupplierNumberText = value;
		}

		public static void SetSupplierDescription(string value, Part part)
		{
			part.SupplierDescription = value;
		}

		public static void SetSupplierNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.SupplierNumber = result;
			}
		}

		public static void SetMachineCatalogue(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.MachineCatalogue = result;
			}
		}

		public static void SetMachineNumberText(string value, Part part)
		{
			part.MachineNumberText = value;
		}

		public static void SetMachineDescription(string value, Part part)
		{
			part.MachineDescription = value;
		}

		public static void SetMachineNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.MachineNumber = result;
			}
		}

		public static void SetMachineLocation(string value, Part part)
		{
			part.MachineLocation = value;
		}

		public static void SetWorkCycleOperation(string value, Part part)
		{
			part.WorkCycleOperation = value;
		}

		public static void SetWorkCycleDescription(string value, Part part)
		{
			part.WorkCycleDescription = value;
		}

		public static void SetLineNumber(string value, Part part)
		{
			part.LineNumber = value;
		}

		public static void SetLineDescription(string value, Part part)
		{
			part.LineDescription = value;
		}

		public static void SetAreaPlantSector(string value, Part part)
		{
			part.AreaPlantSector = value;
		}

		public static void SetDepartment(string value, Part part)
		{
			part.Department = value;
		}

		public static void SetWorkshop(string value, Part part)
		{
			part.Workshop = value;
		}

		public static void SetCostCentre(string value, Part part)
		{
			part.CostCentre = value;
		}

		public static void SetShift(string value, Part part)
		{
			part.Shift = value;
		}

		public static void SetDivisionNumber(string value, Part part)
		{
			part.DivisionNumber = value;
		}

		public static void SetDepartmentNumber(string value, Part part)
		{
			part.DepartmentNumber = value;
		}

		public static void SetWorkshopNumber(string value, Part part)
		{
			part.WorkshopNumber = value;
		}

		public static void SetCostCentreNumber(string value, Part part)
		{
			part.CostCentreNumber = value;
		}

		public static void SetOrderNumber(string value, Part part)
		{
			part.OrderNumber = value;
		}

		public static void SetGoodsReceivedNumber(string value, Part part)
		{
			part.GoodsReceivedNumber = value;
		}

		public static void SetCube(string value, Part part)
		{
			part.Cube = value;
		}

		public static void SetLocation(string value, Part part)
		{
			part.Location = value;
		}

		public static void SetDevice(string value, Part part)
		{
			part.Device = value;
		}

		public static void SetProductionDate(string value, Part part)
		{
			part.ProductionDate = value;
		}

		public static void SetTestFacilityNumberText(string value, Part part)
		{
			part.TestFacilityNumberText = value;
		}

		public static void SetTestFacilityDescription(string value, Part part)
		{
			part.TestFacilityDescription = value;
		}

		public static void SetReasonForTest(string value, Part part)
		{
			part.ReasonForTest = value;
		}

		public static void SetTestBegin(string value, Part part)
		{
			var date = DateConverter.Convert(value);

			if (date != DateTime.MinValue)
			{
				part.TestBegin = date;
			}
		}

		public static void SetTestEnd(string value, Part part)
		{
			var date = DateConverter.Convert(value);

			if (date != DateTime.MinValue)
			{
				part.TestEnd = date;
			}
		}

		public static void SetTestLocation(string value, Part part)
		{
			part.TestLocation = value;
		}

		public static void SetTestPlanDeveloper(string value, Part part)
		{
			part.TestPlanDeveloper = value;
		}

		public static void SetTestFacilityNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.TestFacilityNumber = result;
			}
		}

		public static void SetInspectionType(string value, Part part)
		{
			part.InspectionType = value;
		}

		public static void SetMeasurementType(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.MeasurementType = result;
			}
		}

		public static void SetStandardMasterNumberText(string value, Part part)
		{
			part.StandardMasterNumberText = value;
		}

		public static void SetStandardMasterDescription(string value, Part part)
		{
			part.StandardMasterDescription = value;
		}

		public static void SetStandardMasterNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.StandardMasterNumber = result;
			}
		}

		public static void SetInspectorNumberText(string value, Part part)
		{
			part.InspectorNumberText = value;
		}

		public static void SetInspectorName(string value, Part part)
		{
			part.InspectorName = value;
		}

		public static void SetInspectorNumber(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.InspectorNumber = result;
			}
		}

		public static void SetGageRoom(string value, Part part)
		{
			part.GageRoom = value;
		}

		public static void SetMeasurementProgramNumber(string value, Part part)
		{
			part.MeasurementProgramNumber = value;
		}

		public static void SetMeasurementProgramVersion(string value, Part part)
		{
			part.MeasurementProgramVersion = value;
		}

		public static void SetClient(string value, Part part)
		{
			if (int.TryParse(value, out int result))
			{
				part.Client = result;
			}
		}

		public static void SetTestBatch(string value, Part part)
		{
			part.TestBatch = value;
		}

		public static void SetPlant(string value, Part part)
		{
			part.Plant = value;
		}

		public static void SetPlantNumber(string value, Part part)
		{
			part.PlantNumber = value;
		}

		public static void SetProductionOrder(string value, Part part)
		{
			part.ProductionOrder = value;
		}

		public static void SetTestPlanNumberText(string value, Part part)
		{
			part.TestPlanNumberText = value;
		}

		public static void SetTestPlanName(string value, Part part)
		{
			part.TestPlanName = value;
		}

		public static void SetTestPlanCreationDate(string value, Part part)
		{
			part.TestPlanCreationDate = value;
		}

		public static void SetTestPlanCreator(string value, Part part)
		{
			part.TestPlanCreator = value;
		}

		public static void SetOutputReportFile(string value, Part part)
		{
			part.OutputReportFile = value;
		}

		public static void SetUserFieldDescription1(string value, Part part)
		{
			part.UserFieldDescription1 = value;
		}

		public static void SetUserFieldType1(string value, Part part)
		{
			part.UserFieldType1 = value;
		}

		public static void SetUserFieldContent1(string value, Part part)
		{
			part.UserFieldContent1 = value;
		}

		public static void SetUserFieldDescription2(string value, Part part)
		{
			part.UserFieldDescription2 = value;
		}

		public static void SetUserFieldType2(string value, Part part)
		{
			part.UserFieldType2 = value;
		}

		public static void SetUserFieldContent2(string value, Part part)
		{
			part.UserFieldContent2 = value;
		}

		public static void SetUserFieldDescription3(string value, Part part)
		{
			part.UserFieldDescription3 = value;
		}

		public static void SetUserFieldType3(string value, Part part)
		{
			part.UserFieldType3 = value;
		}

		public static void SetUserFieldContent3(string value, Part part)
		{
			part.UserFieldContent3 = value;
		}

		public static void SetUserFieldDescription4(string value, Part part)
		{
			part.UserFieldDescription4 = value;
		}

		public static void SetUserFieldType4(string value, Part part)
		{
			part.UserFieldType4 = value;
		}

		public static void SetUserFieldContent4(string value, Part part)
		{
			part.UserFieldContent4 = value;
		}

		public static void SetUserFieldDescription5(string value, Part part)
		{
			part.UserFieldDescription5 = value;
		}

		public static void SetUserFieldType5(string value, Part part)
		{
			part.UserFieldType5 = value;
		}

		public static void SetUserFieldContent5(string value, Part part)
		{
			part.UserFieldContent5 = value;
		}

		public static void SetUserFieldDescription6(string value, Part part)
		{
			part.UserFieldDescription6 = value;
		}

		public static void SetUserFieldType6(string value, Part part)
		{
			part.UserFieldType6 = value;
		}

		public static void SetUserFieldContent6(string value, Part part)
		{
			part.UserFieldContent6 = value;
		}

		public static void SetUserFieldDescription7(string value, Part part)
		{
			part.UserFieldDescription7 = value;
		}

		public static void SetUserFieldType7(string value, Part part)
		{
			part.UserFieldType7 = value;
		}

		public static void SetUserFieldContent7(string value, Part part)
		{
			part.UserFieldContent7 = value;
		}

		public static void SetUserFieldDescription8(string value, Part part)
		{
			part.UserFieldDescription8 = value;
		}

		public static void SetUserFieldType8(string value, Part part)
		{
			part.UserFieldType8 = value;
		}

		public static void SetUserFieldContent8(string value, Part part)
		{
			part.UserFieldContent8 = value;
		}

		public static void SetUserFieldDescription9(string value, Part part)
		{
			part.UserFieldDescription9 = value;
		}

		public static void SetUserFieldType9(string value, Part part)
		{
			part.UserFieldType9 = value;
		}

		public static void SetUserFieldContent9(string value, Part part)
		{
			part.UserFieldContent9 = value;
		}

		public static void SetUserFieldDescription10(string value, Part part)
		{
			part.UserFieldDescription10 = value;
		}

		public static void SetUserFieldType10(string value, Part part)
		{
			part.UserFieldType10 = value;
		}

		public static void SetUserFieldContent10(string value, Part part)
		{
			part.UserFieldContent10 = value;
		}
	}
}
