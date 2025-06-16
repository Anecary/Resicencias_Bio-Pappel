using CapaNegocios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CapaPresentacion.Utilerias


{
    public partial class frmBitacora : Form
    {
        HomeCN HomeCN = new HomeCN();

        public frmBitacora()
        {
            InitializeComponent();

            panel69.Paint += new PaintEventHandler(Panel1_Paint);
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

        private void pContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cargarArchivo()
        {
            try
            {
                // Ruta original del archivo de log
                string rutaOriginal = @"C:\Program Files\MariaDB 11.6\data\sql_errors.log";

                // Ruta temporal a la que haremos la copia
                string rutaTemporal = Path.Combine(Path.GetTempPath(), "sql_errors_copy.log");

                // Copiar el archivo para evitar el bloqueo
                File.Copy(rutaOriginal, rutaTemporal, true);

                // Leer todas las líneas del archivo copiado
                string[] lineas = File.ReadAllLines(rutaTemporal);

                // Crear DataTable para mostrar en el DataGridView
                DataTable tablaErrores = new DataTable();
                tablaErrores.Columns.Add("ErrorLog");

                foreach (string linea in lineas)
                {
                    tablaErrores.Rows.Add(linea);
                }

                // Asignar la tabla al DataGridView
                dgvBitacora.DataSource = tablaErrores;
                dgvBitacora.ClearSelection();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
           cargarArchivo();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }
    }
}
