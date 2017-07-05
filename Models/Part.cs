using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Part
	{
		public Characteristic[] Characteristics { get; set; }

		[Display(Name = "K1001", Description = "Part number")]
		public string Number { get; set; }

		[Display(Name = "K1002", Description = "Part description")]
		public string Description { get; set; }

		[Display(Name = "K1003", Description = "Part abbreviation")]
		public string Abbreviation { get; set; }

		[Display(Name = "K1004", Description = "Part Amendment status")]
		public string AmendmentStatus { get; set; }

		[Display(Name = "K1005", Description = "Product")]
		public string Product { get; set; }

		[Display(Name = "K1007", Description = "Part number - short description")]
		public string NumberShort { get; set; }

		[Display(Name = "K1008", Description = "Part type")]
		public string Type { get; set; }

		[Display(Name = "K1009", Description = "Part Code")]
		public string Code { get; set; }

		[Display(Name = "K1010", Description = "Control Item")]
		public int ControlItem { get; set; }

		[Display(Name = "K1011", Description = "Version")]
		public string Version { get; set; }

		[Display(Name = "K1012", Description = "ID Number Annex")]
		public string AnnexId { get; set; }

		[Display(Name = "K1013", Description = "ID Number Index")]
		public string IndexId { get; set; }

		[Display(Name = "K1014", Description = "Part Ident")]
		public string Ident { get; set; }

		[Display(Name = "K1015", Description = "Type Of test")]
		public int TypeOfTest { get; set; }

		[Display(Name = "K1016", Description = "Assembly Part")]
		public string AssemblyPart { get; set; }

		[Display(Name = "K1017", Description = "Test Plan Status")]
		public int TestPlanStatus { get; set; }

		[Display(Name = "K1020", Description = "Manufacturer Catalogue")]
		public int ManufacturerCatalogue { get; set; }

		[Display(Name = "K1021", Description = "Manufacturer Number Text")]
		public string ManufacturerNumberText { get; set; }

		[Display(Name = "K1022", Description = "Manufacturer description")]
		public string ManufacturerDescription { get; set; }

		[Display(Name = "K1023", Description = "Manufacturer number")]
		public int ManufacturerNumber { get; set; }

		[Display(Name = "K1030", Description = "Material Catalogue")]
		public int MaterialCatalogue { get; set; }

		[Display(Name = "K1031", Description = "Material Number Text")]
		public string MaterialNumberText { get; set; }

		[Display(Name = "K1032", Description = "Material Description")]
		public string MaterialDescription { get; set; }

		[Display(Name = "K1033", Description = "Material Number")]
		public int MaterialNumber { get; set; }

		[Display(Name = "K1040", Description = "Drawing Catalogue")]
		public int DrawingCatalogue { get; set; }

		[Display(Name = "K1041", Description = "Drawing Number Text")]
		public string DrawingNumberText { get; set; }

		[Display(Name = "K1042", Description = "Drawing Amendment")]
		public string DrawingAmendment { get; set; }

		[Display(Name = "K1043", Description = "Drawing Index")]
		public string DrawingIndex { get; set; }

		[Display(Name = "K1044", Description = "Drawing Number")]
		public int DrawingNumber { get; set; }

		[Display(Name = "K1045", Description = "Drawing Validity Date")]
		public DateTime DrawingValidityDate { get; set; }

		[Display(Name = "K1046", Description = "Drawing Description")]
		public string DrawingDescription { get; set; }

		[Display(Name = "K1047", Description = "Basic Drawing Number")]
		public string BasicDrawingNumber { get; set; }

		[Display(Name = "K1048", Description = "CAD Drawing File Name")]
		public string CadDrawingFileName { get; set; }

		[Display(Name = "K1050", Description = "Contractor Catalogue")]
		public int ContractorCatalogue { get; set; }

		[Display(Name = "K1051", Description = "Contractor Number Text")]
		public string ContractorNumberText { get; set; }

		[Display(Name = "K1052", Description = "Contractor Description")]
		public string ContractorDescription { get; set; }

		[Display(Name = "K1053", Description = "Contract")]
		public string Contract { get; set; }

		[Display(Name = "K1054", Description = "Contractor Number")]
		public int ContractorNumber { get; set; }

		[Display(Name = "K1060", Description = "Customer Catalogue")]
		public int CustomerCatalogue { get; set; }

		[Display(Name = "K1061", Description = "Customer Number Text")]
		public string CustomerNumberText { get; set; }

		[Display(Name = "K1062", Description = "Customer Description")]
		public string CustomerDescription { get; set; }

		[Display(Name = "K1063", Description = "Customer Number")]
		public int CustomerNumber { get; set; }

		[Display(Name = "K1070", Description = "Supplier Catalogue")]
		public int SupplierCatalogue { get; set; }

		[Display(Name = "K1071", Description = "Supplier Number Text")]
		public string SupplierNumberText { get; set; }

		[Display(Name = "K1072", Description = "Supplier Description")]
		public string SupplierDescription { get; set; }

		[Display(Name = "K1073", Description = "Supplier Number")]
		public int SupplierNumber { get; set; }

		[Display(Name = "K1080", Description = "Machine Catalogue")]
		public int MachineCatalogue { get; set; }

		[Display(Name = "K1081", Description = "Machine Number Text")]
		public string MachineNumberText { get; set; }

		[Display(Name = "K1082", Description = "Machine Description")]
		public string MachineDescription { get; set; }

		[Display(Name = "K1083", Description = "Machine Number")]
		public int MachineNumber { get; set; }

		[Display(Name = "K1085", Description = "Machine Location")]
		public string MachineLocation { get; set; }

		[Display(Name = "K1086", Description = "Work Cycle / Operation")]
		public string WorkCycleOperation { get; set; }

		[Display(Name = "K1087", Description = "Work Cycle Description")]
		public string WorkCycleDescription { get; set; }

		[Display(Name = "K1091", Description = "Line Number")]
		public string LineNumber { get; set; }

		[Display(Name = "K1092", Description = "Line Description")]
		public string LineDescription { get; set; }

		[Display(Name = "K1100", Description = "Area / Plant sector")]
		public string AreaPlantSector { get; set; }

		[Display(Name = "K1101", Description = "Department")]
		public string Department { get; set; }

		[Display(Name = "K1102", Description = "Workshop")]
		public string Workshop { get; set; }

		[Display(Name = "K1103", Description = "Cost Centre")]
		public string CostCentre { get; set; }

		[Display(Name = "K1104", Description = "Shift")]
		public string Shift { get; set; }

		[Display(Name = "K1105", Description = "Division Number")]
		public string DivisionNumber { get; set; }

		[Display(Name = "K1106", Description = "Department Number")]
		public string DepartmentNumber { get; set; }

		[Display(Name = "K1107", Description = "Workshop Number")]
		public string WorkshopNumber { get; set; }

		[Display(Name = "K1108", Description = "Cost Centre Number")]
		public string CostCentreNumber { get; set; }

		[Display(Name = "K1110", Description = "Order Number")]
		public string OrderNumber { get; set; }

		[Display(Name = "K1111", Description = "Goods Received Number")]
		public string GoodsReceivedNumber { get; set; }

		[Display(Name = "K1112", Description = "Cube")]
		public string Cube { get; set; }

		[Display(Name = "K1113", Description = "Location")]
		public string Location { get; set; }

		[Display(Name = "K1114", Description = "Device")]
		public string Device { get; set; }

		///QDAS doc says string but it should be date
		[Display(Name = "K1115", Description = "Production Date")]
		public string ProductionDate { get; set; }

		[Display(Name = "K1201", Description = "Test Facility Number Text")]
		public string TestFacilityNumberText { get; set; }

		[Display(Name = "K1202", Description = "Test Facility Description")]
		public string TestFacilityDescription { get; set; }

		[Display(Name = "K1203", Description = "Reason For Test")]
		public string ReasonForTest { get; set; }

		[Display(Name = "K1204", Description = "Test Begin")]
		public DateTime TestBegin { get; set; }

		[Display(Name = "K1205", Description = "Test End")]
		public DateTime TestEnd { get; set; }

		[Display(Name = "K1206", Description = "Test Location")]
		public string TestLocation { get; set; }

		[Display(Name = "K1207", Description = "Test Plan Developer")]
		public string TestPlanDeveloper { get; set; }

		[Display(Name = "K1208", Description = "Test Facility Number")]
		public int TestFacilityNumber { get; set; }

		[Display(Name = "K1209", Description = "Inspection type (inspection identifier)")]
		public string InspectionType { get; set; }

		[Display(Name = "K1210", Description = "Measurement Type")]
		public int MeasurementType { get; set; }

		[Display(Name = "K1211", Description = "Standard Master Number (Text)")]
		public string StandardMasterNumberText { get; set; }

		[Display(Name = "K1212", Description = "Standard Master Description")]
		public string StandardMasterDescription { get; set; }

		[Display(Name = "K1215", Description = "Standard Master Number")]
		public int StandardMasterNumber { get; set; }

		[Display(Name = "K1221", Description = "Inspector Number (Text)")]
		public string InspectorNumberText { get; set; }

		[Display(Name = "K1222", Description = "Inspector Name")]
		public string InspectorName { get; set; }

		[Display(Name = "K1223", Description = "Inspector Number")]
		public int InspectorNumber { get; set; }

		[Display(Name = "K1230", Description = "Gage room")]
		public string GageRoom { get; set; }

		[Display(Name = "K1231", Description = "Measurement Program Number")]
		public string MeasurementProgramNumber { get; set; }

		[Display(Name = "K1232", Description = "Measurement Program Version")]
		public string MeasurementProgramVersion { get; set; }

		[Display(Name = "K1301", Description = "Client")]
		public int Client { get; set; }

		[Display(Name = "K1302", Description = "Test Batch")]
		public string TestBatch { get; set; }

		[Display(Name = "K1303", Description = "Plant")]
		public string Plant { get; set; }

		[Display(Name = "K1304", Description = "Plant Number")]
		public string PlantNumber { get; set; }

		[Display(Name = "K1311", Description = "Production order")]
		public string ProductionOrder { get; set; }

		[Display(Name = "K1341", Description = "Test Plan Number Text")]
		public string TestPlanNumberText { get; set; }

		[Display(Name = "K1342", Description = "Test Plan Name")]
		public string TestPlanName { get; set; }

		//should be datetime type
		[Display(Name = "K1343", Description = "Test Plan Creation Date")]
		public string TestPlanCreationDate { get; set; }

		[Display(Name = "K1344", Description = "Test Plan Creator")]
		public string TestPlanCreator { get; set; }

		[Display(Name = "K1350", Description = "Output Report File")]
		public string OutputReportFile { get; set; }



		[Display(Name = "K8500", Description = "Subgroup size")]
		public double SubgroupSize { get; set; }

		[Display(Name = "K8501", Description = "Subgroup type")]
		public double SubgroupType { get; set; }

		
	}
}
