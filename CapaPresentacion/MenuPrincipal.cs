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
    public partial class frmMenu : Form
    {
        private PuestosCN puestosCN = new PuestosCN();
        public frmMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void SetInitialView()
        {
            pInicio.Visible = true; 
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pContenedor.Controls.Add(childForm);
            pContenedor.Tag = childForm;

            pInicio.Visible = false;

            childForm.BringToFront();
            childForm.Show();
        }
        private void customizeDesign()
        {
            pSubmenuAccidentes.Visible = false;
            pSubmenuExpediente.Visible = false;
            pSubmenuNotaMedica.Visible = false;
            pSubmenuCumplimientoLegal.Visible = false;
            pSubmenuEmpleados.Visible = false;
            pSubmenuReportes.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pSubmenuAccidentes.Visible == true)
                pSubmenuAccidentes.Visible = false;
            if (pSubmenuExpediente.Visible == true)
                pSubmenuExpediente.Visible = false;
            if (pSubmenuNotaMedica.Visible == true)
                pSubmenuNotaMedica.Visible = false;
            if (pSubmenuCumplimientoLegal.Visible == true)
                pSubmenuCumplimientoLegal.Visible = false;
            if (pSubmenuEmpleados.Visible == true)
                pSubmenuEmpleados.Visible = false;
            if (pSubmenuReportes.Visible == true)
                pSubmenuReportes.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null; 
            }

            SetInitialView();
        }
        private void btnInvAccidente_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuAccidentes);
        }

        private void btnNewAccidente_Click(object sender, EventArgs e)
        {
            openChildForm(new Investigacion_Accidentes.frmNewAccidente());
            hideSubMenu();
        }

        private void btnConsultarAccidentes_Click(object sender, EventArgs e)
        {
            openChildForm(new Investigacion_Accidentes.frmConsultaAccidentes());
            hideSubMenu();
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuExpediente);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuEmpleados);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            openChildForm(new Empleados.frmNewEmpleados2());
            hideSubMenu();
        }
        private void btnAltaEmpleados_Click(object sender, EventArgs e)
        {
            openChildForm(new Empleados.frmAltaEmpleado());
            hideSubMenu();
        }

        private void btnConsultarEmpleados_Click(object sender, EventArgs e)
        {
            openChildForm(new Empleados.frmConsultarEmpleados());
            hideSubMenu();
        }
        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            openChildForm(new Empleados.frmAltaEmpleado());
        }
        private void btnNuevaNotaMedica_Click(object sender, EventArgs e)
        {
            openChildForm(new Nota_Medica.frmNotaMedica());
            hideSubMenu();
        }

        private void btnNotaMedica_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuNotaMedica);
        }

        private void btnConsultarHistorico_Click(object sender, EventArgs e)
        {
            openChildForm(new Nota_Medica.frmConsultaHistorico());
            hideSubMenu();
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            openChildForm(new Empleados.frmPuestos());
            hideSubMenu();
        }

        private void btnSecciones_Click(object sender, EventArgs e)
        {
            openChildForm(new Empleados.frmSecciones());
            hideSubMenu();
        }


    }
}
