using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CapaPresentacion.Empleados
{
    public partial class frmNewEmpleados2 : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel(); 

        public frmNewEmpleados2()
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
        private void frmNewEmpleados2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
