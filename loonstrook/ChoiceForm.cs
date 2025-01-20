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

namespace loonstrook
{
	public partial class ChoiceForm : Form
	{
		private Restaurant restaurant;
		public ChoiceForm(Restaurant restaurant)
		{
			InitializeComponent();
			this.restaurant = restaurant;
		}

		private void ChoiceForm_Load(object sender, EventArgs e)
		{

		}

		private void PdfButton_Click(object sender, EventArgs e)
		{
			Pdf pdf = new Pdf();
			pdf.Show();
		}
	}
}
