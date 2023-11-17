using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Separate
{
    class Nodo
    {
        // Colocamos el dato o datos que guarda el nodo
        private int llave;
        private string valor;
        // Esta variable de referencia es usada para apuntar al nodo siguiente
        private Nodo sig = null;
        // Propiedades
        public int Key { set; get; }
        public string Value { set; get; }
        internal Nodo Next { set; get; }
        // Facil impresión
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", Key, Value);
        }
    }
}
