using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmReportes_Investigacion_Accidente : Form
    {
        public frmReportes_Investigacion_Accidente()
        {
            InitializeComponent();
        }

        private void frmReportes_Investigacion_Accidente_Load(object sender, EventArgs e)
        {

            this.rvInvestigacionAccidente.RefreshReport();
        }
    }
}
