using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDatos
{
    public class SeccionesDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;

        public int ObtenerUltimoIdInsertado(string nombreTabla, string nombreColumnaId)
        {
            int ultimoId = 0;

            // Consulta SQL para obtener el último ID insertado
            string query = $"SELECT MAX({nombreColumnaId}) FROM {nombreTabla};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Ejecuta la consulta y obtén el resultado
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            ultimoId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el último ID: " + ex.Message);
                }
            }

            return ultimoId;
        }

        public DataTable ConsultaGeneral(string nombreProcedimiento)
        {
            {
                DataTable dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Crea un comando para ejecutar el procedimiento almacenado
                        using (MySqlCommand command = new MySqlCommand(nombreProcedimiento, connection))
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
        }

        public void InsertarSeccion(string seccion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("InsertarSeccion", connection))
                    {
                        // Indica que es un procedimiento almacenado
                        command.CommandType = CommandType.StoredProcedure;

                        // Agrega el parámetro del puesto
                        command.Parameters.AddWithValue("p_seccion", seccion);

                        // Ejecuta el procedimiento almacenado
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar la seccion: " + ex.Message);
                }
            }
        }
    }
}
