using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSignos___Aplicación_Stack
{
    class Nodito
    {
        // Aquí colocamos el dato o datos que guarda el nodo
        private char valor;
        // Esta variable de referencia es usada para apuntar al nodo siguiente
        private Nodito Siguiente = null;
        // Propiedades que usaremos
        public char Dato { get; set; }
        internal Nodito Sig { get; set; }
        // Para su facil impresion
        public override string ToString()
        {
            return string.Format("[{0}]", valor);
        }
    }
}
