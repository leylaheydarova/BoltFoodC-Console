using BoltFood.Data.Repositories.Interface;
using BoltFood.Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Service.Services.Implementation
{
    public class MenuService : IMenuService
    {
        public void ShowMenu()
        {
            Console.WriteLine("Welcome to Bolt Food\n1.Restaurant Menu\n2.Product Menu\n0. Exit");

            bool isContinue = true;
            do
            {
                Console.WriteLine("Chooce option: ");
                int.TryParse(Console.ReadLine(), out int step);
                switch (step)
                {
                    case 1:
                        ShowRestaurantMenu();
                        break;
                    case 2:
                        ShowProductMenu();
                        break;
                    case 0:
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Not valid option!");
                        break;
                }
            }
            while(isContinue);
            
        }

        public void ShowRestaurantMenu()
        {
            IRestaurantService restaurantService = new RestaurantService();
            Console.WriteLine("1.Add restaurant\n2.Get All restaurants\n3.Get a Restaurant by ID\n4.Update a restaurant\n5.Delete a restaurant\n0.Exit");
            bool keepgoing = true;
            do
            {
                Console.WriteLine("Chooce option for Restaurant menu: ");
                int.TryParse(Console.ReadLine(), out int useroption);
                switch (useroption)
                {
                    case 0: 
                        keepgoing = false;
                        break;
                    case 1:
                        restaurantService.Add();
                        break;
                    case 2:
                        restaurantService.GetAll();
                        break;
                    case 3:
                        restaurantService.GetById();
                        break;
                    case 4:
                        restaurantService.Update();
                        break;
                    case 5:
                        restaurantService.Delete();
                        break;
                    default:
                        Console.WriteLine("Not valid option!");
                        break;
                }
            }
            while (keepgoing);
        }

        public void ShowProductMenu()
        {
            IProductService productService = new ProductService();
            Console.WriteLine("1.Add product\n2.Get All products\n3.Get a product by ID\n4.Update a product\n5.Delete a product.\nExit");
            bool keepgoing = true;
            do
            {
                Console.WriteLine("Chooce option for product menu: ");
                int.TryParse(Console.ReadLine(), out int useroption);
                switch (useroption)
                {
                    case 0: keepgoing = false; 
                        break;
                    case 1:
                        productService.Add();
                        break;
                    case 2:
                        productService.GetAll();
                        break;
                    case 3:
                        productService.GetByID();
                        break;
                    case 4:
                        productService.Update();
                        break;
                    case 5:
                        productService.Delete();
                        break;
                    default:
                        Console.WriteLine("Not valid option!");
                        break;
                }
            }
            while (keepgoing);

        }
    }
}
