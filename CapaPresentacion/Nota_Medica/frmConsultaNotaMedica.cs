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
    public partial class frmConsultaNotaMedica : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();
        ConsultaMedicaCN consultaMedicaCN = new ConsultaMedicaCN();
        EmpleadosCN empleadosCN = new EmpleadosCN();

        public frmConsultaNotaMedica()
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

            pConsultaGeneral.Paint += new PaintEventHandler(Panel1_Paint);
            pConsultaIndividual.Paint += new PaintEventHandler(Panel1_Paint);
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

        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesDatos.Controls.Add(p);
            p.BackColor = Color.FromArgb(91, 194, 255); // Color para el panel
            p.Size = new Size(187, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesDatos.Controls.Remove(p);
        }

        private Dictionary<Button, bool> panelVisitado = new Dictionary<Button, bool>();

        private void MostrarPanel(Panel panelAMostrar, Button botonPresionado)
        {
            // Marcar este botón como visitado
            if (!panelVisitado.ContainsKey(botonPresionado))
            {
                panelVisitado[botonPresionado] = true;
            }

            // Ocultar todos los paneles y mostrar el deseado
            pConsultaNotaGeneral.Visible = false;
            pConsultaNotaIndividual.Visible = false;

            panelAMostrar.Visible = true;
        }

        private void frmConsultaNotaMedica_Load(object sender, EventArgs e)
        {
            pConsultaNotaGeneral.Visible = true;
            pConsultaNotaIndividual.Visible = false;
        }

        static string ObtenerNomenclatura(string nombre)
        {
            return string.Concat(nombre.Split(' ').Select(palabra => palabra[0]));
        }

        private void cargarDataGrid(string numExpediente)
        {
            if (!string.IsNullOrEmpty(numExpediente))
            {
                try
                {
                    // Consultamos las notas médicas del expediente
                    DataSet ds = consultaMedicaCN.consultaNotaGeneral(numExpediente);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables["ConsultaNotaGeneral"].Rows.Count > 0)
                    {
                        tgvConsultaGeneral.DataSource = ds.Tables["ConsultaNotaGeneral"];

                        // (Opcional) Ajustar nombres de columna para que se vean más amigables
                        tgvConsultaGeneral.Columns["idConsulta"].HeaderText = "ID Consulta";
                        tgvConsultaGeneral.Columns["numExpediente"].HeaderText = "No. Expediente";
                        tgvConsultaGeneral.Columns["fecha"].HeaderText = "Fecha";
                        tgvConsultaGeneral.Columns["proceso"].HeaderText = "Proceso";
                        tgvConsultaGeneral.Columns["causas"].HeaderText = "Causas";

                        // (Opcional) Ajustar el tamaño automático de las columnas
                        tgvConsultaGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        RJMessageBox.Show("No se encontraron notas médicas para este expediente.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tgvConsultaGeneral.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    RJMessageBox.Show("Error al buscar notas médicas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                RJMessageBox.Show("Debe ingresar un número de expediente válido para buscar notas médicas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

                    DateTime fechaNacimiento = dr["fecha_nacimiento"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_nacimiento"]) : DateTime.MinValue;
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
                    string nombre = txtNombreEmpleado.Text;
                    string nomenclarura = ObtenerNomenclatura(nombre);
                    txtNoExpediente.Text = nomenclarura + "-" + txtNumeroNomina.Text;
                    string numExpediente = txtNoExpediente.Text;

                    cargarDataGrid(numExpediente);
                }
                else
                {
                    RJMessageBox.Show("Número de nómina no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                RJMessageBox.Show(" Por favor ingrese un Número de Nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroNomina.Focus();
            }
        }

        private void btnBuscarNotaMedica_Click(object sender, EventArgs e)
        {
            try
            {
                int idConsulta = Convert.ToInt32(txtIdConsulta.Text);
                DataSet ds = consultaMedicaCN.consultaNotaIndividual(idConsulta);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables["ConsultaNotaIndividual"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["ConsultaNotaIndividual"].Rows[0];

                    // Asignar valores a los TextBox
                    txtCausaConsulta.Text = dr["causas"]?.ToString() ?? "";
                    txtDescripcion.Text = dr["tipoCausa"]?.ToString() ?? "";
                    txtFechaNota.Text = Convert.ToDateTime(dr["fecha"]).ToString("yyyy-MM-dd");
                    txtProceso.Text = dr["proceso"]?.ToString() ?? "";
                    txtObservaciones.Text = dr["observaciones"]?.ToString() ?? "";
                    txtDiagnostico.Text = dr["diagnostico"]?.ToString() ?? "";
                }
                else
                {
                    RJMessageBox.Show("No se encontró la nota médica solicitada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error al cargar la nota médica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPanelGeneral_Click(object sender, EventArgs e)
        {
            MostrarPanel(pConsultaNotaGeneral, btnPanelGeneral);
        }

        private void btnPanelIndividual_Click(object sender, EventArgs e)
        {
            MostrarPanel(pConsultaNotaIndividual, btnPanelIndividual);
        }
    }
}



