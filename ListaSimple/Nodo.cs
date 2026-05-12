using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    internal class Nodo
    {
        public Gato Dato { get; set; }
        public Nodo Sig { get; set; }

        public Nodo(Gato dato)
        {
            Dato = dato;
            Sig = null;
        }
    }
}
