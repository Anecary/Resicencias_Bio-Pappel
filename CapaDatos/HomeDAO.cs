using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class HomeDAO
    {
        private conexion objConexion = new conexion();
        private MySqlConnection conn;
        private MySqlDataAdapter adapter;
        private MySqlCommand comando;

        public DataSet ConcultaNumTrabajadores()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalEmpleados", conn);
                adapter.Fill(data, "TotalEmpleados");
                return data;
            }
        }
        public DataSet ObtenerNumConsultas()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalConsultas", conn);
                adapter.Fill(data, "TotalConsultas");
                return data;
            }
        }
        public DataSet ObtenerNumAccidentes()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalAccidentes", conn);
                adapter.Fill(data, "TotalAccidentes");
                return data;
            }
        }
        public DataSet ObtenerNumIncapacidades()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalIncapacidades", conn);
                adapter.Fill(data, "TotalIncapacidades");
                return data;
            }
        }

        public DataSet ObtenerCausasMasFrecuentes()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerPrincipalesCausas", conn);
                adapter.Fill(data, "CausasPrincipales");
                return data;
            }
        }

        public DataSet ObtenerAccidentesTurno()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerAccidentesTurno", conn);
                adapter.Fill(data, "AccidentesXTurno");
                return data;
            }
        }
    }
}
