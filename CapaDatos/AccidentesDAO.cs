using MySql.Data.MySqlClient;
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

        public int InsertarAccidente(int noAccidente, string condicion, DateTime fechaRegistro, int idEmpleado, string puesto, string edad, string turno, Boolean tiempoExtra, string totalHrsExtras, DateTime DiaDescansoPrevio, string parteCuerpoAfectada, string trabajoDesempeñado, string tipoLesion, DateTime fecha_hora_Accidente,
           Boolean lesion30Dias, Boolean lesion12Meses, string proceso, int idSeccionA, string lugarAccidente, string causanteLesion, string equipoProteccionUsado, string equipoProteccionNecesario, string causaAccidente, string descripcionAccidente, Boolean realizoTrabajoAntes, Boolean trabajoHabitual, Boolean trabajoProgramado, Boolean trabajoNecesario, Boolean trabajoUrgente, Boolean danosMateriales, string equipoDanado, string sustituiblePor, int idSeccionB,
           Boolean existenITRs, Boolean equipoAdecuado, Boolean conociaTrabajo, Boolean existiaSupervicion, string riesgosJson, string actosInsegurosJson, string condicionesInsegurasJson,
           string empleadosConocimientoJson, string empleadosInvolucradosJson, Boolean continuaTrabajando, Boolean enviadoDomicilio, Boolean enviadoAtencionMedica, string otro, string diagnosticoFinal, string tratamiento, string incapacidad,
           string accionesCorrectivasPropuestas, string quienCorrectivasPropuesta, string cuandoCorrectivasPropuestas, string accionesPreventivasPropuestas,string quienPreventivoPropuesto, string cuandoPreventivasPropuestas,string seguimiento, DateTime fecha_Hora_Seguimiento, int empleadoSeguimiento, DateTime fecha_Hora_recepcion,
            string testigosJson)
        {
            try
            {
                conn = objConexion.Conecta();
                MySqlCommand cmd = new MySqlCommand("InsertarInvestigacionAccidente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //Insercion de Datos Generales
                cmd.Parameters.AddWithValue("@p_NoAccidente", noAccidente);
                cmd.Parameters.AddWithValue("@p_Condicion", condicion);
                cmd.Parameters.AddWithValue("@p_FechaRegistro", fechaRegistro);
                cmd.Parameters.AddWithValue("@p_idEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@p_Puesto", puesto);
                cmd.Parameters.AddWithValue("@p_Edad", edad);
                cmd.Parameters.AddWithValue("@p_Turno", turno);
                cmd.Parameters.AddWithValue("@p_TiempoExtra", tiempoExtra);
                cmd.Parameters.AddWithValue("@p_TotalHrsExtras", totalHrsExtras);
                cmd.Parameters.AddWithValue("@p_DiaDescansoPrevio", DiaDescansoPrevio);
                cmd.Parameters.AddWithValue("@p_ParteCuerpoAfectada", parteCuerpoAfectada);
                cmd.Parameters.AddWithValue("@p_TrabajoDesempeñado", trabajoDesempeñado);
                cmd.Parameters.AddWithValue("@p_TipoLesion", tipoLesion);
                cmd.Parameters.AddWithValue("@p_fecha_Hora_Accidente", fecha_hora_Accidente);
                cmd.Parameters.AddWithValue("@p_TestigosJson", testigosJson);

                //Insercion de Detalles Accidente 
                cmd.Parameters.AddWithValue("@p_accidentes_previos_30_dias", lesion30Dias);
                cmd.Parameters.AddWithValue("@p_accidentes_previos_12_meses", lesion12Meses);
                cmd.Parameters.AddWithValue("@p_proceso", proceso);
                cmd.Parameters.AddWithValue("@p_idSeccionA", idSeccionA);
                cmd.Parameters.AddWithValue("@p_lugar_accidente", lugarAccidente);
                cmd.Parameters.AddWithValue("@p_causa_Lesion", causanteLesion);
                cmd.Parameters.AddWithValue("@p_equipo_Proteccion_usado", equipoProteccionUsado);
                cmd.Parameters.AddWithValue("@p_equipo_Proteccion_Necesario", equipoProteccionNecesario);
                cmd.Parameters.AddWithValue("@p_causas_basicas_accidente", causaAccidente);
                cmd.Parameters.AddWithValue("@p_descripcion_accidente", descripcionAccidente);
                cmd.Parameters.AddWithValue("@p_trabajo_Realizado_Antes", realizoTrabajoAntes);
                cmd.Parameters.AddWithValue("@p_trabajo_Habitual", trabajoHabitual);
                cmd.Parameters.AddWithValue("@p_trabajo_Programado", trabajoProgramado);
                cmd.Parameters.AddWithValue("@p_trabajo_Necesario", trabajoNecesario);
                cmd.Parameters.AddWithValue("@p_trabajo_Urgente", trabajoUrgente);
                cmd.Parameters.AddWithValue("@p_danosMateriales", danosMateriales);
                cmd.Parameters.AddWithValue("@p_pieza_equipo_danada", equipoDanado);
                cmd.Parameters.AddWithValue("@p_sustituiblePor", sustituiblePor);
                cmd.Parameters.AddWithValue("@p_idSeccionB", idSeccionB);

                //Factores de Seguridad
                cmd.Parameters.AddWithValue("@p_ITRS_Trabajo", existenITRs);
                cmd.Parameters.AddWithValue("@p_herramienta_equipo_adecuado", equipoAdecuado);
                cmd.Parameters.AddWithValue("@p_ubicacion_conocida", conociaTrabajo);
                cmd.Parameters.AddWithValue("@p_supervision", existiaSupervicion);
                cmd.Parameters.AddWithValue("@p_riesgosJson", riesgosJson);
                cmd.Parameters.AddWithValue("@p_actosInsegurosJson", actosInsegurosJson);
                cmd.Parameters.AddWithValue("@p_condicionesInsegurasJson", condicionesInsegurasJson);

                //Seguimiento del Caso
                cmd.Parameters.AddWithValue("@p_empleadosConocimientoJson", empleadosConocimientoJson);
                cmd.Parameters.AddWithValue("@p_empleadosInvolucradosJson", empleadosInvolucradosJson);
                cmd.Parameters.AddWithValue("@p_continua_trabajando", continuaTrabajando);
                cmd.Parameters.AddWithValue("@p_enviado_Domicilio", enviadoDomicilio);
                cmd.Parameters.AddWithValue("@p_atencion_Medica", enviadoAtencionMedica);
                cmd.Parameters.AddWithValue("@p_otro_diagnostico", otro);
                cmd.Parameters.AddWithValue("@p_diagnostico_final", diagnosticoFinal);
                cmd.Parameters.AddWithValue("@p_tratamiento", tratamiento);
                cmd.Parameters.AddWithValue("@p_incapacidad", incapacidad);


                //Control de Acciones
                cmd.Parameters.AddWithValue("@p_acciones_correctivas_prop", accionesCorrectivasPropuestas);
                cmd.Parameters.AddWithValue("@p_quien_accionesC", quienCorrectivasPropuesta);
                cmd.Parameters.AddWithValue("@p_cuando_accionesC", cuandoCorrectivasPropuestas);
                cmd.Parameters.AddWithValue("@p_acciones_preventivas_prop", accionesPreventivasPropuestas);
                cmd.Parameters.AddWithValue("@p_quien_accionesP", quienPreventivoPropuesto);
                cmd.Parameters.AddWithValue("@p_cuando_accionesP", cuandoPreventivasPropuestas);
                cmd.Parameters.AddWithValue("@p_seguimiento", seguimiento);
                cmd.Parameters.AddWithValue("@p_fecha_hora_cierre_acc_seg", fecha_Hora_Seguimiento);
                cmd.Parameters.AddWithValue("@p_idEmpleadoProcesoSST", empleadoSeguimiento);
                cmd.Parameters.AddWithValue("@p_fecha_Recepcion_Documento", fecha_Hora_recepcion);

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
            using(conn = objConexion.Conecta())
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
        public DataTable ObtenerReporteAccidentes()
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesPorAño", conn)) // Llamar al procedimiento almacenado correcto
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

        public DataTable ObtenerReporteAccidentes_Secciones()
        {
            DataTable dt = new DataTable(); // Crear el DataTable para almacenar los datos

            using (MySqlConnection conn = objConexion.Conecta()) // Conectar a la BD
            {
                using (MySqlCommand cmd = new MySqlCommand("AccidentesPorProceso", conn)) // Llamar al procedimiento almacenado correcto
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
