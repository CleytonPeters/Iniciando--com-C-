using System;
using System.Collections.Generic;

namespace Aula76List {
    class Program {
        static void Main(string[] args) {


            List<string> lista = new List<string>();
            List<string> lista2 = new List<string> {"Maria", "Joao"}; //outra forma de inserir informações na lista
            lista.Add("Joao");
            lista.Add("Luana");
            lista.Add("Alex");
            lista.Add("Bruna");
            lista.Add("Anna");
            lista.Add("SuperMan");
            lista.Add("Samara");
            lista.Add("Suelen");
            lista.Add("Sandra");
            lista.Add("Sabino");
            lista.Insert(0, "Marcos"); //insere na posição desejada (Posição, "string")
            

            foreach(string obj in lista) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Lista.Count:  " + lista.Count);


        
            string s1 = lista.Find(Procure); //usa o Find e chama o método bool Procure.
            Console.WriteLine("First 'A': " + s1);

            string s2 = lista.Find(x => x[0] == 'B'); //lambda ->   objeto X tal que X[na posição 0] seja igual caracter 'A'
            Console.WriteLine("Achar por lambda = " + s2);

            string s3 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima ocorrência: "+ s3);

            int posit = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição com FindIndex com 'A': " + posit);
            posit = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima Posição a ser chamada com FindLastIndex: " + posit);

            Console.WriteLine("________________________________________________");

            List<string> lista3= lista.FindAll(x => x.Length >= 5);
            foreach(Object obj in lista3) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("________________________________________________");

            lista.Remove("Anna"); //remover Anna;
            foreach(string obj in lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("________________________________________________");
            lista.RemoveAt(1); //remover da posicao 1;
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("________________________________________________");
            lista.RemoveRange(0, 3); //remover da posição n a n;
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("________________________________________________");

            lista.RemoveAll(x => x[0] == 'S');
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }


        }
            static bool Procure(string s) {
                return s[0] == 'A'; //Procura por A na primeira posição[0] de qualquer posição existente da lista.
            }




    }
}
