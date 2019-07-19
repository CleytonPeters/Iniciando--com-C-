using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            bool completo = false;
            char genero = 'F';
            sbyte x = 100;
            byte n1 = 255;
            int n2 = 2147483647;
            long n3 = 2147483648L;
            float n5 = 4.5f; //necessita do f.
            double n6 = 4.5;
            string nome = "Maria Green";
            Object obj1 = "Alex Brow";
            Object obj2 = 4.5f;

            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(n2);  //escrever cw tab tab ele completa.
            Console.WriteLine(n3);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("_____________________________________");
            Console.WriteLine("");

            int j1 = int.MinValue;
            int j2 = int.MaxValue;
            decimal j3 = decimal.MaxValue;
            Console.WriteLine(j1);
            Console.WriteLine(j2);
            Console.WriteLine(j3);

        }
    }
}
