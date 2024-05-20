using BoltFood.Core.Models;
using BoltFood.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Data.Repositories.Implementation
{
    internal class GenericRepository<T> where T : BaseEntity
    {
        private static List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(int id)
        {
            Product product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            foreach (Product product in _products)
            {
                if (product.ID == id)
                {
                    return product;
                }
            }
            throw new Exception("Product is not found.");
        }

        public void Update(int id, Product product)
        {
            Product product1 = GetById(id);
            if (product1 != null)
            {
                product1 = product;
            }
        }
    }
}
