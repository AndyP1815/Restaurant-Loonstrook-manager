using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using buisness_logic_layer;
using buisness_logic_layer.DTO;
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

		public void CreateEmployee(EmployeeDTO employeeDTO)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string insertEmployee= "INSERT INTO Employee (employee_id, email,month,restaurant_id) VALUES (@Id, @Email,@Month,@Restaurant_id)";

				using (var command = new SQLiteCommand(insertEmployee, connection))
				{
					command.Parameters.AddWithValue("@Id", employeeDTO.Id);
					command.Parameters.AddWithValue("@Email", employeeDTO.Email);
					command.Parameters.AddWithValue("@Month", employeeDTO.MonthNumber);
					command.Parameters.AddWithValue("@Restaurant_id", employeeDTO.RestaurantId);

					command.ExecuteNonQuery();
				}
			}
		}

		public void DeleteEmployee(int employeeId)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string deleteEmployee = "DELETE FROM Employee WHERE id = @id";

				using (var command = new SQLiteCommand(deleteEmployee, connection))
				{
					command.Parameters.AddWithValue("@id", employeeId);
					command.ExecuteNonQuery();
				}
			}
		}

		public List<Employee> GetEmployeesByRestaurant(int restaurantId)
		{
			var employees = new List<Employee>();

			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string query = "SELECT id,employee_id,email,month FROM Employee where restaurant_id = @restaurant_id";

				using (var command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@restaurant_id", restaurantId);

					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var employee = new Employee(reader.GetInt32(0),reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3));

							employees.Add(employee);
						}
					}
				}
			}

			return employees;
		}

		public void SetNewMonth(int employeeId, int MonthNumber)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string updateRestaurant = "update Employee set month = @Month where id = @id";

				using (var command = new SQLiteCommand(updateRestaurant, connection))
				{
					command.Parameters.AddWithValue("@id", employeeId);
					command.Parameters.AddWithValue("@Month", MonthNumber);


					command.ExecuteNonQuery();
				}
			}
		}

		public void UpdateEmployee(EmployeeDTO employeeDTO, int OriginalId)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				// Base query
				string updateRestaurant = @"
		UPDATE Employee 
		SET 
			email = @Email, 
			employee_id = @Id, 
		WHERE 
			id = @OringinalId";

				using (var command = new SQLiteCommand(updateRestaurant, connection))
				{
					command.Parameters.AddWithValue("@Email", employeeDTO.Email);
					command.Parameters.AddWithValue("@Id", employeeDTO.Id);
					command.Parameters.AddWithValue("@OriginalId", OriginalId);

		
					command.ExecuteNonQuery();
				}
			}
		}

	}
}

