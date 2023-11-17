using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_1
{
    public class Lista_Ligada
    {
        //Es el ancla o encabezado de la lista
        public Nodito nodo;
        //Esta variable de referencia nos ayuda trabajar con la lista.
        private Nodito datosx;
        // Esta variable de referencia apoya en ciertas operaciones de la lista.
        private Nodito datosx2;

        public Lista_Ligada()
        {
            //Instanciamos el ancla
            nodo = new Nodito();
            //Cómo es una lista vacía, su siguiente es null
            nodo.setSiguiente(null);
        }

        //Recorre toda la lista
        public void Transversa()
        {
            //datosx al Inicio
            datosx = nodo;
            //Recorremos hasta encontrar el final
            while (datosx.getSiguiente() != null)
            {
                //Avanzamos datosx
                datosx = datosx.getSiguiente();
                //Obtenemos el dato y lo mostramos
                int d = datosx.getDato();
                Console.Write("{0} -> ", d);
            }
            //Bajamos la linea
            Console.WriteLine();
        }

        //Agregar nuevo elemento a la lista
        public void Agregar(int valor)
        {
            //datosx al Inicio
            datosx = nodo;
            //Recorremos hasta encontrar el final
            while (datosx.getSiguiente() != null)
            {
                //Avanzamos datosx
                datosx = datosx.getSiguiente();
            }

            // Creamos el nuevo nodo
            Nodito temporal = new Nodito();
            //Insertemos el dato
            temporal.setDato(valor);
            //Finalizamos correctamente
            temporal.setSiguiente(null);
            //Ligamos el ultimo nodo encontrado con el recien creado
            datosx.setSiguiente(temporal);
        }

        // Vaciar la lista
        public void Vaciar()
        {
            nodo.setSiguiente(null);
        }

        // Indica si la lista esta vacia o no
        public bool isEmpty()
        {
            if (nodo.getSiguiente() != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Regresa el nodo con la primera ocurrencia del dato
        public Nodito Buscar(int valor)
        {
            if (isEmpty()) { return null; }
            datosx2 = nodo;
            //Recorremos para ver si lo encontramos
            while (datosx2.getSiguiente() != null)
            {
                datosx2 = datosx2.getSiguiente();
                //Al encontrarlo lo regresamos...
                if (datosx2.getDato() == valor) { return datosx2; }
            }
            //No se encontró, regresamos null
            return null;
        }

        // Regresa el indice del Nodo
        public int getIndice(int valor)
        {
            int n = -1;
            datosx = nodo;
            while (datosx.getSiguiente() != null)
            {
                datosx = datosx.getSiguiente();
                n++;
                if (datosx.getDato() == valor) { return n; }
            }
            return -1;
        }

        /*
         * Encontrar el nodo anterior
         * Si esta en el primer nodo se regresa al ancla
         * Si el dato no existe se regresa el ultimo nodo
         */
        public Nodito getNoditoAnterior(int valor)
        {
            datosx2 = nodo;
            while (datosx2.getSiguiente() != null && datosx2.getSiguiente().getDato() != valor) { datosx2 = datosx2.getSiguiente(); }
            return datosx2;
        }

        //Borrar elemento de la lista
        public void borrarElemento(int valor)
        {
            //Verificamos que se tengan datos.
            if (isEmpty()) { return; }
            // Buscamos los nodos con los que trabajaremos
            Nodito anterior = getNoditoAnterior(valor);
            Nodito encontrado = Buscar(valor);
            // Si no hay nodo a borrar, salimos
            if (encontrado == null) { return; }
            //Brincamos el nodo
            anterior.setSiguiente(encontrado.getSiguiente());
            // Quitamos el actual de la lista.
            encontrado.setSiguiente(null);
        }

        // Insertar un valor después de la primera ocurrencia del dato pasado a pDonde
        public void Insertar(int indiceInsercion, int valor)
        {
            // Encontramos la posición donde vamos a insertar
            datosx = Buscar(indiceInsercion);
            if (datosx == null) { return; }
            //Creamos el nodo temporal a insertar
            Nodito temporal = new Nodito();
            temporal.setDato(valor);
            //Conectamos el temporal a la lista
            temporal.setSiguiente(datosx.getSiguiente());
            //Conectamos datosx a temporal
            datosx.setSiguiente(temporal);
        }

        //Insertar valor al inicio
        public void insertarInicio(int valor)
        {
            Nodito dato = new Nodito();
            dato.setDato(valor);
            if (isEmpty())
            {
                Agregar(valor);
            }
            else
            {
                dato.setSiguiente(nodo.getSiguiente());
                nodo.setSiguiente(dato);
            }
        }

        //Obtener el nodo que se encuentra en indice especificado
        public Nodito getIndiceNodito(int indice)
        {
            if (isEmpty() || indice > getSize())
            {
                return nodo;
            }

            datosx = nodo;
            int n = 0;
            while (datosx.getSiguiente() != null && n != indice)
            {
                datosx = datosx.getSiguiente();
                n++;
            }
            return datosx;
        }
        
        // Obtener el tamaño de elementos...
        public int getSize()
        {
            datosx = nodo;
            int size = 0;
            while (datosx.getSiguiente() != null) 
            {
                datosx = datosx.getSiguiente();
                size++;
            }
            return size;
        }

        // Indexer ???
        public int? this[int indice]
        {
            get
            {
                datosx = getIndiceNodito(indice);
                return datosx.getDato();
            }
            set
            {
                datosx = getIndiceNodito(indice);
                if (datosx != null)
                {
                    datosx.setDato(Convert.ToInt32(value));
                }
            }
        }

        //Comentario
    }
}
