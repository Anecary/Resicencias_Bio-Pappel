using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace CapaPresentacion.Utilerias
{
    public partial class frmImportarEmpleados : Form
    {
        private DataTable tablaDatos = new DataTable();
        private string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;
        public frmImportarEmpleados()
        {
            InitializeComponent();
        }

        private void frmImportarEmpleados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCargarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx",
                Title = "Selecciona un archivo Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaExcel = openFileDialog.FileName;

                try
                {
                    using (var workbook = new XLWorkbook(rutaExcel))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var range = worksheet.RangeUsed();
                        var rows = range.RowsUsed();

                        tablaDatos = new DataTable();

                        // ✅ Leer encabezados (primera fila)
                        var encabezados = rows.First().Cells();
                        foreach (var celda in encabezados)
                        {
                            tablaDatos.Columns.Add(celda.GetString());
                        }

                        // ✅ Leer datos (desde la segunda fila)
                        foreach (var row in rows.Skip(1))
                        {
                            var nuevaFila = tablaDatos.NewRow();
                            for (int i = 0; i < tablaDatos.Columns.Count; i++)
                            {
                                nuevaFila[i] = row.Cell(i + 1).GetString();
                            }
                            tablaDatos.Rows.Add(nuevaFila);
                        }

                        dgvPuestos.DataSource = tablaDatos;
                    }

                    RJMessageBox.Show("Datos cargados correctamente.");
                    btnSubir.Enabled = true;
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("Error al leer el archivo: " + ex.Message);
                }
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (tablaDatos.Rows.Count == 0)
            {
                RJMessageBox.Show("No hay datos para subir.");
                return;
            }

            try
            {
                using (var conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();

                    foreach (DataRow fila in tablaDatos.Rows)
                    {
                        string query = "CALL InsertarEmpleadoExcel(" +
                            "@numero_Nomina, @nombre, @apellido_Paterno, @apellido_Materno, @fecha_nacimiento, @turno, " +
                            "@puesto_nombre, @fecha_ingreso_puesto, @fecha_ingreso_empresa, @sexo, @estado_Civil, @NSS, @RFC, " +
                            "@domicilio_calle, @domicilio_numero, @domicilio_colonia, @domicilio_CP, @domicilio_ciudad, @domicilio_estado, @telefono" +
                        ")";

                        using (var comando = new MySqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@numero_Nomina", fila["numero_Nomina"]);
                            comando.Parameters.AddWithValue("@nombre", fila["nombre"]);
                            comando.Parameters.AddWithValue("@apellido_Paterno", fila["apellido_Paterno"]);
                            comando.Parameters.AddWithValue("@apellido_Materno", fila["apellido_Materno"]);

                            object fechaNacimientoParam;
                            if (DateTime.TryParse(fila["fecha_nacimiento"].ToString(), out DateTime fechaNacimiento))
                                fechaNacimientoParam = fechaNacimiento.ToString("yyyy-MM-dd");
                            else
                                fechaNacimientoParam = DBNull.Value;

                            comando.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimientoParam);

                            comando.Parameters.AddWithValue("@turno", fila["turno"]);
                            comando.Parameters.AddWithValue("@puesto_nombre", fila["puesto"]);

                            object ingresoPuestoParam;
                            if (DateTime.TryParse(fila["fecha_ingreso_puesto"].ToString(), out DateTime ingresoPuesto))
                                ingresoPuestoParam = ingresoPuesto.ToString("yyyy-MM-dd");
                            else
                                ingresoPuestoParam = DBNull.Value;
                            comando.Parameters.AddWithValue("@fecha_ingreso_puesto", ingresoPuestoParam);

                            object ingresoEmpresaParam;
                            if (DateTime.TryParse(fila["fecha_ingreso_empresa"].ToString(), out DateTime ingresoEmpresa))
                                ingresoEmpresaParam = ingresoEmpresa.ToString("yyyy-MM-dd");
                            else
                                ingresoEmpresaParam = DBNull.Value;
                            comando.Parameters.AddWithValue("@fecha_ingreso_empresa", ingresoEmpresaParam);

                            comando.Parameters.AddWithValue("@sexo", fila["sexo"]);
                            comando.Parameters.AddWithValue("@estado_Civil", fila["estado_Civil"]);
                            comando.Parameters.AddWithValue("@NSS", fila["NSS"]);
                            comando.Parameters.AddWithValue("@RFC", fila["RFC"]);
                            comando.Parameters.AddWithValue("@domicilio_calle", fila["domicilio_calle"]);
                            comando.Parameters.AddWithValue("@domicilio_numero", fila["domicilio_numero"]);
                            comando.Parameters.AddWithValue("@domicilio_colonia", fila["domicilio_colonia"]);
                            comando.Parameters.AddWithValue("@domicilio_CP", fila["domicilio_CP"]);
                            comando.Parameters.AddWithValue("@domicilio_ciudad", fila["domicilio_ciudad"]);
                            comando.Parameters.AddWithValue("@domicilio_estado", fila["domicilio_estado"]);
                            comando.Parameters.AddWithValue("@telefono", fila["telefono"]);

                            comando.ExecuteNonQuery();
                        }
                    }
                }
                RJMessageBox.Show("Empleados insertados correctamente.");
                btnSubir.Enabled = false;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }
    }
}
