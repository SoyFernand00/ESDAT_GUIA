using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Nodo
    {
        public int Dato { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(int dato)
        {
            Dato = dato;
            Izquierda = null;
            Derecha = null;
        }
    }
}
