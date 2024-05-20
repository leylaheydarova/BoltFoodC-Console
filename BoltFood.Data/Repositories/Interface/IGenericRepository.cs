using BoltFood.Core.Models;
using BoltFood.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Data.Repositories.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public void Add(Restaurant restaurant);
        public void Update(int id, Restaurant restaurant);
        public void Delete(int id);
        public List<Restaurant> GetAll();
        public Restaurant GetById(int id);
    }
}
