using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DFQtoJSONConverter.Characteristics;
using DFQtoJSONConverter.Measurements;
using DFQtoJSONConverter.Parts;
using Models;

namespace DFQtoJSONConverter
{
	public class DfqConverter
	{
		public IList<Part> Parts { get; set; }
		public IList<Characteristic> Characteristics { get; set; } = new List<Characteristic>();
		private bool _currentPartHasNoCharacteristics;

		public void Convert(string dfqFilePath)
		{
			if (string.IsNullOrEmpty(dfqFilePath))
				throw new ArgumentException("dfqFilePath");

			Parts = new List<Part>();
			var dfqFile = File.ReadAllLines(dfqFilePath);
			var lineBlock = new List<string>();

			foreach (var line in dfqFile)
			{
				//read entire block until new line 
				if (string.IsNullOrEmpty(line))
				{
					ProcessBlock(lineBlock);
					lineBlock.Clear();
				}
				else
				{
					lineBlock.Add(line);
				}
			}
		}

		public void ProcessBlock(List<string> block)
		{
			var firstLine = block.First();

			if (firstLine.StartsWith("K0100"))
			{
				var values = firstLine.Split(' ');
				int numberOfCharacteristics;

				if (!int.TryParse(values[1], out numberOfCharacteristics))
				{
					throw new Exception("Value of field K0100 is invalid.");
				}

				while (numberOfCharacteristics > Characteristics.Count)
				{
					Characteristics.Add(new Characteristic());
				}

				firstLine = block[1];
			}

			if (firstLine.StartsWith("K0999"))
			{
				//todo finish
			}

			if (firstLine.StartsWith("K1"))
			{
				//process part data
				var part = PartConverter.Convert(block);

				if (part != null)
				{
					if (_currentPart != part && _currentPart != null)
					{
						//assign characteristics to _current part
						_currentPart.Characteristics = Characteristics.Where(p => string.IsNullOrEmpty(p.PartNumber) && !string.IsNullOrEmpty(p.Number));

						foreach (var currentPartCharacteristic in _currentPart.Characteristics)
						{
							currentPartCharacteristic.PartNumber = _currentPart.Number;
						}
					}

					Parts.Add(part);
					_currentPart = part;
				}
			}else if (firstLine.StartsWith("K2"))
			{
				//process characteristic data
				CharacteristicConverter.Convert(block, Characteristics.ToArray());
			}else if (firstLine.StartsWith("K00") || char.IsNumber(firstLine[0]))
			{
				//process value portion
				//todo part and characteristic are considered finished now so make sure we got all processed characteristics assigned to current part
				var measured = MeasurementConverter.Convert(block);
			}
		}

		private Part _currentPart;

		public string GetJson()
		{
			return null;
		}
	}
}
