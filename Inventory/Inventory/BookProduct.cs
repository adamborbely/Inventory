using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class BookProduct : Product
    {
        private int _numOfPages;
        public int NumOfPages { get { return _numOfPages; } set { } }
        public BookProduct()
        {

        }
        public BookProduct(string name, int price, int pages)
        {
            _name = name;
            _price = price;
            _numOfPages = pages;
        }
    }
}
