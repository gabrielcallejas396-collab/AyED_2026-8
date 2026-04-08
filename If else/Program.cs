using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("cantidad de midiclorianos");
         int n = Convert.ToInt32(Console.ReadLine());
         if (n > 15000)
            {
             Console.WriteLine("Potencial Maestro Jedi detectado. Avisar al Consejo");
            }
         else
            {
             if (n > 4999 & n < 1501)
                {
                 Console.WriteLine("Aceptable para entrenamiento Padawan");
                }
                else
                {
                 Console.WriteLine("No posee sensibilidad a la Fuerza");
                }
            }
        }
    }
}
