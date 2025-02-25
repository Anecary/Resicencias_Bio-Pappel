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
        private Panel p = new Panel();

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

        private void btnNuevaNotaMedica_Click(object sender, EventArgs e)
        {
            pNuevaConsultaMedica.Visible = true;
            pConsultaExpMedico.Visible = false;
        }

        private void btnConsultaExpMedico_Click(object sender, EventArgs e)
        {
            pNuevaConsultaMedica.Visible = false;
            pConsultaExpMedico.Visible = true;
        }

        private void frmNotaMedica_Load(object sender, EventArgs e)
        {
            pNuevaConsultaMedica.Visible = true;
            pConsultaExpMedico.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
