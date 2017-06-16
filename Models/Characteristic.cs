namespace Models
{
	public class Characteristic
	{
		public string Number { get; set; }
		public string Description { get; set; }
		public double Nominal { get; set; }
		public double LowerSpecificationLimit { get; set; }
		public double UpperSpecificationLimit { get; set; }
	}
}
