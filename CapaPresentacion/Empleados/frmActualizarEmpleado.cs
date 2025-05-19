using CapaEntidad;
using CapaNegocios;
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
    public partial class frmActualizarEmpleado : Form
    {
        private EmpleadosCN negocios = new EmpleadosCN();
        private PuestosCN negociosP = new PuestosCN();
        public frmActualizarEmpleado()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmActualizarEmpleado_Load);

            txtCiudad.KeyPress += ValidacionKeyPressCompartido;
            txtColonia.KeyPress += ValidacionKeyPressCompartido;
            txtCalle.KeyPress += ValidacionKeyPressCompartido;
            txtNumero.KeyPress += ValidacionKeyPressCompartido;


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
                Pen pen = new Pen(Color.FromArgb(6, 103, 105), 5); // Cambia el color aquí
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
                    RJMessageBox.Show("No hay puestos disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmbPuesto.DataSource = null;
                cmbPuesto.DataSource = puestos; // Solo los nombres de los puestos

                cmbPuesto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error al cargar los puestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNoNomina.Text) ||
                    cmbEstadoCivil.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtCp.Text) ||
                    cmbEstado.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                    string.IsNullOrWhiteSpace(txtColonia.Text) ||
                    string.IsNullOrWhiteSpace(txtCalle.Text) ||
                    string.IsNullOrWhiteSpace(txtNumero.Text) ||  // Se valida antes de convertir a int
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    cmbPuesto.SelectedItem == null ||
                    cmbTurno.SelectedItem == null) // Validar que cmbTurno tenga un valor seleccionado
                    {
                        RJMessageBox.Show("Todos los campos deben estar llenos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                string numero_nomina = txtNoNomina.Text.Trim();
                string estado_civil = cmbEstadoCivil.Text.Trim();
                DateTime fecha_nueva = dtpFecha.Value;
                char turno = cmbTurno.SelectedItem.ToString()[0];
                string domicilio_cp = txtCp.Text.Trim();
                string domicilio_estado = cmbEstado.Text.Trim();
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
                RJMessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();

            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtFechaNac.Clear();
            txtSexo.Clear();
            txtNss.Clear();
            txtCp.Clear();
            //txtEstado.Clear();
            txtCiudad.Clear();
            txtColonia.Clear();
            txtCalle.Clear();
            txtNumero.Clear();
            txtTelefono.Clear();
            txtNoNomina.Clear();

            txtCp.Enabled = false; txtCp.BackColor = Color.WhiteSmoke;
            txtCiudad.Enabled = false; txtCiudad.BackColor = Color.WhiteSmoke;
            txtColonia.Enabled = false; txtColonia.BackColor = Color.WhiteSmoke;
            txtCalle.Enabled = false; txtCalle.BackColor = Color.WhiteSmoke;
            txtNumero.Enabled = false; txtNumero.BackColor = Color.WhiteSmoke;
            txtTelefono.Enabled = false;txtTelefono.BackColor = Color.WhiteSmoke;
            txtNoNomina.Enabled = true; txtNoNomina.BackColor = Color.White;

            cmbEstado.Enabled = false; cmbEstado.BackColor = Color.WhiteSmoke;
            cmbPuesto.Enabled = false; cmbPuesto.BackColor = Color.WhiteSmoke;
            cmbTurno.Enabled = false;cmbTurno.BackColor = Color.WhiteSmoke;
            cmbEstadoCivil.Enabled = false; cmbEstadoCivil.BackColor = Color.WhiteSmoke;


            dtpFecha.Enabled = false; dtpFecha.SkinColor = Color.WhiteSmoke;

            btnActualizar.Enabled = false;
            btnBuscarEmpleadoNN.Enabled = true;
            btmCancelar.Enabled = false;
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBuscarEmpleadoNN_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroNomina = txtNoNomina.Text.Trim();

                if (string.IsNullOrWhiteSpace(numeroNomina))
                {
                    RJMessageBox.Show("Por favor, ingrese un número de nómina.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var datosEmpleado = negocios.ConsultaIndivisualActualizar(numeroNomina);

                //if (datosEmpleado == null)
                //{
                //    RJMessageBox.Show("Número de nómina no encontrado. Verifique e intente nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                txtNombre.Text = datosEmpleado.nombreCompleto;
                txtFechaNac.Text = datosEmpleado.fecha_nac.ToString("yyyy-MM-dd");  // Formato de fecha personalizado
                txtSexo.Text = datosEmpleado.sexo.ToString();
                txtNss.Text = datosEmpleado.nss.ToString();
                cmbEstadoCivil.SelectedItem = datosEmpleado.estado_civil;
                txtCp.Text = datosEmpleado.domicilio_CP;
                cmbEstado.SelectedItem = datosEmpleado.domicilio_estado;
                txtCiudad.Text = datosEmpleado.domicilio_ciudad.ToString();
                txtColonia.Text = datosEmpleado.domicilio_colonia.ToString();
                txtCalle.Text = datosEmpleado.domicilio_calle.ToString();
                txtNumero.Text = datosEmpleado.domicilio_numero.ToString();
                txtTelefono.Text = datosEmpleado.telefono.ToString();
                cmbPuesto.SelectedItem = datosEmpleado.puesto;
                char turno = datosEmpleado.turno;
                dtpFecha.Value = datosEmpleado.fecha;

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

                txtCp.Enabled = true; txtCp.BackColor = Color.White;
                cmbEstado.Enabled = true; cmbEstado.BackColor = Color.White;
                txtCiudad.Enabled = true; txtCiudad.BackColor = Color.White;
                txtColonia.Enabled = true;txtColonia.BackColor = Color.White;
                txtCalle.Enabled = true; txtCalle.BackColor = Color.White;
                txtNumero.Enabled = true; txtNumero.BackColor = Color.White;
                txtTelefono.Enabled = true; txtTelefono.BackColor = Color.White;

                dtpFecha.Enabled = true; dtpFecha.SkinColor = Color.White;

                cmbEstadoCivil.Enabled = true; cmbEstadoCivil.BackColor = Color.White;
                cmbPuesto.Enabled = true; cmbPuesto.BackColor = Color.White;
                cmbTurno.Enabled = true;cmbTurno.BackColor = Color.White;

                
                txtNoNomina.Enabled = false; txtNoNomina.BackColor = Color.WhiteSmoke;
                btmCancelar.Enabled = true;
                btnActualizar.Enabled = true;
                btnBuscarEmpleadoNN.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }
        private void ValidacionKeyPressCompartido(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresEspeciales(e);
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
                                    e.KeyChar == (char)Keys.Space ;

            if (!(esLetraODigito || esGuion || esTeclaControl || esTeclaPermitida))
            {
                e.Handled = true; // Bloquea la tecla
                SystemSounds.Beep.Play(); // Sonido opcional
            }
        }
    }
}
