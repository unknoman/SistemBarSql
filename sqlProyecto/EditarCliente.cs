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
        Cliente cliente1 = new Cliente();

        public EditarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!NombreEdit.Text.Equals(""))
            {
                cliente1.SetNombre(NombreEdit.Text.ToString());
                cliente1.ActualizarCliente(cliente1.getId(), cliente1.GetNombre());
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Tenes que completar el campo para poder editar el nombre");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
