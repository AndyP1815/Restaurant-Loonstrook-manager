using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using buisness_logic_layer;
using buisness_logic_layer.iRepository;

namespace DAL
{
	public class SmtpRepository : iSmtpRepository
	{
		private readonly string connectString;

		public SmtpRepository()
		{
			string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "sqlite.db");
			connectString = $"Data Source={dbFilePath};Version=3;";
		}

		public List<Smtp> GetSmtps()
		{
			var smtps = new List<Smtp>();

			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string query = "SELECT id, email_name,email_setting FROM Smtp";

				using (var command = new SQLiteCommand(query, connection))
				{
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var smtp = new Smtp(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

							smtps.Add(smtp);
						}
					}
				}
			}

			return smtps;
		}
	}
}
