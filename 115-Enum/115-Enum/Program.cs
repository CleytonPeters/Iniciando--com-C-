using System;
using _115_Enum.Entities.Enums;
using _115_Enum.Entities;

namespace _115_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Id = 2322;
            order.Moment = DateTime.Now;
            order.Status = OrderStatus.Shipped;

            Console.WriteLine(order);

        }
    }
}
