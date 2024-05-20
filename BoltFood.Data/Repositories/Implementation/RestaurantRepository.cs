using BoltFood.Core.Models;
using BoltFood.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Data.Repositories.Implementation
{
    public class RestaurantRepository : IRestaurantsRepository
    {
        private static List <Restaurant> _restaurants = new List<Restaurant>();
       

        public void Add(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }



        public void Delete(int id)
        {
            Restaurant restaurant = GetById(id);
            if (restaurant != null)
            {
                _restaurants.Remove(restaurant);
            }
        }

        public List<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant GetById(int id)
        {
            foreach (var restaurant in _restaurants)
            {
                if (restaurant.ID == id) return restaurant;
            }
            throw new Exception("Restaurant is not found");
        }

        public void Update(int id, Restaurant restaurant)
        {
            Restaurant restaurant1 = GetById(id);
            if (restaurant1 != null)
            {
                restaurant1 = restaurant;
            }
        }
    }
}
