using System;
using Aula_142_Criando_Exceções_Personalizadas.Entities.Exceptions;
using Aula_142_Criando_Exceções_Personalizadas.Entities;

namespace Aula_142_Criando_Exceções_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservartion = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reservartion);

                Console.WriteLine("\nEnter date to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine()); Console.Write("Check-in date (");
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservartion.UpdateDates(checkin, checkout);
                Console.WriteLine(reservartion);
            } catch(DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }

        }
    }
}
