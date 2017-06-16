using System.ComponentModel.DataAnnotations;

namespace Models
{
	public class Part
	{
		[Display(Name = "K1001", Description = "Part Number")]
		public string Number { get; set; }

		[Display(Name = "K1002", Description = "Part Description")]
		public string Description { get; set; }

		[Display(Name = "K1022", Description = "Manufacturer Description")]
		public string ManufacturerDescription { get; set; }

		[Display(Name = "K1023", Description = "Manufacturer Number")]
		public string ManufacturerNumber { get; set; }

		[Display(Name = "K1044", Description = "Drawing Number")]
		public string DrawingNumber { get; set; }

		[Display(Name = "K1311", Description = "Production order")]
		public string ProductionOrder { get; set; }

		[Display(Name = "K1062", Description = "Customer Description")]
		public string CustomerDescription { get; set; }

		[Display(Name = "K1063", Description = "Customer Number")]
		public string CustomerNumber { get; set; }

		
	}
}
