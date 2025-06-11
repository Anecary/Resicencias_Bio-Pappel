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
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormPrincipal_KeyDown);
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
            this.pDerecho.MouseDown += new MouseEventHandler(pDerecho_MouseDown);
            this.pInferior.MouseDown += new MouseEventHandler(pInferior_MouseDown);


        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MOVE)
                return;

            base.WndProc(ref m);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblTrabajadores.Text = homeCN.ConcultaNumTrabajadores().Tables["TotalEmpleados"].Rows[0][0].ToString();
            cargarDashboard();
            CargarGraficoCausas();
            LlenarChartTurno();
            LlenarChartSecciones();
        }

        //Movimiento del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // Constantes necesarias
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTBOTTOMRIGHT = 17; // esquina inferior derecha
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTBOTTOM = 15;

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
            //pSubmenuCumplimientoLegal.Visible = false;
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
            //if (pSubmenuCumplimientoLegal.Visible == true)
            //    pSubmenuCumplimientoLegal.Visible = false;
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

        //private void btnCumpliminetoLegal_Click(object sender, EventArgs e)
        //{
        //    showSubMenu(pSubmenuCumplimientoLegal);
        //}

 
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
            AbrirAyudaPDF("Menu.pdf");
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string nombreFormulario = activeForm != null ? activeForm.GetType().Name : "Menu";

                string nombreArchivo;

                switch (nombreFormulario)
                {
                    case "frmNewEmpleados2":
                        nombreArchivo = "NuevoEmpleado.pdf";
                        break;
                    case "frmAltaEmpleado":
                        nombreArchivo = "AltasEmpleado.pdf";
                        break;
                    case "frmConsultarEmpleados":
                        nombreArchivo = "ConsultarEmpleado.pdf";
                        break;
                    case "frmActualizarEmpleado":
                        nombreArchivo = "ActualizarEmpleado.pdf";
                        break;
                    case "frmPuestos":
                        nombreArchivo = "Puestos.pdf";
                        break;
                    case "frmSecciones":
                        nombreArchivo = "Secciones.pdf";
                        break;
                    case "frmNewAccidente":
                        nombreArchivo = "NuevoAccidente.pdf";
                        break;
                    case "frmConsultaAccidentes":
                        nombreArchivo = "ConsultarAccidente.pdf";
                        break;
                    case "frmExpedienteMedico":
                        nombreArchivo = "NuevoExpediente.pdf";
                        break;
                    case "frmModificarExpediente":
                        nombreArchivo = "ActualizarExpediente.pdf";
                        break;
                    case "frmNotaMedica":
                        nombreArchivo = "NuevaNotaMedica.pdf";
                        break;
                    case "frmConsultaNotaMedica":
                        nombreArchivo = "ConsultarNotaMedica.pdf";
                        break;
                    case "frmActualizaNotaMedica":
                        nombreArchivo = "AnexarAExpediente.pdf";
                        break;
                    case "frmReportes_Investigacion_Accidente":
                        nombreArchivo = "ReportesAccidentes.pdf";
                        break;
                    case "frmReportes_Consultas_Medicas":
                        nombreArchivo = "ReportesConsultas.pdf";
                        break;
                    case "frmRespaldar":
                        nombreArchivo = "Respaldar.pdf";
                        break;
                    default:
                        nombreArchivo = "Menu.pdf";
                        break;
                }

                AbrirAyudaPDF(nombreArchivo);
            }
        }




        private void AbrirAyudaPDF(string nombreArchivo)
        {
            string rutaPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ayuda", nombreArchivo);

            if (File.Exists(rutaPDF))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = rutaPDF,
                        UseShellExecute = true // Usa el visor predeterminado
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el archivo de ayuda.\n\n" + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo de ayuda no se encontró:\n" + rutaPDF,
                                "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRevisiones_Click(object sender, EventArgs e)
        {
            openChildForm(new Utilerias.frmRevisiones());
            hideSubMenu();
        }
        private void cargarDashboard()
        {
            // Consultas totales
            DataSet dsConsultas = homeCN.ObtenerNumConsultas();
            if (dsConsultas.Tables.Contains("TotalConsultas") && dsConsultas.Tables["TotalConsultas"].Rows.Count > 0)
            {
                lblConsultas.Text = dsConsultas.Tables["TotalConsultas"].Rows[0][0].ToString();
            }
            else
            {
                lblConsultas.Text = "0";
            }

            DataSet dsAccidentes = homeCN.ObtenerNumAccidentes();
            if (dsAccidentes.Tables.Contains("TotalAccidentes") && dsAccidentes.Tables["TotalAccidentes"].Rows.Count > 0)
            {
                lblAccidentes.Text = dsAccidentes.Tables["TotalAccidentes"].Rows[0][0].ToString();
            }
            else
            {
                lblAccidentes.Text = "0";
            }

            DataSet dsIncapacidades = homeCN.ObtenerNumIncapacidades();
            if (dsIncapacidades.Tables.Contains("TotalIncapacidades") && dsIncapacidades.Tables["TotalIncapacidades"].Rows.Count > 0)
            {
                lblIncapacidades.Text = dsIncapacidades.Tables["TotalIncapacidades"].Rows[0][0].ToString();
            }
            else
            {
                lblIncapacidades.Text = "0";
            }

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
            chartTurno.Series["Turnos"].Color = Color.DarkCyan;

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
            chartSecciones.Series["Secciones"].Color = Color.DarkCyan;
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
        private void btnMesActual_Click(object sender, EventArgs e)
        {
            ocultarRango();
            cargarDashboard();
            CargarGraficoCausas();
            LlenarChartTurno();
            LlenarChartSecciones();
        }

        private void cargarDashboardMesPasado()
        {
            // Consultas del mes pasado
            DataSet dsConsultas = homeCN.ObtenerNumConsultasMesPasado();
            if (dsConsultas.Tables.Contains("TotalConsultas") && dsConsultas.Tables["TotalConsultas"].Rows.Count > 0)
            {
                lblConsultas.Text = dsConsultas.Tables["TotalConsultas"].Rows[0][0].ToString();
            }
            else
            {
                lblConsultas.Text = "0";
            }

            DataSet dsAccidentes = homeCN.ObtenerNumAccidentesMesPasado();
            if (dsAccidentes.Tables.Contains("TotalAccidentes") && dsAccidentes.Tables["TotalAccidentes"].Rows.Count > 0)
            {
                lblAccidentes.Text = dsAccidentes.Tables["TotalAccidentes"].Rows[0][0].ToString();
            }
            else
            {
                lblAccidentes.Text = "0";
            }

            DataSet dsIncapacidades = homeCN.ObtenerNumIncapacidadesMesPasado();
            if (dsIncapacidades.Tables.Contains("TotalIncapacidades") && dsIncapacidades.Tables["TotalIncapacidades"].Rows.Count > 0)
            {
                lblIncapacidades.Text = dsIncapacidades.Tables["TotalIncapacidades"].Rows[0][0].ToString();
            }
            else
            {
                lblIncapacidades.Text = "0";
            }

        }
        private void LlenarChartTurnoMesPasado()
        {
            DataSet ds = homeCN.ObtenerAccidentesTurnoMesPasado();

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
            chartTurno.Series["Turnos"].Color = Color.DarkCyan;

        }
        private void LlenarChartSeccionesMesPasado()
        {
            DataSet ds = homeCN.ObtenerSeccionesConIncidentesMesPasado();

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
            chartSecciones.Series["Secciones"].Color = Color.DarkCyan;
        }

        private void CargarGraficoCausasMesPasado()
        {
            chartCausas.Series.Clear();

            Series series = new Series("Causas más frecuentes");
            series.ChartType = SeriesChartType.Doughnut;

            // Mostrar el valor numérico (total) en cada rebanada
            series.Label = "#VAL (#PERCENT{P0})"; // Muestra algo como "5 (25%)"
            series.LegendText = "#VALX"; // Muestra el nombre de la causa en la leyenda

            DataSet ds = homeCN.ObtenerCausasMasFrecuentesMesPasado();

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
        public void ocultarRango()
        {
            dtpdesde.Visible = false;
            dtphasta.Visible = false;
            btnConsultapersonalizado.Visible = false;
        }
        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            ocultarRango();
            cargarDashboardMesPasado();
            LlenarChartTurnoMesPasado();
            LlenarChartSeccionesMesPasado();
            CargarGraficoCausasMesPasado();
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            btnConsultapersonalizado.Visible = true;
            dtpdesde.Visible = true;
            dtphasta.Visible = true;
        }
        
        private void btnConsultapersonalizado_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpdesde.Value.Date;
            DateTime hasta = dtphasta.Value.Date;

            if (desde > hasta)
            {
                RJMessageBox.Show("La fecha 'desde' no puede ser mayor que la fecha 'hasta'.", "Rango de fechas incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si las fechas no son válidas
            }

            LlenarChartTurnoPersonalizado(desde, hasta);
            LlenarChartSeccionesPorRango(desde, hasta);
            CargarGraficoCausasPorRango(desde, hasta);
            cargarDashboardRango(desde, hasta);
        }
        private void cargarDashboardRango(DateTime desde, DateTime hasta)
        {
            // Total de Consultas
            DataSet dsConsultas = homeCN.ObtenerTotalConsultasPorRango(desde, hasta);
            if (dsConsultas.Tables.Contains("TotalConsultasRango") && dsConsultas.Tables["TotalConsultasRango"].Rows.Count > 0)
            {
                lblConsultas.Text = dsConsultas.Tables["TotalConsultasRango"].Rows[0][0].ToString();
            }
            else
            {
                lblConsultas.Text = "0";
            }

            // Total de Accidentes
            DataSet dsAccidentes = homeCN.ObtenerNumAccidentesPorRango(desde, hasta);
            if (dsAccidentes.Tables.Contains("TotalAccidentes") && dsAccidentes.Tables["TotalAccidentes"].Rows.Count > 0)
            {
                lblAccidentes.Text = dsAccidentes.Tables["TotalAccidentes"].Rows[0][0].ToString();
            }
            else
            {
                lblAccidentes.Text = "0";
            }

            // Total de Incapacidades
            DataSet dsIncapacidades = homeCN.ObtenerNumIncapacidadesPorRango(desde, hasta);
            if (dsIncapacidades.Tables.Contains("TotalIncapacidades") && dsIncapacidades.Tables["TotalIncapacidades"].Rows.Count > 0)
            {
                lblIncapacidades.Text = dsIncapacidades.Tables["TotalIncapacidades"].Rows[0][0].ToString();
            }
            else
            {
                lblIncapacidades.Text = "0";
            }
        }

        private void LlenarChartTurnoPersonalizado(DateTime desde, DateTime hasta)
        {


            DataSet ds = homeCN.ObtenerAccidentesTurnoPorRango(desde, hasta);

            chartTurno.Series.Clear();
            chartTurno.Series.Add("Turnos");

            chartTurno.Series["Turnos"].ChartType = SeriesChartType.Column; // o Column si prefieres barras
            chartTurno.Series["Turnos"].IsValueShownAsLabel = true;

            foreach (DataRow row in ds.Tables["AccidentesXTurnoPersonalizado"].Rows)
            {
                string turno = row["turno"].ToString();
                int total = Convert.ToInt32(row["total_accidentes"]);

                chartTurno.Series["Turnos"].Points.AddXY(turno, total);
            }

            //chartTurno.Titles.Clear();

            chartTurno.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartTurno.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartTurno.Legends[0].Enabled = false;  // Desactivar la leyenda por completo
            chartTurno.Series["Turnos"].Color = Color.DarkCyan;

        }
        private void LlenarChartSeccionesPorRango(DateTime desde, DateTime hasta)
        {

            DataSet ds = homeCN.ObtenerSeccionesConIncidentesPorRango(desde, hasta);

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
            chartSecciones.Series["Secciones"].Color = Color.DarkCyan;
        }

        private void CargarGraficoCausasPorRango(DateTime desde, DateTime hasta)
        {
           

            chartCausas.Series.Clear();

            Series series = new Series("Causas más frecuentes");
            series.ChartType = SeriesChartType.Doughnut;

            // Mostrar el valor numérico (total) en cada rebanada
            series.Label = "#VAL (#PERCENT{P0})"; // Muestra algo como "5 (25%)"
            series.LegendText = "#VALX"; // Muestra el nombre de la causa en la leyenda

            DataSet ds = homeCN.ObtenerCausasMasFrecuentesPorRango(desde, hasta);

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

        private void psuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pDerecho_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pInferior_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnExportarExpedientes_Click(object sender, EventArgs e)
        {
            openChildForm(new Expediente.frmExportarExpediente());
            hideSubMenu();
        }
    }
}
