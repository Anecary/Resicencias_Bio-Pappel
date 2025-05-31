using CapaEntidad;
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
        public void InsertarEmpleado(EmpleadosCE empleados)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("InsertarEmpleadoCandidato", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agrega los parámetros del procedimiento almacenado
                        command.Parameters.AddWithValue("p_nombre", empleados.Nombre);
                        command.Parameters.AddWithValue("p_apellido_paterno", empleados.ApellidoPaterno);
                        command.Parameters.AddWithValue("p_apellido_materno", empleados.ApellidoMaterno);
                        command.Parameters.AddWithValue("p_fecha_nacimiento", empleados.FechaNacimiento);
                        command.Parameters.AddWithValue("p_sexo", empleados.Sexo);
                        command.Parameters.AddWithValue("p_estado_civil", empleados.EstadoCivil);
                        command.Parameters.AddWithValue("p_nss", empleados.NSS);
                        command.Parameters.AddWithValue("p_rfc", empleados.RFC);
                        command.Parameters.AddWithValue("p_domicilio_Calle", empleados.DomicilioCalle);
                        command.Parameters.AddWithValue("p_domicilio_Numero", empleados.DomicilioNumero);
                        command.Parameters.AddWithValue("p_domicilio_Colonia", empleados.DomicilioColonia);
                        command.Parameters.AddWithValue("p_domicilio_CP", empleados.DomicilioCP);
                        command.Parameters.AddWithValue("p_domicilio_Ciudad", empleados.DomicilioCiudad);
                        command.Parameters.AddWithValue("p_domicilio_Estado", empleados.DomicilioEstado);
                        command.Parameters.AddWithValue("p_telefono", empleados.Telefono);

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

        public void altaEmpleado(EmpleadosCE empleado)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("ActuDatosLaborales",connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("p_nss", empleado.NSS);
                        command.Parameters.AddWithValue("p_numero_nomina", empleado.NumeroNomina);
                        command.Parameters.AddWithValue("p_idPuesto_Actual", empleado.IdPuestoActual);
                        command.Parameters.AddWithValue("p_fecha_ingreso_puesto", empleado.FechaIngresoPuesto);
                        command.Parameters.AddWithValue("p_fecha_ingreso_empresa", empleado.FechaIngresoEmpresa);
                        command.Parameters.AddWithValue("p_turno", empleado.Turno);

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
                    using (MySqlCommand command = new MySqlCommand("ConsultaEmpleadosGral", connection))
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

        public DataTable consultaGeneralInactivos()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("ConsultaEmpleadosInactivos", connection))
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

        public DataTable consultaGeneralActivos()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("ConsultaEmpleadosActivos", connection))
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
                                string domicilio_numero = reader.GetString("Numero").ToString();
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

        public void actualizarEmpleado(EmpleadosCE empleado)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("ActualizarEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("p_numero_nomina", empleado.NumeroNomina);
                        command.Parameters.AddWithValue("p_turno", empleado.Turno);
                        command.Parameters.AddWithValue("p_nombre_puesto", empleado.Puesto);
                        command.Parameters.AddWithValue("p_fecha_ingreso_puesto", empleado.FechaIngresoPuesto);
                        command.Parameters.AddWithValue("p_estado_civil", empleado.EstadoCivil);
                        command.Parameters.AddWithValue("p_domicilio_Calle", empleado.DomicilioCalle);
                        command.Parameters.AddWithValue("p_domicilio_Numero", empleado.DomicilioNumero);
                        command.Parameters.AddWithValue("p_domicilio_Colonia", empleado.DomicilioColonia);
                        command.Parameters.AddWithValue("p_domicilio_CP", empleado.DomicilioCP);
                        command.Parameters.AddWithValue("p_domicilio_Ciudad", empleado.DomicilioCiudad);
                        command.Parameters.AddWithValue("p_domicilio_Estado", empleado.DomicilioEstado);
                        command.Parameters.AddWithValue("p_telefono", empleado.Telefono);

                        command.ExecuteNonQuery();
                        Console.WriteLine("Hola como estas?");
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

        public DataSet empleadoExiste(string numNomina)
        {
            using (DataSet data = new DataSet())
            {
                conn = objconexion.Conecta();
                adapter = new MySqlDataAdapter("VerificarEmpleadoExiste", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_nss = new MySqlParameter("@p_nss", MySqlDbType.VarChar);
                p_nss.Direction = ParameterDirection.Input;
                p_nss.Value = numNomina;
                adapter.SelectCommand.Parameters.Add(p_nss);

                adapter.Fill(data, "ConsultaEmpleadoExiste");
                return data;
            }
        }
        public void actualizarEmpleadoReingreso(EmpleadosCE empleados)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("ActualizarEmpleadoReingreso", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agrega los parámetros del procedimiento almacenado
                        command.Parameters.AddWithValue("p_idEmpleado", empleados.IdEmpleado);
                        command.Parameters.AddWithValue("p_sexo", empleados.Sexo);
                        command.Parameters.AddWithValue("p_estado_civil", empleados.EstadoCivil);
                        command.Parameters.AddWithValue("p_domicilio_Calle", empleados.DomicilioCalle);
                        command.Parameters.AddWithValue("p_domicilio_Numero", empleados.DomicilioNumero);
                        command.Parameters.AddWithValue("p_domicilio_Colonia", empleados.DomicilioColonia);
                        command.Parameters.AddWithValue("p_domicilio_CP", empleados.DomicilioCP);
                        command.Parameters.AddWithValue("p_domicilio_Ciudad", empleados.DomicilioCiudad);
                        command.Parameters.AddWithValue("p_domicilio_Estado", empleados.DomicilioEstado);
                        command.Parameters.AddWithValue("p_telefono", empleados.Telefono);

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
        public (string numnomina, string nombreCompleto, DateTime fecha_nac, char sexo, string nss, string estado_civil, string domicilio, string domicilio_CP, string telefono, char turno, string puesto, int antiguedad, DateTime fecha_ingreso_empresa, int idEmpleado) ConsultaEmpleadoNominaONss(string numnomina_nss)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("ObtenerEmpleadoPorNominaONSS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("p_nss_nomina", numnomina_nss);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si hay resultados
                            {
                                string numnomina = reader.GetString("numero_nomina");
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
                                int idEmpleado = reader.GetInt32("idEmpleado");

                                return (numnomina, nombreCompleto, fecha_nac, sexo, nss, estado_civil, domicilio, domicilio_CP, telefono, turno, puesto, antiguedad, fecha_ingreso_empresa, idEmpleado);
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
        public DataSet consultarInvAccidentePorEmpleado(int idempleado)
        {
            using (DataSet data = new DataSet())
            {
                conn = objconexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerInvestigacionAccidenteXEmpleado", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idempleado = new MySqlParameter("@p_idempleado", MySqlDbType.Int32);
                p_idempleado.Direction = ParameterDirection.Input;
                p_idempleado.Value = idempleado;
                adapter.SelectCommand.Parameters.Add(p_idempleado);

                adapter.Fill(data, "InvestigacionAccidentePorEmpleado");
                return data;
            }
        }

        public DataSet ObtenerTotalAccidentesXCondicion(int idEmpleado)
        {
            using (DataSet data = new DataSet())
            {
                conn = objconexion.Conecta();
                adapter = new MySqlDataAdapter("ObtenerTotalAccidentesXCondicion", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                MySqlParameter p_idEmpleado = new MySqlParameter("@p_idEmpleado", MySqlDbType.Int32);
                p_idEmpleado.Direction = ParameterDirection.Input;
                p_idEmpleado.Value = idEmpleado;
                adapter.SelectCommand.Parameters.Add(p_idEmpleado);

                adapter.Fill(data, "AccidentesEmpleadoXCondicion");
                return data;
            }
        }
    }
}
