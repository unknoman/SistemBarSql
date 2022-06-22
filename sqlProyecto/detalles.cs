using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using sqlProyecto.pedido;
using sqlProyecto.controlador;

namespace sqlProyecto
{
    public partial class detalles : Form
    {
        SQLcon db = new SQLcon();
        Controlador controlador = new Controlador();
        Pedido ped = new Pedido();
        string querydatos = "EXEC vertotal 1";
        public detalles()
        {
            InitializeComponent();
            controlador.cargarDatos(querydatos, gridDetallePedido);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            detalles detalles = new detalles();
            detalles.Text("id:" + ped.getIdPedido);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
