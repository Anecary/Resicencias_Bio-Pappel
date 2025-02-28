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
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Definir el radio de los bordes redondeados
                int radius = 20;

                // Crear un pincel para el borde
                Pen pen = new Pen(Color.Blue, 3); // Color y grosor del borde

                // Dibujar los bordes redondeados
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawArc(pen, 0, 0, radius * 2, radius * 2, 180, 90);
                e.Graphics.DrawArc(pen, panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                e.Graphics.DrawArc(pen, 0, panel.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                e.Graphics.DrawArc(pen, panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);

                e.Graphics.DrawLine(pen, radius, 0, panel.Width - radius, 0);
                e.Graphics.DrawLine(pen, radius, panel.Height, panel.Width - radius, panel.Height);
                e.Graphics.DrawLine(pen, 0, radius, 0, panel.Height - radius);
                e.Graphics.DrawLine(pen, panel.Width, radius, panel.Width, panel.Height - radius);
            }
        }
        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesDatos.Controls.Add(p);
            p.BackColor = Color.FromArgb(91, 194, 255); // Color para el panel
            p.Size = new Size(180, 5); // Tamaño del panel
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
                dataGridView1.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                var datosEmpleado = negocios.consultaIndividual(numero_nomina);

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

            }
            catch (Exception ex)
            {

            }
        }
    }
}
