using CapaNegocios;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Empleados
{
    public partial class frmPuestos : Form
    {
        private PuestosCN negocios = new PuestosCN();
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

        public frmPuestos()
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

            pPuestos.Paint += new PaintEventHandler(Panel1_Paint);
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón

        private void frmPuestos_Load(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios para obtener los puestos
                DataTable puestos = negocios.ObtenerPuestos();

                // Asigna el DataTable al DataGridView
                dataGridView1.DataSource = puestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios
                int ultimoId = negocios.ObtenerUltimoId("puestos", "idPuesto");

                // Muestra el último ID en el TextBox de Material Skin
                txtNoNomina.Text = ultimoId.ToString();

                txtPuesto.Enabled = true;
                materialButton2.Enabled = false;
                materialButton3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                // Obtén el nombre del puesto desde el TextBox
                string puesto = txtPuesto.Text;

                // Valida que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(puesto))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llama al método de la capa de negocios para insertar el puesto
                negocios.InsertarPuesto(puesto);

                // Muestra un mensaje de éxito
                MessageBox.Show("Puesto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia el TextBox
                txtNoNomina.Clear();
                txtPuesto.Clear();
                txtPuesto.Enabled= false;
                materialButton2.Enabled = true;
                materialButton3.Enabled = false;
                dataGridView1.DataSource = null;


                //
                DataTable puestos = negocios.ObtenerPuestos();

                // Asigna el DataTable al DataGridView
                dataGridView1.DataSource = puestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pPuestos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la entrada del número
            }
        }
    }
}
