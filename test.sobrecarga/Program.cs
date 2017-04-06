using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades.sobrecarga;
//ConsoleColor.DarkBlue, Etipo.conbrillito 



namespace test.sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            entidades.sobrecarga.tinta a= new entidades.sobrecarga.tinta();
            entidades.sobrecarga.tinta b = new entidades.sobrecarga.tinta(ConsoleColor.DarkBlue);
            entidades.sobrecarga.tinta c = new entidades.sobrecarga.tinta(ConsoleColor.DarkGreen,Etipo.conbrillito);
            Pluma plum = new Pluma("faber", 1, a);
            plum = plum + a;


            //operador "explicit" defino una tinta sin instanciar (" tinta t ") y asigno t= (tinta)plum
            //operador "-" plum = plum - a;  

            Console.WriteLine(plum);
           if (plum == a)
           {
               Console.WriteLine("son iguales");
           }
           else
           {
               Console.WriteLine("son distintas");
           }
            
           Console.ReadLine();


        }
    }
}
