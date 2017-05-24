using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Clase15
{
    public static class ClaseEstatica
    {
        public static void ObtenerInfo(this PersonaExternaSellada p)
        {
            Console.WriteLine("Edad: {0}", p.Edad);
            Console.WriteLine(p.Apellido);
            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Sexo);
            Console.ReadLine();
        }

        public static int CantidadDeLetras(this string s)
        {
            return s.Length;
        }
    }
}
