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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Nota_Medica
{
    public partial class frmActualizaNotaMedica : Form 
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();
        ConsultaMedicaCN consultaMedicaCN = new ConsultaMedicaCN();
        ExpedientesCN expedientesCN = new ExpedientesCN();
        EmpleadosCN empleadosCN = new EmpleadosCN();

        public frmActualizaNotaMedica()
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

            pDatosGenerales.Paint += new PaintEventHandler(Panel1_Paint);
            pConsultaMedica.Paint += new PaintEventHandler(Panel1_Paint);
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

        private void frmActualizaNotaMedica_Load(object sender, EventArgs e)
        {
            cboxNumExpediente2.OnSelectedIndexChanged -= cboxNumExpediente2_OnSelectedIndexChanged;
            cboxNumExpediente2.DataSource = expedientesCN.ConcultaNumExpedientes().Tables["numExpedientes"];
            cboxNumExpediente2.DisplayMember = "Num_Expediente";
            cboxNumExpediente2.ValueMember = "Num_Expediente";
            if (cboxNumExpediente2.Items.Count > 0)
            {
                cboxNumExpediente2.SelectedIndex = 0;
            }
            cboxNumExpediente2.OnSelectedIndexChanged += cboxNumExpediente2_OnSelectedIndexChanged;
        } 

        private void limpiarFormulario()
        {
            txtNumNomina.Clear();
            txtNombreEmpleado.Clear();
            txtIdEmpleado.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtPuesto.Clear();
            txtObservaciones.Clear();
            txtDiagnostico.Clear();
            cboxNumExpediente2.SelectedIndex = 0;
            txtIdConsulta.Clear();
            txtFechaNota.Clear();
            txtProceso.Clear();
            txtCausaConsulta.Clear();
            txtDescripcion.Clear();

            dgvConsultaGeneral.DataSource = null;
        }

        private void limpiarCampos()
        {
            txtObservaciones.Clear();
            txtDiagnostico.Clear();
            txtIdConsulta.Clear();
            txtFechaNota.Clear();
            txtProceso.Clear();
            txtCausaConsulta.Clear();
            txtDescripcion.Clear();
        }

        private void cargarDataGrid(int idEmpleado)
        {
            try
            {
                // Consultamos las notas médicas del expediente
                DataSet ds = consultaMedicaCN.consultaNotaNull(idEmpleado);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables["ConsultaNotaNull"].Rows.Count > 0)
                {
                    // Clonamos la estructura de la tabla original
                    DataTable originalTable = ds.Tables["ConsultaNotaNull"];
                    DataTable invertedTable = originalTable.Clone();

                    // Invertimos las filas
                    for (int i = originalTable.Rows.Count - 1; i >= 0; i--)
                    {
                        invertedTable.ImportRow(originalTable.Rows[i]);
                    }

                    // Asignamos la tabla invertida al DataGridView
                    dgvConsultaGeneral.DataSource = invertedTable;

                    // (Opcional) Ajustar nombres de columna para que se vean más amigables
                    dgvConsultaGeneral.Columns["idConsulta"].HeaderText = "ID Consulta";
                    dgvConsultaGeneral.Columns["nss"].HeaderText = "No. Seguro Social";
                    dgvConsultaGeneral.Columns["fecha"].HeaderText = "Fecha";
                    dgvConsultaGeneral.Columns["causas"].HeaderText = "Causas";
                    dgvConsultaGeneral.Columns["tipoCausa"].HeaderText = "Tipo Causa";

                    // (Opcional) Ajustar el tamaño automático de las columnas
                    dgvConsultaGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    RJMessageBox.Show("Todas las notas ya están anexadas al expediente.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvConsultaGeneral.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error al buscar notas médicas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string ObtenerNomenclatura(string nombre)
        {
            return string.Concat(nombre.Split(' ').Select(palabra => palabra[0]));
        }

        private void btnBuscarNotaMedica_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumNomina.Text))
            {
                DataTable t = empleadosCN.ConsultaEmpleadoNumNomina(txtNumNomina.Text).Tables["ConsultaEmpleado"];

                DataRow dr = t.Rows[0];

                if (dr["estado"].ToString() == "I")
                {
                    var result = RJMessageBox.Show("Este empleado no se encuentra dado de alta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumNomina.Focus();
                    return;
                }

                if (t.Rows.Count > 0)
                {
                    txtNombreEmpleado.Text =
                        (dr["nombre"] as string ?? "") + " " +
                        (dr["apellido_paterno"] as string ?? "") + " " +
                        (dr["apellido_materno"] as string ?? "");

                    txtIdEmpleado.Text = dr["idEmpleado"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtDomicilio.Text = (dr["domicilio_Calle"] as string ?? "") + " #" +
                        (dr["domicilio_Numero"] as string ?? "") + ", " +
                        (dr["domicilio_Colonia"] as string ?? "") + ", " +
                        (dr["domicilio_Ciudad"] as string ?? "") + ", " +
                        (dr["domicilio_Estado"] as string ?? "");
                    txtPuesto.Text = dr["puesto"] as string ?? "N/A";

                    string nombre = txtNombreEmpleado.Text;
                    string nomenclarura = ObtenerNomenclatura(nombre);
                    cboxNumExpediente2.Text = nomenclarura + "-" + txtNumNomina.Text;
                    int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                    cargarDataGrid(idEmpleado);
                }
                else
                {
                    var result = RJMessageBox.Show(" Número de nómina no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var result = RJMessageBox.Show(" Por favor ingrese un Número de Nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumNomina.Focus();
            }
        }

        private void dgvConsultaGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvConsultaGeneral.Rows[e.RowIndex];

                // Obtener el idConsulta de la fila seleccionada
                int idConsulta = Convert.ToInt32(fila.Cells["idConsulta"].Value);

                // Buscar la nota médica
                buscarNotaMedica(idConsulta);
            }
        }

        private void buscarNotaMedica(int idConsulta)
        {
            try
            {
                DataSet ds = consultaMedicaCN.consultaNotaIndividual(idConsulta);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables["ConsultaNotaIndividual"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["ConsultaNotaIndividual"].Rows[0];

                    // Asignar valores a los TextBox
                    txtIdConsulta.Text = dr["IdConsulta"].ToString() ?? "";
                    txtCausaConsulta.Text = dr["causas"]?.ToString() ?? "";
                    txtDescripcion.Text = dr["tipoCausa"]?.ToString() ?? "";
                    txtFechaNota.Text = Convert.ToDateTime(dr["fecha"]).ToString("yyyy-MM-dd");
                    txtProceso.Text = dr["proceso"]?.ToString() ?? "";
                    txtObservaciones.Text = dr["observaciones"]?.ToString() ?? "";
                    txtDiagnostico.Text = dr["diagnostico"]?.ToString() ?? "";

                    txtProceso.Text = string.IsNullOrWhiteSpace(dr["proceso"]?.ToString()) ? "N/A" : dr["proceso"].ToString();
                }
                else
                {
                    RJMessageBox.Show("No se encontró la nota médica solicitada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                RJMessageBox.Show(" Por favor ingrese la Id de la onsulta para continuar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos no están vacíos (agrega validaciones previas)
                if (string.IsNullOrEmpty(txtIdConsulta.Text) || string.IsNullOrEmpty(cboxNumExpediente2.Text))
                {
                    RJMessageBox.Show("Por favor, ingrese la Id de la consulta y el Número del Expediente.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string textoIngresado = cboxNumExpediente2.Text;

                bool existe = false;

                foreach (var item in cboxNumExpediente2.Items)
                {
                    if (item.ToString().Equals(textoIngresado, StringComparison.OrdinalIgnoreCase)) // o simplemente Equals(textoIngresado)
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    MessageBox.Show("Este empleado no cuenta con un expediente médico.");
                    return;
                }

                // Crear la entidad con los valores que vas a insertar
                ConsultaMedica consulta = new ConsultaMedica
                {
                    IdConsulta = Convert.ToInt32(txtIdConsulta.Text),
                    NumExpediente = cboxNumExpediente2.Text
                };

                int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                // Llamar al método de la capa de negocios para insertar los datos
                bool resultado = consultaMedicaCN.ActualizarNumExpediente(consulta);
                if (resultado)
                {
                    RJMessageBox.Show("La nota médica ha sido anexada al expediente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    cargarDataGrid(idEmpleado);
                }
                else
                {
                    RJMessageBox.Show("Hubo un error al anexar la nota médica.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btmCancelar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btnConsultaIndividual_Click(object sender, EventArgs e)
        {
            try
            {
                int idConsulta = Convert.ToInt32(txtIdConsulta.Text);
                buscarNotaMedica(idConsulta);
            } catch (Exception ex)
            {
                RJMessageBox.Show("Por favor, ingrese un idConsulta válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void cboxNumExpediente2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
