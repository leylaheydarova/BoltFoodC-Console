using BoltFood.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Service.Services.Interface
{
    public interface IProductService
    {
        public void Add();
        public void Delete();
        public void GetByID();
        public void GetAll();
        public void Update();     
    }
}
