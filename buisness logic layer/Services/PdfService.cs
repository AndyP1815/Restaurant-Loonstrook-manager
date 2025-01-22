using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace buisness_logic_layer.Services
{
	public class PdfService
	{
		public PdfService() { }
		public string ReturnName(string text)
		{

			string pattern = @"(?:De heer|Mevrouw)\s*(.*)";

			Match match = Regex.Match(text, pattern);


			if (match.Success)
			{
				return match.Groups[1].Value + " " + match.Groups[2].Value;
			}
			else
			{
				return "0";
			}
		}

		public string ReturnNumber(string text)
		{

			string pattern = @"Werknemer\s+(\d+(\s+\d+)*)";

			Match match = Regex.Match(text, pattern);

			if (match.Success)
			{
				string extractedText = match.Groups[1].Value;
				return extractedText;
			}
			else
			{
				return "0";
			}
		}
		public string ReturnText(string file, int pageNumber)
		{
			StringBuilder sb = new StringBuilder();

			using (PdfReader reader = new PdfReader(file))
			{
				// Ensure the page number is valid
				if (pageNumber >= 1 && pageNumber <= reader.NumberOfPages)
				{
					iTextSharp.text.pdf.parser.ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
					string text = PdfTextExtractor.GetTextFromPage(reader, pageNumber, strategy);
					text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
					sb.Append(text);
				}
			}
			return sb.ToString();
		}


		public string CreateMap(string folderName, string newPath)
		{
			
			string newFolderPath = System.IO.Path.Combine(newPath, folderName);

			
			if (!Directory.Exists(newFolderPath))
			{
				Directory.CreateDirectory(newFolderPath);
				return newFolderPath;
			}
			else
			{
				throw new Exception("Directory already exists");
			}
		}


	}
}
