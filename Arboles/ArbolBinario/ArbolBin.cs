using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class ArbolBin
    {
        private Nodo raiz;
        private Nodo trabajo;

        private int i = 0;

        public ArbolBin()
        {
            this.raiz = null;
        }
        internal Nodo Raiz { get; set; }

        // Insertar
        public Nodo Insertar(int dato, Nodo nodo)
        {
            Nodo temp = null;
            // Si no hay a quién insertar entonces creamos el nodo
            if (nodo == null)
            {
                temp = new Nodo();
                temp.Dato = dato;
                return temp;
            }
            // Si el dato es menor
            if (dato < nodo.Dato) { nodo.Izq = Insertar(dato, nodo.Izq); }
            // Si el dato es mayor
            if (dato > nodo.Dato) { nodo.Der = Insertar(dato, nodo.Der); }

            return nodo;
        }

        public void Transversa(Nodo nodo)
        {
            if (nodo == null) { return; }
            // Me proceso primero a mí
            for (int n = 0; n < i; n++) { Console.Write(" "); }
            Console.WriteLine(nodo.Dato);
            // Si tengo izquierda, proceso a la izquierda
            if (nodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(nodo.Izq);
                i--;
            }
            // Si tengo a la derecha, proceso a la derecha
            if (nodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(nodo.Der);
                i--;
            }
        }

        public Nodo Menor(Nodo nodo)
        {
            try
            {
                trabajo = nodo;
                if (trabajo == null) { return trabajo; }
                // Si tengo hijos a la izquierda, los proceso
                if (trabajo.Izq != null) { trabajo = Menor(trabajo.Izq); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return trabajo;
        }

        public Nodo Mayor(Nodo nodo)
        {
            try
            {
                trabajo = nodo;
                if (trabajo == null) { return trabajo; }
                // Si tengo hijos a la derecha, los proceso
                if (nodo.Der != null) { trabajo = Mayor(trabajo.Der); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return trabajo;
        }

        public void TransversaOrdenada(Nodo nodito)
        {
            if (nodito == null) { return; }
            // Si tengo izquierda, proceso a la izquierda
            if (nodito.Izq != null)
            {
                i++;
                TransversaOrdenada(nodito.Izq);
                i--;
            }
            Console.Write("{0}, ", nodito.Dato);
            if (nodito.Der != null)
            {
                i++;
                TransversaOrdenada(nodito.Der);
                i--;
            }
        }

        public Nodo Padre(int hijo, Nodo noditoRaiz)
        {
            if (hijo < noditoRaiz.Dato)
            {
                if (noditoRaiz.Izq.Dato == hijo)
                {
                    // He encontrado al padre
                    trabajo = noditoRaiz;
                }
                else
                {
                    Padre(hijo, noditoRaiz.Izq);
                }
            }
            else if (hijo > noditoRaiz.Dato)
            {
                if (noditoRaiz.Der.Dato == hijo)
                {
                    trabajo = noditoRaiz;
                }
                else
                {
                    Padre(hijo, noditoRaiz.Der);
                }
            }
            else if (noditoRaiz.Dato == hijo)
            {
                return noditoRaiz;
            }
            return trabajo;
        }

        public void BorrarNodo(int dato, Nodo noditoPadre)
        {
            if (dato < noditoPadre.Dato)
            {
                BorrarNodo(dato, noditoPadre.Izq);
            }
            else if (dato > noditoPadre.Dato)
            {
                BorrarNodo(dato, noditoPadre.Der);
            }
            else // El dato y el noditoPadre.Dato son iguales, por lo tanto he encontrado el nodo a borrar
            {
                if (noditoPadre.Izq == null && noditoPadre.Der == null)         // Si es una hoja 'Funciona Perfecto
                {
                    trabajo = Padre(dato, Raiz);
                    if (dato < trabajo.Dato) { trabajo.Izq = null; }
                    else { trabajo.Der = null; }
                }
                else if (noditoPadre.Der != null && noditoPadre.Izq == null)    // Si solamente tiene un hijo a la derecha 'Funciona Perfecto
                {
                    trabajo = Padre(dato, Raiz);
                    if (dato < trabajo.Dato) { trabajo.Izq = noditoPadre.Der; }
                    else { trabajo.Der = noditoPadre.Der; }
                }
                else if (noditoPadre.Der == null && noditoPadre.Izq != null)    // Si solamente tiene un hijo a la izquierda 'Funciona Perfecto
                {
                    trabajo = Padre(dato, Raiz);
                    if (dato > trabajo.Dato) { trabajo.Der = noditoPadre.Izq; }
                    else { trabajo.Izq = noditoPadre.Izq; }
                    
                }
                else if (noditoPadre.Izq != null && noditoPadre.Der != null)    // Si ambos tienen hijos
                {
                    trabajo = Menor(noditoPadre.Der);   // Obtengo el menor del lado derecho
                    int menor = trabajo.Dato;
                    BorrarNodo(menor, noditoPadre);
                    noditoPadre.Dato = menor;
                }
            }
        }
    }
}
