using System;
using System.Collections.Generic;
using System.IO;

namespace MidtermProject
{
    public class Product
    {
        public List<string> Drinks = new List<string>();
        public List<string> Prices = new List<string>();

        public string ReadProductList()
        {

            string path = @"C:\Users\seanf\source\repos\splamb\MidtermProject\MidtermProject\ProductList.txt";

            string[] readText = File.ReadAllLines(path);
            foreach(string s in readText)
            {
                Console.WriteLine(s);
            }

            return null;
        }
    }
}
