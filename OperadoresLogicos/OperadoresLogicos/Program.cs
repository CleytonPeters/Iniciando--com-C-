using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = 2 == 2 && 3 != 4;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
