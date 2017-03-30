using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eze
{
    class Program
    {
        static void Main(string[] args)
        {
            int var=0,i=0,max=0,min=0, acumulador=0;
            float promedio;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un numero");
                var = int.Parse(Console.ReadLine());
                acumulador = acumulador + var;
                if (i == 0)
                {
                    max = var;
                    min = var;
                }
                else if (var > max)
                {
                    max = var;
                }
                else if (var < min)
                {
                    min = var;
                }
            }
            promedio = (float)acumulador / 5;
            Console.WriteLine("el maximo es {0} el minimo es {1} el promedio es {2}", max,min,promedio);
            Console.Read();
        }
    }
}
