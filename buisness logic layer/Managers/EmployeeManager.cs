using System;
using System.Collections.Generic;
using System.Text;
using buisness_logic_layer.DTO;
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


		public void createEmployee(int id,string email,Restaurant restaurant) 
		{
			int monthNumber = DateTime.Now.Month;
			EmployeeDTO employeeDTO = new EmployeeDTO(id,email,monthNumber,restaurant.getId());
			employeeRepository.CreateEmployee(employeeDTO);
		}
		public List<Employee> getEmployeesByRestaurantId(int restaurantId) 
		{
			return employeeRepository.GetEmployeesByRestaurant(restaurantId);
		}
		public void deleteEmployee(int id) 
		{
			employeeRepository.DeleteEmployee(id);
		}
		public void updateEmployee(int id, string email, Restaurant restaurant,int originalId) 
		{
			int monthNumber = DateTime.Now.Month;
			EmployeeDTO employeeDTO = new EmployeeDTO(id, email);
			employeeRepository.UpdateEmployee(employeeDTO,originalId);
		}
		public void setNextMonth(int employeeId) 
		{
			int monthNumber = DateTime.Now.Month;
			employeeRepository.SetNewMonth(employeeId, monthNumber);
		}
	}
}
