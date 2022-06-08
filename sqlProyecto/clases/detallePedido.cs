using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlProyecto.detallePedido
{
    internal class detallePedido
    {
        private int idPedido;
        private int idProducto;
        private int Cantidad;


        public void setIdPedido(int id)
        {
            idPedido = id;
        }

        public int getIdPedido()
        {
        return this.idPedido;
        }

        // --------------------
        public void setIdProducto(int idProducto)
        {
            idProducto = idProducto;
        }

        public int getIdProducto()
        {
            return this.idProducto;
        }

         // ---------------


        public void setCantidad(int cantidad)
        {
            Cantidad = cantidad;
        }

        public int getCantidad()
        {
            return this.Cantidad;
        }



    }
}
