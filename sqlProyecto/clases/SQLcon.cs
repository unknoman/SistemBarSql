using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace sqlProyecto
{
    internal class SQLcon
    {
       string sql = "server=DESKTOP-UKDABGD\\SQLEXPRESS; database=barm; integrated security = true";

       public SqlConnection Conexion = new SqlConnection("server=DESKTOP-UKDABGD\\SQLEXPRESS; database=barm; integrated security = true");
        public void AbrirConeccion()
        {
            try
            {
                Conexion.Open();
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        public void CerrarConec()
        {
            SqlConnection Conexion = new SqlConnection(sql);
            Conexion.Close();
        }



    }
}
