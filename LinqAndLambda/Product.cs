using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Product
    {
        public string catagory;
        public string name;
        public int stock;
        public Product(string Catagory, string Name, int Stock)
        {
            catagory = Catagory;
            name = Name;
            stock = Stock;
        }
    }
}
