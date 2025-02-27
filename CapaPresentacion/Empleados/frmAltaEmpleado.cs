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
using CapaDatos;



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
            try
            {
                string nss = txtNssBusqueda.Text.Trim();

                if (string.IsNullOrWhiteSpace(nss))
                {
                    MessageBox.Show("Por favor, ingrese un NSS.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamada a la capa de negocios
                var datosEmpleado = negocios.ObtenerEmpleadoPorNSS(nss);

                // Mostrar datos en los TextBox de Material Skin
                if (datosEmpleado.estado != "I")
                {
                    MessageBox.Show("Empleado dado de alta.","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtNombreCompleto.Text = datosEmpleado.nombreCompleto;
                txtTelefono.Text = datosEmpleado.telefono;
                txtDomicilio.Text = datosEmpleado.domicilio;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void CargarPuestos()
        {
            try
            {
                // Llama al método de la capa de negocios para obtener los puestos
                var puestos = negociosP.ObtenerPuestosLista();

                // Limpiar el ComboBox antes de llenarlo
                cmbPuestos.Items.Clear();

                // Cargar los puestos
                cmbPuestos.DisplayMember = "Text";  // Lo que se muestra en el ComboBox
                cmbPuestos.ValueMember = "Value";   // El valor asociado

                // Agregar los puestos al ComboBox
                foreach (var puesto in puestos)
                {
                    cmbPuestos.Items.Add(new { Text = puesto.puesto, Value = puesto.idPuesto });
                }

                // Opcional: Seleccionar el primer item o hacer alguna otra configuración
                cmbPuestos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los puestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pDatosLaborales_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
