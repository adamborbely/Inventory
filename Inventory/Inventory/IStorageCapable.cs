using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    interface IStorageCapable
    {
        List<Product> GetAllProduct();
        void StoreCdProduct(string name, int price, int tracks);
        void StoreBookProduct(string name, int price, int pages);
    }
}
