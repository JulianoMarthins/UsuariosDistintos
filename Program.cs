using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosDistintos.entities;

namespace UsuariosDistintos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            
            string path = @"D:\WorkSpace\UsuariosDistintos\Usuarios.txt";

            try {
                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] vetor = sr.ReadLine().Split(' ');
                        string name = vetor[0];
                        DateTime instant = DateTime.Parse(vetor[1]);

                        set.Add(new LogRecord(name, instant));
                    }
                }

                Console.WriteLine("Total Users: " + set.Count);

            }
            catch(IOException e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
