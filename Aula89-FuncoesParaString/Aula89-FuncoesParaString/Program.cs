using System;

namespace Aula89_FuncoesParaString {
    class Program {
        static void Main(string[] args) {

            string original = "abcd EFGH iJkcdL YZF    ";
            string email = "cleytonpeters@teste.com.br";

            string Mainusculo = original.ToUpper();
            string s2 = original.ToLower();
            string DeletarEspaco = original.Trim();
            int FirstLocal = original.IndexOf("cd");
            int o = original.LastIndexOf("cd");
            string CortarInicio = original.Substring(3);
            string Corte2Pontos = original.Substring(3, 5);
            string TrocarCaracter = original.Replace('c', '5');
            string TrocaString = email.Replace("teste.com.br", "gmail.com");
            bool NullOrEmpty = string.IsNullOrEmpty(email);
            bool NullOrWhiteSpace = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original -" + original + "-");
            Console.WriteLine("ToUpper: -" + Mainusculo + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + DeletarEspaco + "-");
            Console.WriteLine("IndexOf: ('cd'): -" + FirstLocal + "-");
            Console.WriteLine("LastIndexOf: ('cd'): -" + o + "-");
            Console.WriteLine("Substring: -" + CortarInicio + "-");
            Console.WriteLine("Substring: (3, 5) -" + Corte2Pontos + "-");
            Console.WriteLine("Replace (c por 5) -" + TrocarCaracter + "-");
            Console.WriteLine("TrocaString: " + TrocaString);
            Console.WriteLine("É Null ou Empty? Bool: " + NullOrEmpty);
            Console.WriteLine("É Null ou Espaço em Branco?  " + NullOrWhiteSpace);
        }
    }
}
