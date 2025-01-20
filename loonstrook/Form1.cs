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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace loonstrook
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			initialize();
		}
		public void initialize() 
		{
			RestaurantManager restaurantManager = new RestaurantManager(new restaurantRepository());
			List<Restaurant> restaurants = restaurantManager.GetRestaurants();

			listBox1.DataSource = restaurants;

			initializeButton.Enabled = false;
			selectButton.Enabled = false;
			DeleteButton.Enabled = false;
			updateButton.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			EmployeeManager employeeManager = new EmployeeManager(new EmployeeRepository());

			var mails = employeeManager.getEmails();

			foreach (var mail in mails) 
			{
				MessageBox.Show(mail);
			}

		}

		private void createButton_Click(object sender, EventArgs e)
		{
			CreateRestaurantForm createRestaurantForm = new CreateRestaurantForm(this);

			createRestaurantForm.Show();

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Restaurant restaurant = listBox1.SelectedItem as Restaurant;

			DeleteButton.Enabled = true;
			updateButton.Enabled = true;

			if (restaurant.tokenConfimred == true)
			{
				initializeButton.Enabled = false;
				selectButton.Enabled = true;
			}
			else 
			{
				initializeButton.Enabled = true;
				selectButton.Enabled = false;
			}
		
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void initializeButton_Click(object sender, EventArgs e)
		{
			Restaurant restaurant = listBox1.SelectedItem as Restaurant;
			int id = restaurant.getId();

			ConfirmTokenForm confirmTokenForm = new ConfirmTokenForm(this,id);

			confirmTokenForm.Show();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null)
			{
				MessageBox.Show("selecteer een Restaurant");
			}
			else 
			{
				

				DialogResult dialogResult = MessageBox.Show("Will je zeker dit restaurant verwijderen", "Confirm", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					RestaurantManager restaurantManager = new RestaurantManager(new restaurantRepository());

					Restaurant restaurant = listBox1.SelectedItem as Restaurant;

					restaurantManager.deleteRestaurant(restaurant.getId());
					this.initialize();

				}
				else
				{

				}
			}
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null)
			{
				MessageBox.Show("selecteer een Restaurant");
			}
			else
			{
				Restaurant restaurant = listBox1.SelectedItem as Restaurant;

				UpdateRestaurant createRestaurantForm = new UpdateRestaurant(restaurant,this);

				createRestaurantForm.Show();
			}
		}
	}
}
