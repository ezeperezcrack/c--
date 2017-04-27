using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Clase08
{
    class Program
    {
        static void Main(string[] args)
        {
           // Tempera temp1 = new Tempera(ConsoleColor.Blue, " azul ",1);
            
           // Tempera temp3 = new Tempera(ConsoleColor.Black, " negro ",3);
            //Tempera temp2 = new Tempera(ConsoleColor.Red, " rojo ",2);
            Stack Pila = new Stack();
            
            /*
            Pila.Push(temp1);
            Pila.Push(temp2);
            Pila.Push(temp3);
            
         
            Queue cola = new Queue();
            int i = 0;
            cola.Enqueue(temp1);
            cola.Enqueue(temp2);
            cola.Enqueue(temp3);
            
            
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine((string)(Tempera)cola.Dequeue());
                Console.ReadLine();
            }
            */
            ArrayList lista = new ArrayList();
            /*
            for (int i=0;i<5;i++)
            {
                lista.Add(i+1);
            }
            lista.Reverse();
            foreach (int j in lista)
                Console.WriteLine("{0}", j);
            Console.ReadLine();
            lista.Sort();
            foreach (int j in lista)
                Console.WriteLine("{0}", j);
            Console.ReadLine();
             
            lista.Add(temp1);
            lista.Add(temp2);
            lista.Add(temp3);

            lista.Sort();
            foreach (Tempera j in lista)
                Console.WriteLine("{0}",(string)(Tempera) j);
            Console.ReadLine();
            */
            Hashtable ht = new Hashtable();
            ht.Add("valor1", 1);
            ht.Add("valor3", 3);
            ht.Add("valor2", 2);

            foreach (object j in ht.Keys)
                Console.WriteLine("{0}", ht[j]);
            Console.ReadLine();
            

        }
    }
}
