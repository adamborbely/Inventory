using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public abstract class Product
    {
        protected string _name;
        protected int _price;
        public int Price { get { return _price; } set { } }
        public string Name { get { return _name; } set { } }
        public Product()
        {

        }
    }
}
