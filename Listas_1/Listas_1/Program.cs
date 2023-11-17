using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista_Ligada listita = new Lista_Ligada();
            listita.Agregar(3);
            listita.Agregar(5);
            listita.Agregar(7);
            listita.Agregar(9);
            listita.Agregar(11);
            listita.Agregar(15);
            listita.Transversa();
            Console.WriteLine(listita.isEmpty());

            //listita.Vaciar();
            //listita.Transversa();
            //Console.WriteLine(listita.isEmpty());

            /*listita.borrarElemento(7);
            listita.Transversa();
            listita.borrarElemento(3);
            listita.Transversa();
            listita.Insertar(11, 20);
            listita.Transversa();
            listita.Insertar(5, 7);
            listita.Transversa();
            listita.Insertar(7, 1000);
            listita.Insertar(3, 12);
            listita.Transversa();
            Console.WriteLine("-------------");
            Console.WriteLine("Insertar Inicio");
            listita.insertarInicio(9);
            listita.Transversa();
            listita.insertarInicio(84938);
            listita.insertarInicio(1010101);
            listita.Transversa();
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
            Console.WriteLine("Obtener Nodo por Indice");
            Nodito elemento = listita.getIndiceNodito(1);
            if (elemento.Equals(listita.nodo))
            {
                Console.WriteLine("Error Indice Fuera de Rango...");
            }
            else
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine("-------------");
            Nodito encontrado = listita.Buscar(15);
            Console.WriteLine(encontrado);

            int indice = listita.getIndice(97);
            if (indice != -1)
            {
                Console.WriteLine(indice);
            }
            Console.WriteLine("---Indexer---");
            listita.Transversa();
            Console.WriteLine(listita[3]);
            listita[3] = 66;
            listita.Transversa();
            Console.WriteLine("-------------");*/

            for (int i=0;i< listita.getSize();i++) {
                Console.WriteLine(i);
            }
        }
    }
}
