using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnitos
{
    class Alumno : Persona
    {

        private List<float> _notas;
        private string _curso;

        public Alumno(string a, string b, int c):base(a,b,c)
        {
            this._notas = new List<float>();
        }
        
        public Alumno(string a, string b, int c, string d): this(a,b,c)
        {
            
            this._curso=d;
        }

        public string Mostrar()
        {
            string lista="";
            foreach(float nota in this._notas)
            {
                lista= lista + nota.ToString() + ";";
            }
            return base.Mostrar() +" curso "+ this._curso + " notas " + lista;
        }
    }
}
