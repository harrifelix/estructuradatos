using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Árbol Genérico
            Arbol arbolito = new Arbol();
            NodoArbolG raiz = arbolito.Insertar("A", null);
            arbolito.Insertar("B", raiz);
            arbolito.Insertar("C", raiz);

            //arbolito.TransversaPre(raiz);

            NodoArbolG n = arbolito.Insertar("D", raiz);
            arbolito.Insertar("H", n);
            n = arbolito.Insertar("E", raiz);
            NodoArbolG i = arbolito.Insertar("I", n);
            arbolito.Insertar("J", i);
            NodoArbolG p = arbolito.Insertar("Q", n);
            arbolito.Insertar("P", p);

            n = arbolito.Insertar("F", raiz);
            arbolito.Insertar("k", n);
            arbolito.Insertar("L", n);
            arbolito.Insertar("M", n);
            n = arbolito.Insertar("G", raiz);
            arbolito.Insertar("N", n);

            arbolito.TransversaPre(raiz);
            Console.WriteLine("-------");
            Console.WriteLine("Transversa Post-Order");
            arbolito.TransversaPost(raiz);
            //
            Console.WriteLine("Busqueda");
            if (arbolito.Buscar("N", raiz) != null) { Console.WriteLine("Dato encontrado = " + arbolito.Buscar("k", raiz).Dato); }
            else { Console.WriteLine("No lo encontre :("); }

            // Proceso de Inserción
            string donde = "";
            string que = "";
            Console.WriteLine("En dónde deseas insertar?");
            donde = Console.ReadLine();
            Console.WriteLine("Qué deseas insertar?");
            que = Console.ReadLine();
            NodoArbolG encontrado = arbolito.Buscar(donde,raiz);
            arbolito.Insertar(que, encontrado);
            arbolito.TransversaPre(raiz);
        }
    }
}
