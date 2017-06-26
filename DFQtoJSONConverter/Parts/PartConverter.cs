using System.Collections.Generic;
using Models;

namespace DFQtoJSONConverter.Parts
{
	public static class PartConverter
	{
		public static Part Convert(IEnumerable<string> block)
		{
			var part = new Part();

			foreach (var line in block)
			{
				var values = line.Split(' ');

				KeySettter.SetProperty(values[0], values[1], part);
			}

			return part;
		}
	}
}
