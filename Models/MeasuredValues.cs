using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class MeasurementKeys
	{
		public const string Value = "K0001";
		public const string Attribute = "K0002";
		public const string DateTime = "K0004";
		public const string Events = "K0005";
		public const string BatchNumber = "K0006";
		public const string SpindleNumber = "K0007";
		public const string OperatorNumber = "K0008";
		public const string Text = "K0009";
		public const string MachineNumber = "K0010";
		public const string ProcessParameter = "K0011";
		public const string GageNumber = "K0012";
	}

	public class MeasuredValues
	{
		/// <summary>
		/// K0001 - Value
		/// </summary>
		[Display(Name = MeasurementKeys.Value, Description = "Value")]
		public float? Value { get; set; }

		/// <summary>
		/// K0002 - Attribute
		/// </summary>
		[Display(Name = MeasurementKeys.Attribute, Description = "Attribute")]
		public int Attribute { get; set; }

		/// <summary>
		/// "K0004 - Date Time
		/// </summary>
		[Display(Name = MeasurementKeys.DateTime, Description = "Date Time")]
		public DateTime DateTime { get; set; }

		/// <summary>
		/// K0005 - Events
		/// </summary>
		[Display(Name = MeasurementKeys.Events, Description = "Events")]
		public string Events { get; set; }

		/// <summary>
		/// K0006 - Batch Number
		/// </summary>
		[Display(Name = MeasurementKeys.BatchNumber, Description = "Batch Number")]
		public string BatchNumber { get; set; }

		/// <summary>
		/// K0007 - Cavity Number / Spindle Number
		/// </summary>
		[Display(Name = MeasurementKeys.SpindleNumber, Description = "Cavity Number / Spindle Number")]
		public int SpindleNumber { get; set; }

		/// <summary>
		/// K0008 - Operator Number
		/// </summary>
		[Display(Name = MeasurementKeys.OperatorNumber, Description = "Operator Number")]
		public int OperatorNumber { get; set; }

		/// <summary>
		/// K0009 - Text
		/// </summary>
		[Display(Name = MeasurementKeys.Text, Description = "Text")]
		public string Text { get; set; }

		/// <summary>
		/// K0010 - Machine Number
		/// </summary>
		[Display(Name = MeasurementKeys.MachineNumber, Description = "Machine Number")]
		public int MachineNumber { get; set; }

		/// <summary>
		/// K0011 - Process Parameter
		/// </summary>
		[Display(Name = MeasurementKeys.ProcessParameter, Description = "Process Parameter")]
		public string ProcessParameter { get; set; }

		/// <summary>
		/// K0012 - Gage Number
		/// </summary>
		[Display(Name = MeasurementKeys.GageNumber, Description = "Gage Number")]
		public int GageNumber { get; set; }

		[Display(Name = "K0014", Description = "Part Ident")]
		public string PartIdent { get; set; }

		[Display(Name = "K0015", Description = "Reason For Test")]
		public int ReasonForTest { get; set; }

		[Display(Name = "K0016", Description = "Production Number")]
		public string ProductionNumber { get; set; }

		[Display(Name = "K0017", Description = "Work Piece Fixture Number")]
		public string WorkPieceFixtureNumber { get; set; }

		[Display(Name = "K0020", Description = "Subgroup Size")]
		public int SubgroupSize { get; set; }

		[Display(Name = "K0021", Description = "Number Of Errors")]
		public int NumberOfErrors { get; set; }

		/// <summary>
		/// K0053 - Order Number
		/// </summary>
		[Display(Name = "K0053", Description = "Order Number")]
		public string OrderNumber { get; set; }

		[Display(Name = "K0097", Description = "Values Guid")]
		public Guid ValuesGuid { get; set; }
	}
}
