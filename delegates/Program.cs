using System;
using System.Collections.Generic;
using delegates.Entities;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(p => p.Price >= 100.0);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
