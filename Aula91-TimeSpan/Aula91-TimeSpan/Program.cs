using System;

namespace Aula91_TimeSpan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1 = new TimeSpan(0, 1, 30); //hora - min - segundo
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(20, 10, 55, 00);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4+"\n\n");


            TimeSpan t5 = TimeSpan.FromDays(1.5);
            TimeSpan t6 = TimeSpan.FromHours(1.5);
            TimeSpan t7 = TimeSpan.FromMinutes(1.5);

            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
        }
    }
}
