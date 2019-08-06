using System;
using _115_OrderEnum.Entities.Enums;
using _115_OrderEnum.Entities;

namespace _115_OrderEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1503,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,

            };

            Console.WriteLine("Id: " +order.Id);
            Console.WriteLine("Status: " + order.Status);
            Console.WriteLine("Consulting at: " + order.Moment);


            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine("String: " + txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //transforma txt para enum
            Console.WriteLine(os);

        }
    }
}
