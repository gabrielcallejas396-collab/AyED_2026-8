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
            Console.WriteLine("estacionemiento EL CHIQUI TAPIA");
            Console.Write("minutos en el estacionamiento: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
            int horas = minutos / 60;
            int resto = minutos - 60 * horas;
            int ph = horas * 6000;
            int mh = minutos * 150;
            int to = mh + ph;
            int total = (to * 21) / 100 ;
            Console.WriteLine("horas en el estacionamiento " + horas + " minutos " + resto + " el total a pagar es: " + total );
        }
    }
}
