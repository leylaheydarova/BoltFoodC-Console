using BoltFood.Core.Models;
using BoltFood.Data.Repositories.Implementation;
using BoltFood.Data.Repositories.Interface;
using BoltFood.Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace BoltFood.Service.Services.Implementation
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantsRepository _repository;
        public RestaurantService()
        {
            _repository = new RestaurantRepository();
        }
        public void Add()
        {
            Restaurant restaurant = new Restaurant();
            Console.WriteLine("Add Restaurant Name:");
            restaurant.Name = Console.ReadLine();
            Console.WriteLine("Address:");
            restaurant.Address = Console.ReadLine();
            Console.WriteLine("Phone:");
            restaurant.PhoneNumber = Console.ReadLine();

        //    Restaurant restaurant = new Restaurant()
        //    {
        //        Name = name,
        //        Address = address,
        //        PhoneNumber = phone,
        //        CreatedAt = DateTime.Now
        //    };
         _repository.Add(restaurant);
        }

        public void Delete()
        {
            Console.WriteLine("Enter deleted Restaurant ID: ");
            int.TryParse(Console.ReadLine(), out int id);
            try
            {
                _repository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetAll()
        {
            List<Restaurant> restaurants = _repository.GetAll();
            foreach (var restaurant in restaurants)
            {
                Console.WriteLine(restaurant);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter Restaurant ID:");
            int.TryParse(Console.ReadLine(), out int id);
            try
            {
                Restaurant restaurant = _repository.GetById(id);
                Console.WriteLine(restaurant);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter Updated Restaurant ID:");
            int.TryParse(Console.ReadLine(), out int id);

            Console.WriteLine("Add Restaurant Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Phone:");
            string phone = Console.ReadLine();
            Restaurant restaurant = new Restaurant()
            {
                Name = name,
                Address = address,
                PhoneNumber = phone,
                UpdatedAt = DateTime.Now
            };
            try
            {
                _repository.Update(id, restaurant);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    }
