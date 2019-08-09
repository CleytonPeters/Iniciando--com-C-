using System;
using System.Collections.Generic;
using System.Text;

namespace Aula122_ExercicioProposto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Name);
            str.Append(", ");
            str.Append(Price);
            return str.ToString();
        }

    }
}
