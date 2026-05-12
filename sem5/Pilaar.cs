using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem5
{
    internal class Pilaar
    {
        private int[] datos = Array.Empty<int>();

        public void Push(int valor)
        {
            Array.Resize(ref datos, datos.Length + 1);
            datos[datos.Length - 1] = valor;
        }
        public int Pop()
        {
            int valor = datos[datos.Length - 1];
            Array.Resize(ref datos, datos.Length - 1);
            return valor;

        }
        public int Top()
        {
                       return datos[datos.Length - 1];
        }
        public int size()
        {
            return datos.Length;
        }
        public bool Empty()
        {
            return datos.Length == 0;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in datos)
            {
                str += i.ToString() + " ";
            }
            return str;
        }
    }
}
