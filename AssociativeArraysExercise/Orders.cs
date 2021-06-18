﻿using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] currProduct = command.Split();
                string productName = currProduct[0];
                double productPrice = double.Parse(currProduct[1]);
                double quantity = double.Parse(currProduct[2]);

                if (output.ContainsKey(productName) == false)
                {
                    List<double> priceAndQuantity = new List<double> { productPrice, quantity };
                    output.Add(productName, priceAndQuantity);
                    //similar to: output.Add(productName, new List<double> {productPrice, quantity};)
                }
                else
                {
                    output[productName][0] = productPrice;
                    output[productName][1] += quantity;
                }
                command = Console.ReadLine();
            }

            foreach (var item in output)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}