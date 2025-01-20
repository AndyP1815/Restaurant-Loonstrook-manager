using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisness_logic_layer.Managers;
using DAL;

namespace loonstrook
{
	public partial class ConfirmTokenForm : Form
	{
		private int restaurantId;
		private Form1 parentForm;
		public ConfirmTokenForm(Form1 form, int id)
		{
			InitializeComponent();

			parentForm = form;

			restaurantId =id;

		}

		private void confirmButton_Click(object sender, EventArgs e)
		{
			RestaurantManager restaurantManager = new RestaurantManager(new restaurantRepository());
			string filledToken = textBox1.Text;
			string realToken = restaurantManager.getToken(restaurantId);

			if (filledToken.Trim() == realToken.Trim())
			{
				restaurantManager.updateConfirmToken(restaurantId);
				parentForm.initialize();
				this.Close();
			}
			else 
			{
				MessageBox.Show("Verkeerde token is ingevuld");
			}

		}

		private void ConfirmTokenForm_Load(object sender, EventArgs e)
		{

		}
	}
}
