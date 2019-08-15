using System;
using System.IO;

namespace Aula_141_Finally_LeituraDeDadosComFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"c:\doc.txt";
            FileStream fs = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);

                if (myStreamReader.Peek() >= 0)
                {
                    string line = myStreamReader.ReadLine();
                }

            }
            catch(FileNotFoundException e) {
                Console.WriteLine(e.Message);
            } finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
