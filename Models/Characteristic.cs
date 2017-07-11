using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Characteristic
	{
		public string PartNumber { get; set; }
		public IList<MeasuredValues> Measurements { get; set; } = new List<MeasuredValues>();

		/// <summary>
		/// K2001
		/// </summary>
		[Display(Name = "K2001", Description = "Characteristic number")]
		public string Number { get; set; }

		/// <summary>
		/// K2002
		/// </summary>
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

		/// <summary>
		/// K2101 - Nominal Value
		/// </summary>
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

		/// <summary>
		/// K2110 - Upper Specification Limit
		/// </summary>
		[Display(Name = "K2110", Description = "Lower Specification Limit")]
		public float LowerSpecificationLimit { get; set; }

		/// <summary>
		/// K2111 - Upper Specification Limit
		/// </summary>
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

		[Display(Name = "K2138", Description = "Classification Source")]
		public int ClassificationSource { get; set; }

		[Display(Name = "K2139", Description = "Classification Model Source")]
		public int ClassificationModelSource { get; set; }

		[Display(Name = "K2141", Description = "Unit")]
		public int Unit { get; set; }

		/// <summary>
		/// K2142 - Unit Description
		/// </summary>
		[Display(Name = "K2142", Description = "Unit Description")]
		public string UnitDescription { get; set; }

		[Display(Name = "K2143", Description = "Unit Relative Axis")]
		public string UnitRelativeAxis { get; set; }

		/// <summary>
		/// K2144 - Addition Constant Relative Axis
		/// </summary>
		[Display(Name = "K2144", Description = "Addition Constant Relative Axis")]
		public float AdditionConstantRelativeAxis { get; set; }

		/// <summary>
		/// K2145 - Multiplication Factor Relative Axis
		/// </summary>
		[Display(Name = "K2145", Description = "Multiplication Factor Relative Axis")]
		public float MultiplicationFactorRelativeAxis { get; set; }

		/// <summary>
		/// K2146 - Decimal Places Relative Axis
		/// </summary>
		[Display(Name = "K2146", Description = "Decimal Places Relative Axis")]
		public int DecimalPlacesRelativeAxis { get; set; }

		/// <summary>
		/// K2151 -Tolerance(as Text)
		/// </summary>
		[Display(Name = "K2151", Description = "Tolerance(as Text)")]
		public string ToleranceText { get; set; }

		/// <summary>
		/// K2152 - Calculated Tolerance
		/// </summary>
		[Display(Name = "K2152", Description = "Calculated Tolerance")]
		public float CalculatedTolerance { get; set; }

		/// <summary>
		/// K2160 - Batch Size
		/// </summary>
		[Display(Name = "K2160", Description = "Batch Size")]
		public int BatchSize { get; set; }

		/// <summary>
		/// K2161 - Re-work Cost
		/// </summary>
		[Display(Name = "K2161", Description = "Re-work Cost")]
		public float ReworkCost { get; set; }

		/// <summary>
		/// K2162 - Rejects Cost
		/// </summary>
		[Display(Name = "K2162", Description = "Rejects Cost")]
		public float RejectsCost { get; set; }

		/// <summary>
		/// K2163 -Error Cost
		/// </summary>
		[Display(Name = "K2163", Description = "Error Cost")]
		public float ErrorCost { get; set; }

		/// <summary>
		/// K2170 - Censoring Point In Time
		/// </summary>
		[Display(Name = "K2170", Description = "Censoring Point In Time")]
		public float CensoringPointInTime { get; set; }

		/// <summary>
		/// K2171 - Extrapolation
		/// </summary>
		[Display(Name = "K2171", Description = "Extrapolation")]
		public float Extrapolation { get; set; }

		/// <summary>
		/// K2172 - Permitted Failure Rate
		/// </summary>
		[Display(Name = "K2172", Description = "Permitted Failure Rate")]
		public float PermittedFailureRate { get; set; }

		/// <summary>
		/// K2173 - Failure Free Time
		/// </summary>
		[Display(Name = "K2173", Description = "Failure Free Time")]
		public float FailureFreeTime { get; set; }

		/// <summary>
		/// K2174 - Parts In The Field
		/// </summary>
		[Display(Name = "K2174", Description = "Parts In The Field")]
		public int PartsInTheField { get; set; }

		/// <summary>
		/// K2175 - Conditions For Frequency Sums
		/// </summary>
		[Display(Name = "K2175", Description = "Conditions For Frequency Sums")]
		public int ConditionsForFrequencySums { get; set; }

		/// <summary>
		/// K2176 - Life Distance After Eckel
		/// </summary>
		[Display(Name = "K2176", Description = "Life Distance After Eckel")]
		public int LifeDistanceAfterEckel { get; set; }

		/// <summary>
		/// K2177 - Life Time X2
		/// </summary>
		[Display(Name = "K2177", Description = "Life time X2")]
		public float LifeTimeX1 { get; set; }

		/// <summary>
		/// K2178 - Life Time X2
		/// </summary>
		[Display(Name = "K2178", Description = "Life Time X2")]
		public float LifeTimeX2 { get; set; }

		/// <summary>
		/// K2180 - Weibull Parameter B
		/// </summary>
		[Display(Name = "K2180", Description = "Weibull Parameter B")]
		public float WeibullParameterB { get; set; }

		/// <summary>
		/// K2181 - Weibull Parameter T
		/// </summary>
		[Display(Name = "K2181", Description = "Weibull Parameter T")]
		public float WeibullParameterT { get; set; }

		/// <summary>
		/// K2182 - Sum probability(B(x1))
		/// </summary>
		[Display(Name = "K2182", Description = "Sum Probability(B(x1))")]
		public float SumProbability1 { get; set; }

		/// <summary>
		/// K2183 - Sum Probability(B(x2))
		/// </summary>
		[Display(Name = "K2183", Description = "Sum Probability(B(x2))")]
		public float SumProbability2 { get; set; }

		/// <summary>
		/// K2185 - Number Of Parts In The Field(For Eckel Method)
		/// </summary>
		[Display(Name = "K2185", Description = "Number Of Parts In The Field(For Eckel Method)")]
		public int PartsInTheFieldEckel { get; set; }

		/// <summary>
		/// K2186 - Usage Time For Parts In The Field(For Eckel Method)
		/// </summary>
		[Display(Name = "K2186", Description = "Usage Time For Parts In The Field(For Eckel Method)")]
		public float UsageTimeEckel { get; set; }

		/// <summary>
		/// K2201 - Process Variation
		/// </summary>
		[Display(Name = "K2201", Description = "Process Variation")]
		public float ProcessVariation { get; set; }

		/// <summary>
		/// K2202 - Evaluation Type
		/// </summary>
		[Display(Name = "K2202", Description = "Evaluation Type")]
		public int EvaluationType { get; set; }

		/// <summary>
		/// K2205 - Number Of Parts
		/// </summary>
		[Display(Name = "K2205", Description = "Number of Parts")]
		public int NumberOfParts { get; set; }

		/// <summary>
		/// K2206 - Number Of Devices
		/// </summary>
		[Display(Name = "K2206", Description = "Number of Devices")]
		public int NumberOfDevices { get; set; }

		/// <summary>
		/// K2207 - Number Of Test Intervals
		/// </summary>
		[Display(Name = "K2207", Description = "Number Of Test Intervals")]
		public int NumberOfTestIntervals { get; set; }

		/// <summary>
		/// K2210 - Master Catalogue
		/// </summary>
		[Display(Name = "K2210", Description = "Master Catalogue")]
		public int MasterCatalogue { get; set; }

		/// <summary>
		/// K2211 - Master Number Text
		/// </summary>
		[Display(Name = "K2211", Description = "Master Number Text")]
		public string MasterNumbertext { get; set; }

		/// <summary>
		/// K2212 - Master Description
		/// </summary>
		[Display(Name = "K2212", Description = "Master Description")]
		public string MasterDescription { get; set; }

		/// <summary>
		/// K2213 - Master Actual Value
		/// </summary>
		[Display(Name = "K2213", Description = "Master Actual Value")]
		public float MasterActualValue { get; set; }

		/// <summary>
		/// K2214 - Master Temperature
		/// </summary>
		[Display(Name = "K2214", Description = "Master Temperature")]
		public float MasterTemperature { get; set; }

		/// <summary>
		/// K2215 - Master Number
		/// </summary>
		[Display(Name = "K2215", Description = "Master Number")]
		public int MasterNumber { get; set; }

		/// <summary>
		/// K2216 - Master Serial number
		/// </summary>
		[Display(Name = "K2216", Description = "Master –Serial number")]
		public string MasterSerialnumber { get; set; }

		/// <summary>
		/// K2217 - Master Manufacturer
		/// </summary>
		[Display(Name = "K2217", Description = "Master Manufacturer")]
		public string MasterManufacturer { get; set; }

		/// <summary>
		/// K2220 - Number Of Operators
		/// </summary>
		[Display(Name = "K2220", Description = "Number Of Operators")]
		public int NumberOfOperators { get; set; }

		/// <summary>
		/// K2221 - Number Of Trials
		/// </summary>
		[Display(Name = "K2221", Description = "Number Of Trials")]
		public int NumberOfTrials { get; set; }

		/// <summary>
		/// K2222 - No. Of Reference Measurements
		/// </summary>
		[Display(Name = "K2222", Description = "No. Of Reference Measurements")]
		public int NoOfReferenceMeasurements { get; set; }

		/// <summary>
		/// K2225 - Determined Cg Value
		/// </summary>
		[Display(Name = "K2225", Description = "Determined Cg Value")]
		public float DeterminedCgValue { get; set; }

		/// <summary>
		/// K2226 - Determined Cgk Value
		/// </summary>
		[Display(Name = "K2226", Description = "Determined Cgk Value")]
		public float DeterminedCgkValue { get; set; }

		/// <summary>
		/// K2226 - Deviation GC Type 3 – GC Type 1
		/// </summary>
		[Display(Name = "K2227", Description = "Deviation GC Type 3 – GC Type 1")]
		public float DeviationGcType3GcType1 { get; set; }

		/// <summary>
		/// K2228 - Sg Type 1 - Stability
		/// </summary>
		[Display(Name = "K2228", Description = "Sg Type 1 - Stability")]
		public float SgType1Stability { get; set; }

		/// <summary>
		/// K2243 - Drawing File Name
		/// </summary>
		[Display(Name = "K2243", Description = "Drawing File Name")]
		public string DrawingFileName { get; set; }

		/// <summary>
		/// K2244 - Drawing Reference Point X
		/// </summary>
		[Display(Name = "K2244", Description = "Drawing Reference Point X")]
		public int DrawingReferencePointX { get; set; }

		/// <summary>
		/// K2245 - Drawing Reference Point Y
		/// </summary>
		[Display(Name = "K2245", Description = "Drawing Reference Point Y")]
		public int DrawingReferencePointY { get; set; }

		/// <summary>
		/// K2246 - Drawing Reference Point Z
		/// </summary>
		[Display(Name = "K2246", Description = "Drawing Reference Point Z")]
		public int DrawingReferencePointZ { get; set; }

		/// <summary>
		/// K2261 - Reference Part number
		/// </summary>
		[Display(Name = "K2261", Description = "Reference Part Number")]
		public string ReferencePartNumberString { get; set; }

		/// <summary>
		/// K2262 - Reference Part Description
		/// </summary>
		[Display(Name = "K2262", Description = "Reference Part Description")]
		public string ReferencePartDescription { get; set; }

		/// <summary>
		/// K2263 - Reference Part Actual Value
		/// </summary>
		[Display(Name = "K2263", Description = "Reference Part Actual Value")]
		public float ReferencePartActualValue { get; set; }

		/// <summary>
		/// K2264 - Reference Part Temperature
		/// </summary>
		[Display(Name = "K2264", Description = "Reference Part Temperature")]
		public float ReferencePartTemperature { get; set; }

		/// <summary>
		/// K2265 - Reference Part Number (num)
		/// </summary>
		[Display(Name = "K2265", Description = "Reference Part Number (num)")]
		public int ReferencePartNumber { get; set; }

		/// <summary>
		/// K2266 - Reference Part Serial Number
		/// </summary>
		[Display(Name = "K2266", Description = "Reference Part Serial Number")]
		public string ReferencePartSerialNumber { get; set; }

		/// <summary>
		/// K2281 - Calibration Part Number Middle
		/// </summary>
		[Display(Name = "K2281", Description = "Calibration Part Number Middle")]
		public string CalibrationPartNumberMiddleString { get; set; }

		/// <summary>
		/// K2282 - Calibration Part Description Middle
		/// </summary>
		[Display(Name = "K2282", Description = "Calibration Part Description Middle")]
		public string CalibrationPartDescriptionMiddle { get; set; }

		/// <summary>
		/// K2283 - Calibration Part Actual Value Middle
		/// </summary>
		[Display(Name = "K2283", Description = "Calibration Part Actual Value Middle")]
		public float CalibrationPartActualValueMiddle { get; set; }

		/// <summary>
		/// K2284 - Calibration Part Temperature Middle
		/// </summary>
		[Display(Name = "K2284", Description = "Calibration Part Temperature Middle")]
		public float CalibrationPartTemperatureMiddle { get; set; }

		/// <summary>
		/// K2285 - Calibration Part Number (num) Middle
		/// </summary>
		[Display(Name = "K2285", Description = "Calibration Part Number (num) Middle")]
		public int CalibrationPartNumberMiddle { get; set; }

		/// <summary>
		/// K2286 - Calibration Part Serial Number Middle
		/// </summary>
		[Display(Name = "K2286", Description = "Calibration Part Serial Number Middle")]
		public string CalibrationPartSerialNumberMiddle { get; set; }

		/// <summary>
		/// K2301 - Machine Number Text
		/// </summary>
		[Display(Name = "K2301", Description = "Machine Number Text")]
		public string MachineNumberText { get; set; }

		/// <summary>
		/// K2302 - Machine Description
		/// </summary>
		[Display(Name = "K2302", Description = "Machine Description")]
		public string MachineDescription { get; set; }

		/// <summary>
		/// K2303 - Department / Cost Centre
		/// </summary>
		[Display(Name = "K2303", Description = "Department / Cost Centre")]
		public string DepartmentCostCentre { get; set; }

		/// <summary>
		/// K2304 - Machine Location
		/// </summary>
		[Display(Name = "K2304", Description = "Machine Location")]
		public string MachineLocation { get; set; }

		/// <summary>
		/// K2305 - Machine Number
		/// </summary>
		[Display(Name = "K2305", Description = "Machine Number")]
		public int MachineNumber { get; set; }

		/// <summary>
		/// K2306 - Area / Plant Sector
		/// </summary>
		[Display(Name = "K2306", Description = "Area / Plant Sector")]
		public string AreaPlantSector { get; set; }

		/// <summary>
		/// K2307 - PTM Number
		/// </summary>
		[Display(Name = "K2307", Description = "PTM Number")]
		public string PtmNumber { get; set; }

		/// <summary>
		/// K2311 - Production Type Text(Operation)
		/// </summary>
		[Display(Name = "K2311", Description = "Production Type Text(Operation)")]
		public string ProductionTypeTextOperation { get; set; }


		/// <summary>
		/// K2312 - Production Type Description
		/// </summary>
		[Display(Name = "K2312", Description = "Production Type Description")]
		public string ProductionTypeDescription { get; set; }

		/// <summary>
		/// K2313 - Production Type Number
		/// </summary>
		[Display(Name = "K2313", Description = "Production Type Number")]
		public int ProductionTypeNumber { get; set; }

		/// <summary>
		/// K2320 - Contract Number
		/// </summary>
		[Display(Name = "K2320", Description = "Contract Number")]
		public string ContractNumber { get; set; }

		/// <summary>
		/// K2321 - Contractor Number Text
		/// </summary>
		[Display(Name = "K2321", Description = "Contractor Number Text")]
		public string ContractorNumberText { get; set; }

		/// <summary>
		/// K2322 - Contractor Name
		/// </summary>
		[Display(Name = "K2322", Description = "Contractor Name")]
		public string ContractorName { get; set; }

		/// <summary>
		/// K2323 - Contractor Number
		/// </summary>
		[Display(Name = "K2323", Description = "Contractor Number")]
		public int ContractorNumber { get; set; }

		/// <summary>
		/// K2331 - Work Piece Number Text
		/// </summary>
		[Display(Name = "K2331", Description = "Work Piece Number Text")]
		public string WorkPieceNumberText { get; set; }

		/// <summary>
		/// K2332 - Work Piece Description
		/// </summary>
		[Display(Name = "K2332", Description = "Work Piece Description")]
		public string WorkPieceDescription { get; set; }

		/// <summary>
		/// K2333 - Work Piece Number
		/// </summary>
		[Display(Name = "K2333", Description = "Work Piece Number")]
		public int WorkPieceNumber { get; set; }

		/// <summary>
		/// K2341 - Test Plan Number Text
		/// </summary>
		[Display(Name = "K2341", Description = "Test Plan Number Text")]
		public string TestPlanNumberText { get; set; }

		/// <summary>
		/// K2342 - Test Plan Name
		/// </summary>
		[Display(Name = "K2342", Description = "Test Plan Name")]
		public string TestPlanName { get; set; }

		/// <summary>
		/// K2343 - Test Plan Creation Date
		/// </summary>
		[Display(Name = "K2343", Description = "Test Plan Creation Date")]
		public DateTime TestPlanCreationDate { get; set; }

		/// <summary>
		/// K2344 - Test Plan Creator
		/// </summary>
		[Display(Name = "K2344", Description = "Test Plan Creator")]
		public string TestPlanCreator { get; set; }

		/// <summary>
		/// K2401 - Gage Number Text
		/// </summary>
		[Display(Name = "K2401", Description = "Gage Number Text")]
		public string GageNumberText { get; set; }

		/// <summary>
		/// K2402 - Gage Description
		/// </summary>
		[Display(Name = "K2402", Description = "Gage Description")]
		public string GageDescription1 { get; set; }

		/// <summary>
		/// K2403 - Gage Group
		/// </summary>
		[Display(Name = "K2403", Description = "Gage Group")]
		public string GageGroup { get; set; }

		/// <summary>
		/// K2404 - Gage Resolution
		/// </summary>
		[Display(Name = "K2404", Description = "Gage Resolution")]
		public float GageResolution { get; set; }

		/// <summary>
		/// K2405 - Gage Number
		/// </summary>
		[Display(Name = "K2405", Description = "Gage Number")]
		public int GageNumber { get; set; }

		/// <summary>
		/// K2406 - Gage Manufacturer
		/// </summary>
		[Display(Name = "K2406", Description = "Gage Manufacturer")]
		public string GageManufacturer { get; set; }

		/// <summary>
		/// K2407 - SPC Device Number
		/// </summary>
		[Display(Name = "K2407", Description = "SPC Device Number")]
		public string SpcDeviceNumber { get; set; }

		/// <summary>
		/// K2408 - SPC Device Description
		/// </summary>
		[Display(Name = "K2408", Description = "SPC Device Description")]
		public string SpcDeviceDescription { get; set; }

		/// <summary>
		/// K2409 - SPC Device Type
		/// </summary>
		[Display(Name = "K2409", Description = "SPC Device Type")]
		public string SpcDeviceType { get; set; }

		/// <summary>
		/// K2410 - Test Location
		/// </summary>
		[Display(Name = "K2410", Description = "Test Location")]
		public string TestLocation { get; set; }

		/// <summary>
		/// K2411 - Test Begin
		/// </summary>
		[Display(Name = "K2411", Description = "Test Begin")]
		public DateTime TestBegin { get; set; }

		/// <summary>
		/// K2412 - Test End
		/// </summary>
		[Display(Name = "K2412", Description = "Test End")]
		public DateTime TestEnd { get; set; }

		/// <summary>
		/// K2413 - Gage Graphic
		/// </summary>
		[Display(Name = "K2413", Description = "Gage Graphic")]
		public string GageGraphic { get; set; }

		/// <summary>
		/// K2415 + Gage Serial Number
		/// </summary>
		[Display(Name = "K2415", Description = "Gage Serial Number")]
		public string GageSerialNumber { get; set; }

		/// <summary>
		/// K2416 - Display Device
		/// </summary>
		[Display(Name = "K2416", Description = "Display Device")]
		public string DisplayDevice { get; set; }

		/// <summary>
		/// K2421 - Operator Number Text
		/// </summary>
		[Display(Name = "K2421", Description = "Operator Number Text")]
		public string OperatorNumberText { get; set; }

		/// <summary>
		/// K2422 - Operator Name
		/// </summary>
		[Display(Name = "K2422", Description = "Operator Name")]
		public string OperatorName { get; set; }

		/// <summary>
		/// K2423 - Operator Number
		/// </summary>
		[Display(Name = "K2423", Description = "Operator Number")]
		public int OperatorNumber { get; set; }

		/// <summary>
		/// K2430 - Sampling Type
		/// </summary>
		[Display(Name = "K2430", Description = "Sampling Type")]
		public int SamplingType { get; set; }

		/// <summary>
		/// K2432 - Individual Value Output
		/// </summary>
		[Display(Name = "K2432", Description = "Individual Value Output")]
		public int IndividualValueOutput { get; set; }

		/// <summary>
		/// K2434 - Proof Of Process Capability
		/// </summary>
		[Display(Name = "K2434", Description = "Proof of Process Capability")]
		public int ProofOfProcessCapability { get; set; }

		/// <summary>
		/// K2436 - Test Frequency
		/// </summary>
		[Display(Name = "K2436", Description = "Test Frequency")]
		public string TestFrequency { get; set; }

		/// <summary>
		/// K2438 - Quantity Tested
		/// </summary>
		[Display(Name = "K2438", Description = "Quantity Tested")]
		public string QuantityTested { get; set; }

		/// <summary>
		/// K2440 - Assembly Component
		/// </summary>
		[Display(Name = "K2440", Description = "Assembly Component")]
		public string AssemblyComponent { get; set; }

		/// <summary>
		/// K2442 - Assembly Component Mass
		/// </summary>
		[Display(Name = "K2442", Description = "Assembly Component Mass")]
		public string AssemblyComponentMass { get; set; }

		/// <summary>
		/// K2444 - Assembly Component Material
		/// </summary>
		[Display(Name = "K2444", Description = "Assembly Component Material")]
		public string AssemblyComponentMaterial { get; set; }

		/// <summary>
		/// K2446 - Supplier’s Product Description
		/// </summary>
		[Display(Name = "K2446", Description = "Supplier’s Product Description")]
		public string SuppliersProductDescription { get; set; }

		/// <summary>
		/// K2448 - Assembly Component Manufacturer
		/// </summary>
		[Display(Name = "K2448", Description = "Assembly Component Manufacturer")]
		public string AssemblyComponentManufacturer { get; set; }

		/// <summary>
		/// K2501 - Dimension Attribute
		/// </summary>
		[Display(Name = "K2501", Description = "Dimension Attribute")]
		public int DimensionAttribute { get; set; }

		/// <summary>
		/// K2502 - Tolerance Display Format
		/// </summary>
		[Display(Name = "K2502", Description = "Tolerance Display Format")]
		public int ToleranceDisplayFormat { get; set; }

		/// <summary>
		/// K2503 - Dimension Type
		/// </summary>
		[Display(Name = "K2503", Description = "Dimension Type")]
		public int DimensionType { get; set; }

		/// <summary>
		/// K2504 - Drawing Change Status
		/// </summary>
		[Display(Name = "K2504", Description = "Drawing Change Status")]
		public int DrawingChangeStatus { get; set; }

		/// <summary>
		/// K2505 - View Description
		/// </summary>
		[Display(Name = "K2505", Description = "View Description")]
		public string ViewDescription { get; set; }

		/// <summary>
		/// K2506 - Sheet Number
		/// </summary>
		[Display(Name = "K2506", Description = "Sheet Number")]
		public int SheetNumber { get; set; }

		/// <summary>
		/// K2507 - Drawing Field Character
		/// </summary>
		[Display(Name = "K2507", Description = "Drawing Field Character")]
		public string DrawingFieldCharacter { get; set; }

		/// <summary>
		/// Drawing Field Number
		/// </summary>
		[Display(Name = "K2508", Description = "Drawing Field Number")]
		public int DrawingFieldNumber { get; set; }






		[Display(Name = "K2402", Description = "Gage Description")]
		public string GageDescription { get; set; }
	}
}
