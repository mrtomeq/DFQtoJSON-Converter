using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class MeasuredValues
	{
		[Display(Name = "K0001", Description = "Value")]
		public float Value { get; set; }

		[Display(Name = "K0002", Description = "Attribute")]
		public int Attribute { get; set; }

		[Display(Name = "K0004", Description = "Date Time")]
		public DateTime DateTime { get; set; }

		[Display(Name = "K0005", Description = "Events")]
		public string Events { get; set; }

		[Display(Name = "K0006", Description = "Batch Number")]
		public string BatchNumber { get; set; }

		[Display(Name = "K0007", Description = "Cavity Number / Spindle Number")]
		public int SpindleNumber { get; set; }

		[Display(Name = "K0008", Description = "Operator Number")]
		public int OperatorNumber { get; set; }

		[Display(Name = "K0009", Description = "Text")]
		public string Text { get; set; }

		[Display(Name = "K0010", Description = "Machine Number")]
		public int MachineNumber { get; set; }

		[Display(Name = "K0011", Description = "Process Parameter")]
		public string ProcessParameter { get; set; }

		[Display(Name = "K0012", Description = "Gage Number")]
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

		[Display(Name = "K0053", Description = "Order Number")]
		public string OrderNumber { get; set; }

		[Display(Name = "K0097", Description = "Values Guid")]
		public Guid ValuesGuid { get; set; }
	}
}
