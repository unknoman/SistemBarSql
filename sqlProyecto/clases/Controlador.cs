using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sqlProyecto.cliente;
using System.Data.SqlClient;
using System.Data;
namespace sqlProyecto.controlador
{
    internal class Controlador
    {


        public void cargarDatos(string queryxd, DataGridView gridxd)
        {
            SQLcon sabnock = new SQLcon();
            gridxd.EnableHeadersVisualStyles = false;
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(queryxd, sabnock.Conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                gridxd.DataSource = dt;
                gridxd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridxd.Columns[gridxd.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridxd.EnableHeadersVisualStyles = false;
                SQLcon con = new SQLcon();
                con.CerrarConec();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
