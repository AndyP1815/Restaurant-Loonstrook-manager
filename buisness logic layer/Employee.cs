using System;
using System.Collections.Generic;
using System.Text;

namespace buisness_logic_layer
{
	public class Employee
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public string Email { get; set; }
		public int MonthNumber { get; set; }

		public Employee(int id, int employeeId,string email, int monthNumber)
		{
			this.Id = id;
			this.Email = email;
			this.MonthNumber = monthNumber;
			this.EmployeeId = employeeId;
		}

		public override string ToString()
		{
			return $"{this.EmployeeId}-{this.Email}";
		}
	}
}
