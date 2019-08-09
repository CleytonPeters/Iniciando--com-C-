using System;
using System.Collections.Generic;
using Aula122_ExercicioProposto.Entities.Enum;

namespace Aula122_ExercicioProposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double Total()
        {
            return 0;
        }

       


    }
}
