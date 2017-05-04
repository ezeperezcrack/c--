using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Gaseosa:Producto
    {
        protected float _litros;
        public Gaseosa(EMarcaProducto marcaProducto, float precio, int codigoBarra, float litros)
            : base(marcaProducto, precio, codigoBarra)
            
        {

        }
        public Gaseosa(Producto producto, float litros):this(producto.Marca,producto.Precio, (int)producto, litros)
        {
            this._litros = litros;
        }
        public string MostrarGaseosa()
        {
            return "codigo de barra: \n" + base._codigoDeBarra +"marca: \n" + base._marca +"litros: \n" +this._litros+"precio: \n" + base._precio;
        }
    }
}
