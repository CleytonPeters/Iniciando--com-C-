using System.Globalization;
using System.Collections.Generic;
using System.Text;
namespace Aula122_ExercicioProposto.Entities
{
    class OrderItem
    {

        public int Quantity { get; set; }
        public double Price { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public void AddProduct(string name, double price)
        {
            Products.Add(new Product(name, price));
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

        double sum = 0;
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Products);
            str.Append(", ");
            str.Append(Quantity);
            str.Append(", ");
            foreach(Product x in Products)
            {
                str.Append("Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                sum += SubTotal();
            }
            str.Append("Total Price: " + sum);
            return str.ToString();

        }


    }
}
