using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using buisness_logic_layer.iRepository;

namespace DAL
{
	public class EmployeeRepository: iEmployeeRepository
	{
		private readonly string connectString;

		public EmployeeRepository()
		{
			string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "sqlite.db");
			connectString = $"Data Source={dbFilePath};Version=3;";
		}

		public List<string> getEmails()
		{
			var emails = new List<string>();

			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();
				string query = "SELECT email FROM Employee";

				using (var command = new SQLiteCommand(query, connection))
				{
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							if (reader["email"] != DBNull.Value)
							{
								emails.Add(reader["email"].ToString());
							}
						}
					}
				}
			}

			return emails;
		}
	}
}
