using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("estacionemiento EL CHIQUI TAPIA");
            Console.Write("minutos en el estacionamiento: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            double horas = (double)minutos / 60;
            Console.Write.Line("horas en el estacionamiento " + horas);

        }
    }
}
