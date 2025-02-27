using MySql.Data.MySqlClient;
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
    }
}
