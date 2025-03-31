using CapaEntidad;
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

namespace CapaPresentacion.Nota_Medica
{
    public partial class frmNotaMedica : Form
    {
        private MaterialSkinManager materialSkinManager;
        ConsultaMedicaCN consultaMedicaCN = new ConsultaMedicaCN(); 
        ExpedientesCN expedientesCN = new ExpedientesCN();
        EmpleadosCN empleadosCN = new EmpleadosCN();

        // Array para guardar las idTipoCausa
        List<int> idTipoCausaList = new List<int>();

        public frmNotaMedica()
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

        private void CargarCausasConsulta()
        {
            // Obtener los datos desde la capa de negocios
            DataSet ds = consultaMedicaCN.consultaCausas();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cboxCausaConsulta.DataSource = ds.Tables[0];
                cboxCausaConsulta.DisplayMember = "causas"; // Nombre de la columna en la BD
                cboxCausaConsulta.ValueMember = "causas";  // Puede ser un ID si lo deseas
            }
            else
            {
                MessageBox.Show("No se encontraron causas de consulta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarTipoCausa(int idCausa)
        {
            // Obtener los datos de tipo de causa basado en el idCausa
            DataSet ds = consultaMedicaCN.consultaTipoCausa(idCausa + 1);

            // Limpiar la lista de idTipoCausa en cada llamada
            idTipoCausaList.Clear();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Limpiar la ComboBox antes de agregar nuevos elementos
                cboxTipoCausa.DataSource = null;

                // Añadir los datos a la ComboBox
                cboxTipoCausa.DataSource = ds.Tables[0];
                cboxTipoCausa.DisplayMember = "tipoCausa"; // Nombre de la columna visible
                cboxTipoCausa.ValueMember = "idTipoCausa";  // Valor asociado, que es el idTipoCausa

                // Llenar la lista de idTipoCausa
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int idTipoCausa = Convert.ToInt32(row["idTipoCausa"]);
                    idTipoCausaList.Add(idTipoCausa); // Guardamos los idTipoCausa en la lista
                }
            }
            else
            {
                cboxTipoCausa.DataSource = null;
                MessageBox.Show("No se encontraron tipos de causa para la causa seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmNotaMedica_Load(object sender, EventArgs e)
        {
            CargarCausasConsulta();

            panel3.Visible = true;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pAntecedentes.Visible = true;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnEstudiosParaclinicos_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = true;
        }

        private void btnNuevaNotaMedica_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnNoPatologicos_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = true;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnPatologicos_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = true;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnExploracionFisica_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pAntecedentes.Visible = false; 
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = true;
            pEstudiosParaclinicos.Visible = false;
        }

        private void cboxCausaConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCausaConsulta.SelectedValue != null)
            {
                int idCausa = cboxCausaConsulta.SelectedIndex;
                CargarTipoCausa(idCausa);
            }
        }

        static string ObtenerNomenclatura(string nombre)
        {
            return string.Concat(nombre.Split(' ').Select(palabra => palabra[0]));
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumeroNomina.Text))
            {
                DataTable t = empleadosCN.ConsultaEmpleadoNumNomina(txtNumeroNomina.Text).Tables["ConsultaEmpleado"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];

                    txtNombreEmpleado.Text =
                        (dr["nombre"] as string ?? "") + " " +
                        (dr["apellido_paterno"] as string ?? "") + " " +
                        (dr["apellido_materno"] as string ?? "");

                    txtIdEmpleado.Text = dr["idEmpleado"].ToString();

                    DateTime fechaNacimiento = dr["fecha_nacimiento"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_nacimiento"]) : DateTime.MinValue;
                    DateTime fechaIngresoAlPuesto = dr["fecha_ingreso_puesto"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_ingreso_puesto"]) : DateTime.MinValue;
                    DateTime fechaActual = DateTime.Now;

                    int edad = 0;
                    edad = fechaNacimiento != DateTime.MinValue
                        ? fechaActual.Year - fechaNacimiento.Year - (fechaActual < fechaNacimiento.AddYears(edad) ? 1 : 0)
                        : 0;
                    txtEdad.Text = edad > 0 ? edad.ToString() : "N/A";
                    txtSexo.Text = dr["sexo"].ToString();
                    txtEstadoCivil.Text = dr["estado_civil"].ToString();
                    txtNSS.Text = dr["nss"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtDomicilio.Text = (dr["domicilio_Calle"] as string ?? "") + " #" +
                        (dr["domicilio_Numero"] as string ?? "") + ", " +
                        (dr["domicilio_Colonia"] as string ?? "") + ", " +
                        (dr["domicilio_Ciudad"] as string ?? "") + ", " +
                        (dr["domicilio_Estado"] as string ?? "");
                    txtPuesto.Text = dr["puesto"] as string ?? "N/A";
                    txtFechaIngreso.Text = fechaIngresoAlPuesto.ToString("dd-MMMM-yyyy");
                    string nombre = txtNombreEmpleado.Text;
                    string nomenclarura = ObtenerNomenclatura(nombre);
                    txtNoExpediente.Text = nomenclarura + "-" + txtNumeroNomina.Text;
                }
                else
                {
                    var result = RJMessageBox.Show(" Número de nómina no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                var result = RJMessageBox.Show(" Por favor ingrese un Número de Nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroNomina.Focus();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos no están vacíos (agrega validaciones previas)
                if (string.IsNullOrEmpty(txtNoExpediente.Text) || string.IsNullOrEmpty(txtObservaciones.Text) || string.IsNullOrEmpty(txtDiagnostico.Text) || string.IsNullOrEmpty(cboxProceso.Text) || cboxTipoCausa.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el idTipoCausa de la lista utilizando el índice seleccionado
                int idTipoCausa = idTipoCausaList[cboxTipoCausa.SelectedIndex];

                // Crear la entidad con los valores que vas a insertar
                ConsultaMedica consulta = new ConsultaMedica
                {
                    NumExpediente = txtNoExpediente.Text,
                    Fecha = dtpFechaConsulta.Value,
                    Observaciones = txtObservaciones.Text,
                    Diagnostico = txtDiagnostico.Text,
                    Proceso = cboxProceso.Text,
                    IdTipoCausa = idTipoCausa
                };

                // Llamar al método de la capa de negocios para insertar los datos
                bool resultado = consultaMedicaCN.InsertarConsultaMedica(consulta);
                    if (resultado)
                    {
                        MessageBox.Show("Consulta médica registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al registrar la consulta médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
