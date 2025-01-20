using System;
using System.Collections.Generic;
using System.Text;
using buisness_logic_layer.iRepository;

namespace buisness_logic_layer.Managers
{
	public class EmployeeManager
	{
		private iEmployeeRepository employeeRepository;

		public EmployeeManager(iEmployeeRepository iEmployeeRepository) 
		{
			this.employeeRepository = iEmployeeRepository;
		}

		public List<string> getEmails() 
		{
			return employeeRepository.getEmails();
		}
	}
}
