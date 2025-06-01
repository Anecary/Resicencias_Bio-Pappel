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
        public DataSet ObtenerSeccionesConIncidentes()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalSecciones", conn);
                adapter.Fill(data, "SeccionesAccidentes");
                return data;
            }
        }















        public DataSet ObtenerNumConsultasMesPasado()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalConsultasMesPasado", conn);
                adapter.Fill(data, "TotalConsultas");
                return data;
            }
        }
        public DataSet ObtenerNumAccidentesMesPasado()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalAccidentesMesPasado", conn);
                adapter.Fill(data, "TotalAccidentes");
                return data;
            }
        }
        public DataSet ObtenerNumIncapacidadesMesPasado()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalIncapacidadesMesPasado", conn);
                adapter.Fill(data, "TotalIncapacidades");
                return data;
            }
        }

        public DataSet ObtenerCausasMasFrecuentesMesPasado()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerPrincipalesCausasMesPasado", conn);
                adapter.Fill(data, "CausasPrincipales");
                return data;
            }
        }

        public DataSet ObtenerAccidentesTurnoMesPasado()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerAccidentesTurnoMesPasado", conn);
                adapter.Fill(data, "AccidentesXTurno");
                return data;
            }
        }
        public DataSet ObtenerSeccionesConIncidentesMesPasado()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalSeccionesMesPasado", conn);
                adapter.Fill(data, "SeccionesAccidentes");
                return data;
            }
        }







        public DataSet ObtenerTotalConsultasPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalConsultasRango(@p_fechaInicio, @p_fechaFin)", conn);

                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaInicio", fechaInicio);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaFin", fechaFin);

                adapter.Fill(data, "TotalConsultasRango");
                return data;
            }
        }

        public DataSet ObtenerAccidentesTurnoPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerAccidentesTurnoPersonalizado(@p_fechaInicio, @p_fechaFin)", conn);

                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaInicio", fechaInicio);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaFin", fechaFin);

                adapter.Fill(data, "AccidentesXTurnoPersonalizado");
                return data;
            }
        }
        public DataSet ObtenerNumAccidentesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalAccidentesPorRango(@p_fechaInicio, @p_fechaFin)", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaInicio", fechaInicio);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaFin", fechaFin);

                adapter.Fill(data, "TotalAccidentes");
                return data;
            }
        }
        public DataSet ObtenerNumIncapacidadesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalIncapacidadesPorRango(@p_fechaInicio, @p_fechaFin)", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaInicio", fechaInicio);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaFin", fechaFin);

                adapter.Fill(data, "TotalIncapacidades");
                return data;
            }
        }

        public DataSet ObtenerSeccionesConIncidentesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerTotalSeccionesPorRango(@p_fechaInicio, @p_fechaFin)", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaInicio", fechaInicio);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaFin", fechaFin);

                adapter.Fill(data, "SeccionesAccidentes");
                return data;
            }
        }
        public DataSet ObtenerCausasMasFrecuentesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerPrincipalesCausasPorRango(@p_fechaInicio, @p_fechaFin)", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaInicio", fechaInicio);
                adapter.SelectCommand.Parameters.AddWithValue("@p_fechaFin", fechaFin);

                adapter.Fill(data, "CausasPrincipales");
                return data;
            }
        }
    }
}
