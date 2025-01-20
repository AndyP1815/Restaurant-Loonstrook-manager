using System;
using System.Collections.Generic;
using System.Text;
using buisness_logic_layer.iRepository;

namespace buisness_logic_layer.Managers
{
	public class SmtpManager
	{
		private iSmtpRepository smtpRepository;

		public SmtpManager(iSmtpRepository ismtpRepository)
		{
			this.smtpRepository = ismtpRepository;
		}

		public List<Smtp> Getsmtps() 
		{
			return smtpRepository.GetSmtps();
		}

	}
}
