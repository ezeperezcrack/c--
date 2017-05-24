using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        public Persona(string n, string a, int e, ESexo s)
        {
            this._nombre = n;
            this._apellido = a;
            this._edad = e;
            this._sexo = s;
        }

        public string Nombre
        {get { return "Nombre: " + this._nombre; } }
        public string Apellido
        { get { return "Apellido: " + this._apellido; } }
        public int Edad
        { get { return this._edad; } }
        public string Sexo
        { get { return "Sexo: " + this._sexo; } }

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
