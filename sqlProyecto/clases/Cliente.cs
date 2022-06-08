using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace sqlProyecto.cliente
{
    class Cliente
    {
       private int id;
       private string nombre = "test";


       public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void Setid(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }


        public void insertarCliente(String nombre)
        {
            Cliente cliente1 = new Cliente();
            try
            {
                string query = "INSERT INTO barm.cliente (Nombre, Creacion) VALUES (@nombre, GETDATE());";
                SQLcon db = new SQLcon();
                db.Conexion.Open();
                SqlCommand comando = new SqlCommand(query, db.Conexion);
                comando.Parameters.Add(new SqlParameter("@nombre", nombre));
                comando.ExecuteNonQuery();
                db.CerrarConec();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}
