using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaColaSimple
{
    class CQueue
    {
        public CNodo primero;
        public CNodo ultimo;

        public CQueue()
        {
            primero = ultimo = null;
        }
        public void Encolar(int valor)
        {
            CNodo n = new CNodo();
            n.Dato = valor;
            if (primero == null)
            {
                primero = ultimo = n;
                n.Siguiente = null;
            }
            else
            {
                ultimo.Siguiente = n;
                n.Siguiente = null;
                ultimo = n;
            }
        }

        public void Desencolar()
        {
            if (primero == null)
            {
                Console.WriteLine("La cola esa vacia");

            }
            else
            {
                primero = primero.Siguiente;
            }

        }

        public int DesencolarValor()
        {
            int valor = 0;
            if (primero == null)
            {
                Console.WriteLine("Cola Vacia");
            }
            else
            {
                valor = primero.Dato;
                primero = primero.Siguiente;
            }
            return valor;
        }
        public void Mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("Cola Vacia");
            }
            else
            {
                CNodo puntero;
                puntero = primero;
                do
                {
                    Console.WriteLine("{0}\t", puntero.Dato);
                    puntero = puntero.Siguiente;
                } while (puntero != null);
            }
            Console.WriteLine("\n");
        }



    }
}
