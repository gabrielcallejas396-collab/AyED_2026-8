using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("los kg son ");
         int kg = Convert.ToInt32(Console.ReadLine());
         int resto = kg - 5000;
         if (kg <= 5000)
            {
                Console.WriteLine("Despegue autorizado. Buen viaje, mando");
            }
         else
            {
             Console.WriteLine("Alerta: Exceso de peso.Debes descargar " + resto +  " kg para despegar");
            }
        }
    }
}
