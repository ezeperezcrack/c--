using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    public abstract class Producto
    {
        protected EMarcaProducto _marca;
        protected float _precio;
        protected int _codigoDeBarra;

        public EMarcaProducto Marca 
        {
            get
            {
                return this._marca;
            }
        }
        public float Precio
        {
            get
            {
                return this._precio;
            }
        }
        public Producto(EMarcaProducto enumMarca, float precio, int codigoBarra)
        {
            this._marca = enumMarca ;
            this._precio = precio;
            this._codigoDeBarra = codigoBarra;
        }
        protected static string MostrarProducto(Producto p)
        {
            return "Marca:\n"+p._marca+"\nPrecio:\n"+p._precio + "\nCodigo de Barra:\n"+p._codigoDeBarra+".\n";
        }

        public static Boolean operator ==(Producto p1, Producto p2)
        {
            Boolean ejection = false ;
            if (p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra)
                ejection = true;
            return ejection;
        }

        public static Boolean operator !=(Producto p1, Producto p2)
        {
            return !(p1==p2);
        }

        public static Boolean operator ==(Producto p, EMarcaProducto m)
        {
            Boolean ejection = false ;
            if (p._marca == m)
                ejection = true;
            return ejection;
        }

        public static Boolean operator !=(Producto p1, EMarcaProducto m)
        {
            return !(p1 == m);
        }

        public static explicit operator int(Producto producto)
        {
            return producto._codigoDeBarra;
        }

       /* public static implicit operator string(Producto producto)
        {
            return MostrarProducto(producto);
        }

        public Boolean Equals(Object objeto1, Object objeto2)
        {
            return Object.Equals(objeto1, objeto2);
        }
        public abstract float CalcularCostoDeProduccion
        {
            get;            
        }
        public virtual String Consumir()
        {
            return "Parte de una mezcla.";
        }*/

    }
}
