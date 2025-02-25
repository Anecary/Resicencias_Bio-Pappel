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
        }

        private void frmNewEmpleados2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesDatos.Controls.Add(p);
            p.BackColor = Color.FromArgb(91, 194, 255); // Color para el panel
            p.Size = new Size(160, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesDatos.Controls.Remove(p);
        }
    }
}
