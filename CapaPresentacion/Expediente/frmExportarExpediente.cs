using CapaNegocios;
using CapaPresentacion.Restaurar_Y_Respaldar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Drawing.Drawing2D;
// using System.Windows.Controls;
using MaterialSkin;
namespace CapaPresentacion.Expediente
{
    public partial class frmExportarExpediente : Form
    {
        private Panel p = new Panel();
        ExpedientesCN expedientesCN = new ExpedientesCN();
       
        public frmExportarExpediente()
        {
            InitializeComponent();


            panel4.Paint += new PaintEventHandler(Panel1_Paint);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Definir el radio de los bordes redondeados
                int radius = 20;

                // Crear un `GraphicsPath` para el área recortada del panel
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(0, panel.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                // Aplicar el área recortada al panel
                panel.Region = new Region(path);

                // Dibujar el borde con el color deseado
                Pen pen = new Pen(Color.FromArgb(6, 103, 105), 5); // Cambia el color aquí
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void frmExportarExpediente_Load(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Ocurrió un error al cargar los expedientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarGrid()
        {
            var ds = expedientesCN.CargaDataGridVista();
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables["vistaExpedientes"];

                // Limpiar filas anteriores, pero NO las columnas
                dgvVistaExpedientes.Rows.Clear();

                // Agregar los datos a las columnas ya creadas (rowtabla, rowCampooriginal, rowcampo)
                foreach (DataRow dr in dt.Rows)
                {
                    int index = dgvVistaExpedientes.Rows.Add();
                    DataGridViewRow row = dgvVistaExpedientes.Rows[index];

                    row.Cells["rowTabla"].Value = dr["Tabla"].ToString();
                    row.Cells["rowCampoOriginal"].Value = dr["CampoOriginal"].ToString();
                    row.Cells["rowCampo"].Value = dr["Campo"].ToString();
                }

                // Centrar la columna si aún lo deseas
                foreach (DataGridViewRow row in dgvVistaExpedientes.Rows)
                {
                    row.Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvVistaExpedientes.Rows)
            {
                row.Cells["rowSeleccion"].Value = true; // Marcar el checkbox como seleccionado

            }
        }

        private void btnAnularSeleccion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvVistaExpedientes.Rows)
            {
                row.Cells["rowSeleccion"].Value = false; // Marcar el checkbox como seleccionado

            }
        }
        private void btnExportarExpediente_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una columna seleccionada
            bool algunaSeleccionada = dgvVistaExpedientes.Rows
                .Cast<DataGridViewRow>()
                .Any(fila => Convert.ToBoolean((fila.Cells["rowSeleccion"] as DataGridViewCheckBoxCell)?.Value));

            if (!algunaSeleccionada)
            {
                RJMessageBox.Show("Por favor, seleccione al menos un campo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> columnasSeleccionadas = new List<string>();

            foreach (DataGridViewRow fila in dgvVistaExpedientes.Rows)
            {
                var checkBox = fila.Cells["rowSeleccion"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkBox?.Value))
                {
                    string tabla = fila.Cells["rowTabla"]?.Value?.ToString()?.Trim();
                    string campo = fila.Cells["rowCampoOriginal"]?.Value?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(tabla) && !string.IsNullOrEmpty(campo))
                    {
                        columnasSeleccionadas.Add($"{tabla}.{campo}");
                    }
                }
            }

            string columnas = string.Join(",", columnasSeleccionadas);

            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    save.Title = "Guardar expediente exportado";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        DataSet datos = expedientesCN.consultaCamposDinamico(columnas);
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            foreach (DataTable table in datos.Tables)
                            {
                                workbook.Worksheets.Add(table, "ConsultaExpedienteDinamico");
                            }

                            workbook.SaveAs(save.FileName);
                            RJMessageBox.Show("Exportación completada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Ocurrió un error al exportar el expediente:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
