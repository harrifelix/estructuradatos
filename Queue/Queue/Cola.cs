using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Cola
    {
        // Es el ancla o encabezado de la cola
        Nodito ancla;
        // Esta variable de referencia nos ayuda trabajar con la cola
        Nodito trabajo;

        public Cola()
        {
            // Instanciamos el ancla
            ancla = new Nodito();
            // Cómo es una cola vacia su siguiente es null
            ancla.Siguiente = null;
        }

        public void Transversa()
        {
            // Trabajo al inicio
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;
                Console.Write("<=={0} ", trabajo.Valor);
            }
            Console.WriteLine();
        }

        public void Enqueue(int dato)
        {
            // Trabajo al inicio
            trabajo = ancla;
            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo hasta el final
                trabajo = trabajo.Siguiente;
            }
            // Creamos el nuevo elemento de cola
            Nodito newEnCola = new Nodito();
            // Insertamos el dato
            newEnCola.Valor = dato;
            // El nuevo elemento apuntará a nulo ultimo nodo actual
            newEnCola.Siguiente = null;
            // El ultimo de la cola apuntará al nuevo ultimo
            trabajo.Siguiente = newEnCola;
        }

        public int Dequeue()
        {
            // Esta version no contiene código de seguridad
            // Colocar una excepción cuando se intente hacer un Dequeue cuando el queue está vacío
            int valor = 0;
            // Llevamos a cabo el trabajo solo si hay elementos en la cola
            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Valor;
                // Lo sacamos del queue
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        public int Peek()
        {
            // Esta version no contiene código de seguridad
            // Colocar una excepción cuando se intente hacer un Peek cuando el queue está vacío
            int valor = 0;
            // Llevamos a cabo el trabajo solo si hay elementos en la cola
            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Valor;
            }
            return valor;
        }
    }
}
