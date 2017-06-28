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


		public double Nominal { get; set; }
		public double LowerSpecificationLimit { get; set; }
		public double UpperSpecificationLimit { get; set; }


		[Display(Name = "K2402", Description = "Characteristic description")]
		public string GageDescription { get; set; }
	}
}
