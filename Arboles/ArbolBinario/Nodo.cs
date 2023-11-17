using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Nodo
    {
        private int dato;
        private Nodo izq;
        private Nodo der;
        public int Dato { get; set; }
        internal Nodo Izq { get; set; }
        internal Nodo Der { get; set; }
        public Nodo()
        {
            dato = 0;
            izq = null;
            der = null;
        }
    }
}
