using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PuestosDAO
    {
        private conexion objConexion = new conexion();
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataAdapter adaptador;

        public PuestosDAO()
        {
            connection = objConexion.Conecta();
            cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            adaptador = new MySqlDataAdapter(cmd);
        }

        public DataSet SubePuestos()
        {
            DataSet data = new DataSet();
            try
            {
                cmd.CommandText = "SubePuestos";
                connection.Open();

                adaptador.Fill(data, "Sube");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }
    }
}
