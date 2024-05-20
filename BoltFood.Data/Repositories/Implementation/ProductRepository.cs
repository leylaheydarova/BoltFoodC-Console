using BoltFood.Core.Models;
using BoltFood.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Data.Repositories.Implementation
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
       
    }
}
