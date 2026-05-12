using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    internal class Gato
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double precio { get; set; }

        public Gato(string nombre, int edad, double precio)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.precio = precio;
        }
        public override string? ToString()
        {
            return "Nombre: "+nombre+" y edad es "+edad+" al precio de "+precio;
        }
    }
}
