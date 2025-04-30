using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CapaDatos
{
    public class ConsultaMedicaDAO
    {
        private conexion objConexion = new conexion();
        private MySqlConnection conn;
        private MySqlDataAdapter adapter;

        public DataSet consultaCausas()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerCausas", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(data, "ConsultaCausas");
                return data;
            }
        }

        public DataSet consultaTipoCausa(int idCausa)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerTipoCausa", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Creación y asignación del parámetro correcto
                MySqlParameter p_idCausa = new MySqlParameter("@p_idCausa", MySqlDbType.Int32);
                p_idCausa.Direction = ParameterDirection.Input;
                p_idCausa.Value = idCausa;
                adapter.SelectCommand.Parameters.Add(p_idCausa);

                adapter.Fill(data, "ConsultaTipoCausa");
                return data;
            }
        }

        public DataSet consultaEmpleadoNota(string nss)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ConsultarEmpleadoNota", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                // Creación y asignación del parámetro correcto
                MySqlParameter p_nss = new MySqlParameter("@p_nss", MySqlDbType.VarChar);
                p_nss.Direction = ParameterDirection.Input;
                p_nss.Value = nss;
                adapter.SelectCommand.Parameters.Add(p_nss);

                adapter.Fill(data, "consultarEmpleadoNota");
                return data;
            }
        }

        public DataSet consultarExpMedico(string numExpediente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ConsultarExpMedico", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_numExpediente = new MySqlParameter("@p_numExpediente", MySqlDbType.VarChar);
                p_numExpediente.Direction = ParameterDirection.Input;
                p_numExpediente.Value = numExpediente;
                adapter.SelectCommand.Parameters.Add(p_numExpediente);

                adapter.Fill(data, "consultarExpMedico");
                return data;
            }
        }

        public DataSet consultaNotaGeneral(string numExpediente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ConsultaNotaGeneral", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_numExpediente = new MySqlParameter("@p_numExpediente", MySqlDbType.VarChar);
                p_numExpediente.Direction = ParameterDirection.Input;
                p_numExpediente.Value = numExpediente;
                adapter.SelectCommand.Parameters.Add(p_numExpediente);

                adapter.Fill(data, "ConsultaNotaGeneral");
                return data;
            }
        }

        public DataSet consultaNotaNSS(string nss)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ConsultaNotaNSS", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_nss = new MySqlParameter("@p_nss", MySqlDbType.VarChar);
                p_nss.Direction = ParameterDirection.Input;
                p_nss.Value = nss;
                adapter.SelectCommand.Parameters.Add(p_nss);

                adapter.Fill(data, "ConsultaNotaNSS");
                return data;
            }
        }

        public DataSet consultaNotaIndividual(int idConsulta)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ConsultaNotaIndividual", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idConsulta = new MySqlParameter("@p_idConsulta", MySqlDbType.Int32);
                p_idConsulta.Direction = ParameterDirection.Input;
                p_idConsulta.Value = idConsulta;
                adapter.SelectCommand.Parameters.Add(p_idConsulta);

                adapter.Fill(data, "ConsultaNotaIndividual");
                return data;
            }
        }

        public bool InsertarConsultaMedica(int idEmpleado, string numExpediente, DateTime fecha, string observaciones, string diagnostico, string proceso, int idTipoCausa)
        {
            try
            {
                conn = objConexion.Conecta();
                using (MySqlCommand comando = new MySqlCommand("InsertarConsultaMedica", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@p_idEmpleado", idEmpleado);
                    comando.Parameters.AddWithValue("@p_numExpediente", numExpediente);
                    comando.Parameters.AddWithValue("@p_fecha", fecha);
                    comando.Parameters.AddWithValue("@p_observaciones", observaciones);
                    comando.Parameters.AddWithValue("@p_diagnostico", diagnostico);
                    comando.Parameters.AddWithValue("@p_proceso", proceso);
                    comando.Parameters.AddWithValue("@p_idTipoCausa", idTipoCausa);

                    conn.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool InsertarConsultaMedicaSin(int idEmpleado, DateTime fecha, string observaciones, string diagnostico, int idTipoCausa)
        {
            try
            {
                conn = objConexion.Conecta();
                using (MySqlCommand comando = new MySqlCommand("InsertarConsultaMedicaSin", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@p_idEmpleado", idEmpleado);
                    comando.Parameters.AddWithValue("@p_fecha", fecha);
                    comando.Parameters.AddWithValue("@p_observaciones", observaciones);
                    comando.Parameters.AddWithValue("@p_diagnostico", diagnostico);
                    comando.Parameters.AddWithValue("@p_idTipoCausa", idTipoCausa);

                    conn.Open();
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
