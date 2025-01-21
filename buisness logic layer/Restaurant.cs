using System;
using System.Collections.Generic;
using System.Text;

namespace buisness_logic_layer
{
	public class Restaurant
	{
		private int id;
		private string email;


		public bool tokenConfimred{  get; set; }

		public Smtp smtp {  get; set; }

		public Restaurant(int id, string email,bool tokenConfimred,Smtp smtp) 
		{
			this.id = id;
			this.email = email;
			this.tokenConfimred = tokenConfimred;
			this.smtp = smtp;

		}


		public override string ToString()
		{
			return tokenConfimred ? $"{email}" : $"{email}-XXX";
		}
		

		public string getEmail() 
		{
			return email;
		}
		public int getId() 
		{
			return id;
		}

	}
}
