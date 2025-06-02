using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Utilerias
{
    public partial class frmRespaldar : Form
    {
        public frmRespaldar()
        {
            InitializeComponent();

            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            panel4.Paint += new PaintEventHandler(Panel1_Paint);

        }

        private void frmRespaldar_Load(object sender, EventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            HacerBackup();
        }

        private void HacerBackup()
        {
            try
            {
                string fechaHora = DateTime.Now.ToString("yyyy_MM_dd_HH");
                string nombreArchivo = $"backup_{fechaHora}.sql";

                string rutaCarpeta = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Respaldo"));
                Directory.CreateDirectory(rutaCarpeta);
                string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);


                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = @"C:\Program Files\MariaDB 11.6\bin\mysqldump.exe",
                    Arguments = "-u root -p1234 db_sistemaatenquique",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process proceso = Process.Start(psi))
                using (StreamReader reader = proceso.StandardOutput)
                {
                    string resultado = reader.ReadToEnd();
                    File.WriteAllText(rutaArchivo, resultado);
                    proceso.WaitForExit();
                }

                RegistrarBackup("root", rutaArchivo);
                RJMessageBox.Show("Respaldo realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Error al realizar respaldo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarBackup(string usuario, string rutaArchivo)
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=1234;database=db_sistemaatenquique;";
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand("RegistrarBackup", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_usuario", usuario);
                        cmd.Parameters.AddWithValue("@p_ruta_archivo", rutaArchivo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Error al registrar el respaldo:\n{ex.Message}", "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaurarBackup();
        }


        private void RestaurarBackup()
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Respaldo");
            Directory.CreateDirectory(rutaCarpeta); // Asegura que exista

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = rutaCarpeta,
                Filter = "Archivos SQL (*.sql)|*.sql",
                Title = "Seleccionar archivo de respaldo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                try
                {
                    string rutaMySQL = @"C:\Program Files\MariaDB 11.6\bin\mysql.exe"; // Ajusta si está en otra ruta

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = rutaMySQL,
                        Arguments = "-u root -p1234 db_sistemaatenquique",
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process proceso = Process.Start(psi))
                    {
                        using (StreamReader reader = new StreamReader(rutaArchivo))
                        {
                            proceso.StandardInput.Write(reader.ReadToEnd());
                        }

                        proceso.StandardInput.Close();
                        proceso.WaitForExit();
                    }

                    RJMessageBox.Show("Restauración completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show($"Error al restaurar la base de datos:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
