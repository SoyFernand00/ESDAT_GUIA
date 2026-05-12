using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_para_T1
{
    internal class Lista
    {

        LinkedList<string> lista = new LinkedList<string>();

        public void insertarini(string valor)
        {
            lista.AddFirst(valor);
        }
        public void insertarfinal(string valor)
        {
            lista.AddLast(valor);
        }
        public void eliminarini()
        {
            lista.RemoveFirst();
        }
        public void eliminarfinal()
        {
            lista.RemoveLast();
        }
        public void mostrar()
        {
            foreach (string valor in lista)
            {
                Console.WriteLine(valor);
            }
        }
        public void mostrarinverso()
        {
            foreach (string valor in lista.Reverse())
            {
                Console.WriteLine(valor);
            }
        }
        public void eliminar(string valor)
        {
            lista.Remove(valor);
        }
        public void mezclar(Lista otraLista)
        {
            foreach (string valor in otraLista.lista)
            {
                lista.AddLast(valor);
            }
        }

    }
}
