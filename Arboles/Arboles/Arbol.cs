using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        private NodoArbolG raiz;
        private NodoArbolG trabajo;
        private int i = 0;

        // constructor de nuevo árbol
        public Arbol()
        {
            raiz = new NodoArbolG();
        }

        public NodoArbolG Insertar(string cadena, NodoArbolG nodo)
        {
            // Si no hay nodo donde insertar, tomamos como si fuera en la raiz
            if (nodo == null)
            {
                raiz = new NodoArbolG();
                raiz.Dato = cadena;
                // No hay hijo
                raiz.Hijo = null;
                // No hay hermano
                raiz.Hermano = null;
                return raiz;
            }
            // Verificamos si no tiene hijo
            if (nodo.Hijo == null)
            {
                NodoArbolG temp = new NodoArbolG();
                temp.Dato = cadena;
                // Conectamos el nuevo nodo como hijo
                nodo.Hijo = temp;
                return temp;
            }
            else // Ya tiene un hijo, tenemos que insertarlo como hermano.
            {
                trabajo = nodo.Hijo;
                // Avanzamos hasta el ultimo hermano
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                // Creamos nodo temporal
                NodoArbolG temp = new NodoArbolG();
                temp.Dato = cadena;
                // Unimos el temp al último hermano
                trabajo.Hermano = temp;
                return temp;
            }
        }

        // Transversa Pre Order
        public void TransversaPre(NodoArbolG nodo)
        {
            if (nodo == null) { return; }
            // Me proceseo primero a mí...
            for (int n = 0; n < i; n++) { Console.Write(" "); }
            Console.WriteLine(nodo.Dato);
            // Luego proceso a mi hijo
            if (nodo.Hijo != null)
            {
                i++;
                TransversaPre(nodo.Hijo);
                i--;
            }
            // Si tengo hermanos los proceso
            if (nodo.Hermano != null) { TransversaPre(nodo.Hermano); }
        }

        public void TransversaPost(NodoArbolG nodo)
        {
            if (nodo == null) { return; }
            // Primero proceso a mi hijo
            if (nodo.Hijo != null)
            {
                i++;
                TransversaPost(nodo.Hijo);
                i--;
            }
            // Si tengo hermanos los proceso
            if (nodo.Hermano != null) { TransversaPost(nodo.Hermano); }
            // Luego me proceso a mí.
            for (int n = 0; n < i; n++) { Console.Write(" "); }
            Console.WriteLine(nodo.Dato);
        }

        public NodoArbolG Buscar(string valor, NodoArbolG nodo)
        {
            NodoArbolG encontrado = null;
            if (nodo == null) { return encontrado; }
            if (nodo.Dato.CompareTo(valor) == 0)
            {
                encontrado = nodo;
                return encontrado;
            }
            // Luego proceso a mi hijo
            if (nodo.Hijo != null)
            {
                encontrado = Buscar(valor, nodo.Hijo);
                if (encontrado != null) { return encontrado; }
            }
            // Si tengo hermanos los proceso
            if (nodo.Hermano != null)
            {
                encontrado = Buscar(valor, nodo.Hermano);
                if (encontrado != null) { return encontrado; }
            }

            return encontrado;
        }
    }
}
