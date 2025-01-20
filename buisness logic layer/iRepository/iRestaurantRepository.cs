using System;
using System.Collections.Generic;
using System.Text;
using buisness_logic_layer.DTO;

namespace buisness_logic_layer.iRepository
{
	public interface iRestaurantRepository
	{
		string getPassword(int id);

		List<Restaurant> GetRestaurants();

		Restaurant GetRestaurant(int id);

		void createRestaurant(RestaurantDTO restaurantDTO);
		void updateRestaurant(RestaurantDTO restaurantDTO);

		string getRestaurantToken(int id);

		void setRestaurantConfirmTokenToTrue(int id);

		void deleteRestaurant(int id);
	}
}
