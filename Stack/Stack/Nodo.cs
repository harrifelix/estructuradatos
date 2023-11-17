using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Nodo
    {
        // Aquí colocamos el dato o datos que guarda el nodo
        private char valor;
        // Esta variable de referencia es usada para apuntar al nodo siguiente
        private Nodo Siguiente = null;
        // Propiedades que usaremos
        public char Dato { get; set; }
        internal Nodo Sig { get; set; }
        // Para su facil impresion
        public override string ToString()
        {
            return string.Format("[{0}]", valor);
        }
    }
}
