using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Restaurar_Y_Respaldar
{
    public partial class frmNotificacion : Form
    {
        public frmNotificacion()
        {
            InitializeComponent();
        }
        public frmNotificacion( string pTitulo, string pMsgIm, String pMsg, Color pcolor, int pImg)
        {
            InitializeComponent();
            lblTitulo.Text = pTitulo;
            lblImagen.Text = pMsgIm;
            lblMsg.Text = pMsg;
            lblTitulo.ForeColor= pcolor;
            pImagen.BackColor = pcolor;
            pRight.BackColor = pcolor;

            if(pImg == 1)
            {
                pbErr.Visible = false;
                pbCrut.Visible = false;
            }
            else if(pImg == 2)
            {
                pbSuc.Visible = false;
                pbCrut.Visible = false;
            }
            else if(pImg == 3)
            {
                pbSuc.Visible = false;
                pbErr.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.Black;
        }

        private void frmNotificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
