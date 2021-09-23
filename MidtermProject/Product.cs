using System;
using System.Collections.Generic;
using System.IO;

namespace MidtermProject
{
    public class Product
    {
        public List<string> Drinks = new List<string>();
        public List<string> Prices = new List<string>();

        public void ReadProductList()
        {
            using (var reader = new StreamReader(@".\ProductList.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Drinks.Add(values[0]);
                    Prices.Add(values[1]);
                }
            }

            Console.WriteLine(Drinks);
        }
    }
}
