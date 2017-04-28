using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnitos
{
    class Persona
    {
        protected string _nombrePe;
        protected string _apellidoPe;
        protected int _dniPe;

        
        public Persona(string a, string b, int c)
        {
            this._nombrePe = a;
            this._apellidoPe = b;
            this._dniPe = c;
        }

        public string Mostrar()
        {
            return "nombre " + this._nombrePe + " apellido " + this._apellidoPe + " Dni " + this._dniPe.ToString();
        }
    }
}
