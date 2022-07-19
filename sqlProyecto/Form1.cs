using System.Data.SqlClient;
using System;
using System.Data;
using sqlProyecto.controlador;
using sqlProyecto.cliente;
using sqlProyecto.pedido;

namespace sqlProyecto
{
    public partial class Form1 : Form
    {
        string sqlcliente = "SELECT * FROM barm.cliente";
        string sqlProducto = "SELECT * FROM barm.Producto";
        string sqlEliminar = "DELETE FROM barm.cliente WHERE id = @id";
        string sqlPedido = "select * from verpedidos";
        Controlador controlador = new Controlador();
        Cliente cliente = new Cliente();
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
            Pedido pedido = new Pedido();
          //  detalles detalles = new detalles();
            pedido.setIdPedido(Convert.ToInt32(this.pedidosgrid.SelectedRows[0].Cells[0].Value));
          //  detalles.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cliente.Setid(Convert.ToInt32(this.clientesgrid.SelectedRows[0].Cells[0].Value));
            cliente.getId();
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

        private void button9_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea borrar el cliente: " + Convert.ToString(this.clientesgrid.SelectedRows[0].Cells[1].Value) + "?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    cliente.Setid(Convert.ToInt32(this.clientesgrid.SelectedRows[0].Cells[0].Value));
                    cliente.borrarcliente(cliente.getId());
                    controlador.cargarDatos(this.sqlcliente, this.clientesgrid);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Pedido pedido = new Pedido();
            pedido.setIdPedido(Convert.ToInt32(this.pedidosgrid.SelectedRows[0].Cells[0].Value));
            form2.ShowDialog();
        }
    }
}