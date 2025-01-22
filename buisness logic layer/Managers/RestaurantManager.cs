using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using buisness_logic_layer.DTO;
using buisness_logic_layer.iRepository;
using buisness_logic_layer.Services;
using business_logic_layer;
using RandomString4Net;

namespace buisness_logic_layer.Managers
{
	public class RestaurantManager
	{
		private iRestaurantRepository restaurantRepository;

		public RestaurantManager(iRestaurantRepository iRestaurantRepository)
		{
			this.restaurantRepository = iRestaurantRepository;
		}

		public List<Restaurant> GetRestaurants() 
		{
			return restaurantRepository.GetRestaurants();
		}


		public async Task createRestaurantAsync(string email, string password,Smtp smtp) 
		{
			
				PasswordEncrypter passwordEncrypter = new PasswordEncrypter();
				string token = RandomString.GetString(Types.ALPHABET_LOWERCASE, 7);

				string encryptedPassword = passwordEncrypter.Encrypt(password);


				RestaurantDTO restaurantDTO = new RestaurantDTO(email, encryptedPassword, token, false, smtp.Id);

				EmailService emailService = new EmailService();

				var mail = new MailDTO("andypan363@gmail.com", email, $"token for {email}", token, smtp.smtpSetting);
			
			bool success = await emailService.SendEmail(mail, password, null);

			if (!success) 
			{
				throw new Exception("Something went wrong and the mail is not send");
			}


				restaurantRepository.createRestaurant(restaurantDTO);
			
			
		}

		public string getToken(int id) 
		{
			return restaurantRepository.getRestaurantToken(id);
		}
		public void updateConfirmToken(int id) 
		{
			restaurantRepository.setRestaurantConfirmTokenToTrue(id);
		}

		public void deleteRestaurant(int id)
		{
			restaurantRepository.deleteRestaurant(id);
		}
		public async Task updateRestaurantAsync(string email, string password, Smtp smtp, int id) 
		{
			PasswordEncrypter passwordEncrypter = new PasswordEncrypter();
			string usedPassword = password;
			string encryptedPassword = "";
			if (!string.IsNullOrEmpty(password))
			{
				encryptedPassword = passwordEncrypter.Encrypt(password);
			}
			else 
			{
				encryptedPassword = restaurantRepository.getPassword(id);
				password = passwordEncrypter.Decrypt(encryptedPassword);
			}

			EmailService emailService = new EmailService();

			var mail = new MailDTO(email, email, $"update restaurant confirmation", "Het restaurant moet nu geupdated zijn", smtp.smtpSetting);

			bool success = await emailService.SendEmail(mail, password, null);

			if (!success)
			{
				throw new Exception("Er is iets mis gegaan en de mail is niet verzonden");
			}


			RestaurantDTO restaurantDTO = new RestaurantDTO(id, email, encryptedPassword, smtp.Id);

			restaurantRepository.updateRestaurant(restaurantDTO);

		}
		public string getPassword(int restaurantId) 
		{
			return restaurantRepository.getPassword(restaurantId);
		}
	}
}
