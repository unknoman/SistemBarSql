using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlProyecto.pedido
{
    class Pedido
    {
        private static int idPedido;

        public void setIdPedido(int id)
        {
            idPedido = id;
        }
        
        public int getIdPedido()
        {
            return idPedido;
        }
    }
}
