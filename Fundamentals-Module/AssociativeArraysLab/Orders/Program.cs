using System;
using System.Collections.Generic;

namespace Orders
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product(string name,double price,int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();

            string line = Console.ReadLine();
            while (line != "buy")
            {
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string productName = input[0];
                double productPrice =double.Parse( input[1]);
                int productQuantity = int.Parse(input[2]);

                Product newProduct = new Product(productName, productPrice, productQuantity);
                productsList.Add(newProduct);
                for (int i = 0; i < productsList.Count; i++)
                {
                    for (int j = i+1; j < productsList.Count; j++)
                    {
                        if (productsList[i].Name == productsList[j].Name)
                        {
                            productsList[i].Price = productsList[j].Price;
                            productsList[i].Quantity += productsList[j].Quantity;
                            productsList.RemoveAt(j);
                        }
                    }
                }

                line = Console.ReadLine();  
            }

                Dictionary<string, double> result = new Dictionary<string, double>();
                foreach (var product in productsList)
                {
                    string name = product.Name;
                    double totalPrice = (product.Price * product.Quantity);
                    result.Add(name, totalPrice);
                }
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
                }


        }
    }
}
