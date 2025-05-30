using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaNegocios.RevisionesCN;
using static CapaEntidad.RevisionesCE;
using CapaEntidad;

namespace CapaPresentacion.Utilerias
{
    public partial class frmRevisiones : Form
    {
        RevisionesCN revisionesCN = new RevisionesCN();
        
        public frmRevisiones()
        {
            InitializeComponent();
            this.Load += FrmRevisiones_Load;
        }

        private void FrmRevisiones_Load(object sender, EventArgs e)
        {
            DataTable dt = revisionesCN.consultaGeneralRevisiones();

            dgvRevisiones.DataSource = dt;
            dgvRevisiones.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string noRevision = txtNumRevision.Text;
            DateTime fecha_emision = dtpFechaIngreso.Value;
            DateTime fecha_revision = selectorFechaPersonalizado1.Value;

            RevisionesCE revisiones = new RevisionesCE
            {
                codigo = codigo,
                no_revision = noRevision,
                fecha_emision = fecha_emision,
                fecha_revision = fecha_revision
            };

            if (revisionesCN.insertarRevision(revisiones) == 1)
            {
                RJMessageBox.Show("la revisión ha sido dada de Alta correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Text = "";
                txtNumRevision.Text = "";
                dtpFechaIngreso.Value = DateTime.Now;
                selectorFechaPersonalizado1.Value = DateTime.Now;
            }
            else
            {
                RJMessageBox.Show("Error: " + "Revisión no fue posible ser dada de alta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
