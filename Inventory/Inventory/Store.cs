using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Inventory
{
    [XmlRoot("Products")]
    [XmlInclude(typeof(PersistentStore))]
    [XmlInclude(typeof(BookProduct))]
    [XmlInclude(typeof(CDProduct))]
    public abstract class Store
    {
        private string path = "products.xml";
        protected List<Product> _productList;
        public List<Product> ProductList { get { return _productList; } }

        public Store()
        {
            _productList = new List<Product>();
        }

        private void SaveToXML(Product product)
        {
            using (Stream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(Store));
                serializer2.Serialize(fs, this);
            }
        }
        protected abstract void StoreProduct(Product product);
        protected Product CreateProduct(string type, string name, int price, int size)
        {
            if (type == "Book")
            {
                return new BookProduct(name, price, size);
            }
            else if (type == "CD")
            {
                return new CDProduct(name, price, size);
            }
            else
            {
                throw new Exception();
            }
        }
        public List<Product> LoadProducts()
        {
            return _productList;
        }
        public void DoStore(Product product)
        {
            StoreProduct(product);
            SaveToXML(product);
        }
    }
}
