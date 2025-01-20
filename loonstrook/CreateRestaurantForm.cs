using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisness_logic_layer;
using buisness_logic_layer.Managers;
using DAL;

namespace loonstrook
{
	public partial class CreateRestaurantForm : Form
	{
		private Form1 parentForm;
		public CreateRestaurantForm(Form1 form)
		{
			InitializeComponent();
			SmtpManager smtpManager = new SmtpManager(new SmtpRepository());

			systenComboBox.DataSource = smtpManager.Getsmtps();

			parentForm = form;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void CreateRestaurantForm_Load(object sender, EventArgs e)
		{

		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string password = passwordTextBox.Text;
			string email = emailTextBox.Text;

			if (string.IsNullOrEmpty(password) ^ string.IsNullOrEmpty(email))
			{
				MessageBox.Show("Je moet nog iets invullen");
			}
			else
			{

				DialogResult dialogResult = MessageBox.Show("Will je zeker een restaurant erbij aanmaken", "Confirm", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					RestaurantManager restaurantManager = new RestaurantManager(new restaurantRepository());

					Smtp smtp =  systenComboBox.SelectedItem as Smtp;

					try { 
					restaurantManager.createRestaurant(email, password, smtp);
						}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					parentForm.initialize();
					this.Close();

				}
				else
				{

				}
			}
		}

		private void emailTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void systenComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
