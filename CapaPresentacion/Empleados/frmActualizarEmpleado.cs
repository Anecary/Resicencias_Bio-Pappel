using CapaEntidad;
using CapaNegocios;
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

namespace CapaPresentacion.Empleados
{
    public partial class frmActualizarEmpleado : Form
    {
        private EmpleadosCN negocios = new EmpleadosCN();
        private PuestosCN negociosP = new PuestosCN();
        public frmActualizarEmpleado()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmActualizarEmpleado_Load);

            panel3.Paint += new PaintEventHandler(Panel1_Paint);
            panel4.Paint += new PaintEventHandler(Panel1_Paint);
            panel5.Paint += new PaintEventHandler(Panel1_Paint);
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
                Pen pen = new Pen(Color.FromArgb(27, 77, 141), 5); // Cambia el color aquí
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
        private void frmActualizarEmpleado_Load(object sender, EventArgs e)
        {
            // Código para cargar los puestos u otros datos aquí
            try
            {
                var puestos = negociosP.ObtenerNombresPuestos();

                if (puestos == null || puestos.Count == 0)
                {
                    MessageBox.Show("No hay puestos disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmbPuesto.DataSource = null;
                cmbPuesto.DataSource = puestos; // Solo los nombres de los puestos

                cmbPuesto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los puestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            try
            {
                String numero_nomina = txtNoNomina.Text;

                if (string.IsNullOrEmpty(numero_nomina))
                {
                    MessageBox.Show("Por favor, ingrese un Numero de nomina.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var datosEmpleado = negocios.ConsultaIndivisualActualizar(numero_nomina);

                txtNombre.Text = datosEmpleado.nombreCompleto;
                txtFechaNac.Text = datosEmpleado.fecha_nac.ToString("yyyy-MM-dd");  // Formato de fecha personalizado
                txtSexo.Text = datosEmpleado.sexo.ToString();
                txtNss.Text = datosEmpleado.nss.ToString();
                cmbEstadoCivil.SelectedItem = datosEmpleado.estado_civil;
                txtCp.Text = datosEmpleado.domicilio_CP;
                txtEstado.Text = datosEmpleado.domicilio_estado.ToString();
                txtCiudad.Text = datosEmpleado.domicilio_ciudad.ToString();
                txtColonia.Text = datosEmpleado.domicilio_colonia.ToString();
                txtCalle.Text = datosEmpleado.domicilio_calle.ToString();
                txtNumero.Text = datosEmpleado.domicilio_numero.ToString();
                txtTelefono.Text = datosEmpleado.telefono.ToString();
                cmbPuesto.SelectedItem = datosEmpleado.puesto;
                char turno = datosEmpleado.turno;
                dateTimePicker1.Value = datosEmpleado.fecha;

                Dictionary<char, string> turnosMap = new Dictionary<char, string>
                {
                    { 'M', "Matutino" },
                    { 'V', "Vespertino" },
                    { 'N', "Nocturno" }
                };

                // Verificar si la letra existe en el diccionario y seleccionarla en el ComboBox
                if (turnosMap.ContainsKey(turno))
                {
                    cmbTurno.SelectedItem = turnosMap[turno];
                }

                txtCp.Enabled = true;
                txtEstado.Enabled = true;
                txtCiudad.Enabled = true;
                txtColonia.Enabled = true;
                txtCalle.Enabled = true;
                txtNumero.Enabled = true;
                txtTelefono.Enabled = true;

                cmbEstadoCivil.Enabled = true;
                cmbPuesto.Enabled = true;
                cmbTurno.Enabled = true;

                btnActualizar.Enabled = true;

                txtNoNomina.Enabled = false;
                btmCancelar.Enabled = true;
                materialFloatingActionButton2.Enabled = false;
            }
            catch (Exception ex) 
            {
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNoNomina.Text) ||
                    string.IsNullOrWhiteSpace(cmbEstadoCivil.Text) ||
                    string.IsNullOrWhiteSpace(txtCp.Text) ||
                    string.IsNullOrWhiteSpace(txtEstado.Text) ||
                    string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                    string.IsNullOrWhiteSpace(txtColonia.Text) ||
                    string.IsNullOrWhiteSpace(txtCalle.Text) ||
                    string.IsNullOrWhiteSpace(txtNumero.Text) ||  // Se valida antes de convertir a int
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(cmbPuesto.Text) ||
                    cmbTurno.SelectedItem == null) // Validar que cmbTurno tenga un valor seleccionado
                    {
                        MessageBox.Show("Todos los campos deben estar llenos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                string numero_nomina = txtNoNomina.Text.Trim();
                string estado_civil = cmbEstadoCivil.Text.Trim();
                DateTime fecha_nueva = dateTimePicker1.Value;
                char turno = cmbTurno.SelectedItem.ToString()[0];
                string domicilio_cp = txtCp.Text.Trim();
                string domicilio_estado = txtEstado.Text.Trim();
                string domicilio_ciudad = txtCiudad.Text.Trim();
                string domicilio_colonia = txtColonia.Text.Trim();
                string domicilio_calle = txtCalle.Text.Trim();
                string domicilio_numero = txtNumero.Text.Trim();

                string telefono = txtTelefono.Text.Trim();
                string puesto = cmbPuesto.Text.Trim();

                EmpleadosCE empleados = new EmpleadosCE
                {
                    NumeroNomina = numero_nomina,
                    EstadoCivil = estado_civil,
                    FechaIngresoPuesto = fecha_nueva,
                    Turno = turno,
                    DomicilioCP = domicilio_cp,
                    DomicilioEstado = domicilio_estado,
                    DomicilioCiudad = domicilio_ciudad,
                    DomicilioColonia = domicilio_colonia,
                    DomicilioCalle = domicilio_calle,
                    DomicilioNumero = domicilio_numero,
                    Telefono = telefono,
                    Puesto = puesto
                };

                negocios.actualizarEmpleado(empleados);
                MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtFechaNac.Clear();
            txtSexo.Clear();
            txtNss.Clear();
            txtCp.Clear();
            txtEstado.Clear();
            txtCiudad.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtTelefono.Clear();
            txtNoNomina.Clear();

            txtCp.Enabled = false;
            txtEstado.Enabled = false;
            txtCiudad.Enabled = false;
            txtColonia.Enabled = false;
            txtCalle.Enabled = false;
            txtNumero.Enabled = false;
            txtTelefono.Enabled = false;
            txtNoNomina.Enabled = true;

            cmbEstadoCivil.Enabled = false;
            cmbPuesto.Enabled = false;
            cmbTurno.Enabled = false;

            btnActualizar.Enabled = false;
            materialFloatingActionButton2.Enabled = true;
            btmCancelar.Enabled = false;
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
