using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Characteristic
	{
		public string PartNumber { get; set; }
		public IList<MeasuredValues> Measurements { get; set; } = new List<MeasuredValues>();

		[Display(Name = "K2001", Description = "Characteristic number")]
		public string Number { get; set; }

		[Display(Name = "K2002", Description = "Characteristic description")]
		public string Description { get; set; }

		[Display(Name = "K2003", Description = "Characteristic Abbreviation")]
		public string Abbreviation { get; set; }

		[Display(Name = "K2004", Description = "Characteristic Type")]
		public int Type { get; set; }

		[Display(Name = "K2005", Description = "Characteristic Class")]
		public int Class { get; set; }

		[Display(Name = "K2006", Description = "Control Item")]
		public int ControlItem { get; set; }

		[Display(Name = "K2007", Description = "Control Type")]
		public int ControlType { get; set; }

		[Display(Name = "K2008", Description = "Group Type")]
		public int GroupType { get; set; }

		[Display(Name = "K2009", Description = "Measured Quantity")]
		public int MeasuredQuantity { get; set; }

		[Display(Name = "K2011", Description = "Saved Distribution")]
		public int SavedDistribution { get; set; }

		[Display(Name = "K2013", Description = "Natural Class Width")]
		public float NaturalClassWidth { get; set; }

		[Display(Name = "K2015", Description = "Tool Wear Type (Trend)")]
		public int ToolWearType { get; set; }

		[Display(Name = "K2016", Description = "100 % Measurement")]
		public int CompleteMeasurement { get; set; }

		[Display(Name = "K2017", Description = "Alarm Detection Type")]
		public int AlarmDetectionType { get; set; }

		[Display(Name = "K2018", Description = "Acceptance Limit Extended")]
		public int AcceptanceLimitExtended { get; set; }

		[Display(Name = "K2019", Description = "Ordinal Classes Catalogue")]
		public int OrdinalClassesCatalogue { get; set; }

		[Display(Name = "K2021", Description = "Logical Operation Formula")]
		public string LogicalOperationFormula { get; set; }

		[Display(Name = "K2022", Description = "Decimal Places")]
		public int DecimalPlaces { get; set; }

		[Display(Name = "K2023", Description = "Transformation Type")]
		public int TransformationType { get; set; }

		[Display(Name = "K2024", Description = "Transformation Parameter A")]
		public float TransformationParameterA { get; set; }

		[Display(Name = "K2025", Description = "Transformation Parameter B")]
		public float TransformationParameterB { get; set; }

		[Display(Name = "K2026", Description = "Transformation Parameter C")]
		public float TransformationParameterC { get; set; }

		[Display(Name = "K2027", Description = "Transformation Parameter D")]
		public float TransformationParameterD { get; set; }

		[Display(Name = "K2028", Description = "Natural Distribution")]
		public int NaturalDistribution { get; set; }

		[Display(Name = "K2030", Description = "Group Number / ELS-Number")]
		public int GroupNumber { get; set; }

		[Display(Name = "K2031", Description = "Group Element Number / ELS Number for error type of a ELS")]
		public int GroupElementNumber { get; set; }

		[Display(Name = "K2035", Description = "Calibration Date")]
		public DateTime CalibrationDate { get; set; }

		[Display(Name = "K2041", Description = "Recording Type")]
		public int RecordingType { get; set; }

		[Display(Name = "K2042", Description = "Recording Device Number")]
		public int RecordingDeviceNumber { get; set; }

		[Display(Name = "K2043", Description = "Recording Device Name")]
		public string RecordingDeviceName { get; set; }

		[Display(Name = "K2044", Description = "Recording Device Index")]
		public int RecordingDeviceIndex { get; set; }

		[Display(Name = "K2045", Description = "Recording Channel")]
		public int RecordingChannel { get; set; }

		[Display(Name = "K2046", Description = "Recording Sub-channel")]
		public int RecordingSubchannel { get; set; }

		[Display(Name = "K2047", Description = "Software Requirement Index")]
		public int SoftwareRequirementIndex { get; set; }

		[Display(Name = "K2048", Description = "Takeover Channel")]
		public int TakeoverChannel { get; set; }

		[Display(Name = "K2049", Description = "Channel Initialization-Index")]
		public int ChannelInitializationIndex { get; set; }

		[Display(Name = "K2051", Description = "Interface")]
		public int Interface { get; set; }

		[Display(Name = "K2052", Description = "Baud Rate")]
		public int BaudRate { get; set; }

		[Display(Name = "K2053", Description = "IRQ Number")]
		public int IrqNumber { get; set; }

		[Display(Name = "K2054", Description = "Parity")]
		public int Parity { get; set; }

		[Display(Name = "K2055", Description = "Data Bits")]
		public int DataBits { get; set; }

		[Display(Name = "K2056", Description = "Stop Bits")]
		public int StopBits { get; set; }

		[Display(Name = "K2060", Description = "Events Catalogue(action code)")]
		public int EventsCatalogue { get; set; }

		[Display(Name = "K2061", Description = "Process Parameter Catalogue")]
		public int ProcessParameterCatalogue { get; set; }

		[Display(Name = "K2062", Description = "Cavity Catalogue")]
		public int CavityCatalogue { get; set; }

		[Display(Name = "K2063", Description = "Machine catalogue")]
		public int MachineCatalogue { get; set; }

		[Display(Name = "K2064", Description = "Gage Catalogue")]
		public int GageCatalogue { get; set; }

		[Display(Name = "K2065", Description = "Operator Catalogue")]
		public int OperatorCatalogue { get; set; }

		[Display(Name = "K2066", Description = "Sub-catalogue K0061")]
		public int SubcatalogueK0061 { get; set; }

		[Display(Name = "K2067", Description = "Sub-catalogue K0062")]
		public int SubcatalogueK0062 { get; set; }

		[Display(Name = "K2068", Description = "Sub-catalogue K0063")]
		public int SubcatalogueK0063 { get; set; }

		[Display(Name = "K2071", Description = "Accumulating Constant")]
		public float AccumulatingConstant { get; set; }

		[Display(Name = "K2072", Description = "Multiplication Factor")]
		public float MultiplicationFactor { get; set; }

		[Display(Name = "K2073", Description = "Dimension Of The Calibration Master")]
		public float DimensionOfTheCalibrationMaster { get; set; }

		[Display(Name = "K2074", Description = "Actual Offset For Calibration Measurements")]
		public float ActualOffsetForCalibrationMeasurements { get; set; }

		[Display(Name = "K2075", Description = "Amplification Factor For Calibration Measurements")]
		public float AmplificationFactorForCalibrationMeasurements { get; set; }

		//This is dup in specification
		[Display(Name = "K2076", Description = "Calibration Date")]
		public DateTime CalibrationDate1 { get; set; }

		[Display(Name = "K2080", Description = "Characteristic Satus(activated, deactivated)")]
		public int CharacteristicSatus { get; set; }

		[Display(Name = "K2091", Description = "Characteristic Index")]
		public string CharacteristicIndex { get; set; }

		[Display(Name = "K2092", Description = "Characteristic Text")]
		public string CharacteristicText { get; set; }

		[Display(Name = "K2093", Description = "Processing Status")]
		public string ProcessingStatus { get; set; }

		[Display(Name = "K2095", Description = "Element Code")]
		public string ElementCode { get; set; }

		[Display(Name = "K2096", Description = "Element Index")]
		public string ElementIndex { get; set; }

		[Display(Name = "K2097", Description = "Element Text")]
		public string ElementText { get; set; }

		[Display(Name = "K2098", Description = "Element Address")]
		public string ElementAddress { get; set; }

		[Display(Name = "K2100", Description = "Target Value")]
		public float TargetValue { get; set; }

		[Display(Name = "K2101", Description = "Nominal Value")]
		public float NominalValue { get; set; }

		[Display(Name = "K2102", Description = "Pmax")]
		public float Pmax { get; set; }

		[Display(Name = "K2103", Description = "Tolerance Class")]
		public string ToleranceClass { get; set; }

		[Display(Name = "K2104", Description = "Tolerance Value")]
		public int ToleranceValue { get; set; }

		[Display(Name = "K2105", Description = "Parts OK At Censoring")]
		public int PartsOkAtCensoring { get; set; }

		[Display(Name = "K2110", Description = "Lower Specification Limit")]
		public float LowerSpecificationLimit { get; set; }

		[Display(Name = "K2111", Description = "Upper Specification Limit")]
		public float UpperSpecificationLimit { get; set; }

		[Display(Name = "K2112", Description = "Lower Allowance")]
		public float LowerAllowance { get; set; }

		[Display(Name = "K2113", Description = "Upper Allowance")]
		public float UpperAllowance { get; set; }

		[Display(Name = "K2114", Description = "Lower Scrap Limit")]
		public float LowerScrapLimit { get; set; }

		[Display(Name = "K2115", Description = "Upper Scrap Limit")]
		public float UpperScrapLimit { get; set; }

		[Display(Name = "K2116", Description = "Lower Acceptance Limit")]
		public float TargetVLowerAcceptanceLimitalue { get; set; }

		[Display(Name = "K2117", Description = "Upper Acceptance Limit")]
		public float UpperAcceptanceLimit { get; set; }

		[Display(Name = "K2120", Description = "Lower Limit Type")]
		public int LowerLimitType { get; set; }

		[Display(Name = "K2121", Description = "Upper Limit Type")]
		public int UpperLimitType { get; set; }

		[Display(Name = "K2130", Description = "Lower Plausibility Limit")]
		public float LowerPlausibilityLimit { get; set; }

		[Display(Name = "K2131", Description = "Upper Plausibility Limit")]
		public float UpperPlausibilityLimit { get; set; }

		[Display(Name = "K2135", Description = "Lower Class Limit")]
		public float LowerClassLimit { get; set; }

		[Display(Name = "K2136", Description = "Upper Class Limit")]
		public float UpperClassLimit { get; set; }

		[Display(Name = "K2137", Description = "Number Of Classes")]
		public int NumberOfClasses { get; set; }






		[Display(Name = "K2402", Description = "Characteristic description")]
		public string GageDescription { get; set; }
	}
}
