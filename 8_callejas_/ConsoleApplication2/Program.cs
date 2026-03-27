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
            string juego;
            string consola;
            Console.WriteLine("Hola wachin");
            Console.Write("como te llamas wachin?: ");
            nombre = Console.ReadLine();
            Console.Write("cual es tu juego favorito?: ");
            juego = Console.ReadLine();
            Console.Write("en que consola se juega?: ");
            consola = Console.ReadLine();
            Console.WriteLine("hola " + nombre + ".Tu juego favorito es " + juego + " y se juega en " + consola + "." );
        }
    }
}
