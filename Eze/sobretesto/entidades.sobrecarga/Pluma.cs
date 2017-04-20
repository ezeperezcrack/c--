using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.sobrecarga
{
    public class Pluma
    {
        private string marca;
        private int cantidad;
        private tinta tinta;

        public Pluma()
        {
            this.marca = "";
            this.cantidad = 0;
            this.tinta = null;
        }
        public Pluma(String a)
            : this()
        {
            this.marca = a;
        }
        public Pluma(string a, int b)
            : this(a)
        {
            this.cantidad = b;
        }

        public Pluma(string a, int b, tinta c)
            : this(a, b)
        {
            this.tinta = c;
        }

        private string mostrar()
        {
            return this.marca.ToString() + this.cantidad.ToString() + entidades.sobrecarga.tinta.mostrar(this.tinta);
        }

        public static Boolean operator ==(Pluma t1, tinta t2)
        {
           return (t1.tinta == t2);
        }
        public static Boolean operator !=(Pluma t1, tinta t2)
        {
            return !(t1 == t2);
        }

        public static Pluma operator +(Pluma p, tinta t)
        {
            if (p == t)
            {
                p.cantidad++;
                return p;
            }
            else
                return p;
        }
        public static Pluma operator -(Pluma p, tinta t)
        {
            if (p == t && p.cantidad > 0)
            {
                p.cantidad--;
                return p;
            }
            else if (p == t && p.cantidad < 1)
            {
                p.tinta = null;
                return p;
            }
            else
            {
                return p;
            }
        }
        public static implicit operator string(Pluma p)
        {
            return p.mostrar();
        }
        public static explicit operator tinta(Pluma p)
        {
            return p.tinta;
        }
    }
}
