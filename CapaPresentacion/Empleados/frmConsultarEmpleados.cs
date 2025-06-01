using CapaNegocios;
using CapaPresentacion.Investigacion_Accidentes;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Empleados
{
    public partial class frmConsultarEmpleados : Form
    {
        private EmpleadosCN negocios = new EmpleadosCN();
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();
        public frmConsultarEmpleados()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmAltaEmpleado_Load);
            pConsultaGeneral.Visible = true;
            pConsultaIndividual.Visible = false;

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
            panel5.Paint += new PaintEventHandler(Panel1_Paint);
            panel6.Paint += new PaintEventHandler(Panel1_Paint);
            panel7.Paint += new PaintEventHandler(Panel1_Paint);


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
            p.Size = new Size(btn.Width, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesDatos.Controls.Remove(p);
        }


        private void btnConsultaIndividual_Click(object sender, EventArgs e)
        {
            pConsultaGeneral.Visible = false;
            pConsultaIndividual.Visible = true;
        }

        private void btnConsultaGral_Click(object sender, EventArgs e)
        {
            pConsultaGeneral.Visible = true;
            pConsultaIndividual.Visible = false;
        }
        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            // Código para cargar los puestos u otros datos aquí
            try
            {
                // Llama al método de la capa de negocios para obtener los puestos
                DataTable empleados = negocios.ObtenerPuestos();

                // Asigna el DataTable al DataGridView
                dgvEmpleados.DataSource = empleados;
                dgvEmpleados.ClearSelection();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void rbtTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios para obtener los puestos
                DataTable empleados = negocios.ObtenerPuestos();

                // Asigna el DataTable al DataGridView
                dgvEmpleados.DataSource = empleados;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtInactivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios para obtener los puestos
                DataTable empleados = negocios.consultaGeneralInactivos();

                // Asigna el DataTable al DataGridView
                dgvEmpleados.DataSource = empleados;
                
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtActivos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Llama al método de la capa de negocios para obtener los puestos
                DataTable empleados = negocios.consultaGeneralActivo();

                // Asigna el DataTable al DataGridView
                dgvEmpleados.DataSource = empleados;
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarEmpleadoNN_Click(object sender, EventArgs e)
        {
            try
            {
                String numero_nomina = txtNoNomina.Text;

                if (string.IsNullOrEmpty(numero_nomina))
                {
                    RJMessageBox.Show("Por favor, ingrese un Numero de nomina.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var datosEmpleado = negocios.ConsultaEmpleadoNominaONss(numero_nomina);
                txtnumeronomina.Text = datosEmpleado.numnomina;
                txtNombre.Text = datosEmpleado.nombreCompleto;
                txtFechaNac.Text = datosEmpleado.fecha_nac.ToString("yyyy-MM-dd");  // Formato de fecha personalizado
                txtSexo.Text = datosEmpleado.sexo.ToString();
                txtNss.Text = datosEmpleado.nss.ToString();
                txtEstadoCivil.Text = datosEmpleado.estado_civil.ToString();
                txtDomicilio.Text = datosEmpleado.domicilio.ToString();
                txtCp.Text = datosEmpleado.domicilio_CP.ToString();
                txtTelefono.Text = datosEmpleado.telefono.ToString();

                txtTurno.Text = datosEmpleado.turno.ToString();
                txtAntiguedad.Text = datosEmpleado.antiguedad.ToString();
                txtPuesto.Text = datosEmpleado.puesto.ToString();
                txtFechaIngreso.Text = datosEmpleado.fecha_ingreso_empresa.ToString("yyyy-MM-dd");
                txtIdEmpleado.Text = datosEmpleado.idEmpleado.ToString();

                DataTable data = negocios.consultarInvAccidentePorEmpleado(Convert.ToInt32(txtIdEmpleado.Text)).Tables["InvestigacionAccidentePorEmpleado"];
                dgvHistorico.DataSource = data;
                dgvHistorico.Columns["idEmpleado"].Visible = false;
                dgvHistorico.Columns["Id Accidente"].Visible = false;
                dgvHistorico.Columns["numRevisionHistorico"].Visible = false;

                llenarChartAccidentesXCondicion(Convert.ToInt32(txtIdEmpleado.Text));
            }
            catch (Exception ex)
            {

            }

        }
        private void dgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvHistorico.Rows[e.RowIndex];

                // Obtener el idConsulta de la fila seleccionada
                //string hola = Convert.ToString(fila.Cells["idConsulta"].Value);
                //dgvHistorico.Columns["idEmpleado"].Visible = false;
                
                //int idEmpleado = Convert.ToInt32(dgvHistorico.Columns["idEmpleado"]);
                //int noRevision = Convert.ToInt32(dgvHistorico.Columns["numRevisionHistorico"]);
                int idEmpleado = Convert.ToInt32(dgvHistorico.Rows[e.RowIndex].Cells["idEmpleado"].Value);
                int noRevision = Convert.ToInt32(dgvHistorico.Rows[e.RowIndex].Cells["numRevisionHistorico"].Value);
                
                //int noRevision = int.Parse(dgvHistorico.Columns["numRevisionHistorico"].ToString());
                var Llamar_reporte = new Llamar_reporte(idEmpleado, noRevision);
                Llamar_reporte.Show();
            }
        }


        private void llenarChartAccidentesXCondicion(int idEmpleado)
        {
            DataSet ds = negocios.ObtenerTotalAccidentesXCondicion(idEmpleado);

            // Asegúrate que la tabla en el DataSet tenga el nombre correcto
            // Si no lo estás nombrando, puedes usar Tables[0] directamente
            DataTable tabla = ds.Tables["AccidentesEmpleadoXCondicion"];

            chartAccidentesXCondicion.Series.Clear();
            chartAccidentesXCondicion.Series.Add("Condiciones");

            chartAccidentesXCondicion.Series["Condiciones"].ChartType = SeriesChartType.Column;
            chartAccidentesXCondicion.Series["Condiciones"].IsValueShownAsLabel = true;

            foreach (DataRow row in tabla.Rows)
            {
                string condicion = row["Condición"].ToString();
                int cantidad = Convert.ToInt32(row["Cantidad de Accidentes"]);

                chartAccidentesXCondicion.Series["Condiciones"].Points.AddXY(condicion, cantidad);
                //chartAccidentesXCondicion.Series["Condiciones"].Color = Color.FromArgb(100, 180, 255); 

            }

            chartAccidentesXCondicion.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartAccidentesXCondicion.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartAccidentesXCondicion.Legends[0].Enabled = false;
            chartAccidentesXCondicion.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartAccidentesXCondicion.ChartAreas[0].AxisX.Interval = 1;
            chartAccidentesXCondicion.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            chartAccidentesXCondicion.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            chartAccidentesXCondicion.Series["Condiciones"].Color = Color.DarkCyan; 

        }

        
    }
}
