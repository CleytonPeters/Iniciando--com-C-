using System;

namespace Aula71ExercicioDeFixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] rent = new Aluguel[9];

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Rent #" + i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                if (rent[room] == null) {
                    rent[room] = new Aluguel { Name = name, Email = email, Room = room };
                } else {
                    Console.WriteLine("Quarto ocupado, escolha outro!");
                    room = int.Parse(Console.ReadLine());
                    rent[room] = new Aluguel { Name = name, Email = email, Room = room };
                }
            }
            if (n == 1) {
                Console.WriteLine("Busy room: ");
            } else {
                Console.WriteLine("Busy rooms: ");
            }
            for(int i = 0; i < rent.Length; i++) {
                if(rent[i] != null) {
                    Console.WriteLine(rent[i]);
                }
            }           



        }
    }
}
