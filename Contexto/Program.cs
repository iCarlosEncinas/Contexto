using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Contexto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Matemáticas matemáticas = new Matemáticas();
            double sumando1 = 10;
            double sumando2 = 43;
            double resultado = Matemáticas.sumar(sumando1 , sumando2);

            Console.WriteLine(sumando1.ToString() + " + " + sumando2.ToString() + " = " + resultado.ToString());
            Console.WriteLine("PI: " + Matemáticas.PI);
            //Matemáticas.PI = 95;
            double radio = 3.67;
            Console.WriteLine("Radio: " + radio.ToString() + ", Area: " + Matemáticas.areaCirculo(radio));
            
            Console.ReadKey();


        }
    }
}
