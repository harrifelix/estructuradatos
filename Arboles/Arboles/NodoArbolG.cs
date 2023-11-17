using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class NodoArbolG
    {
        // Dato
        private string dato;
        private NodoArbolG hijo;
        private NodoArbolG hermano;

        public string Dato { get; set; }
        public NodoArbolG Hijo { get; set; }
        public NodoArbolG Hermano { get; set; }
        
        public NodoArbolG()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
