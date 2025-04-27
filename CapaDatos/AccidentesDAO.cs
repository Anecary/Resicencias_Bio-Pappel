using MySql.Data.MySqlClient;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types;

namespace CapaDatos
{
    public class AccidentesDAO
    {
        private conexion objConexion = new conexion();
        private MySqlConnection conn;
        private MySqlDataAdapter adapter;
        private MySqlCommand comando;

        public int InsertarAccidente(AccidentesCE accidente)
        {
            try
            {
                conn = objConexion.Conecta();
                MySqlCommand cmd = new MySqlCommand("InsertarInvestigacionAccidente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //Insercion de Datos Generales
                cmd.Parameters.AddWithValue("@p_NoAccidente", accidente.NoAccidente);
                cmd.Parameters.AddWithValue("@p_Condicion", accidente.Condicion);
                cmd.Parameters.AddWithValue("@p_FechaRegistro", accidente.FechaRegistro);
                cmd.Parameters.AddWithValue("@p_idEmpleado", accidente.IdEmpleado);
                cmd.Parameters.AddWithValue("@p_numNomina", accidente.NumNomina);
                cmd.Parameters.AddWithValue("@p_Puesto", accidente.Puesto);
                cmd.Parameters.AddWithValue("@p_antiguedad", accidente.Antiguedad);
                cmd.Parameters.AddWithValue("@p_Edad", accidente.Edad);
                cmd.Parameters.AddWithValue("@p_Turno", accidente.Turno);
                cmd.Parameters.AddWithValue("@p_TiempoExtra", accidente.TiempoExtra);
                cmd.Parameters.AddWithValue("@p_TotalHrsExtras", accidente.TotalHrsExtras);
                cmd.Parameters.AddWithValue("@p_DiaDescansoPrevio", accidente.DiaDescansoPrevio);
                cmd.Parameters.AddWithValue("@p_DebidoA", accidente.DebidoA);
                cmd.Parameters.AddWithValue("@p_ParteCuerpoAfectada", accidente.ParteCuerpoAfectada);
                cmd.Parameters.AddWithValue("@p_TrabajoDesempeñado", accidente.TrabajoDesempenado);
                cmd.Parameters.AddWithValue("@p_TipoLesion", accidente.TipoLesion);
                cmd.Parameters.AddWithValue("@p_fecha_Hora_Accidente", accidente.FechaHoraAccidente);
                cmd.Parameters.AddWithValue("@p_TestigosJson", accidente.TestigosJson);

                //Insercion de Detalles Accidente 
                cmd.Parameters.AddWithValue("@p_accidentes_previos_30_dias", accidente.Lesion30Dias);
                cmd.Parameters.AddWithValue("@p_accidentes_previos_12_meses", accidente.Lesion12Meses);
                cmd.Parameters.AddWithValue("@p_proceso", accidente.Proceso);
                cmd.Parameters.AddWithValue("@p_idSeccionA", accidente.IdSeccionA);
                cmd.Parameters.AddWithValue("@p_lugar_accidente", accidente.LugarAccidente);
                cmd.Parameters.AddWithValue("@p_causa_Lesion", accidente.CausanteLesion);
                cmd.Parameters.AddWithValue("@p_equipo_Proteccion_usado", accidente.EquipoProteccionUsado);
                cmd.Parameters.AddWithValue("@p_equipo_Proteccion_Necesario", accidente.EquipoProteccionNecesario);
                cmd.Parameters.AddWithValue("@p_causas_basicas_accidente", accidente.CausaAccidente);
                cmd.Parameters.AddWithValue("@p_descripcion_accidente", accidente.DescripcionAccidente);
                cmd.Parameters.AddWithValue("@p_trabajo_Realizado_Antes", accidente.RealizoTrabajoAntes);
                cmd.Parameters.AddWithValue("@p_trabajo_Habitual", accidente.TrabajoHabitual);
                cmd.Parameters.AddWithValue("@p_trabajo_Programado", accidente.TrabajoProgramado);
                cmd.Parameters.AddWithValue("@p_trabajo_Necesario", accidente.TrabajoNecesario);
                cmd.Parameters.AddWithValue("@p_trabajo_Urgente", accidente.TrabajoUrgente);
                cmd.Parameters.AddWithValue("@p_danosMateriales", accidente.DanosMateriales);
                cmd.Parameters.AddWithValue("@p_pieza_equipo_danada", accidente.EquipoDanado);
                cmd.Parameters.AddWithValue("@p_sustituiblePor", accidente.SustituiblePor);
                cmd.Parameters.AddWithValue("@p_idSeccionB", accidente.IdSeccionB);

                //Factores de Seguridad
                cmd.Parameters.AddWithValue("@p_ITRS_Trabajo", accidente.ExistenITRs);
                cmd.Parameters.AddWithValue("@p_herramienta_equipo_adecuado", accidente.EquipoAdecuado);
                cmd.Parameters.AddWithValue("@p_ubicacion_conocida", accidente.ConociaTrabajo);
                cmd.Parameters.AddWithValue("@p_supervision", accidente.ExistiaSupervision);
                cmd.Parameters.AddWithValue("@p_riesgosJson", accidente.RiesgosJson);
                cmd.Parameters.AddWithValue("@p_actosInsegurosJson", accidente.ActosInsegurosJson);
                cmd.Parameters.AddWithValue("@p_condicionesInsegurasJson", accidente.CondicionesInsegurasJson);

                //Seguimiento del Caso
                cmd.Parameters.AddWithValue("@p_empleadosConocimientoJson", accidente.EmpleadosConocimientoJson);
                cmd.Parameters.AddWithValue("@p_empleadosInvolucradosJson", accidente.EmpleadosInvolucradosJson);
                cmd.Parameters.AddWithValue("@p_continua_trabajando", accidente.ContinuaTrabajando);
                cmd.Parameters.AddWithValue("@p_enviado_Domicilio", accidente.EnviadoDomicilio);
                cmd.Parameters.AddWithValue("@p_atencion_Medica", accidente.EnviadoAtencionMedica);
                cmd.Parameters.AddWithValue("@p_otro_diagnostico", accidente.Otro);
                cmd.Parameters.AddWithValue("@p_diagnostico_final", accidente.DiagnosticoFinal);
                cmd.Parameters.AddWithValue("@p_tratamiento", accidente.Tratamiento);
                cmd.Parameters.AddWithValue("@p_incapacidad", accidente.Incapacidad);


                //Control de Acciones
                cmd.Parameters.AddWithValue("@p_acciones_correctivas_prop", accidente.AccionesCorrectivasPropuestas);
                cmd.Parameters.AddWithValue("@p_quien_accionesC", accidente.QuienCorrectivasPropuesta);
                cmd.Parameters.AddWithValue("@p_cuando_accionesC", accidente.CuandoCorrectivasPropuestas);
                cmd.Parameters.AddWithValue("@p_acciones_preventivas_prop", accidente.AccionesPreventivasPropuestas);
                cmd.Parameters.AddWithValue("@p_quien_accionesP", accidente.QuienPreventivoPropuesto);
                cmd.Parameters.AddWithValue("@p_cuando_accionesP", accidente.CuandoPreventivasPropuestas);
                cmd.Parameters.AddWithValue("@p_seguimiento", accidente.Seguimiento);
                cmd.Parameters.AddWithValue("@p_fecha_hora_cierre_acc_seg", accidente.FechaHoraSeguimiento);
                cmd.Parameters.AddWithValue("@p_idEmpleadoProcesoSST", accidente.EmpleadoSeguimiento);
                cmd.Parameters.AddWithValue("@p_fecha_Recepcion_Documento", accidente.FechaHoraRecepcion);

                conn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("JAJAJAJAJJAJAJAJAJAJAJJAJAJAJAJAJJA");
                Console.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet ConcultaRiesgos()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerRiesgos", conn);
                adapter.Fill(data, "Riesgos");
                return data;
            }
        }
        public DataSet ConcultaActosInseguros()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerActosInseguros", conn);
                adapter.Fill(data, "ActosInseguros");
                return data;
            }
        }
        public DataSet ConcultaCondicionesInseguras()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerCondicionesInseguras", conn);
                adapter.Fill(data, "CondicionesInseguras");
                return data;
            }
        }
        public int InsertaNuevoRiesgo(string nuevoRiesgo)
        {
            using (conn = objConexion.Conecta())
            {
                conn.Open();
                comando = new MySqlCommand("InsertarRiesgo", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_riesgo", nuevoRiesgo);

                return comando.ExecuteNonQuery();
            }
        }
        public int InsertaNuevoActoInseguro(string nuevoActoInseguro)
        {
            using (conn = objConexion.Conecta())
            {
                conn.Open();
                comando = new MySqlCommand("InsertarActoInseguro", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_acto_inseguro", nuevoActoInseguro);

                return comando.ExecuteNonQuery();
            }
        }
        public int InsertaNuevaCondicionInsegura(string nuevaCondicionInsegura)
        {
            using (conn = objConexion.Conecta())
            {
                conn.Open();
                comando = new MySqlCommand("InsertarCondicionInsegura", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@p_condicion_insegura", nuevaCondicionInsegura);

                return comando.ExecuteNonQuery();
            }
        }
        public bool VerificarRiesgoExiste(string riesgo)
        {

            conn = objConexion.Conecta();
            comando = new MySqlCommand("call VerificarRiesgoExistente(@p_riesgo)", conn);
            comando.Parameters.AddWithValue("@p_riesgo", riesgo);
            conn.Open();
            int count = Convert.ToInt32(comando.ExecuteScalar());
            conn.Close();
            return count > 0;
        }
        public bool VerificarCondicionInseguraExiste(string condicionInsegura)
        {

            conn = objConexion.Conecta();
            comando = new MySqlCommand("call VerificarCondicionesInsegurasExistente(@p_condicion_insegura)", conn);
            comando.Parameters.AddWithValue("@p_condicion_insegura", condicionInsegura);
            conn.Open();
            int count = Convert.ToInt32(comando.ExecuteScalar());
            conn.Close();
            return count > 0;
        }
        public bool VerificarActoInseguroExiste(string actoInseguro)
        {
            conn = objConexion.Conecta();
            comando = new MySqlCommand("call VerificarActosInsegurosExistente(@p_acto_inseguro)", conn);
            comando.Parameters.AddWithValue("@p_acto_inseguro", actoInseguro);
            conn.Open();
            int count = Convert.ToInt32(comando.ExecuteScalar());
            conn.Close();
            return count > 0;
        }

        public DataSet consultaFechasAccidentesPorEmpleado(int idEmpleado)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerFechasAccidentesPorEmpleado", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idEmpleado = new MySqlParameter("@p_idEmpleado", MySqlDbType.Int32);
                p_idEmpleado.Direction = ParameterDirection.Input;
                p_idEmpleado.Value = idEmpleado;
                adapter.SelectCommand.Parameters.Add(p_idEmpleado);

                adapter.Fill(data, "ConsultaAccidentesXFecha");
                return data;
            }
        }
        public DataSet consultarDetalleInvAccidente_ActosInseguros(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerDetalle_InvAccidenteActosInseguros", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "Detalle_InvAccidenteActosInseguros");
                return data;
            }
        }
        public DataSet consultarDetalleInvAccidente_CondicionesInseguras(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerDetalle_InvAccidenteCondicionesInseguras", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "Detalle_InvAccidenteCondicionesInseguras");
                return data;
            }
        }
        public DataSet consultarDetalleInvAccidente_Riesgos(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerDetalle_InvAccidenteRiesgos", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "Detalle_InvAccidenteRiesgos");
                return data;
            }
        }
        public DataSet consultarDetalleInvAccidente_EmpleadosConocimiento(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerDetalle_EmpleadosConocimiento", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "Detalle_InvAccidenteEmpleadosConocimiento");
                return data;
            }
        }
        public DataSet consultarDetalleInvAccidente_EmpleadosInvolucrados(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerDetalle_EmpleadosInvolucrados", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "Detalle_InvAccidenteEmpleadosInvolucrados");
                return data;
            }
        }
        public DataSet consultarDetalleInvAccidente_EmpleadosTestigos(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerDetalle_EmpleadosTestigos", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "Detalle_InvAccidenteEmpleadosTestigos");
                return data;
            }
        }
        public DataSet consultarInvAccidentePorID(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerInvestigacionAccidentePorID", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "InvestigacionAccidentePorID");
                return data;
            }
        }
        public DataSet consultarInvAccidentesAcciones(int idAccidente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerInvestigacionAccidente_AccionesPorID", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idAccidente = new MySqlParameter("@p_idAccidente", MySqlDbType.Int32);
                p_idAccidente.Direction = ParameterDirection.Input;
                p_idAccidente.Value = idAccidente;
                adapter.SelectCommand.Parameters.Add(p_idAccidente);

                adapter.Fill(data, "InvestigacionAccidenteAcciones");
                return data;
            }
        }

        /*---+++++AREA DE REPORTES+++++----*/
        public DataTable ObtenerReporteAccidentes(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesPorAño", conn)) // Llamar al procedimiento almacenado
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro que espera el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@anio", año); // Asegúrate de que este nombre coincida con el del parámetro en el SP

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
                        // Es buena práctica al menos registrar el error
                        Console.WriteLine("Error al obtener el reporte: " + ex.Message);
                    }
                }
            }

            return dt; // Retornar el DataTable con los datos
        }

        public DataTable ObtenerReporteAccidentes_Secciones(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesPorProceso", conn)) // Llamar al procedimiento almacenado correcto
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

        public DataTable ObtenerReporteAccidentes_Semana(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesPorDia", conn)) // Llamar al procedimiento almacenado correcto
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

        public DataTable ObtenerReporteAccidentes_parteCuerpo(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesPorParteCuerpo", conn)) // Llamar al procedimiento almacenado correcto
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

        public DataTable ObtenerReporteAccidentes_Turno(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesPorTurno", conn)) // Llamar al procedimiento almacenado correcto
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


        public DataTable ObtenerReporteAccidentes_TLesion(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesTLesion", conn)) // Llamar al procedimiento almacenado correcto
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


        public DataTable ObtenerReporteAccidentes_IncapDepto(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesIncapDepto", conn)) // Llamar al procedimiento almacenado correcto
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

        public DataTable ObtenerReporteAccidentes_Condicion(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesCondicion", conn)) // Llamar al procedimiento almacenado correcto
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

        public DataTable ObtenerReporteAccidentes_Edad(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesEdad", conn)) // Llamar al procedimiento almacenado correcto
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

        public DataTable ObtenerReporteAccidentes_DebidoA(int año)
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesDebidoA", conn)) // Llamar al procedimiento almacenado correcto
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
    }
}
