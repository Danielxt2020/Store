using System;
using System.Globalization;
using System.Collections.Generic;
using Store.Entities;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char cha = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (cha == 'i')
                {
                    Console.Write("Customs fee:");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (cha == 'c')
                {

                    list.Add(new Product(name, price));
                }
                else if (cha == 'u')
                {

                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufacture));

                }
            }

                
                Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach ( Product go in list)
                {
                    Console.WriteLine(go.PriceTag());
                }
            }
        }
    }


