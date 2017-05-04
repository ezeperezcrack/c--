using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    public class Jugo : Producto
    {
        protected ESaborJugo _sabor;
        public Jugo(EMarcaProducto marcaProducto, float precio, int codigoBarra, ESaborJugo h) : base(marcaProducto,precio,codigoBarra)
        {
            this._sabor = h;
        }
        public string MostrarJugo()
        {
            return "codigo de barra: \n" + base._codigoDeBarra +"marca: \n" + base._marca +"sabor: \n" +this._sabor+"precio: \n" +base._precio;
        }
        /*
        public String ToString(Producto a)
        {
            return this.MostrarJugo(a);
        }*/
    }
}
