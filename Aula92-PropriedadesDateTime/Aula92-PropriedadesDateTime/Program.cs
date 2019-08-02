using System;
using System.Globalization;

namespace Aula92_PropriedadesDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime date = new DateTime(2014, 07, 11, 14, 35, 28);
            Console.WriteLine("Day: " + date.Day);
            Console.WriteLine("Month: " + date.Month);
            Console.WriteLine("Year: " + date.Year);
            Console.WriteLine();
            Console.WriteLine("DayOfYear: " + date.DayOfYear);
            Console.WriteLine("DayOfWeek: " + date.DayOfWeek);
            Console.WriteLine("date.Date: " + date.Date);
            Console.WriteLine("just: date: " + date);
            Console.WriteLine();

            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());

            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());

            string s6 = date.ToString("yyyy-MM-dd HH-mm-ss");
            Console.WriteLine(s6 + "\n\n");

            DateTime data = new DateTime(2001, 08, 22, 13, 30, 00);

            DateTime d1 = data.AddHours(70.5);
            Console.WriteLine(data);
            Console.WriteLine(d1 + "\n");


            DateTime dataInicio = new DateTime(2000, 10, 02);
            DateTime dataFim = new DateTime(2000, 10, 08);

            TimeSpan tempo = dataFim.Subtract(dataInicio); //transforma em TimeSpan por ser tempo.

            Console.WriteLine("Dias trabalhados: " + tempo.Days);
            
        }
    }
}
