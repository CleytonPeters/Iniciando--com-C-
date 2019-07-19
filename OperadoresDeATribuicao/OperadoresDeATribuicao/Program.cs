using System;

namespace OperadoresDeATribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a -= 2;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 2;
            Console.WriteLine(a);
            a %= 2;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);


            Console.WriteLine();

            int variavel1 = 10;
            Console.WriteLine(variavel1);
            int variavel2 = variavel1++;
            int variavel3 = ++variavel1;
            Console.WriteLine(variavel1);
            Console.WriteLine(variavel2);
            Console.WriteLine(variavel3);

        }
    }
}
