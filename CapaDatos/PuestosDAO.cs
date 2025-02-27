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
    public class PuestosDAO
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

        public void InsertarPuesto(string puesto)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("InsertarPuesto", connection))
                    {
                        // Indica que es un procedimiento almacenado
                        command.CommandType = CommandType.StoredProcedure;

                        // Agrega el parámetro del puesto
                        command.Parameters.AddWithValue("p_puesto", puesto);

                        // Ejecuta el procedimiento almacenado
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el puesto: " + ex.Message);
                }
            }
        }

        public List<(int idPuesto, string puesto)> ObtenerPuestos()
        {
            List<(int, string)> puestos = new List<(int, string)>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT idPuesto, puesto FROM puestos"; // Ajusta el nombre de la tabla y columnas si es necesario

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar los resultados a la lista
                                puestos.Add((reader.GetInt32("idPuesto"), reader.GetString("puesto")));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los puestos: " + ex.Message);
                }
            }

            return puestos; // Devuelve la lista de puestos
        }
    }
}
