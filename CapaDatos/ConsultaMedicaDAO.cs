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

        public DataSet consultaNotaNull(int idEmpleado)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ConsultaNotaNull", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idEmpleado = new MySqlParameter("@p_idEmpleado", MySqlDbType.Int32);
                p_idEmpleado.Direction = ParameterDirection.Input;
                p_idEmpleado.Value = idEmpleado;
                adapter.SelectCommand.Parameters.Add(p_idEmpleado);

                adapter.Fill(data, "ConsultaNotaNull");
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

        public bool InsertarConsultaMedica(ConsultaMedica consulta)
        {
            try
            {
                conn = objConexion.Conecta();
                using (MySqlCommand comando = new MySqlCommand("InsertarConsultaMedica", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@p_idEmpleado", consulta.IdEmpleado);
                    comando.Parameters.AddWithValue("@p_numExpediente", consulta.NumExpediente);
                    comando.Parameters.AddWithValue("@p_fecha", consulta.Fecha);
                    comando.Parameters.AddWithValue("@p_observaciones", consulta.Observaciones);
                    comando.Parameters.AddWithValue("@p_diagnostico", consulta.Diagnostico);
                    comando.Parameters.AddWithValue("@p_proceso", consulta.Proceso);
                    comando.Parameters.AddWithValue("@p_idTipoCausa", consulta.IdTipoCausa);

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

        public bool InsertarConsultaMedicaSin(ConsultaMedica consulta)
        {
            try
            {
                conn = objConexion.Conecta();
                using (MySqlCommand comando = new MySqlCommand("InsertarConsultaMedicaSin", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@p_idEmpleado", consulta.IdEmpleado);
                    comando.Parameters.AddWithValue("@p_fecha", consulta.Fecha);
                    comando.Parameters.AddWithValue("@p_observaciones", consulta.Observaciones);
                    comando.Parameters.AddWithValue("@p_diagnostico", consulta.Diagnostico);
                    comando.Parameters.AddWithValue("@p_proceso", consulta.Proceso);
                    comando.Parameters.AddWithValue("@p_idTipoCausa", consulta.IdTipoCausa);

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

        public bool ActualizarNumExpediente(ConsultaMedica consulta)
        {
            try
            {
                conn = objConexion.Conecta();
                using (MySqlCommand comando = new MySqlCommand("ActualizarNumExpediente", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros del procedimiento almacenado
                    comando.Parameters.AddWithValue("@p_idConsulta", consulta.IdConsulta);
                    comando.Parameters.AddWithValue("@p_numExpediente", consulta.NumExpediente);
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

        public DataTable ObtenerReporteNotaMedica_Causas(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("ConsultasCausas", conn)) // Llamar al procedimiento almacenado correcto
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@anio", año);
                    try
                    {
                        conn.Open();

                        // Ejecutar y llenar el DataTable
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return dt; // Retornar el DataTable con los datos
        }

        public DataTable ObtenerReporteNotaMedica_diaSemana(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("ConsultasDias", conn)) // Llamar al procedimiento almacenado correcto
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@anio", año);
                    try
                    {
                        conn.Open();

                        // Ejecutar y llenar el DataTable
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return dt; // Retornar el DataTable con los datos
        }

        public DataTable ObtenerReporteNotaMedica_Proceso(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("ConsultasProcesos", conn)) // Llamar al procedimiento almacenado correcto
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@anio", año);
                    try
                    {
                        conn.Open();

                        // Ejecutar y llenar el DataTable
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return dt; // Retornar el DataTable con los datos
        }

        public DataTable ObtenerReporteNotaMedica_Hora(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("ConsultasPorHora", conn)) // Llamar al procedimiento almacenado correcto
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@anio", año);
                    try
                    {
                        conn.Open();

                        // Ejecutar y llenar el DataTable
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return dt; // Retornar el DataTable con los datos
        }

        public DataTable ObtenerReporteNotaMedica_Año()
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("ConsultasPorAnio", conn)) // Llamar al procedimiento almacenado correcto
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        conn.Open();

                        // Ejecutar y llenar el DataTable
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            return dt; // Retornar el DataTable con los datos
        }
    }
}
