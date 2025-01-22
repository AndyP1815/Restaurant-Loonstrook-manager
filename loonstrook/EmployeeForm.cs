using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buisness_logic_layer;
using buisness_logic_layer.DTO;
using buisness_logic_layer.Managers;
using buisness_logic_layer.Services;
using com.itextpdf.text.pdf;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace loonstrook
{
	public partial class EmployeeForm : Form
	{
		private Restaurant restaurant;
		private EmployeeManager manager;
		private int state = 0;
		public EmployeeForm(Restaurant restaurant)
		{
			InitializeComponent();
			this.restaurant = restaurant;

			IdNumUpDown.DecimalPlaces = 0;

			this.manager = new EmployeeManager(new EmployeeRepository());

			initialize();
		}

		public void initialize() 
		{
			List<Employee> list = this.manager.getEmployeesByRestaurantId(restaurant.getId()).OrderBy(q => q.EmployeeId).ToList(); 
			EmployeelistBox.DataSource = list;

			if (state != 0) 
			{
				Employee employee = list.Find(item => item.EmployeeId == state);
				if (employee != null) 
				{
					EmployeelistBox.SelectedItem = employee;
				}
			}
			
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

			if (employees.Any(item => item.EmployeeId == id))
			{
				initialize();
				MessageBox.Show("Medewerker met hetzelfde id bestaat ookal, pas dit eerst aan");
			}
			else 
			{
				manager.createEmployee(id,email,this.restaurant);
				this.state = id;
				initialize();
			}


		}

		private void button3_Click(object sender, EventArgs e)
		{
			List<Employee> employees = EmployeelistBox.DataSource as List<Employee>;
			Employee employee = EmployeelistBox.SelectedItem as Employee;

			employees.Remove(employee);

			int id = (int)IdNumUpDown.Value;
			string email = EmailTextBox.Text;


			if (employee == null)
			{
				MessageBox.Show("Er is geen medewerker geselecteerd");
			}
			else
			{
				if (employees.Any(item => item.EmployeeId == id))
				{
					initialize();
					MessageBox.Show("Medewerker met hetzelfde id bestaat ookal, pas dit eerst aan");
				}
				else
				{
					manager.updateEmployee(id, email, this.restaurant, employee.Id);
					this.state = id;
					initialize();
				}
			}
		}

		private void EmployeeForm_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (EmployeelistBox.SelectedItem == null)
			{
				MessageBox.Show("selecteer een Medewerker");
			}
			else
			{
				Employee employee = EmployeelistBox.SelectedItem as Employee;

				if (employee == null)
				{
					MessageBox.Show("Er is geen medewerker geselecteerd");
				}
				else
				{
					DialogResult dialogResult = MessageBox.Show($"Will je zeker deze medewerker:{employee.Email} verwijderen", "Confirm", MessageBoxButtons.YesNo);

					if (dialogResult == DialogResult.Yes)
					{
						manager.deleteEmployee(employee.Id);
						this.initialize();
					}
					else
					{

					}
				}
			}
		}

		private void ImportButton_Click(object sender, EventArgs e)
		{

			List<Employee> employees = EmployeelistBox.DataSource as List<Employee>;
			CsvService csvService = new CsvService();

			try
			{
				string file = csvService.chooseCsv();
				List<EmployeeDTO> employeeDTOs = csvService.GetEmployees(file, this.restaurant.getId());

				foreach (var employeeDTO in employeeDTOs)
				{
					if (employees.Any(item => item.EmployeeId == employeeDTO.Id))
					{
						MessageBox.Show($"Medewerker met email:{employeeDTO.Email} kan niet worden toegevoeg omdat id:{employeeDTO.Id} al bestaat");
					}
					else
					{
						manager.createEmployee(employeeDTO.Id, employeeDTO.Email, this.restaurant);
					}
				}
				initialize();
			}
			catch (IOException ex) 
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DownloadButton_Click(object sender, EventArgs e)
		{
			try 
			{
				List<Employee> employees = EmployeelistBox.DataSource as List<Employee>;
				CsvService csvService = new CsvService();
				csvService.SaveCsvToDownloads(employees);
				MessageBox.Show("it is saved in downloads");
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
