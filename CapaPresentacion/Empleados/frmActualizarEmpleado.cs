using CapaNegocios;
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
    public partial class frmActualizarEmpleado : Form
    {
        private EmpleadosCN negocios = new EmpleadosCN();
        private PuestosCN negociosP = new PuestosCN();
        public frmActualizarEmpleado()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmActualizarEmpleado_Load);
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
                int domicilio_numero = int.Parse(txtNumero.Text);
                string telefono = txtTelefono.Text.Trim();
                string puesto = cmbPuesto.Text.Trim();

                negocios.actualizarEmpleado(numero_nomina, fecha_nueva, estado_civil, domicilio_cp, domicilio_estado, domicilio_ciudad, domicilio_colonia, domicilio_calle, domicilio_numero, telefono, turno, puesto);
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
