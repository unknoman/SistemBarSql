using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlProyecto.cliente;

namespace sqlProyecto
{
    public partial class EditarCliente : Form
    {
        Cliente cliente = new Cliente();
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.SetNombre(NombreEdit.Text.ToString());
            Cliente.ActualizarCliente(Cliente.getId(), Cliente.GetNombre());
            MessageBox.Show(cliente.GetNombre());
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
