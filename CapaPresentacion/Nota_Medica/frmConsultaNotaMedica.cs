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
    public partial class frmConsultaNotaMedica : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

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
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón

        private void frmConsultaHistorico_Load(object sender, EventArgs e)
        {

        }
    }
}
