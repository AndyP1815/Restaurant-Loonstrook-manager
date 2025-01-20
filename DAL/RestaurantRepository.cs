using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.IO;
using System.Text;
using buisness_logic_layer;
using buisness_logic_layer.DTO;
using buisness_logic_layer.iRepository;

namespace DAL
{
	public class restaurantRepository : iRestaurantRepository
	{

		private readonly string connectString;

		public restaurantRepository()
		{
			string dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "sqlite.db");
			connectString = $"Data Source={dbFilePath};Version=3;";
		}

		public void createRestaurant(RestaurantDTO restaurantDTO)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string insertRestaurant = "INSERT INTO Restaurant (email, password, token, token_confirmed,smtp_id) VALUES (@Email, @Password, @Token, @TokenConfirmed,@Smtp_id)";

				using (var command = new SQLiteCommand(insertRestaurant, connection))
				{
					command.Parameters.AddWithValue("@Email", restaurantDTO.Email);
					command.Parameters.AddWithValue("@Password",restaurantDTO.Password ); 
					command.Parameters.AddWithValue("@Token", restaurantDTO.Token);
					command.Parameters.AddWithValue("@TokenConfirmed", restaurantDTO.TokenConfirmed);
					command.Parameters.AddWithValue("@Smtp_id", restaurantDTO.smtpId);

					command.ExecuteNonQuery();
				}
			}
		}

		public void deleteRestaurant(int id)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string deleteRestaurant = "DELETE FROM Restaurant WHERE id = @id";

				using (var command = new SQLiteCommand(deleteRestaurant, connection))
				{
					command.Parameters.AddWithValue("@id", id);
					command.ExecuteNonQuery();
				}
			}
		}

		public string getPassword(int id)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string query = "SELECT password FROM Restaurant WHERE id = @Id";

				using (var command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					var result = command.ExecuteScalar();

					if (result != null)
					{
						return (string)result;
					}

					return null;
				}
			}
		}

		public Restaurant GetRestaurant(int id)
		{
			throw new NotImplementedException();
		}

		public List<Restaurant> GetRestaurants()
		{
			var restaurants = new List<Restaurant>();

			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string query = "SELECT Restaurant.id, email,token_confirmed,Smtp_id,email_name,email_setting FROM Restaurant inner join Smtp on Restaurant.smtp_id = Smtp.id \r\n";

				using (var command = new SQLiteCommand(query, connection))
				{
					using (var reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							var restaurant = new Restaurant(reader.GetInt32(0),reader.GetString(1),reader.GetBoolean(2),new Smtp(reader.GetInt32(3),reader.GetString(4),reader.GetString(5)));

							restaurants.Add(restaurant);
						}
					}
				}
			}

			return restaurants;
		}

		public string getRestaurantToken(int id)
		{

			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string query = "SELECT token FROM Restaurant WHERE id = @Id";

				using (var command = new SQLiteCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", id);

					var result = command.ExecuteScalar();

					if (result != null)
					{
						return (string)result;
					}

					return null;
				}
			}
		}

		public void setRestaurantConfirmTokenToTrue(int id)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				string updateRestaurant = "update Restaurant set token_confirmed = 1 where id = @id";

				using (var command = new SQLiteCommand(updateRestaurant, connection))
				{
					command.Parameters.AddWithValue("@id", id);


					command.ExecuteNonQuery();
				}
			}
		}

		
		public void updateRestaurant(RestaurantDTO restaurantDTO)
		{
			using (var connection = new SQLiteConnection(connectString))
			{
				connection.Open();

				// Base query
				string updateRestaurant = @"
		UPDATE Restaurant 
		SET 
			email = @Email, 
			password = @Password, 
			smtp_id = @Smtp_id
		WHERE 
			id = @Id";

				// Adjust query if Password is null or empty
				if (string.IsNullOrEmpty(restaurantDTO.Password))
				{
					updateRestaurant = @"
			UPDATE Restaurant 
			SET 
				email = @Email, 
				smtp_id = @Smtp_id
			WHERE 
				id = @Id";
				}

				using (var command = new SQLiteCommand(updateRestaurant, connection))
				{
					command.Parameters.AddWithValue("@Email", restaurantDTO.Email);
					command.Parameters.AddWithValue("@Smtp_id", restaurantDTO.smtpId);
					command.Parameters.AddWithValue("@Id", restaurantDTO.Id);

					// Only add the Password parameter if it is included in the query
					if (!string.IsNullOrEmpty(restaurantDTO.Password))
					{
						command.Parameters.AddWithValue("@Password", restaurantDTO.Password);
					}

					command.ExecuteNonQuery();
				}
			}
		}

	}

}
