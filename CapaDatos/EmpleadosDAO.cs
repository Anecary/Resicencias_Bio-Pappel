using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EmpleadosDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;
        private conexion objconexion = new conexion();
        private MySqlConnection conn;   
        private MySqlDataAdapter adapter;
        private MySqlCommand command;
        public void InsertarEmpleado(
            string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento,
            char sexo, string estadoCivil, string nss, string rfc, string domicilioCalle,
            int domicilioNumero, string domicilioColonia, string domicilioCP, string domicilioCiudad,
            string domicilioEstado, string telefono)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("InDatosPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agrega los parámetros del procedimiento almacenado
                        command.Parameters.AddWithValue("p_nombre", nombre);
                        command.Parameters.AddWithValue("p_apellido_paterno", apellidoPaterno);
                        command.Parameters.AddWithValue("p_apellido_materno", apellidoMaterno);
                        command.Parameters.AddWithValue("p_fecha_nacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("p_sexo", sexo);
                        command.Parameters.AddWithValue("p_estado_civil", estadoCivil);
                        command.Parameters.AddWithValue("p_nss", nss);
                        command.Parameters.AddWithValue("p_rfc", rfc);
                        command.Parameters.AddWithValue("p_domicilio_Calle", domicilioCalle);
                        command.Parameters.AddWithValue("p_domicilio_Numero", domicilioNumero);
                        command.Parameters.AddWithValue("p_domicilio_Colonia", domicilioColonia);
                        command.Parameters.AddWithValue("p_domicilio_CP", domicilioCP);
                        command.Parameters.AddWithValue("p_domicilio_Ciudad", domicilioCiudad);
                        command.Parameters.AddWithValue("p_domicilio_Estado", domicilioEstado);
                        command.Parameters.AddWithValue("p_telefono", telefono);

                        // Ejecuta el procedimiento almacenado
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el empleado: " + ex.Message);
                }
            }
        }

        public void altaEmpleado(
            string nss,
            string numero_nomina,
            DateTime fecha_ingreso_puesto,
            DateTime fecha_ingreso_empresa,
            char turno,
            int idPuesto,
            char estado)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("ActuDatosLaborales",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("p_nss", nss);
                        command.Parameters.AddWithValue("p_numero_nomina", numero_nomina);
                        command.Parameters.AddWithValue("p_idPuesto_Actual", idPuesto);
                        command.Parameters.AddWithValue("p_fecha_ingreso_puesto", fecha_ingreso_puesto);
                        command.Parameters.AddWithValue("p_fecha_ingreso_empresa", fecha_ingreso_empresa);
                        command.Parameters.AddWithValue("p_turno", turno);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta al empleado: " + ex.Message);
            }
        }

        public (string nombreCompleto, string telefono, string domicilio, string estado) BusquedaParaActualizar(string nss)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("obtNSS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("p_nss", nss);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si hay resultados
                            {
                                string nombreCompleto = reader.GetString("nombre_completo");
                                string telefono = reader.GetString("telefono");
                                string domicilio = reader.GetString("dom");
                                string estado = reader.GetString("estado");

                                return (nombreCompleto, telefono, domicilio, estado);
                            }
                            else
                            {
                                throw new Exception("No se encontró un empleado con ese NSS.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el empleado: " + ex.Message);
                }
            }
        }

        public DataTable consultaGeneral () 
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("ConsulGe", connection))
                    {
                        // Indica que es un procedimiento almacenado
                        command.CommandType = CommandType.StoredProcedure;

                        // Crea un adaptador para llenar el DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            // Llena el DataTable con los resultados del procedimiento
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }

            return dataTable;

        }
        public (string nombreCompleto, DateTime fecha_nac , char sexo , string nss , string estado_civil, string domicilio, string domicilio_CP, string telefono, char turno, string puesto, int antiguedad, DateTime fecha_ingreso_empresa) ConsultaIndivisual(string numero_nomina)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("ConsIndi", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("a_numero_nomina", numero_nomina);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si hay resultados
                            {
                                string nombreCompleto = reader.GetString("nombre_completo");
                                DateTime fecha_nac = reader.GetDateTime("fecha_nacimiento");
                                char sexo = reader.GetChar("sexo");
                                string nss = reader.GetString("nss");
                                string estado_civil = reader.GetString("estado_civil");
                                string domicilio = reader.GetString("dom");
                                string domicilio_CP = reader.GetString("domicilio_CP");
                                string telefono = reader.GetString("telefono");
                                char turno = reader.GetChar("turno");
                                string puesto = reader.GetString("puesto");  // Reemplaza si "puesto" puede ser NULL
                                int antiguedad = reader.GetInt32("antiguedad");
                                DateTime fecha_ingreso_empresa = reader.GetDateTime("fecha_ingreso_empresa");


                                return (nombreCompleto, fecha_nac, sexo, nss, estado_civil, domicilio, domicilio_CP,telefono, turno, puesto, antiguedad, fecha_ingreso_empresa);
                            }
                            else
                            {
                                throw new Exception("No se encontró un empleado con ese NSS.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el empleado: " + ex.Message);
                }
            }
        }

        public (string nombreCompleto, DateTime fecha_nac, char sexo, string nss,string estado_civil, string domicilio_CP, 
            string domicilio_estado, string domicilio_ciudad, string domicilio_colonia, string domicilio_calle, string domicilio_numero, string telefono, char turno, DateTime fecha ,string puesto) ConsultaIndivisualActualizar(string numero_nomina)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("ObtenEmple", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("p_numero_nomina", numero_nomina);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si hay resultados
                            {
                                
                                string nombreCompleto = reader.GetString("nombre_completo");
                                DateTime fecha_nac = reader.GetDateTime("Fecha_Nacimiento");
                                char sexo = reader.GetChar("Sexo");
                                string nss = reader.GetString("Numero_Seguro");
                                string estado_civil = reader.GetString("Estado_Civil");
                                string domicilio_CP = reader.GetString("Codigo_Postal");          
                                string domicilio_estado = reader.GetString("Estado");
                                string domicilio_ciudad = reader.GetString("Ciudad");
                                string domicilio_colonia = reader.GetString("Colonia");
                                string domicilio_calle = reader.GetString("Calle");
                                string domicilio_numero = reader.GetInt32("Numero").ToString();
                                string telefono = reader.GetString("Telefono");
                                char turno = reader.GetString("Turno")[0];
                                DateTime fecha = reader.GetDateTime("Fecha");
                                string puesto = reader.GetString("Puesto");  // Reemplaza si "puesto" puede ser NULL
                                return (nombreCompleto, fecha_nac, sexo, nss, estado_civil, domicilio_CP, domicilio_estado,domicilio_ciudad, domicilio_colonia, domicilio_calle, domicilio_numero ,telefono, turno, fecha,puesto);
                            }
                            else
                            {
                                throw new Exception("No se encontró un empleado con ese NSS.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el empleado: " + ex.Message);
                }
            }

        }

        public void actualizarEmpleado(
            string numero_nomina,
            DateTime fecha_nueva,
            string estado_civil,
            string domicilio_CP,
            string domicilio_estado,
            string domicilio_ciudad,
            string domicilio_colonia,
            string domicilio_calle,
            int domicilio_numero,
            string telefono,
            char turno,
            string puesto)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("ActuEmple", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("p_numero_nomina", numero_nomina);
                        command.Parameters.AddWithValue("p_turno", turno);
                        command.Parameters.AddWithValue("p_nombre_puesto", puesto);
                        command.Parameters.AddWithValue("p_fecha_ingreso_puesto", fecha_nueva);
                        command.Parameters.AddWithValue("p_estado_civil", estado_civil);
                        command.Parameters.AddWithValue("p_domicilio_Calle", domicilio_calle);
                        command.Parameters.AddWithValue("p_domicilio_Numero", domicilio_numero);
                        command.Parameters.AddWithValue("p_domicilio_Colonia", domicilio_colonia);
                        command.Parameters.AddWithValue("p_domicilio_CP", domicilio_CP);
                        command.Parameters.AddWithValue("p_domicilio_Ciudad", domicilio_ciudad);
                        command.Parameters.AddWithValue("p_domicilio_Estado", domicilio_estado);
                        command.Parameters.AddWithValue("p_telefono", telefono);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de alta al empleado: " + ex.Message);
            }
        }

        public DataSet consultaEmpleadoNumNomina(string numNomina)
        {
            using (DataSet data = new DataSet())
            {
                conn = objconexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerEmpleadoPorNumNomina", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_numNomina = new MySqlParameter("@num_Nomina", MySqlDbType.VarChar);
                p_numNomina.Direction = ParameterDirection.Input;
                p_numNomina.Value = numNomina;
                adapter.SelectCommand.Parameters.Add(p_numNomina);

                adapter.Fill(data, "ConsultaEmpleado");
                return data;
            }
        }

    }
}
