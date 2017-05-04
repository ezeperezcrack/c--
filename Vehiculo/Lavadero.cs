using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Lavadero:Vehiculo
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero() 
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float a, float c, float m):this()
        {
            this._precioAuto = a;
            this._precioCamion = c;
            this._precioMoto = m;
        }

        public string lavadero 
        {
            get
            {
                string retorno="";
                retorno += "precio auto" + this._precioAuto + "\n" + "precio camion" + this._precioCamion + "\n" + "precio moto" + this._precioMoto + "\n";
                foreach (Vehiculo n in this._vehiculos)
                {
                    
                    if (n is Auto)
                    {
                        retorno += ((Auto)n).Mostrar();
                    }
                    if (n is Moto)
                    {
                        retorno += ((Moto)n).Mostrar();
                    }
                    if (n is Camion)
                    {
                        retorno += ((Camion)n).MostrarCamion();
                    }
                }
                return retorno;
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this._vehiculos; }
        }

        public Double MostrarTotalFacturado()
        {
            return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);            
        }

        public Double MostrarTotalFacturado(EVehiculos tipo)
        {
            double total = 0;
            foreach (Vehiculo a in this._vehiculos)
            {
                if (a is Auto && tipo == EVehiculos.Auto)
                {
                    total = total + this._precioAuto;
                }
                else if (a is Camion && tipo == EVehiculos.Camion)
                {
                    total = total + this._precioCamion;
                }
                else if (a is Moto && tipo == EVehiculos.Moto)
                {
                    total = total + this._precioMoto;
                }
            }
            return total;
        }

        public static Boolean operator ==(Vehiculo v, Lavadero l)
        {
            foreach (Vehiculo a in l._vehiculos)
            {
                if (v == a)
                    return true;
            }
            return false;
        }
        public static Boolean operator !=(Vehiculo v, Lavadero l)
        {
            return !(v==l);
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if (v != l)
            {
                l._vehiculos.Add(v);
                return l;
            }
            return l;
        }
        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            if (v == l)
            {
                l._vehiculos.Remove(v);
                return l;
            }
            return l;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo a, Vehiculo b)
        {
            //return string.Compare(a.Patente, b.Patente);
            return a.Patente.CompareTo(b.Patente);
        }
        /*
        public static int CompararPatenteDescendente(Vehiculo a, Vehiculo b)
        {
            //return string.Compare(a.Patente, b.Patente);
            return b.Patente.CompareTo(a.Patente);
        }

        public int CompararMarcaAscendente(Vehiculo a, Vehiculo b)
        {
            return string.Compare(a.Patente, b.Patente);
            //return a.Marca.CompareTo(b.Marca);
        }*/
         
        public int OrdenarVehiculoPorMarca(Vehiculo a, Vehiculo b)
        {
            return string.Compare(a.Marca.ToString(), b.Marca.ToString());         
        }

        /*public int OrdenarVehiculoPorMarca(Vehiculo a, Vehiculo b)
        {
            int retorno=0;
            if (a.Marca == b.Marca)
                retorno = 0;
            else if ((a.Marca).ToString() < (b.Marca).ToString())
                retorno = 1;
            else if (a.Marca > b.Marca)
            {
                retorno = -1;
            }
            return retorno;
        }*/
    }
}
