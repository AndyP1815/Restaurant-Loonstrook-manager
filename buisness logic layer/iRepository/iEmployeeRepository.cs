using System;
using System.Collections.Generic;
using System.Text;
using buisness_logic_layer.DTO;
using Org.BouncyCastle.Cms;

namespace buisness_logic_layer.iRepository
{
	public interface iEmployeeRepository
	{
		 List<Employee> GetEmployeesByRestaurant(int restaurantId);
		void CreateEmployee(EmployeeDTO employeeDTO);
		void UpdateEmployee(EmployeeDTO employeeDTO, int OriginalId);
		void SetNewMonth(int employeeId,int MonthNumber);
		void DeleteEmployee(int employeeId);
		
	}
}
	