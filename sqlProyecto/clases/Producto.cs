using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlProyecto.clases
{
    internal class Producto
    {
        private string nombre;
        private int precio;


        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setPrecio(int precio)
        {
            this.precio = precio;
        }

        public int getPrecio()
        {
            return this.precio;
        }

    }
}
