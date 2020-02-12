using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    class StoreManager
    {
        private IStorageCapable _storageCapable;

        public void AddStorage(IStorageCapable storageCapable)
        {
            this._storageCapable = storageCapable;
        }
        public void AddCDProduct(string name, int price, int tracks)
        {
            _storageCapable.StoreCdProduct(name, price, tracks);
        }
        public void AddBookProduct(string name, int price, int pages)
        {
            _storageCapable.StoreBookProduct(name, price, pages);
        }
        public string ListProducts()
        {
            var fullList = _storageCapable.GetAllProduct();
            var nameList = new List<string>();
            foreach (var product in fullList)
            {
                nameList.Add(product.Name);
            }
            var result = string.Join(", ", nameList);
            return result;
        }
        public int GetTotalProductPrice()
        {
            var result = 0;
            var fullList = _storageCapable.GetAllProduct();
            foreach (var product in fullList)
            {
                result += product.Price;
            }
            return result;
        }
    }
}
