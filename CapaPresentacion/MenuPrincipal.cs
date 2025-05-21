using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        private PuestosCN puestosCN = new PuestosCN();
        private HomeCN homeCN = new HomeCN();
        public frmMenu()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            customizeDesign();
            //pInicio.Visible = true;
            foreach (Control control in this.Controls)
            {
                if (control is Button) // Solo los controles que son botones
                {
                    Button btn = (Button)control;
                    btn.MouseEnter += button_MouseOver;
                    btn.MouseDown += button_MouseDown;
                    btn.MouseLeave += button_MouseLeave;
                }
            }

            panel4.Paint += new PaintEventHandler(panel_Paint);
            panel12.Paint += new PaintEventHandler(panel_Paint);
            panel13.Paint += new PaintEventHandler(panel_Paint);
            panel14.Paint += new PaintEventHandler(panel_Paint);
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            cargarDashboard();
            CargarGraficoCausas();
            LlenarChartTurno();
            LlenarChartSecciones();
        }
        private void cargarDashboard()
        {
            lblTrabajadores.Text = homeCN.ConcultaNumTrabajadores().Tables["TotalEmpleados"].Rows[0][0].ToString();
            lblConsultas.Text = homeCN.ObtenerNumConsultas().Tables["TotalConsultas"].Rows[0][0].ToString();
            lblAccidentes.Text = homeCN.ObtenerNumAccidentes().Tables["TotalAccidentes"].Rows[0][0].ToString();
            lblIncapacidades.Text = homeCN.ObtenerNumIncapacidades().Tables["TotalIncapacidades"].Rows[0][0].ToString();
        }
        private void LlenarChartTurno()
        {
            DataSet ds = homeCN.ObtenerAccidentesTurno();

            chartTurno.Series.Clear();
            chartTurno.Series.Add("Turnos");

            chartTurno.Series["Turnos"].ChartType = SeriesChartType.Column; // o Column si prefieres barras
            chartTurno.Series["Turnos"].IsValueShownAsLabel = true;

            foreach (DataRow row in ds.Tables["AccidentesXTurno"].Rows)
            {
                string turno = row["turno"].ToString();
                int total = Convert.ToInt32(row["total_accidentes"]);

                chartTurno.Series["Turnos"].Points.AddXY(turno, total);
            }

            //chartTurno.Titles.Clear();
            
            chartTurno.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTurno.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartTurno.Legends[0].Enabled = false;  // Desactivar la leyenda por completo

        }
        private void LlenarChartSecciones()
        {
            DataSet ds = homeCN.ObtenerSeccionesConIncidentes();

            chartSecciones.Series.Clear();
            chartSecciones.Series.Add("Secciones");

            chartSecciones.Series["Secciones"].ChartType = SeriesChartType.Column;
            chartSecciones.Series["Secciones"].IsValueShownAsLabel = true;

            foreach (DataRow row in ds.Tables["SeccionesAccidentes"].Rows)
            {
                string seccion = row["seccion"].ToString();
                int total = Convert.ToInt32(row["total"]);

                chartSecciones.Series["Secciones"].Points.AddXY(seccion, total);
            }

            chartSecciones.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartSecciones.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartSecciones.Legends[0].Enabled = false; // O puedes cambiarlo a true si quieres mostrar "Secciones"
        }

        private void CargarGraficoCausas()
        {
            chartCausas.Series.Clear();

            Series series = new Series("Causas más frecuentes");
            series.ChartType = SeriesChartType.Doughnut;

            // Mostrar el valor numérico (total) en cada rebanada
            series.Label = "#VAL (#PERCENT{P0})"; // Muestra algo como "5 (25%)"
            series.LegendText = "#VALX"; // Muestra el nombre de la causa en la leyenda

            DataSet ds = homeCN.ObtenerCausasMasFrecuentes();

            if (ds.Tables["CausasPrincipales"].Rows.Count > 0)
            {
                foreach (DataRow fila in ds.Tables["CausasPrincipales"].Rows)
                {
                    string causa = fila["causas"].ToString();
                    int total = Convert.ToInt32(fila["total"]);

                    series.Points.AddXY(causa, total);
                }
            }

            chartCausas.Series.Add(series);
            chartCausas.Legends[0].Enabled = true;
        }


        //Movimiento del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void psuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void SetInitialView()
        {
            pInicio.Visible = true; 
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null; 
            }
            cargarDashboard();
            CargarGraficoCausas();
            LlenarChartTurno();
            LlenarChartSecciones();
            hideSubMenu();
            SetInitialView();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        // Cambiar el color de fondo y de texto cuando el mouse está sobre el botón
        private void button_MouseOver(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.BackColor = Color.FromArgb(51, 181, 253);  
            //btn.ForeColor = Color.FromArgb(0, 0, 0);   
        }

        // Cambiar el color de fondo y de texto cuando el mouse es presionado sobre el botón
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.BackColor = Color.FromArgb(51, 181, 253);   
            //btn.ForeColor = Color.FromArgb(0, 0, 0);                   
        }

        // Restablecer los colores cuando el mouse ya no está sobre el botón
        private void button_MouseLeave(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.BackColor = Color.FromArgb(22, 104, 179);      
            //btn.ForeColor = Color.White;
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
            pSubmenuUtilerias.Visible = false;
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
            if (pSubmenuUtilerias.Visible == true)
                pSubmenuUtilerias.Visible = false;

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
            openChildForm(new Empleados.frmActualizarEmpleado());
            hideSubMenu();
        }

        private void btnNuevaNotaMedica_Click(object sender, EventArgs e)
        {
            openChildForm(new Nota_Medica.frmNotaMedica());
            hideSubMenu();
        }

        private void btnConsultaNotaMedica_Click(object sender, EventArgs e)
        {
            openChildForm(new Nota_Medica.frmConsultaNotaMedica());
            hideSubMenu();
        }

        private void btnNotaMedica_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuNotaMedica);
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

        private void btnCumpliminetoLegal_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuCumplimientoLegal);
        }

 
    private void panel_Paint(object sender, PaintEventArgs e)
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
            Pen pen = new Pen(Color.FromArgb(255, 255, 255), 3); // Cambia el color aquí
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        }
    }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuReportes);
        }

        private void btnReportesInvAccidentes_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes.frmReportes_Investigacion_Accidente());
            hideSubMenu();
        }

        private void btnNewExpediente_Click(object sender, EventArgs e)
        {
            openChildForm(new Expediente.frmExpedienteMedico());
            hideSubMenu();
        }

        private void btnActualizarExpediente_Click(object sender, EventArgs e)
        {
            openChildForm(new Expediente.frmModificarExpediente());
            hideSubMenu();
        }

        private void btnReportesConsultasM_Click(object sender, EventArgs e)
        {
            openChildForm(new Reportes.frmReportes_Consultas_Medicas());
            hideSubMenu();
        }

        private void btnActualizarNotaMedica_Click(object sender, EventArgs e)
        {
            openChildForm(new Nota_Medica.frmActualizaNotaMedica());
            hideSubMenu();
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            openChildForm(new Utilerias.frmRespaldar());
            hideSubMenu();
        }

        private void btnUtileris_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubmenuUtilerias);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirAyudaPDF();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                AbrirAyudaPDF();
            }
        }

        private void AbrirAyudaPDF()
        {
            string rutaPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ayudas", "menu.pdf");

            if (File.Exists(rutaPDF))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaPDF,
                    UseShellExecute = true // Usa el visor predeterminado del sistema
                });
            }
            else
            {
                MessageBox.Show("El archivo de ayuda no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
