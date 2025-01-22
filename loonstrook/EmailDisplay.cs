using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisness_logic_layer;
using buisness_logic_layer.DTO;
using buisness_logic_layer.Managers;
using buisness_logic_layer.Services;
using business_logic_layer;
using DAL;

namespace loonstrook
{
	public partial class EmailDisplay : Form
	{

		private Restaurant restaurant;
		private string title;
		private string message;
		private string pdfFolders;
		private EmployeeManager EmployeeManager;
		private List<Employee> employees;
		public EmailDisplay(Restaurant restaurant, string title, string message, string PdfFolders,EmailForm emailForm,List<Employee> employees)
		{
			InitializeComponent();
			this.restaurant = restaurant;
			this.title = title;
			this.message = message;
			this.pdfFolders = PdfFolders;
			this.employees = employees;
			this.EmployeeManager = new EmployeeManager(new EmployeeRepository());
			initializeEmployee();
			emailForm.Close();
			this.Shown += EmailDisplay_Shown;


		}

		private void EmailDisplay_Shown(object sender, EventArgs e)
		{

			sentEmailAsync();
		}

		private async void sentEmailAsync()
		{
			PdfService pdfService = new PdfService();
			EmailService emailService = new EmailService();
			RestaurantManager restaurantManager = new RestaurantManager(new restaurantRepository());
			PasswordEncrypter passwordEncrypter = new PasswordEncrypter();
			string password = passwordEncrypter.Decrypt(restaurantManager.getPassword(this.restaurant.getId()));


			ToSendListBox.DataSource = this.employees;

			List<string> pdfsInFolder = Directory.GetFiles(this.pdfFolders, "*.pdf").ToList();

			foreach (string pdfs in pdfsInFolder)
			{
				string PdfText = pdfService.ReturnText(pdfs, 1);
				string number = pdfService.ReturnNumber(PdfText);

				Employee targetEmployee = employees.FirstOrDefault(x => x.EmployeeId == Convert.ToInt32(number));
				if (targetEmployee != null)
				{
					this.employees.Remove(targetEmployee);
					ToSendListBox.DataSource = null;
					ToSendListBox.DataSource = this.employees; 

					sendingTextBox.Text = targetEmployee.ToString();

					Attachment attachment = new Attachment(pdfs, MediaTypeNames.Application.Pdf);
					var mail = targetEmployee.Email;
					var FileName = System.IO.Path.GetFileName(pdfs);

					try
					{
						await Task.Delay(TimeSpan.FromSeconds(30));
						bool success = await emailService.SendEmail(new MailDTO(mail, restaurant.getEmail(), this.title, this.message, this.restaurant.smtp.smtpSetting), password, attachment);
						
						if (success)
						{
						 	this.EmployeeManager.setNextMonth(targetEmployee.Id);
							SendListBox.Items.Add(targetEmployee);
						
						}
						else
						{
						
							FailureListBox.Items.Add(targetEmployee);
						}

					}
					catch (Exception ex)
					{
						FailureListBox.Items.Add(targetEmployee);
						MessageBox.Show(ex.Message);
					}
				}
				sendingTextBox.Text = "";
			}
			sendingTextBox.Text = "Geen mails meer om verzonden te worden";
			label4.Text = string.Empty;
		}

		public void initializeEmployee() 
		{
			ToSendListBox.DataSource = this.employees;
		}
		
		private void EmailDisplay_Load(object sender, EventArgs e)
		{
			
		}

		
	}
}
