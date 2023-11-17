using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Listas_1
{
    public class Nodito
    {
        //Aquí colocamos el dato o datos que guarda el nodo.
        private int dato;
        //Esta variable de referencia es usada para apuntar al nodo siguiente
        private Nodito siguiente = null;
        //Propiedades que usaremos
        public int getDato()
        {
            return dato;
        }
        public void setDato(int dato){
            this.dato = dato;
        }
        internal Nodito getSiguiente(){
            return siguiente;
        }
        internal void setSiguiente(Nodito value){
            siguiente = value;
        }
        //Para su facil impresión
        public override string ToString(){
            return string.Format("[{0}]",dato);
        }
    }
}
