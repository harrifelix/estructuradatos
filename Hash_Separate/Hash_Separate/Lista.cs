using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Separate
{
    class Lista
    {
        // Es el ancla o encabezado de la lista
        private Nodo ancla;
        private Nodo trabajo;
        // Esta variable de referencia apoyará en ciertas operaciones de la lista.
        private Nodo trabajo2;

        public Lista()
        {
            // Instanciamos el ancla
            ancla = new Nodo();
            // Como es una lista vacía su siguiente es null
            ancla.Next = null;
        }
        // Recorre toda la lista
        public void Transversa()
        {
            // Trabajo al Inicio
            trabajo = ancla;
            // Recorremos hasta llegar al final
            while (trabajo.Next != null)
            {
                trabajo = trabajo.Next;
                Console.Write("{0}->", trabajo);
            }
        }
        // Adiciona un nuevo valor
        // La adición siempre va al final
        public void Adicionar(int Llave, string Valor)
        {
            // Trabajo al inicio
            trabajo = ancla;
            // Recorrer el trabajo hasta encontrar el final
            while (trabajo.Next != null) { trabajo = trabajo.Next; }
            // Creamos el nuevo nodo
            Nodo temp = new Nodo();
            // Insertamos los valores
            temp.Key = Llave;
            temp.Value = Valor;
            // Finalizamos correctamente
            temp.Next = null;
            // Ligamos el ultimo nodo encontrado con el recien creado
            trabajo.Next = temp;
        }
        // Vaciar la lista
        public void Vaciar() { ancla.Next = null; }
        // Verificar lista vacía
        public bool listaEstaVacia() { return ancla.Next == null; }
        // Buscar elemento
        public Nodo Buscar(int Llave)
        {
            if (listaEstaVacia()) { return null; }
            trabajo2 = ancla;
            // Recorremos para ver si lo encontramos
            while (trabajo2.Next != null)
            {
                trabajo2 = trabajo2.Next;
                // Al encontrarlo lo regresamos
                if (trabajo2.Key == Llave) { return trabajo2; }
            }
            // No se encontró, regresamos null;
            return null;
        }
        // Buscar el indice dónde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int Llave)
        {
            int n = -1;
            trabajo = ancla;
            while (trabajo.Next != null)
            {
                trabajo = trabajo.Next;
                n++;
                if (trabajo.Key == Llave){ return n; }
            }
            return -1;
        }
        // Buscar el nodo anterior de
        public Nodo BuscarAnterior(int Llave)
        {
            trabajo2 = ancla;
            while (trabajo2.Next != null & trabajo2.Next.Key != Llave) { trabajo2 = trabajo2.Next; }
            return trabajo2;
        }
        // Borra la primera ocurrencia del dato
        public void Borrar(int Llave)
        {
            if (listaEstaVacia()) { return; }
            // Buscamos los nodos con los que trabajaremos
            Nodo anterior = BuscarAnterior(Llave);
            Nodo encontrado = Buscar(Llave);
            // Si no hay nodo a borrar, salimos
            if(encontrado == null) { return; }
            // Brincamos el nodo
            anterior.Next = encontrado.Next;
            // Quitamos el actual de la lista
            encontrado.Next = null;
        }
        // Inserta el dato pValor después de la primera ocurrencia del dato pasado a pDonde
        public void InsertarEn(int Indice, int Llave, string Valor)
        {
            // Encontramos la posición donde vamos a insertar
            trabajo = Buscar(Indice);
            // Verifiacamos que exista donde vamos a insertar
            if(trabajo == null) { return; }
            // Creamos el nodo temporal a insertar
            Nodo temp = new Nodo();
            temp.Key = Llave;
            temp.Value = Valor;
            // Conectamos el temporal a la lista
            temp.Next = trabajo.Next;
            // Conectamos trabajo a temporal
            trabajo.Next = temp;
        }
        // Inserta al inicio de la lista
        public void InsertarInicio(int Llave, string Valor)
        {
            Nodo temp = new Nodo();
            temp.Key = Llave;
            temp.Value = Valor;
            // a -- > nodo >>> a --> temp --> nodo
            temp.Next = ancla.Next;
            ancla.Next = temp;
        }
        // Obtenemos la referencia al nodo dado el indice
        public Nodo ObtenPorIndice(int Indice)
        {
            Nodo trabajo2 = null;
            int indice = -1;
            trabajo = ancla;
            while (trabajo.Next != null)
            {
                trabajo = trabajo.Next;
                indice++;
                if (indice == Indice) { trabajo2 = trabajo; }
            }
            return trabajo2;
        }
        // Indexer
        public int this[int Indice]
        {
            get
            {
                trabajo = ObtenPorIndice(Indice);
                return trabajo.Key;
            }
            set
            {
                trabajo = ObtenPorIndice(Indice);
                if (trabajo != null) { trabajo.Key = value; }
            }
        }
    }
}
