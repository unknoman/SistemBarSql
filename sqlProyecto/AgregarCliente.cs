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
using sqlProyecto.cliente;
using sqlProyecto.controlador;

namespace sqlProyecto
{
    public partial class AgregarCliente : Form
    {
      
        public AgregarCliente()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)

        {
            Controlador controlador = new Controlador();
            Cliente cliente = new Cliente();
            cliente.SetNombre(clienteTextbox.Text.ToString());
            cliente.insertarCliente(cliente.GetNombre());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
