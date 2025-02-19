using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EmpleadosDAO
    {
        private conexion objConexion = new conexion();
        private MySqlConnection connection;
        private MySqlCommand cmd;
        private MySqlDataAdapter adaptador;

        public EmpleadosDAO()
        {
            connection = objConexion.Conecta();
            cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            adaptador = new MySqlDataAdapter(cmd);
        }
    }
}
