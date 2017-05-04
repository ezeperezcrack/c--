using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte c)
            : this()
        {
            this._capacidad = c;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string retorno = "";
            foreach (Producto p in e._productos)
            {

                if (p is Jugo)
                {
                    retorno += ((Jugo)p).MostrarJugo();
                }
                if (p is Galletita)
                {
                    retorno += Galletita.MostrarGalletita((Galletita)p);
                }
                if (p is Gaseosa)
                {
                    retorno += ((Gaseosa)p).MostrarGaseosa();
                }
            }
            return retorno;
        }

        public static Boolean operator ==(Estante e, Producto p)
        {
            foreach (Producto a in e._productos)
            {
                if (p == a)
                    return true;
            }
            return false;
        }

        public static Boolean operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static Boolean operator +(Estante e, Producto p)
        {
            if (e._capacidad > 0 && e != p)
            {
                e._productos.Add(p);
                e._capacidad--;
                return true;
            }
            return false;
        }
        public static Boolean operator -(Estante e, Producto p)
        {
            
        }
    }
}
