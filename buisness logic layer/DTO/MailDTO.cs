using System;
using System.Collections.Generic;
using System.Text;

namespace buisness_logic_layer.DTO
{
	public class MailDTO
	{
		public string Email { get; set; }
		public string SenderMail { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public string SmtpSetting { get; set; }
		public MailDTO(string email,string senderMail,string subject, string message, string smtpSetting)
		{
			this.Email = email;
			this.SenderMail = senderMail;
			this.Subject = subject;
			this.Message = message;
			this.SmtpSetting = smtpSetting;
		}
	}
}
