using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_para_T1
{
    internal class Nodo
    {
        public String Dato { get; set; }
        public Nodo sig { get; set; }
        public Nodo ant {  get; set; }

        public Nodo(string dato)
        {
            Dato = dato;
            sig = null;
            ant=null;
        }
    }
}
