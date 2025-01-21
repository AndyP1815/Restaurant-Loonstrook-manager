using System.Data.SQLite;
using System.IO;
using System;

public static class DatabaseHelper
{
	private static string connectString;

	static DatabaseHelper()
	{
		// Set the database file path to the execution directory
		string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "sqlite.db");

		// Ensure the Files directory exists
		string directory = Path.GetDirectoryName(dbFilePath);
		if (!Directory.Exists(directory))
		{
			Directory.CreateDirectory(directory);
		}

		connectString = $"Data Source={dbFilePath};Version=3;";
	}

	public static void Initialize()
	{
		if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "sqlite.db")))
		{
			SQLiteConnection.CreateFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "sqlite.db"));
		}

		using (var connection = new SQLiteConnection(connectString))
		{
			connection.Open();

			// Create Smtp Table
			string createSmtpTable = "CREATE TABLE IF NOT EXISTS Smtp (" +
									 "id INTEGER PRIMARY KEY, " +
									 "email_name TEXT NOT NULL, " +
									 "email_setting TEXT NOT NULL)";

			// Create Restaurant Table with smtp_id as Foreign Key (Directly on creation)
			string createRestaurantTable = "CREATE TABLE IF NOT EXISTS Restaurant (" +
										   "id INTEGER PRIMARY KEY, " +
										   "email TEXT NOT NULL, " +
										   "password TEXT NOT NULL, " +
										   "token TEXT NOT NULL, " +
										   "token_confirmed BOOLEAN NOT NULL, " +
										   "smtp_id INTEGER, " + // Foreign key column
										   "FOREIGN KEY(smtp_id) REFERENCES Smtp(id))"; // Foreign key relationship

			// Create Employee Table
			string createEmployeeTable = "CREATE TABLE IF NOT EXISTS Employee (" +
										 "id INTEGER PRIMARY KEY, " +
										 "employee_id Interger NOT NULL," +
										 "email TEXT NOT NULL, " +
										 "month INTEGER NOT NULL, " +
										 "restaurant_id INTEGER NOT NULL, " +
										 "FOREIGN KEY (restaurant_id) REFERENCES Restaurant(id))";


			string insertSmtpGmail = "INSERT OR IGNORE INTO Smtp (id, email_name, email_setting) VALUES (1, 'Gmail.com', 'smtp.gmail.com')";
			string insertSmtpOne = "INSERT OR IGNORE INTO Smtp (id, email_name, email_setting) VALUES (2, 'One.com', 'send.one.com')";
			string insertSmtpOutlook = "INSERT OR IGNORE INTO Smtp (id, email_name, email_setting) VALUES (3, 'Outlook.com', 'smtp-mail.outlook.com')";

		
			using (var command = new SQLiteCommand(connection))
			{
			
				command.CommandText = createSmtpTable;
				command.ExecuteNonQuery();

				command.CommandText = createRestaurantTable;
				command.ExecuteNonQuery();

				command.CommandText = createEmployeeTable;
				command.ExecuteNonQuery();

				command.CommandText = insertSmtpGmail;
				command.ExecuteNonQuery();

				command.CommandText = insertSmtpOne;
				command.ExecuteNonQuery();

				command.CommandText = insertSmtpOutlook;
				command.ExecuteNonQuery();
			}
		}
	}
}
