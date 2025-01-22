using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using buisness_logic_layer.iRepository;
using business_logic_layer;
using buisness_logic_layer.DTO;

namespace buisness_logic_layer.Services
{
	public class EmailService
	{
		public async Task<bool> SendEmail(MailDTO mailDTO, string password, Attachment attachment = null)
		{
			try
			{
				var mail = mailDTO.SenderMail;
				var pw = password;

				using (var client = new SmtpClient(mailDTO.SmtpSetting, 587))
				{
					client.EnableSsl = true;
					client.Credentials = new NetworkCredential(mail, pw);

					using (var mailMessage = new MailMessage(mail, mailDTO.Email, mailDTO.Subject, mailDTO.Message))
					{
						if (attachment != null)
						{
							mailMessage.Attachments.Add(attachment);
						}
						await client.SendMailAsync(mailMessage);
						return true;
					}
				}
			}
			catch (SmtpException smtpEx)
			{
				return false;
			}
			catch (Exception ex)
			{
				return false;
			}




		}}
	}
