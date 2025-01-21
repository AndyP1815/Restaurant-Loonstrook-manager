using System;
using System.Collections.Generic;
using System.Text;

namespace buisness_logic_layer.DTO
{
	public class EmployeeDTO
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public int MonthNumber { get; set; }
		public int RestaurantId { get; set; }
		public EmployeeDTO(int id, string email, int monthNumber, int restaurantId)
		{
			this.Id = id;
			this.Email = email;
			this.MonthNumber = monthNumber;
			RestaurantId = restaurantId;
		}
		public EmployeeDTO(int id,string email) 
		{
			this.Email=email;
			this.Id=id;
		}

	}
}
