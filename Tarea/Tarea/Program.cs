using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tarea
{
    //Clase
    class Persona
    {
        //Atributos de la clase
        public string nombre;
        public string apellidoP;
        public string apellidom;
        public int edad;

        //Constructor de la clase
        public Persona(string nombre, string apellidoP, string apellidom, int edad)
        {
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidom = apellidom;
            this.edad = edad;
        }
        //CLase de impresion
        public void Impresion()
        {
            Console.WriteLine("-Impresion de los datos-");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido paterno: " + apellidoP);
            Console.WriteLine("Apellido materno: " + apellidom);
            Console.WriteLine("Edad: " + edad);
        }
    
    }
        class Program
        {
            static void Main(string[] args)
            {
                //Variables
                string nombre, apellidop, apellidom;
                int edad;
                //Captura de datos
                Console.WriteLine("-Captura de datos de la persona-");
                Console.Write("\nIngrese nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese apellido paterno: ");
                apellidop = Console.ReadLine();
                Console.Write("Ingrese apellido materno: ");
                apellidom = Console.ReadLine();
                Console.Write("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
                //Creacion del objeto
                Persona per = new Persona(nombre, apellidop, apellidom, edad);
                Console.WriteLine("\nIngrese ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();

                //Ejecucion del metodo
                per.Impresion();
                Console.WriteLine("\nIngrese ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();

                //Creacion del documento
                StreamWriter sw = new StreamWriter("Datos.txt", true);
                //Impresion en txt
                sw.WriteLine("\nNombre: "+per.nombre + "\nApellido Paterno: " + per.apellidoP + "\nApellido Materno: " + per.apellidom + "\nEdad: " + per.edad);
                
                sw.Close();

                Console.WriteLine("Escribiendo en el archivo....");
                Console.ReadLine();

            }
        }
    
}

