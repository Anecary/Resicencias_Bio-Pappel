using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class conexion
    {
        private MySqlConnection Conection;

        public MySqlConnection Conecta()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;
            Conection = new MySqlConnection(connectionString);
            return Conection;
        }
    }
}
