using CapaEntidad;
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
using System.Windows.Forms;



namespace CapaPresentacion.Empleados
{
    public partial class frmAltaEmpleado : Form
    {
        private EmpleadosCN negocios = new EmpleadosCN();
        private PuestosCN negociosP = new PuestosCN();
        private MaterialSkinManager materialSkinManager;
        public frmAltaEmpleado()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAltaEmpleado_Load);

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
        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            // Código para cargar los puestos u otros datos aquí
            CargarPuestos();
        }
        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuestos.SelectedItem != null)
            {
                string puestoSeleccionado = cmbPuestos.SelectedItem.ToString();
                int idPuesto = negociosP.ObtenerIdPuestoPorNombre(puestoSeleccionado);

                // Guardar en un TextBox invisible
                txtIdPuesto.Text = idPuesto.ToString();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtNoNomina.Text) ||
                    cmbPuestos.SelectedItem == null ||
                    cmbTurno.SelectedItem == null)
                {
                    RJMessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución si hay campos vacíos
                }
                string nss = txtNssBusqueda.Text;
                string numero_nomina = txtNoNomina.Text.Trim();
                DateTime fecha_ingreso_puesto = dtpFechaIngreso.Value;
                DateTime fecha_ingreso_empresa = dtpFechaIngreso.Value;
                char turno = cmbTurno.SelectedItem.ToString()[0];
                int idPuesto = int.Parse(txtIdPuesto.Text);

                EmpleadosCE empleado = new EmpleadosCE
                {
                    NSS = nss,
                    NumeroNomina = numero_nomina,
                    FechaIngresoPuesto = fecha_ingreso_puesto,
                    FechaIngresoEmpresa = fecha_ingreso_empresa,
                    Turno = turno,
                    IdPuestoActual = idPuesto
                };

                negocios.altaEmpleado(empleado);
                RJMessageBox.Show("Empleado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();

            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPuestos()
        {
            try
            {
                var puestos = negociosP.ObtenerNombresPuestos();

                if (puestos == null || puestos.Count == 0)
                {
                    RJMessageBox.Show("No hay puestos disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmbPuestos.DataSource = null;
                cmbPuestos.DataSource = puestos; // Solo los nombres de los puestos

                cmbPuestos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error al cargar los puestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pDatosLaborales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LimpiarControles()
        {
            txtNssBusqueda.Text = "";
            txtNombreCompleto.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            txtNoNomina.Text = "";

            txtNoNomina.Enabled = false; txtNoNomina.BackColor = Color.WhiteSmoke;
            cmbPuestos.SelectedIndex = 0;
            cmbPuestos.Enabled = false;cmbPuestos.BackColor = Color.WhiteSmoke;
            cmbTurno.SelectedIndex = 0;
            cmbTurno.Enabled = false; cmbTurno.BackColor = Color.WhiteSmoke;

            dtpFechaIngreso.Enabled = false; dtpFechaIngreso.SkinColor= Color.WhiteSmoke;

            txtNssBusqueda.Enabled = true; txtNssBusqueda.BackColor = Color.White;
            btnBuscarEmpleadoNSS.Enabled = true; 
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnBuscarEmpleadoNSS_Click(object sender, EventArgs e)
        {
            try
            {
                string nss = txtNssBusqueda.Text.Trim();

                if (string.IsNullOrWhiteSpace(nss))
                {
                    RJMessageBox.Show("Por favor, ingrese un NSS.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamada a la capa de negocios
                var datosEmpleado = negocios.ObtenerEmpleadoPorNSS(nss);

                // Mostrar datos en los TextBox de Material Skin
                if (datosEmpleado.estado != "I")
                {
                    RJMessageBox.Show("Empleado dado de alta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtNombreCompleto.Text = datosEmpleado.nombreCompleto;
                txtTelefono.Text = datosEmpleado.telefono;
                txtDomicilio.Text = datosEmpleado.domicilio;

                txtNoNomina.Enabled = true; txtNoNomina.BackColor = Color.White;
                cmbPuestos.Enabled = true; cmbPuestos.BackColor = Color.White;
                cmbTurno.Enabled = true; cmbTurno.BackColor = Color.White;
                dtpFechaIngreso.Enabled = true; dtpFechaIngreso.SkinColor = Color.White;

                txtNssBusqueda.Enabled = false; txtNssBusqueda.BackColor = Color.WhiteSmoke;
                btnBuscarEmpleadoNSS.Enabled = false;

                btnGrabar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtNoNomina_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, guión y teclas de control como borrar (Backspace)
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
                SystemSounds.Beep.Play(); // Sonido opcional
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
