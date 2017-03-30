using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerezEzequielEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int var = 10, i=0, h=0, color =0;
           /* Console.WriteLine("ingrese un numero");
            var = int.Parse(Console.ReadLine());
            */
            for(i=0;i<var;i++)
            {
                if (color >2)
                    color = 0;

                switch (color)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }
                    if (i > 0)
                    {
                        for (h = 0; h < i; h++)
                        {
                            Console.Write("**");
                        }
                    }
                Console.WriteLine("*");
                color++;
            }
            Console.Read();
        }
    }
}
