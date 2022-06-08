using System.Data.SqlClient;
using System;
using System.Data;
using sqlProyecto.controlador;
using sqlProyecto.cliente;
namespace sqlProyecto
{
    public partial class Form1 : Form
    {
        string sqlcliente = "SELECT * FROM barm.cliente";
        string sqlProducto = "SELECT * FROM barm.Producto";
        string sqlPedido = "pedido_Join";
        Controlador controlador = new Controlador();
        Cliente Cliente = new Cliente();
        AgregarCliente agregarCliente = new AgregarCliente();
        EditarCliente editarCliente = new EditarCliente();
        public Form1()
        {
            InitializeComponent();
            controlador.cargarDatos(sqlcliente, clientesgrid);
            controlador.cargarDatos(sqlProducto, productoGrid);
            controlador.cargarDatos(sqlPedido, pedidosgrid);
        }





        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cliente.Setid(Convert.ToInt32(this.clientesgrid.SelectedRows[0].Cells[0].Value));
            if (editarCliente.ShowDialog() == DialogResult.OK)
            {
                controlador.cargarDatos(this.sqlcliente, this.clientesgrid);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (agregarCliente.ShowDialog() == DialogResult.OK)
            {
                controlador.cargarDatos(this.sqlcliente, this.clientesgrid);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

    }
}