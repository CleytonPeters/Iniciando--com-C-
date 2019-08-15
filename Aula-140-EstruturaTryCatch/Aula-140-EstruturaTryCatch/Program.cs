using System;

namespace Aula_140_EstruturaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

            
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int result = x / y;

            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! Division by zero.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }                       
        }
    }
}
