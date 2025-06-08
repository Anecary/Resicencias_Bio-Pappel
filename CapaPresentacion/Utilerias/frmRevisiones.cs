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
using System.Drawing.Drawing2D;

namespace CapaPresentacion.Utilerias
{
    public partial class frmRevisiones : Form
    {
        RevisionesCN revisionesCN = new RevisionesCN();
        
        public frmRevisiones()
        {
            InitializeComponent();
            this.Load += FrmRevisiones_Load;
            pPuestos.Paint += new PaintEventHandler(Panel1_Paint);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Definir el radio de los bordes redondeados
                int radius = 20;

                // Crear un `GraphicsPath` para el área recortada del panel
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(0, panel.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                // Aplicar el área recortada al panel
                panel.Region = new Region(path);

                // Dibujar el borde con el color deseado
                Pen pen = new Pen(Color.FromArgb(6, 103, 105), 5); // Cambia el color aquí
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
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
