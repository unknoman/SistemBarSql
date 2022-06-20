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
        protected int id;
        protected string nombre;
        private static int id1;


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
            id1 = id;
        }

        public int getId()
        {
            return id1;
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



        public void ActualizarCliente(int id, string nombre)
        {
            Cliente cliente1 = new Cliente();
            try
            {
                string query = "UPDATE barm.cliente SET Nombre = @nombre WHERE idCliente = @IdCliente;";
                SQLcon db = new SQLcon();
                db.Conexion.Open();
                SqlCommand comando = new SqlCommand(query, db.Conexion);
                comando.Parameters.Add(new SqlParameter("@IdCliente", id));
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
