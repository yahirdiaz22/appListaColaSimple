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
        public CNodo siguente;
        public CNodo anterior;

        public CNodo Siguiente

        {
            get { return siguente; }
            set { siguente = value; }
        }
        public CNodo Anterior

        {
            get { return anterior; }
            set { anterior = value; }
        }

        public CNodo()
        {
            dato = 0;
            siguente = null;
            anterior = null;
        }
        public CNodo(int d)
        {
            dato = d;
            siguente = null;
            anterior = null;
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
