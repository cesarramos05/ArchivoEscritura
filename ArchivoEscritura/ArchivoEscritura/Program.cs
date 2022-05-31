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
            //StreamWriter sw = new StreamWriter("ejemplo.txt", true);

            string[] t = new string[1];
            string nom;
            Console.WriteLine("Ingrese nombre; ");
            nom = Console.ReadLine();
            t[0] = nom;

           using (StreamWriter writer = new StreamWriter("Nombres.txt", true))
            {
                for(int i = 0; i <t.Length; i++)
                {
                    writer.WriteLine(t[i].ToString());
                }
                writer.Close();

            }
            

                /* string text;
                 Console.WriteLine("Captura nombre a guardar: ");
                 text = Console.ReadLine();

                    /* string[] lines =
                 {
                     "Esta linea es nueva",
                 "Esta es la segunda linea"
                 };
                foreach(string line in lines)
                 {
                     sw.WriteLine(line);//Escribe en el archivo
                 }*/
                //sw.Close();

            Console.WriteLine("Escribiendo en el archivo....");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
