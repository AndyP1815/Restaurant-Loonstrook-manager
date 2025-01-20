using System;
using System.Collections.Generic;
using System.Text;

namespace buisness_logic_layer.DTO
{
	public class RestaurantDTO
	{
		public int Id;
		public string Email;
		public string Password;
		public string Token;
		public bool TokenConfirmed;
		public int smtpId;

		public RestaurantDTO(string email,string password,string token,bool tokenConfirmed,int smtpId) 
		{
			this.Email = email;
			this.Password = password;
			this.Token = token;
			this.TokenConfirmed = tokenConfirmed;
			this.smtpId = smtpId;
		}

		public RestaurantDTO(int id, string email,string password,int smtpId) 
		{
			this.Id = id;
			this.smtpId=smtpId;
			this.Email = email;
			this.Password = password;

		}

	}
}
