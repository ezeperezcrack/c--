using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase15;

namespace ConsoleApplication1
{
    class Program
    {   
        static void Main(string[] args)
        {
            
            Persona p = new Persona("nombre","apellido",8,ESexo.Indeterminado);
            Herencia pe = new Herencia("nombre2", "apellido2", 18, Entidades.Externa.ESexo.Indefinido);
            pe.obtenerInfo();
            Entidades.Externa.Sellada.PersonaExternaSellada algo = new Entidades.Externa.Sellada.PersonaExternaSellada("algo","algo",28,Entidades.Externa.Sellada.ESexo.Femenino);
            algo.ObtenerInfo();

            string hola = "hola";
            Console.WriteLine(hola.CantidadDeLetras());
            Console.ReadLine();
        }
    }
}
