using CapaEntidad;
using CapaNegocios;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;

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
                    //string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    string.IsNullOrWhiteSpace(txtColonia.Text) ||
                    string.IsNullOrWhiteSpace(txtCp.Text) ||
                    string.IsNullOrWhiteSpace(txtMunicipio.Text) ||
                    cboEstado.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    RJMessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución si hay campos vacíos
                }
                int edad = DateTime.Today.Year - dtpFechaNacimiento.Value.Year;

                if (dtpFechaNacimiento.Value.Date > DateTime.Today.AddYears(-edad))
                {
                    edad--;
                }

                if (edad <= 18)
                {
                    RJMessageBox.Show("Ingrese una fecha de nacimiento válida. Debe tener al menos 18 años.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener valores después de la validación
                string nombre = txtNombre.Text.Trim();
                string apellidoPaterno = txtApellidoP.Text.Trim();
                string apellidoMaterno = txtApellidoM.Text.Trim();
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                char sexo = cmbSexo.SelectedItem.ToString()[0];
                string estadoCivil = cmbEstadoCivil.SelectedItem.ToString();
                string nss = txtNss.Text.Trim();
                string rfc = txtRFC.Text.Trim();
                string domicilioCalle = txtCalle.Text.Trim();
                string domicilioNumero = txtNumero.Text.Trim();
                string domicilioColonia = txtColonia.Text.Trim();
                string domicilioCP = txtCp.Text.Trim();
                string domicilioCiudad = txtMunicipio.Text.Trim();
                string domicilioEstado = cboEstado.Text.Trim();
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
                RJMessageBox.Show("Empleado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar controles
                LimpiarControles();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarControles()
        {
            // Limpia todos los controles de entrada
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbSexo.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            txtNss.Clear();
            txtRFC.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtColonia.Clear();
            txtCp.Clear();
            txtMunicipio.Clear();
            //txtEstado.Clear();
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
        public void ValidacionNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back ||
                  e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Enter ||
                  e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Escape ||
                  e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right))
            {
                e.Handled = true; // Bloquea la entrada de caracteres no permitidos
                SystemSounds.Beep.Play();
                var result = RJMessageBox.Show("Solo se pueden introducir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);
        }

        private void txtNss_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);
        }

        private void txtCp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void validacionCaracteresEspeciales(KeyPressEventArgs e)
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
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }

        private void txtMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
        }
    }
}
