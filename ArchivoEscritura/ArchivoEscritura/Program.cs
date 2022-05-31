using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivoEscritura
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);

                string[] lines =
            {
                "Esta linea es nueva",
            "Esta es la segunda linea"
            };
           foreach(string line in lines)
            {
                sw.WriteLine(line);//Escribe en el archivo
            }
            sw.Close();

            Console.WriteLine("Escribiendo en el archivo....");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
