using CapaNegocios;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Empleados
{
    public partial class frmSecciones : Form
    {
        private SeccionesCN negocios = new SeccionesCN();
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

        public frmSecciones()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, // Color primario
                Primary.Blue900, // Color de fondo oscuro
                Primary.Blue700, // Color de botones
                Accent.LightBlue200, // Color de acento
                TextShade.WHITE // Color del texto
            );
            panel4.Paint += new PaintEventHandler(Panel1_Paint);
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón

        private void frmSecciones_Load(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios para obtener los puestos
                DataTable seccciones = negocios.ObtenerSecciones();

                // Asigna el DataTable al DataGridView
                dataGridView1.DataSource = seccciones;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
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
        private void materialButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la entrada del número
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios
                int ultimoId = negocios.ObtenerUltimoId("secciones", "idSeccion");

                // Muestra el último ID en el TextBox de Material Skin
                txtIdSeccion.Text = ultimoId.ToString();

                txtSeccion.Enabled = true;
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el nombre del puesto desde el TextBox
                string secccion = txtSeccion.Text;

                // Valida que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(secccion))
                {
                    RJMessageBox.Show("El campo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llama al método de la capa de negocios para insertar el puesto
                negocios.InsertarSecciones(secccion);

                // Muestra un mensaje de éxito
                RJMessageBox.Show("Seccion insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia el TextBox
                txtIdSeccion.Clear();
                txtSeccion.Clear();
                txtSeccion.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                dataGridView1.DataSource = null;


                //Invoca el metodo ObtenerSecciones() de la capa de negocio
                DataTable puestos = negocios.ObtenerSecciones();

                // Asigna el DataTable al DataGridView
                dataGridView1.DataSource = puestos;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtSeccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bool esLetraODigito = char.IsLetterOrDigit(e.KeyChar);
            bool esGuion = e.KeyChar == '-';
            bool esTeclaControl = char.IsControl(e.KeyChar);

            bool esTeclaPermitida = e.KeyChar == (char)Keys.Back ||
                                    e.KeyChar == (char)Keys.Delete ||
                                    e.KeyChar == (char)Keys.Enter ||
                                    e.KeyChar == (char)Keys.Tab ||
                                    e.KeyChar == (char)Keys.Escape ||
                                    e.KeyChar == (char)Keys.Left ||
                                    e.KeyChar == (char)Keys.Right ||
                                    e.KeyChar == (char)Keys.Space;

            if (!(esLetraODigito || esGuion || esTeclaControl || esTeclaPermitida))
            {
                e.Handled = true; // Bloquea la tecla
                SystemSounds.Beep.Play(); // Sonido opcional
            }
        }
    }
}
