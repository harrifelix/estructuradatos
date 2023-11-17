using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arbol Completo refiriendome a que esta es la estructura de arbol
            ArbolBin arbol = new ArbolBin();
            // Declarando la raíz del árbol
            Nodo raiz = arbol.Insertar(6, null);
            arbol.Raiz = raiz;
            // Cuerpo de la raiz del árbol binario
            arbol.Insertar(2, raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(1, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(3, raiz);
            //arbol.Insertar(5, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(14, raiz);
            // Mostrando el contenido del árbol
            arbol.Transversa(raiz);

            // Mostrando el menor
            Console.WriteLine("Menor del árbol = " + arbol.Menor(raiz).Dato);
            Console.WriteLine("Mayor del árbol = " + arbol.Mayor(raiz).Dato);
            Console.WriteLine("Transversa Ordenada :");
            arbol.TransversaOrdenada(raiz);
            Console.WriteLine();
            Console.Write("Padre de Nodito 11 = ");
            Console.WriteLine(arbol.Padre(11, raiz).Dato);
            // Hijo Derecho
            //Console.Write("Borrar Nodo 3");
            //arbol.BorrarNodo(3,raiz);
            //arbol.Transversa(raiz);
            //arbol.TransversaOrdenada(raiz);
            // Hijo Izquierdo
            //Console.Write("Borrar Nodo 5");
            //arbol.BorrarNodo(5, raiz);
            //Console.WriteLine();
            //arbol.Transversa(raiz);
            //arbol.TransversaOrdenada(raiz);
            // Hoja
            //Console.Write("Borrar Nodo 5");
            //arbol.BorrarNodo(-1, raiz);
            //Console.WriteLine();
            //arbol.Transversa(raiz);
            //arbol.TransversaOrdenada(raiz);
            //Console.WriteLine();
            // Sub raíz
            arbol.BorrarNodo(11, raiz);
            Console.WriteLine();
            arbol.Transversa(raiz);
            arbol.TransversaOrdenada(raiz);
            Console.WriteLine();
        }
    }
}
