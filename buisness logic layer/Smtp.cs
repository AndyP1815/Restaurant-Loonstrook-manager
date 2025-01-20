using System;
using System.Collections.Generic;
using System.Text;

namespace buisness_logic_layer
{
	public class Smtp
	{
		public int Id {  get; private set; }
		public string EmailName { get; private set; }
		public string smtpSetting { get; private set; }
		public Smtp(int id,string emailname,string smtpsetting) 
		{
			this.Id = id;
			this.EmailName = emailname;
			this.smtpSetting = smtpsetting;
		}

		public override string ToString()
		{
			return this.EmailName;
		}
	}
}
