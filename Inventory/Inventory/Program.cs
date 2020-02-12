using System;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var storemanager = new StoreManager();
            storemanager.AddStorage(new PersistentStore());
            storemanager.AddBookProduct("Maki", 200, 342);
            storemanager.AddBookProduct("Makos", 345, 341);
            storemanager.AddCDProduct("Lajhar Lajko", 546, 12);
            storemanager.AddCDProduct("Lajhar", 345, 12);
            Console.WriteLine(storemanager.ListProducts());
            Console.WriteLine(storemanager.GetTotalProductPrice());

        }
    }
}
