using BoltFood.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltFood.Core.Models
{
    public class Restaurant:BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Product>? Products { get; set; }

        public Restaurant()
        {
            Products = new List<Product>();
        }
        public override string ToString()
        {
            return "Id: " + ID + "Name: " + Name + "Address: " + Address;
        }
    }
}
