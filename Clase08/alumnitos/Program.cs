using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Obrero ob = new Obrero("carlos", 3, "perez", 8, 12.3f);
            Alumno pe = new Alumno("eze", "cholo", 5,"H");
            List<Persona> lista = new List<Persona>();
            lista.Add(ob);
            lista.Add(pe);
            foreach (Persona p in lista)
            {
                if (p is Obrero)
                { 
                    Console.WriteLine(Obrero.Mostrar((Obrero)p));
                } else if(p is Alumno )
                {
                    Console.WriteLine(((Alumno)p).Mostrar());
                }                                  
                Console.ReadLine();
                
            }

        }
    }
}
