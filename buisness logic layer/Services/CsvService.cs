using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;
using buisness_logic_layer.DTO;

namespace buisness_logic_layer.Services
{
	public class CsvService
	{
		public CsvService() 
		{

		}

		public string chooseCsv() 
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				// Configure the OpenFileDialog
				openFileDialog.Title = "Select File";
				openFileDialog.InitialDirectory = @"C:\";
				openFileDialog.Filter = "All files (*.*)|*.*|CSV Files (*.csv)|*.csv";
				openFileDialog.FilterIndex = 2;

			
				if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
				{
					return openFileDialog.FileName; 
				}
				else
				{
					throw new Exception("nothing selected");
				}
			}
		}
		public List<EmployeeDTO> GetEmployees(string file, int restaurantId)
		{
			var employees = new List<EmployeeDTO>();
			int oldMonthNumber = DateTime.Now.AddMonths(-1).Month; 

			try
			{
				foreach (var line in File.ReadLines(file).Skip(1)) 
				{
					string test = line;
					string[] data = line.Split(',');


					employees.Add(new EmployeeDTO(Convert.ToInt32(data[0]), data[1], oldMonthNumber, restaurantId));
				}
			}
			catch (IOException ex)
			{
				Console.WriteLine($"Error reading file: {ex.Message}");
			}
			catch (Exception ex)
			{
				// Handle other errors
				Console.WriteLine($"Unexpected error: {ex.Message}");
			}

			return employees;
		}

		public string SaveCsvToDownloads(List<Employee> employees)
		{
			try
			{
				string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

				string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss"); 
				string fileName = $"employees_{timestamp}.csv";
				string filePath = Path.Combine(downloadsPath, fileName);

				// Create and write to the CSV file
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					
					writer.WriteLine("Id,Email");

					// Write employee data
					foreach (var employee in employees)
					{
						writer.WriteLine($"{employee.EmployeeId},{employee.Email}");
					}
				}

				return filePath;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error saving CSV: {ex.Message}");
				throw;
			}
		}
	}
}
