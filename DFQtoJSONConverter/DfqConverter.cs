using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Models;

namespace DFQtoJSONConverter
{
	public class DfqConverter
	{
		public IList<Part> Parts { get; set; }

		public void Convert(string dfqFilePath)
		{
			if (string.IsNullOrEmpty(dfqFilePath))
				throw new ArgumentException("dfqFilePath");

			Parts = new List<Part>();
			var dfqFile = File.ReadAllLines(dfqFilePath);
			var lineBlock = new List<string>();

			foreach (var line in dfqFile)
			{
				//todo read entire block until new line 
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

			if(firstLine.StartsWith("K1") || firstLine.StartsWith("K0100"))
			{
				//process part data
				var partConverter = new PartConverter();
				var part = partConverter.ConvertPart(block);

				if (part != null)
				{
					_currentPart = part;
					Parts.Add(part);
				}
			}else if (firstLine.StartsWith("K2"))
			{
				//todo process characteristic data
			}
		}

		private void ProcessLine(string line)
		{
			if (line.StartsWith("K0100"))
			{
				//skip number of characteristics ?
				return;
			}

			//todo read entire block until new line 
			if (line.StartsWith("K1"))
			{
				//process part data
				//ProcessPart(line);
				//todo add to part list, change current part to new part
			}

			
			throw new NotImplementedException();
		}

		private Part _currentPart;


		public string GetJson()
		{
			return null;
		}

		//read file

		//process each line

		//process part

		//process characteristic

		//process measurements
	}
}
