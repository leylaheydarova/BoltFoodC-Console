using BoltFood.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Service.Services.Interface
{
    public interface IRestaurantService
    {
        public void Add();
        public void Update();
        public void Delete();
        public void GetAll();
        public void GetById();
    }
}
