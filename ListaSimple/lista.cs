using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    internal class lista
    {
        public Nodo Pri { get; set; }

        public void agregar2posi(string nombre, int edad, double precio)
        {
            Nodo nuevo = new Nodo(new Gato(nombre, edad, precio));
            if (Pri == null)
            {
                Pri = nuevo;
            }
            else if (Pri.Sig == null)
            {
                Pri.Sig = nuevo;
            }
            else if (Pri.Sig != null)
            {
                Nodo segundo = Pri.Sig;
                nuevo.Sig = segundo;
                Pri.Sig = nuevo;
            }

        }
        public string Imprime()
        {
            Nodo temp = Pri;
            string resultado = "";
            while (temp != null)
            {
                resultado += temp.Dato + "\n";
                temp = temp.Sig;
            }
            return resultado;
        }
        public int Cantidad()
        {
            Nodo temp = Pri;
            int cont = 0;
            while (temp != null)
            {
                cont++;
                temp = temp.Sig;
            }
            return cont;
        }
        public lista SegundaMitad()
        {
            int mitad = (int)(Cantidad() / 2);
            lista nuevo = new lista();
            Nodo temp = Pri;
            for (int cont = 0; cont < mitad; cont++)
            {
                temp = temp.Sig;
            }
            nuevo.Pri = temp;
            return nuevo;
        }


    }
}
