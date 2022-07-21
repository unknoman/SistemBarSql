using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlProyecto.pedido;
using sqlProyecto.controlador;

namespace sqlProyecto
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            Pedido pedido = new Pedido();
            Controlador controlador = new Controlador();
            int idpedido = pedido.getIdPedido();
           controlador.cargarDatos("SELECT Nombre, Cantidad, Estado, Unidad, TotalProducto FROM detallepedido", gridDetallePedido);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
