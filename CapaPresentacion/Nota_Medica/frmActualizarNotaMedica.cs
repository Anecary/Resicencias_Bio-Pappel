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
    public partial class frmActualizarNotaMedica : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();
        ConsultaMedicaCN consultaMedicaCN = new ConsultaMedicaCN();
        ExpedientesCN expedientesCN = new ExpedientesCN();
        EmpleadosCN empleadosCN = new EmpleadosCN();

        public frmActualizarNotaMedica()
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
            p.BackColor = Color.FromArgb(247, 167, 62); // Color para el panel
            p.Size = new Size(225, 5); // Tamaño del panel
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
            pDatosGenerales.Visible = false;

            panelAMostrar.Visible = true;
        }

        private void frmActualizarNotaMedica_Load(object sender, EventArgs e)
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

            pDatosGenerales.Visible = true;
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
                        // Clonamos la estructura de la tabla original
                        DataTable originalTable = ds.Tables["ConsultaNotaGeneral"];
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
                        dgvConsultaGeneral.Columns["numExpediente"].HeaderText = "No. Expediente";
                        dgvConsultaGeneral.Columns["fecha"].HeaderText = "Fecha";
                        dgvConsultaGeneral.Columns["proceso"].HeaderText = "Proceso";
                        dgvConsultaGeneral.Columns["causas"].HeaderText = "Causas";

                        // (Opcional) Ajustar el tamaño automático de las columnas
                        dgvConsultaGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        RJMessageBox.Show("No se encontraron notas médicas para este expediente.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvConsultaGeneral.DataSource = null;
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

        private void dgvConsultaGeneral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvConsultaGeneral.Rows[e.RowIndex];

                // Obtener el idConsulta de la fila seleccionada
                // txtIdConsulta.Text = Convert.ToString(fila.Cells["idConsulta"].Value);

                // Mostrar al panel de la consulta individual
                // MostrarPanel(pConsultaNotaIndividual, btnPanelIndividual);

                // Buscar la nota médica
                // btnBuscarNotaMedica_Click(sender, e);
            }
        }

        private void cboxNumExpediente2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable t = expedientesCN.consultaExpediente(cboxNumExpediente2.SelectedValue.ToString()).Tables["ConsultaNumExpediente"];

            if (t.Rows.Count > 0)
            {
                DataRow dr = t.Rows[0];

                // Función auxiliar para evitar la repetición de DBNull
                string GetStringValue(object value) => value != DBNull.Value ? value.ToString() : "";

                txtNombreEmpleado.Text = $"{GetStringValue(dr["nombre"])} {GetStringValue(dr["apellido_paterno"])} {GetStringValue(dr["apellido_materno"])}";
                txtNumeroNomina.Text = GetStringValue(dr["NumNomina"]);

                DateTime fechaNacimiento = dr["fecha_nacimiento"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_nacimiento"]) : DateTime.MinValue;
                DateTime fechaActual = DateTime.Now;

                int edad = (fechaNacimiento != DateTime.MinValue) ? fechaActual.Year - fechaNacimiento.Year - (fechaActual < fechaNacimiento.AddYears(fechaActual.Year - fechaNacimiento.Year) ? 1 : 0) : 0;
                txtEdad.Text = edad > 0 ? edad.ToString() : "N/A";

                // Asignar los valores de texto
                txtIdEmpleado.Text = GetStringValue(dr["idEmpleado"]);
                txtSexo.Text = GetStringValue(dr["sexo"]);
                txtNSS.Text = GetStringValue(dr["nss"]);
                txtTelefono.Text = GetStringValue(dr["telefono"]);
                txtDomicilio.Text = (dr["domicilio_Calle"] as string ?? "") + " #" +
                     (dr["domicilio_Numero"] as string ?? "") + ", " +
                     (dr["domicilio_Colonia"] as string ?? "") + ", " +
                     (dr["domicilio_Ciudad"] as string ?? "") + ", " +
                     (dr["domicilio_Estado"] as string ?? "");
                txtPuesto.Text = GetStringValue(dr["puesto"]);
                string nombre = txtNombreEmpleado.Text;
                string nomenclarura = ObtenerNomenclatura(nombre);
                string numExpediente = nomenclarura + "-" + txtNumeroNomina.Text;

                cargarDataGrid(numExpediente);

            }

        }
    }
}
