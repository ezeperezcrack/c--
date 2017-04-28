using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnitos
{
    class Obrero:Persona
    {
        private int _legajo;
        private float _sueldo;

        public Obrero(string a, int b, string c):base(a,c,b)
        {
        }

        public Obrero(string a, int b, string c, int d, float e)
            : this(a, b, c)
        {
            this._legajo = d;
            this._sueldo = e;
        }
        public static string Mostrar(Obrero ob)
        {
            return ob.Mostrar() + " legajo " + ob._legajo.ToString() +" sueldo "+ ob._sueldo.ToString();
        }
    }
}
