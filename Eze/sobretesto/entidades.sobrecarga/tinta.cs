using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.sobrecarga
{
    public class tinta
    {
        private ConsoleColor color;
        private Etipo tipo;

        public tinta()
        {
            this.color=ConsoleColor.Blue;
            this.tipo=Etipo.comun;
        }

        public tinta(ConsoleColor a):this()
        {
            this.color= a;
        }

        public tinta(ConsoleColor a,Etipo b) :this(a)
        {
            this.tipo=b;
        }
        private string mostrar()
        {
            return this.color.ToString() + this.tipo.ToString(); 
        }
        public static string mostrar(tinta thing)
        {
            return thing.color.ToString() + thing.tipo.ToString(); 
        }
        
        public static Boolean operator == (tinta t1, tinta t2)
        {
            if (t1.color == t2.color && t1.tipo == t2.tipo)
                return true;
            else 
                return false;
        }
        public static Boolean operator != (tinta t1, tinta t2)
        {
            return !(t1 == t2);
        }
    }
}
