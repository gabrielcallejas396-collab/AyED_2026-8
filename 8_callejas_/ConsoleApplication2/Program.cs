using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string pelicula;
            Console.WriteLine("Hola wachin");
            Console.Write("como te llamas wachin?: ");
            nombre = Console.ReadLine();
            Console.Write("cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();
            Console.WriteLine("hola " + nombre + ".Tu pelicula favorita " + pelicula + " es una porqueria.");
        }
    }
}
