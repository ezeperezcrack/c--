using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Clase15
{
    public class Herencia:PersonaExterna
    {
        public Herencia(string n, string a, int e, Entidades.Externa.ESexo s) :base(n,a,e,s)
        {

        }

        public string Nombre
        {get { return "Nombre: " + base._nombre; } }
        public string Apellido
        { get { return "Apellido: " + base._apellido; } }
        public int Edad
        { get { return base._edad; } }
        public string Sexo
        { get { return "Sexo: " + base._sexo; } }

        public void obtenerInfo()
        {
            Console.WriteLine("Edad: {0}", this.Edad);
            Console.WriteLine(this.Apellido);
            Console.WriteLine(this.Nombre);
            Console.WriteLine(this.Sexo);
            Console.ReadLine();
        }
    }
}
