using System;

namespace Aula94_DateTimeKindeIso8601 {
    class Program {
        static void Main(string[] args) {


            DateTime d1 = DateTime.UtcNow;

            Console.WriteLine(d1 + " UtcNow");
            Console.WriteLine(d1.ToLocalTime() +" ToLocalTime ");
            Console.WriteLine(d1.ToUniversalTime() +" ToUniversalTime \n\n");

            DateTime d2 = new DateTime(2014, 01, 11, 10, 30, 00, DateTimeKind.Local);
            Console.WriteLine(d2);
            DateTime d3 = new DateTime(2014, 01, 11, 10, 30, 00, DateTimeKind.Utc);
            Console.WriteLine(d3);
            DateTime d4 = new DateTime(2014, 01, 11, 10, 30, 00);
            Console.WriteLine(d4);
            Console.WriteLine();

            DateTime t1 = DateTime.Parse("2000-08-15 13:05:58"); //pega data normal
            DateTime t2 = DateTime.Parse("2000-08-15T13:05:58Z"); //transforma hora local
            Console.WriteLine(t1);
            Console.WriteLine(t2);



        }
    }
}
