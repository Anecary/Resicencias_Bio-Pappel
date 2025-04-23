using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CapaPresentacion.Empleados
{
    public partial class frmNewEmpleados2 : Form
    {
        private EmpleadosCN negocios = new EmpleadosCN();
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel(); 

        public frmNewEmpleados2()
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
            panel3.Paint += new PaintEventHandler(Panel1_Paint);
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
        private void frmNewEmpleados2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoP.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoM.Text) ||
                    cmbSexo.SelectedItem == null ||
                    cmbEstadoCivil.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtNss.Text) ||
                    string.IsNullOrWhiteSpace(txtRFC.Text) ||
                    string.IsNullOrWhiteSpace(txtCalle.Text) ||
                    string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    string.IsNullOrWhiteSpace(txtColonia.Text) ||
                    string.IsNullOrWhiteSpace(txtCp.Text) ||
                    string.IsNullOrWhiteSpace(txtMunicipio.Text) ||
                    string.IsNullOrWhiteSpace(txtEstado.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución si hay campos vacíos
                }

                // Obtener valores después de la validación
                string nombre = txtNombre.Text.Trim();
                string apellidoPaterno = txtApellidoP.Text.Trim();
                string apellidoMaterno = txtApellidoM.Text.Trim();
                DateTime fechaNacimiento = dateTimePicker2.Value;
                char sexo = cmbSexo.SelectedItem.ToString()[0];
                string estadoCivil = cmbEstadoCivil.SelectedItem.ToString();
                string nss = txtNss.Text.Trim();
                string rfc = txtRFC.Text.Trim();
                string domicilioCalle = txtCalle.Text.Trim();
                string domicilioNumero = txtNumero.Text.Trim();
                string domicilioColonia = txtColonia.Text.Trim();
                string domicilioCP = txtCp.Text.Trim();
                string domicilioCiudad = txtMunicipio.Text.Trim();
                string domicilioEstado = txtEstado.Text.Trim();
                string telefono = txtTelefono.Text.Trim();

                // Llamada al método de negocios para insertar el empleado
                EmpleadosCE empleados = new EmpleadosCE
                {
                    Nombre = nombre,
                    ApellidoPaterno = apellidoPaterno,
                    ApellidoMaterno = apellidoMaterno,
                    FechaNacimiento = fechaNacimiento,
                    Sexo = sexo,
                    EstadoCivil = estadoCivil,
                    NSS = nss,
                    RFC = rfc,
                    DomicilioCalle= domicilioCalle,
                    DomicilioNumero = domicilioNumero,
                    DomicilioColonia= domicilioColonia,
                    DomicilioCP= domicilioCP,
                    DomicilioCiudad= domicilioCiudad,
                    DomicilioEstado = domicilioEstado,
                    Telefono = telefono
                };
                negocios.InsertarEmpleado(empleados);

                // Mensaje de éxito
                MessageBox.Show("Empleado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar controles
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarControles()
        {
            // Limpia todos los controles de entrada
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            dateTimePicker2.Value = DateTime.Now;
            cmbSexo.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            txtNss.Clear();
            txtRFC.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtColonia.Clear();
            txtCp.Clear();
            txtMunicipio.Clear();
            txtEstado.Clear();
            txtTelefono.Clear();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la entrada del número
            }
        }

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la entrada del número
            }
        }
    }
}
