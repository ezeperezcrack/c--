using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Galletita:Producto
    {
        protected float _peso;
        public Galletita(EMarcaProducto marcaProducto, float precio, int codigoBarra, float p)
            : base(marcaProducto, precio, codigoBarra)
        {
            this._peso = p;
        }

        public static string MostrarGalletita(Galletita galleta)
        {
         
            return "codigo de barra: \n" + (Producto)galleta + "marca: \n" + galleta.Marca + "peso: " + galleta._peso + "precio: \n" + galleta.Precio;
        }
    }
}
