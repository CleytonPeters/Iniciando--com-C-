using System;

namespace Aula87_SintaxeAlternativa_SwitchCase {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter a number from week: ");
            int number = int.Parse(Console.ReadLine());
            string day;

            switch(number) {
                case 1:
                    day = "Sunday.";
                    break;
                case 2:
                    day = "Monday.";
                    break;
                case 3:
                    day = "Tuesday.";
                    break;
                case 4:
                    day = "Wednesday.";
                    break;
                case 5:
                    day = "Thursday.";
                    break;
                case 6:
                    day = "Friday.";
                    break;
                case 7:
                    day = "Saturday.";
                    break;
                default:
                    day = "Dia inválido.";
                    break;
            }
            Console.WriteLine("Day: " + day);
        }
    }
}
