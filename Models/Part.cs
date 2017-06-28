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

		[Display(Name = "K1022", Description = "Manufacturer description")]
		public string ManufacturerDescription { get; set; }

		[Display(Name = "K1023", Description = "Manufacturer number")]
		public string ManufacturerNumber { get; set; }

		[Display(Name = "K1044", Description = "Drawing number")]
		public string DrawingNumber { get; set; }

		[Display(Name = "K1311", Description = "Production order")]
		public string ProductionOrder { get; set; }

		[Display(Name = "K1062", Description = "Customer description")]
		public string CustomerDescription { get; set; }

		[Display(Name = "K1063", Description = "Customer number")]
		public string CustomerNumber { get; set; }

		[Display(Name = "K8500", Description = "Subgroup size")]
		public double SubgroupSize { get; set; }

		[Display(Name = "K8501", Description = "Subgroup type")]
		public double SubgroupType { get; set; }
	}
}
