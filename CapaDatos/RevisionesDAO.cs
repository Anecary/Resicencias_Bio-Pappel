using CapaEntidad;
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
    public class RevisionesDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;
        private conexion objconexion = new conexion();
        private MySqlConnection conn;
        private MySqlDataAdapter adapter;
        private MySqlCommand command;
        public DataTable consultaGeneralRevisiones()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("SELECT codigo,fecha_emision, fecha_revision, no_revision FROM revisiones", connection))
                    {
                        
                        command.CommandType = CommandType.Text;

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
        public int InsertarRevision(RevisionesCE revisiones)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Crea un comando para ejecutar el procedimiento almacenado
                    using (MySqlCommand command = new MySqlCommand("INSERTAR_REVISION", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agrega los parámetros del procedimiento almacenado
                        command.Parameters.AddWithValue("p_codigo", revisiones.codigo);
                        command.Parameters.AddWithValue("p_fecha_emision", revisiones.fecha_emision);
                        command.Parameters.AddWithValue("p_fecha_revision", revisiones.fecha_revision);
                        command.Parameters.AddWithValue("p_no_revision", revisiones.no_revision);

                        // Ejecuta el procedimiento almacenado
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar la revision: " + ex.Message);
                    return 0;
                }
            }
            return 1;
        }
    }
}
