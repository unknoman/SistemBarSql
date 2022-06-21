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
                MessageBox.Show("" + cliente1.getId());
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("El campo no tiene que estar en blanco");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
