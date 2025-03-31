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

        private void frmNotaMedica_Load(object sender, EventArgs e)
        {
            pDatosGenerales.Visible = true;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            pDatosGenerales.Visible = false;
            pAntecedentes.Visible = true;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnEstudiosParaclinicos_Click(object sender, EventArgs e)
        {
            pDatosGenerales.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = true;
        }

        private void btnNuevaNotaMedica_Click(object sender, EventArgs e)
        {
            pDatosGenerales.Visible = true;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnNoPatologicos_Click(object sender, EventArgs e)
        {
            pDatosGenerales.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = true;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnPatologicos_Click(object sender, EventArgs e)
        {
            pDatosGenerales.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = true;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnExploracionFisica_Click(object sender, EventArgs e)
        {
            pDatosGenerales.Visible = false;
            pAntecedentes.Visible = false; 
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = true;
            pEstudiosParaclinicos.Visible = false;
        }
    }
}
