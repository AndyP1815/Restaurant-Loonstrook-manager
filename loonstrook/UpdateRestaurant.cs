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
	public partial class UpdateRestaurant : Form
	{
		private Restaurant restaurant;

		private Form1 parentForm;
		public UpdateRestaurant(Restaurant restaurant,Form1 form)
		{
			InitializeComponent();
			this.restaurant = restaurant;
			this.parentForm = form;
			emailTextBox.Text = restaurant.getEmail();
			SmtpManager smtpManager = new SmtpManager(new SmtpRepository());

			systenComboBox.DataSource = smtpManager.Getsmtps();

			systenComboBox.SelectedItem = restaurant.smtp;


		}

		private void UpdateRestaurant_Load(object sender, EventArgs e)
		{

		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string password = passwordTextBox.Text;
			string email = emailTextBox.Text;

			if (string.IsNullOrEmpty(email))
			{
				MessageBox.Show("Je moet nog iets invullen");
			}
			else
			{

				DialogResult dialogResult = MessageBox.Show("Will je zeker het restaurant updaten", "Confirm", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					RestaurantManager restaurantManager = new RestaurantManager(new restaurantRepository());

					Smtp smtp = systenComboBox.SelectedItem as Smtp;

					try
					{
						restaurantManager.updateRestaurant(email, password, smtp,restaurant.getId());
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
	}
}
