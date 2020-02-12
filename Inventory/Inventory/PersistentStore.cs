using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory
{
    public class PersistentStore : Store, IStorageCapable
    {
        public List<Product> GetAllProduct()
        {
            return LoadProducts();
        }

        public void StoreBookProduct(string name, int price, int pages)
        {
            Product newProduct = CreateProduct("Book", name, price, pages);
            DoStore(newProduct);
        }

        public void StoreCdProduct(string name, int price, int tracks)
        {
            Product newProduct = CreateProduct("CD", name, price, tracks);
            DoStore(newProduct);
        }

        protected override void StoreProduct(Product product)
        {
            _productList.Add(product);
        }
    }
}
