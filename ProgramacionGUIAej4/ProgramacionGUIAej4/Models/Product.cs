using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionGUIAej4.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Id {get; set;}
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product() { }
        public Product(string name, int id, double price, int stock)
        {
            this.Name = name;
            this.Id = id;
            this.Price = price;
            this.Stock = stock;
        }



    }
}
