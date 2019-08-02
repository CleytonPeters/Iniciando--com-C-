using System;
using System.Globalization;

namespace Aula90_DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine(date.ToUniversalTime());
            Console.WriteLine(date.Ticks + "\n");

            DateTime d1 = new DateTime(2019, 08, 02);
            DateTime d2 = new DateTime(2019, 08, 02, 16, 09, 3); //ano, mes, dia, hora, minuto, segundo.

            Console.WriteLine(d1);
            Console.WriteLine(d2+"\n");

            DateTime p1 = DateTime.Parse("2012-07-22");
            DateTime p2 = DateTime.Parse("2012-07-22 22:00:05");
            DateTime p3 = DateTime.Parse("1993-07-22 02:55:00");

            DateTime formato = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine("Formato escolhido: " + formato);
            
        }
    }
}
