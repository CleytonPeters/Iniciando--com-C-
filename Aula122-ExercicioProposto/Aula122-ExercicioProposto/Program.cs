using System;
using System.Collections.Generic;
using Aula122_ExercicioProposto.Entities;
using Aula122_ExercicioProposto.Entities.Enum;

namespace Aula122_ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string client = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus> (Console.ReadLine());

            Client cliente = new Client(client, email, date);

                     
            Console.Write("How many items to this order: ");
            int N = int.Parse(Console.ReadLine());
            Order nameItem = new Order();
            OrderItem qtd = new OrderItem();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                qtd = new OrderItem(quantity, price);
                qtd.AddProduct(name, price);               
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + DateTime.Now);
            Console.WriteLine("Order status: " + status);
            Console.WriteLine("Client: " + client + " (" + date + ") " + " - " + email);
            Console.WriteLine("Order items:");
            Console.WriteLine(qtd);
           
        }
    }
}
