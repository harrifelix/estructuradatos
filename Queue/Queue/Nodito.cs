using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Nodito
    {
        // Aquí colocamos el dato o datos que guarda el nodo
        private int dato;
        // Esta variable de referencia es usada para apuntar al nodo siguiente
        private Nodito siguiente = null;
        // Propiedades que usaremos
        public int Valor { get => dato; set => dato = value; }
        internal Nodito Siguiente { get => siguiente; set => siguiente = value; }
        // Para su fácil impresión
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
