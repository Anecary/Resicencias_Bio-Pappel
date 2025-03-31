using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ExpedientesDAO
    {
        private conexion objConexion = new conexion();
        private MySqlConnection conn;
        private MySqlDataAdapter adapter;
        private MySqlCommand comando;

        public int InsertarExpediente(ExpedientesCE expediente)
        {
            try
            {
                conn = objConexion.Conecta();
                MySqlCommand cmd = new MySqlCommand("insertarExpediente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //Insercion de Datos Generales
                cmd.Parameters.AddWithValue("@p_Num_Expediente", expediente.NumExpediente);
                cmd.Parameters.AddWithValue("@p_IdEmpleado", expediente.IdEmpleado);
                cmd.Parameters.AddWithValue("@p_numNomina", expediente.NumNomina);
                cmd.Parameters.AddWithValue("@p_Fecha_apertura_Exp", expediente.FechaApertura);
                cmd.Parameters.AddWithValue("@p_Antecedentes_Heredofamiliares", expediente.HeredoFamiliar);
                cmd.Parameters.AddWithValue("@p_Diagnostico_inicial", expediente.DiagnosticoInicial);

                // No Patológicos
                cmd.Parameters.AddWithValue("@p_Casa", expediente.Casa);
                cmd.Parameters.AddWithValue("@p_Alimentacion", expediente.Alimentacion);
                cmd.Parameters.AddWithValue("@p_Animales", expediente.Animales);
                cmd.Parameters.AddWithValue("@p_Inmunizaciones", expediente.Inmunizaciones);
                cmd.Parameters.AddWithValue("@p_Toxicomanias", expediente.Toxicomanias);
                cmd.Parameters.AddWithValue("@p_Trabajo_actividades_anteriores", expediente.TrabajoActividadesAnteriores);
                cmd.Parameters.AddWithValue("@p_Deportes", expediente.Deportes);
                cmd.Parameters.AddWithValue("@p_Entorno_Familiar", expediente.EntornoFamiliar);
                cmd.Parameters.AddWithValue("@p_Escolaridad", expediente.Escolaridad);

                // Patológicos (Convertimos bool a int para BD)
                cmd.Parameters.AddWithValue("@p_Hospitalizaciones", expediente.Hospitalizaciones ? 1 : 0);
                cmd.Parameters.AddWithValue("@p_Cirugias", expediente.Cirugias ? 1 : 0);
                cmd.Parameters.AddWithValue("@p_Transfusiones", expediente.Transfusiones ? 1 : 0);
                cmd.Parameters.AddWithValue("@p_Alergias", expediente.Alergias);

                // Sistemas del cuerpo
                cmd.Parameters.AddWithValue("@p_SistemaNervioso_Central", expediente.SistemaNerviosoCentral);
                cmd.Parameters.AddWithValue("@p_SistemaCardiovascular", expediente.SistemaCardiovascular);
                cmd.Parameters.AddWithValue("@p_SistemaRespiratorio", expediente.SistemaRespiratorio);
                cmd.Parameters.AddWithValue("@p_SistemaGastrointestinal", expediente.SistemaGastrointestinal);
                cmd.Parameters.AddWithValue("@p_SistemaEndocrinico", expediente.SistemaEndocrinico);
                cmd.Parameters.AddWithValue("@p_SistemaGenitourinario", expediente.SistemaGenitourinario);
                cmd.Parameters.AddWithValue("@p_SistemaMusculoesqueletico", expediente.SistemaMusculoesqueletico);
                cmd.Parameters.AddWithValue("@p_Organo_Sentidos", expediente.OrganoSentidos);
                cmd.Parameters.AddWithValue("@p_Grupo_Sanguineo", expediente.GrupoSanguineo);

                // Estudios Paraclínicos
                cmd.Parameters.AddWithValue("@p_Estudios_Laboratorio", expediente.EstudiosLaboratorio);
                cmd.Parameters.AddWithValue("@p_Estudios_Radiologicos", expediente.EstudiosRadiologicos);
                cmd.Parameters.AddWithValue("@p_Otros", expediente.Otros);

                // Constitución Física
                cmd.Parameters.AddWithValue("@p_Constitucion_Fisica", expediente.Constitucion_Fisica);
                cmd.Parameters.AddWithValue("@p_Talla", expediente.Talla);
                cmd.Parameters.AddWithValue("@p_Peso", expediente.Peso);
                cmd.Parameters.AddWithValue("@p_IMC", expediente.IMC);
                cmd.Parameters.AddWithValue("@p_Grado", expediente.Grado);
                cmd.Parameters.AddWithValue("@p_FC", expediente.Fc);
                cmd.Parameters.AddWithValue("@p_FR", expediente.Fr);
                cmd.Parameters.AddWithValue("@p_Pulso", expediente.Pulso);
                cmd.Parameters.AddWithValue("@p_TA", expediente.Ta);
                cmd.Parameters.AddWithValue("@p_Temperatura", expediente.Temperatura);

                // Exploración Física
                cmd.Parameters.AddWithValue("@p_Craneo", expediente.Craneo);
                cmd.Parameters.AddWithValue("@p_Ojos", expediente.Ojos);
                cmd.Parameters.AddWithValue("@p_Oidos", expediente.Oidos);
                cmd.Parameters.AddWithValue("@p_Nariz", expediente.Nariz);
                cmd.Parameters.AddWithValue("@p_Boca", expediente.Boca);
                cmd.Parameters.AddWithValue("@p_Cuello", expediente.Cuello);
                cmd.Parameters.AddWithValue("@p_Torax", expediente.Torax);
                cmd.Parameters.AddWithValue("@p_Abdomen", expediente.Abdomen);
                cmd.Parameters.AddWithValue("@p_Genitourinario", expediente.Genitourinario);
                cmd.Parameters.AddWithValue("@p_MusculoEsqueletico", expediente.MusculoEsqueletico);
                cmd.Parameters.AddWithValue("@p_Neurologico", expediente.Neurologico);


                cmd.Parameters.AddWithValue("@p_UltimaFechaActualizacion", expediente.UltimaActualizacion);



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

        public DataSet consultaExpediente(string numExpediente)
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerExpediente", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_numExpediente = new MySqlParameter("@p_numExpediente", MySqlDbType.VarChar);
                p_numExpediente.Direction = ParameterDirection.Input;
                p_numExpediente.Value = numExpediente;
                adapter.SelectCommand.Parameters.Add(p_numExpediente);

                adapter.Fill(data, "ConsultaNumExpediente");
                return data;
            }
        }
        public DataSet ConcultaNumExpedientes()
        {
            using (DataSet data = new DataSet())
            {
                conn = objConexion.Conecta();
                adapter = new MySqlDataAdapter("call ObtenerNumExpedientes", conn);
                adapter.Fill(data, "numExpedientes");
                return data;
            }
        }
        public int ActualizarExpediente(ExpedientesCE expediente)
        {
            try
            {
                conn = objConexion.Conecta();
                MySqlCommand cmd = new MySqlCommand("actualizarExpediente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //Insercion de Datos Generales
                cmd.Parameters.AddWithValue("@p_Num_Expediente", expediente.NumExpediente);
                cmd.Parameters.AddWithValue("@p_Antecedentes_Heredofamiliares", expediente.HeredoFamiliar);
                cmd.Parameters.AddWithValue("@p_Diagnostico_inicial", expediente.DiagnosticoInicial);

                // No Patológicos
                cmd.Parameters.AddWithValue("@p_Casa", expediente.Casa);
                cmd.Parameters.AddWithValue("@p_Alimentacion", expediente.Alimentacion);
                cmd.Parameters.AddWithValue("@p_Animales", expediente.Animales);
                cmd.Parameters.AddWithValue("@p_Inmunizaciones", expediente.Inmunizaciones);
                cmd.Parameters.AddWithValue("@p_Toxicomanias", expediente.Toxicomanias);
                cmd.Parameters.AddWithValue("@p_Trabajo_actividades_anteriores", expediente.TrabajoActividadesAnteriores);
                cmd.Parameters.AddWithValue("@p_Deportes", expediente.Deportes);
                cmd.Parameters.AddWithValue("@p_Entorno_Familiar", expediente.EntornoFamiliar);
                cmd.Parameters.AddWithValue("@p_Escolaridad", expediente.Escolaridad);

                // Patológicos (Convertimos bool a int para BD)
                cmd.Parameters.AddWithValue("@p_Hospitalizaciones", expediente.Hospitalizaciones ? 1 : 0);
                cmd.Parameters.AddWithValue("@p_Cirugias", expediente.Cirugias ? 1 : 0);
                cmd.Parameters.AddWithValue("@p_Transfusiones", expediente.Transfusiones ? 1 : 0);
                cmd.Parameters.AddWithValue("@p_Alergias", expediente.Alergias);

                // Sistemas del cuerpo
                cmd.Parameters.AddWithValue("@p_SistemaNervioso_Central", expediente.SistemaNerviosoCentral);
                cmd.Parameters.AddWithValue("@p_SistemaCardiovascular", expediente.SistemaCardiovascular);
                cmd.Parameters.AddWithValue("@p_SistemaRespiratorio", expediente.SistemaRespiratorio);
                cmd.Parameters.AddWithValue("@p_SistemaGastrointestinal", expediente.SistemaGastrointestinal);
                cmd.Parameters.AddWithValue("@p_SistemaEndocrinico", expediente.SistemaEndocrinico);
                cmd.Parameters.AddWithValue("@p_SistemaGenitourinario", expediente.SistemaGenitourinario);
                cmd.Parameters.AddWithValue("@p_SistemaMusculoesqueletico", expediente.SistemaMusculoesqueletico);
                cmd.Parameters.AddWithValue("@p_Organo_Sentidos", expediente.OrganoSentidos);
                cmd.Parameters.AddWithValue("@p_Grupo_Sanguineo", expediente.GrupoSanguineo);

                // Estudios Paraclínicos
                cmd.Parameters.AddWithValue("@p_Estudios_Laboratorio", expediente.EstudiosLaboratorio);
                cmd.Parameters.AddWithValue("@p_Estudios_Radiologicos", expediente.EstudiosRadiologicos);
                cmd.Parameters.AddWithValue("@p_Otros", expediente.Otros);

                // Constitución Física
                cmd.Parameters.AddWithValue("@p_Constitucion_Fisica", expediente.Constitucion_Fisica);
                cmd.Parameters.AddWithValue("@p_Talla", expediente.Talla);
                cmd.Parameters.AddWithValue("@p_Peso", expediente.Peso);
                cmd.Parameters.AddWithValue("@p_IMC", expediente.IMC);
                cmd.Parameters.AddWithValue("@p_Grado", expediente.Grado);
                cmd.Parameters.AddWithValue("@p_FC", expediente.Fc);
                cmd.Parameters.AddWithValue("@p_FR", expediente.Fr);
                cmd.Parameters.AddWithValue("@p_Pulso", expediente.Pulso);
                cmd.Parameters.AddWithValue("@p_TA", expediente.Ta);
                cmd.Parameters.AddWithValue("@p_Temperatura", expediente.Temperatura);

                // Exploración Física
                cmd.Parameters.AddWithValue("@p_Craneo", expediente.Craneo);
                cmd.Parameters.AddWithValue("@p_Ojos", expediente.Ojos);
                cmd.Parameters.AddWithValue("@p_Oidos", expediente.Oidos);
                cmd.Parameters.AddWithValue("@p_Nariz", expediente.Nariz);
                cmd.Parameters.AddWithValue("@p_Boca", expediente.Boca);
                cmd.Parameters.AddWithValue("@p_Cuello", expediente.Cuello);
                cmd.Parameters.AddWithValue("@p_Torax", expediente.Torax);
                cmd.Parameters.AddWithValue("@p_Abdomen", expediente.Abdomen);
                cmd.Parameters.AddWithValue("@p_Genitourinario", expediente.Genitourinario);
                cmd.Parameters.AddWithValue("@p_MusculoEsqueletico", expediente.MusculoEsqueletico);
                cmd.Parameters.AddWithValue("@p_Neurologico", expediente.Neurologico);


                cmd.Parameters.AddWithValue("@p_UltimaFechaActualizacion", expediente.UltimaActualizacion);



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
    }
}
