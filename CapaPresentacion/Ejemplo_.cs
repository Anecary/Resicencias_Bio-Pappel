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

namespace CapaPresentacion
{
    public partial class Ejemplo_ : Form
    {
        private AccidentesCN negocios = new AccidentesCN();
        public Ejemplo_()
        {
            InitializeComponent();
        }

        private void Ejemplo__Load(object sender, EventArgs e)
        {
            DataTable dtReporte = negocios.ObtenerReporteAccidentesBLL();

            // Verificar si tiene filas antes de asignarlo al DataGridView
            if (dtReporte.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtReporte;
            }
            else
            {
                MessageBox.Show("No hay datos disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
