using BoltFood.Data.Repositories.Implementation;
using BoltFood.Service.Services.Implementation;
using BoltFood.Service.Services.Interface;

MenuService menu = new MenuService();
menu.ShowMenu();

IProductService service = new ProductService();
service.Add();
service.GetAll();
