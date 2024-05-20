using BoltFood.Core.Enum;
using BoltFood.Core.Models;
using BoltFood.Data.Repositories.Implementation;
using BoltFood.Data.Repositories.Interface;
using BoltFood.Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Service.Services.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository = new ProductRepository();
        private IRestaurantsRepository _restaurantsRepository = new RestaurantRepository();
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public void Add()
        {
            Console.WriteLine("Set Product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Price: ");
            double.TryParse(Console.ReadLine(), out double price);
            var enums = Enum.GetValues(typeof(ProductCategory));
            foreach (var enum1 in enums)
            {
                Console.WriteLine((int)enum1 + "." + enum1);
            }
            Console.WriteLine("Category number: ");
            int.TryParse(Console.ReadLine(), out int categorynumber);
            Console.WriteLine("Restaurant ID: ");
            int.TryParse(Console.ReadLine(), out int res_id);
            try
            {
                Restaurant restaurant = _restaurantsRepository.GetById(res_id);

                _productRepository.Add(new Product()
                {
                    Name = name,
                    Description = description,
                    Price = price,
                    Restaurant = restaurant,
                    Category = (ProductCategory)categorynumber,
                    CreatedAt = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Delete()
        {
            Console.WriteLine("Input ID: ");
            int.TryParse(Console.ReadLine(), out int id);
            try
            {
                _productRepository.Delete(id);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetAll()
        {
            List<Product> products = _productRepository.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void GetByID()
        {
            Console.WriteLine("Input ID: ");
            int.TryParse(Console.ReadLine(), out int id);
            try
            {
                Console.WriteLine(_productRepository.GetById(id));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void Update()
        {
            Console.WriteLine("Input ID: ");
            int.TryParse(Console.ReadLine(), out int id);
            Product product = _productRepository.GetById(id);
            if (product.ID == id)
            {
                Console.WriteLine("New name:");
                product.Name = Console.ReadLine();
                Console.WriteLine("New Description:");
                product.Description = Console.ReadLine();
                Console.WriteLine("New Price:");
                double.TryParse(Console.ReadLine(), out double price);
                product.Price = price;
                Console.Write("Updated at: ");
                product.UpdatedAt = DateTime.Now;
            }

        }
    }
}
