using System;

namespace ConversaoImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int b;

            a = 5.1;
            b = (int)a; //forçar uma conversão implicita;

            Console.WriteLine(b);


        }
    }
}
