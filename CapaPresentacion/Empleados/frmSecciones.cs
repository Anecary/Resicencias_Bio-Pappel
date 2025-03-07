using CapaNegocios;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios
                int ultimoId = negocios.ObtenerUltimoId("secciones", "idSeccion");

                // Muestra el último ID en el TextBox de Material Skin
                txtNoNomina.Text = ultimoId.ToString();

                txtSeccion.Enabled = true;
                materialButton2.Enabled = false;
                materialButton3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el nombre del puesto desde el TextBox
                string secccion = txtSeccion.Text;

                // Valida que el campo no esté vacío
                if (string.IsNullOrWhiteSpace(secccion))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llama al método de la capa de negocios para insertar el puesto
                negocios.InsertarSecciones(secccion);

                // Muestra un mensaje de éxito
                MessageBox.Show("Seccion insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia el TextBox
                txtNoNomina.Clear();
                txtSeccion.Clear();
                txtSeccion.Enabled = false;
                materialButton2.Enabled = true;
                materialButton3.Enabled = false;
                dataGridView1.DataSource = null;


                //
                DataTable puestos = negocios.ObtenerSecciones();

                // Asigna el DataTable al DataGridView
                dataGridView1.DataSource = puestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la entrada del número
            }
        }
    }
}
