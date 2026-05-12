using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem5
{
    internal class Pilalis
    {
        Nodo Primero { get; set; }
        Nodo Ultimo { get; set; }
        public void AgregaInicio(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (this.Primero == null)
            {//no hay nodos
                this.Primero = nuevo;
                this.Ultimo = nuevo;
            }
            else
            {
                Nodo prim = this.Primero;
                this.Primero = nuevo;
                prim.Ant = nuevo;
                nuevo.Sig = prim;
            }
        }   

        public void AgregaFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (this.Ultimo == null)
            {//no hay nodos
                this.Primero = nuevo;
                this.Ultimo = nuevo;
            }
            else
            {
                Nodo ult = this.Ultimo;
                this.Ultimo = nuevo;
                ult.Sig = nuevo;
                nuevo.Ant = ult;
            }
        }
        public void EliminaFinal()
        {
            if (this.Ultimo != null)
            {
                Nodo ult = this.Ultimo;
                this.Ultimo = ult.Ant;
                if (this.Ultimo != null)
                {
                    this.Ultimo.Sig = null;
                }
                else
                {
                    this.Primero = null;
                }
            }
        }

        public int Pop()
        {
            if (this.Ultimo != null)
            {
                int valor = this.Ultimo.Dato;
                this.EliminaFinal();
                return valor;
            }
            else
            {
                Console.WriteLine("La lista está vacía.");
                return 0;
            }
        }
        public int Top()
        {
            if (this.Ultimo != null)
            {
                return this.Ultimo.Dato;
            }
            else
            {
                Console.WriteLine("La lista está vacía.");
                return -1;
            }
        }
        public bool Empty()
        {
            return this.Primero == null;
        }
        public int Size()
        {
            int count = 0;
            Nodo actual = this.Primero;
            while (actual != null)
            {
                actual = actual.Sig;
                count++;

            }
            return count;
        }
        public void Mostrar()
        {
                       Nodo actual = this.Primero;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Sig;
            }
            Console.WriteLine();
        }
    }
}
