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
	public partial class EmployeeForm : Form
	{
		private Restaurant restaurant;
		public EmployeeForm(Restaurant restaurant)
		{
			InitializeComponent();
			this.restaurant = restaurant;

			IdNumUpDown.DecimalPlaces = 0;

			EmployeeManager employeeManager = new EmployeeManager(new EmployeeRepository());

			EmployeelistBox.DataSource = employeeManager.getEmployeesByRestaurantId(restaurant.getId());
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void EmployeelistBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Employee employee = EmployeelistBox.SelectedItem as Employee;

			IdNumUpDown.Value = employee.EmployeeId;
			EmailTextBox.Text = employee.Email;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<Employee> employees = EmployeelistBox.DataSource as List<Employee>;

			int id = (int)IdNumUpDown.Value;
			string email = EmailTextBox.Text;

			if (employees.Any(e => e.Id == id))
			{
				// Your code to handle the case where an employee with the given id exists.
			}
			else
			{
				// Your code to handle the case where an employee with the given id does not exist.
			}


		}
	}
