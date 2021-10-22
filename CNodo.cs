using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaColaSimple
{
    class CNodo
    {
        private int dato;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public CNodo siguiente;
        public CNodo anterior;

        public CNodo Siguiente

        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public CNodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public CNodo()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
        }
        public CNodo(int d)
        {
            dato = d;
            siguiente = null;
            anterior = null;
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
