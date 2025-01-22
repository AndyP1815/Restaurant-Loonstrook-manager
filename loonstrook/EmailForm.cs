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
	public partial class EmailForm : Form
	{
		private Restaurant restaurant;
		public EmailForm(Restaurant restaurant)
		{
			InitializeComponent();
			this.restaurant = restaurant;
			initializeListBoxes();

			string dateString = DateTime.Now.AddMonths(-1).ToString("MMMM yyyy");

			MessageTextbx.Text = $"Loonstrook {dateString}";
			Titletxtbx.Text = $"Loonstrook {dateString}";
		}

		public void initializeListBoxes() 
		{
			EmployeeManager employeeManager = new EmployeeManager(new EmployeeRepository());

			List<Employee> employees = employeeManager.getEmployeesByRestaurantId(this.restaurant.getId());

			List<Employee> Sending = new List<Employee>();
			List<Employee> notSending = new List<Employee>();

			foreach (Employee employee in employees) 
			{
				int monthNumber = DateTime.Now.Month;

				int adjustedEmployeeMonth = (employee.MonthNumber - monthNumber + 12) % 12;

				if (adjustedEmployeeMonth <= 0)
				{
					Sending.Add(employee);
				}
				else
				{
					notSending.Add(employee);
				}
			}
			SendListBox.DataSource = Sending.OrderBy(q => q.EmployeeId).ToList(); ;
			NotSendListBox.DataSource = notSending.OrderBy(q => q.EmployeeId).ToList(); ;



		}

		private void SelectButton_Click(object sender, EventArgs e)
		{
			using (var folderDialog = new FolderBrowserDialog())
			{
				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					string selectedFolderPath = folderDialog.SelectedPath;
					MailFolderTxtbx.Text = selectedFolderPath;
				}
			}
		}

		private void EmailForm_Load(object sender, EventArgs e)
		{

		}

		private void SendButton_Click(object sender, EventArgs e)
		{
			if (Titletxtbx.Text != string.Empty ^ MailFolderTxtbx.Text != string.Empty ^ MessageTextbx.Text != string.Empty)
			{
				DialogResult dialogResult = MessageBox.Show($"Will je zeker de mails verzenden", "Confirm", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					List<Employee> employees = SendListBox.DataSource as List<Employee>;
					EmailDisplay emailDisplay = new EmailDisplay(this.restaurant, Titletxtbx.Text, MessageTextbx.Text, MailFolderTxtbx.Text, this, employees.OrderBy(q => q.EmployeeId).ToList());
					emailDisplay.ShowDialog();
				}
				else
				{

				}
			
				
			}
			else
			{
				MessageBox.Show("Je moet nog iets invullen");
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void addEmployeeButton_Click(object sender, EventArgs e)
		{
			Employee employee = NotSendListBox.SelectedItem as Employee;

		
			if (employee == null)
			{
				MessageBox.Show("Kies eerst een medewerk", "No Selection");
				return;
			}

			List<Employee> notSendEmployees = NotSendListBox.DataSource as List<Employee>;
			List<Employee> sendEmployees = SendListBox.DataSource as List<Employee>;

			notSendEmployees.Remove(employee);
			sendEmployees.Add(employee);

			NotSendListBox.DataSource = null;
			SendListBox.DataSource = null;

			NotSendListBox.DataSource = notSendEmployees.OrderBy(q => q.EmployeeId).ToList(); ;
			SendListBox.DataSource = sendEmployees.OrderBy(q => q.EmployeeId).ToList(); ;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Employee employee = SendListBox.SelectedItem as Employee;

			
			if (employee == null)
			{
				MessageBox.Show("Kies eerst een medewerk", "No Selection");
				return;
			}

			List<Employee> notSendEmployees = NotSendListBox.DataSource as List<Employee>;
			List<Employee> sendEmployees = SendListBox.DataSource as List<Employee>;

			sendEmployees.Remove(employee);
			notSendEmployees.Add(employee);

			NotSendListBox.DataSource = null;
			SendListBox.DataSource = null;

			NotSendListBox.DataSource = notSendEmployees.OrderBy(q => q.EmployeeId).ToList(); ;
			SendListBox.DataSource = sendEmployees.OrderBy(q => q.EmployeeId).ToList(); ;
		}

	}
}
