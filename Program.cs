using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaColaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            CQueue objcola = new CQueue();
            Console.WriteLine("Se han colocado 5 elementos a la cola");
            objcola.Encolar(5);
            objcola.Encolar(3);
            objcola.Encolar(7);
            objcola.Encolar(1);
            objcola.Mostrar();

            Console.WriteLine("Se ha eliminado dos elementos en la cola");
            objcola.Desencolar();
            objcola.Mostrar();
            objcola.Desencolar();
            objcola.Desencolar();
     

            Console.WriteLine("Se retiro un nodo mas, con el valor de {0}", objcola.DesencolarValor());
            objcola.Mostrar();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
