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

namespace CapaPresentacion.Investigacion_Accidentes
{
    public partial class frmConsultaAccidentes : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();
        public frmConsultaAccidentes()
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

            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            panel4.Paint += new PaintEventHandler(Panel1_Paint);
            panel6.Paint += new PaintEventHandler(Panel1_Paint);
            panel7.Paint += new PaintEventHandler(Panel1_Paint);
            panel14.Paint += new PaintEventHandler(Panel1_Paint);
            panel15.Paint += new PaintEventHandler(Panel1_Paint);
            panel26.Paint += new PaintEventHandler(Panel1_Paint);
            panel27.Paint += new PaintEventHandler(Panel1_Paint);
            panel28.Paint += new PaintEventHandler(Panel1_Paint);
            panel29.Paint += new PaintEventHandler(Panel1_Paint);
            panel31.Paint += new PaintEventHandler(Panel1_Paint);
            panel32.Paint += new PaintEventHandler(Panel1_Paint);
            panel33.Paint += new PaintEventHandler(Panel1_Paint);

            pDatosGenerales.Visible = true;
            pDetallesAccidente.Visible = false;
            pFactoresSeguridad.Visible = false;
            pControlAcciones.Visible = false;
            pSeguimientoCaso.Visible = false;
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
            p.Size = new Size(185, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesDatos.Controls.Remove(p);
        }
        private void MostrarPanel(Panel panelAMostrar)
        {

            pDatosGenerales.Visible = false;
            pDetallesAccidente.Visible = false;
            pFactoresSeguridad.Visible = false;
            pControlAcciones.Visible = false;
            pSeguimientoCaso.Visible = false;

            panelAMostrar.Visible = true;
        }

        private void btnDatosGenerales_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDatosGenerales);
        }

        private void btnDetallesAccidente_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDetallesAccidente);
        }

        private void btnFactoresSeguridad_Click(object sender, EventArgs e)
        {
            MostrarPanel(pFactoresSeguridad);
        }

        private void btnSeguimientoCaso_Click(object sender, EventArgs e)
        {
            MostrarPanel(pSeguimientoCaso);
        }

        private void btnControlAcciones_Click(object sender, EventArgs e)
        {
            MostrarPanel(pControlAcciones);
        }
    }
}
