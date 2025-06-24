using CapaEntidad;
using CapaNegocios;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Expediente
{
    public partial class frmModificarExpediente : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

        EmpleadosCN empleadosCN = new EmpleadosCN();
        ExpedientesCN expedientesCN = new ExpedientesCN();
        public frmModificarExpediente()
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

            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            panel4.Paint += new PaintEventHandler(Panel1_Paint);
            panel5.Paint += new PaintEventHandler(Panel1_Paint);
            panel6.Paint += new PaintEventHandler(Panel1_Paint);
            panel7.Paint += new PaintEventHandler(Panel1_Paint);
            panel8.Paint += new PaintEventHandler(Panel1_Paint);
            panel9.Paint += new PaintEventHandler(Panel1_Paint);
            panel10.Paint += new PaintEventHandler(Panel1_Paint);


            pDatosGenerales.Visible = true;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }
        private void frmModificarExpediente_Load(object sender, EventArgs e)
        {
            cboxNumExpediente2.OnSelectedIndexChanged -= cboxNumExpediente2_OnSelectedIndexChanged;
            cboxNumExpediente2.DataSource = expedientesCN.ConcultaNumExpedientes().Tables["numExpedientes"];
            cboxNumExpediente2.DisplayMember = "Num_Expediente";
            cboxNumExpediente2.ValueMember = "Num_Expediente";
            if (cboxNumExpediente2.Items.Count > 0)
            {
                cboxNumExpediente2.SelectedIndex = 0;
            }
            cboxNumExpediente2.OnSelectedIndexChanged += cboxNumExpediente2_OnSelectedIndexChanged;
        }
        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesExpediente.Controls.Add(p);
            p.BackColor = Color.FromArgb(247, 167, 62); // Color para el panel
            p.Size = new Size(btn.Width, 5); // Tamaño del panel
            p.Location = new System.Drawing.Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }
        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesExpediente.Controls.Remove(p);
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

        private void MostrarPanel(Panel panelAMostrar)
        {


            // Ocultar todos los paneles y mostrar el deseado
            pDatosGenerales.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;

            panelAMostrar.Visible = true;
        }

        private void btnNoPatologicos_Click(object sender, EventArgs e)
        {
            MostrarPanel(pNoPatologicos);
        }

        private void btnDatosGenerales_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDatosGenerales);
        }

        private void btnEstudiosParaclinicos_Click(object sender, EventArgs e)
        {
            MostrarPanel(pEstudiosParaclinicos);
        }

        private void btnExploracionFisica_Click(object sender, EventArgs e)
        {
            MostrarPanel(pExploracionFisica);
        }

        private void btnPatologicos_Click(object sender, EventArgs e)
        {
            MostrarPanel(pPatologicos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = true;
            btnGrabarActualizacion.Visible = true;
            btnActualizar.Visible = false;
            cboxNumExpediente2.Enabled = false;
            // Habilitar los TextBox específicos
            txtHeredoFamiliar.Enabled = true; txtHeredoFamiliar.BackColor = Color.White;
            txtDiagnostico.Enabled = true; txtDiagnostico.BackColor = Color.White;
            txtCasa.Enabled = true; txtCasa.BackColor = Color.White;
            txtAlimentacion.Enabled = true; txtAlimentacion.BackColor = Color.White;
            txtAnimales.Enabled = true; txtAnimales.BackColor = Color.White;
            txtInmunizaciones.Enabled = true; txtInmunizaciones.BackColor = Color.White;
            txtToxicomanias.Enabled = true; txtToxicomanias.BackColor = Color.White;
            txtTrabajosYActAnteriores.Enabled = true; txtTrabajosYActAnteriores.BackColor = Color.White;
            txtDeportesRecreacion.Enabled = true; txtDeportesRecreacion.BackColor = Color.White;
            txtEntornoFamiliar.Enabled = true; txtEntornoFamiliar.BackColor = Color.White;
            txtEscolaridad.Enabled = true; txtEscolaridad.BackColor = Color.White;

            txtAlergias.Enabled = true; txtAlergias.BackColor = Color.White;
            txtSNerviosoCentral.Enabled = true; txtSNerviosoCentral.BackColor = Color.White;
            txtSCardiovascular.Enabled = true; txtSCardiovascular.BackColor = Color.White;
            txtSRespiratorio.Enabled = true; txtSRespiratorio.BackColor = Color.White;
            txtSGastrointestinal.Enabled = true; txtSGastrointestinal.BackColor = Color.White;
            txtSEndocrino.Enabled = true; txtSEndocrino.BackColor = Color.White;
            txtSGenitoUrinario.Enabled = true; txtSGenitoUrinario.BackColor = Color.White;
            txtSMusculoEsqueletico.Enabled = true; txtSMusculoEsqueletico.BackColor = Color.White;
            txtGinecoObstetrico.Enabled = true; txtGinecoObstetrico.BackColor = Color.White;
            txtOrganoSentidos.Enabled = true; txtOrganoSentidos.BackColor = Color.White;
            txtGrupoSanguineo.Visible = false;

            txtEstudiosLaboratorio.Enabled = true; txtEstudiosLaboratorio.BackColor = Color.White;
            txtEstudiosRadiologicos.Enabled = true; txtEstudiosRadiologicos.BackColor = Color.White;
            txtOtros.Enabled = true; txtOtros.BackColor = Color.White;

            txtConstitucionFisica.Enabled = true; txtConstitucionFisica.BackColor = Color.White;
            txtTalla.Enabled = true; txtTalla.BackColor = Color.White;
            txtPeso.Enabled = true; txtPeso.BackColor = Color.White;
            txtIMC.Enabled = true; txtIMC.BackColor = Color.White;
            txtGrado.Enabled = true; txtGrado.BackColor = Color.White;
            txtFC.Enabled = true; txtFC.BackColor = Color.White;
            txtFR.Enabled = true; txtFR.BackColor = Color.White;
            txtPulso.Enabled = true; txtPulso.BackColor = Color.White;
            txtTA.Enabled = true; txtTA.BackColor = Color.White;
            txtTemperatura.Enabled = true; txtTemperatura.BackColor = Color.White;

            txtCraneo.Enabled = true; txtCraneo.BackColor = Color.White;
            txtOjos.Enabled = true; txtOjos.BackColor = Color.White;
            txtOidos.Enabled = true; txtOidos.BackColor = Color.White;
            txtNariz.Enabled = true; txtNariz.BackColor = Color.White;
            txtBoca.Enabled = true; txtBoca.BackColor = Color.White;
            txtCuello.Enabled = true; txtCuello.BackColor = Color.White;
            txtTorax.Enabled = true; txtTorax.BackColor = Color.White;
            txtAbdomen.Enabled = true; txtAbdomen.BackColor = Color.White;
            txtGenitourinario.Enabled = true; txtGenitourinario.BackColor = Color.White;
            txtMusculoEsqueletico.Enabled = true; txtMusculoEsqueletico.BackColor = Color.White;
            txtNeurologico.Enabled = true; txtNeurologico.BackColor = Color.White;


            // Habilitar los RadioButton específicos
            rbtnHozpitalizaciones.Enabled = true;
            rbtnCirugias.Enabled = true;
            rbtnTransfusiones.Enabled = true;

            //Combos 
            cboxGrupoSanguineo.Visible = true;
            txtGrupoSanguineo.Visible = false;

            cboxConstitucionFisica.Visible = true;
            txtConstitucionFisica.Visible = false;

            cboxGrado.Visible = true;
            txtGrado.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarCampos();
        }
        public void desactivarCampos()
        {
            btnCancelar.Visible = false;
            btnGrabarActualizacion.Visible = false;
            btnActualizar.Visible = true;
            cboxNumExpediente2.Enabled = true;
            // Deshabilitar los TextBox específicos
            txtHeredoFamiliar.Enabled = false; txtHeredoFamiliar.BackColor = Color.WhiteSmoke;
            txtDiagnostico.Enabled = false; txtDiagnostico.BackColor = Color.WhiteSmoke;
            txtCasa.Enabled = false; txtCasa.BackColor = Color.WhiteSmoke;
            txtAlimentacion.Enabled = false; txtAlimentacion.BackColor = Color.WhiteSmoke;
            txtAnimales.Enabled = false; txtAnimales.BackColor = Color.WhiteSmoke;
            txtInmunizaciones.Enabled = false; txtInmunizaciones.BackColor = Color.WhiteSmoke;
            txtToxicomanias.Enabled = false; txtToxicomanias.BackColor = Color.WhiteSmoke;
            txtTrabajosYActAnteriores.Enabled = false; txtTrabajosYActAnteriores.BackColor = Color.WhiteSmoke;
            txtDeportesRecreacion.Enabled = false; txtDeportesRecreacion.BackColor = Color.WhiteSmoke;
            txtEntornoFamiliar.Enabled = false; txtEntornoFamiliar.BackColor = Color.WhiteSmoke;
            txtEscolaridad.Enabled = false; txtEscolaridad.BackColor = Color.WhiteSmoke;

            txtAlergias.Enabled = false; txtAlergias.BackColor = Color.WhiteSmoke;
            txtSNerviosoCentral.Enabled = false; txtSNerviosoCentral.BackColor = Color.WhiteSmoke;
            txtSCardiovascular.Enabled = false; txtSCardiovascular.BackColor = Color.WhiteSmoke;
            txtSRespiratorio.Enabled = false; txtSRespiratorio.BackColor = Color.WhiteSmoke;
            txtSGastrointestinal.Enabled = false; txtSGastrointestinal.BackColor = Color.WhiteSmoke;
            txtSEndocrino.Enabled = false; txtSEndocrino.BackColor = Color.WhiteSmoke;
            txtSGenitoUrinario.Enabled = false; txtSGenitoUrinario.BackColor = Color.WhiteSmoke;
            txtSMusculoEsqueletico.Enabled = false; txtSMusculoEsqueletico.BackColor = Color.WhiteSmoke;
            txtGinecoObstetrico.Enabled = false; txtGinecoObstetrico.BackColor = Color.WhiteSmoke;
            txtOrganoSentidos.Enabled = false; txtOrganoSentidos.BackColor = Color.WhiteSmoke;
            txtGrupoSanguineo.Visible = true;

            txtEstudiosLaboratorio.Enabled = false; txtEstudiosLaboratorio.BackColor = Color.WhiteSmoke;
            txtEstudiosRadiologicos.Enabled = false; txtEstudiosRadiologicos.BackColor = Color.WhiteSmoke;
            txtOtros.Enabled = false; txtOtros.BackColor = Color.WhiteSmoke;

            txtConstitucionFisica.Enabled = false; txtConstitucionFisica.BackColor = Color.WhiteSmoke;
            txtTalla.Enabled = false; txtTalla.BackColor = Color.WhiteSmoke;
            txtPeso.Enabled = false; txtPeso.BackColor = Color.WhiteSmoke;
            txtIMC.Enabled = false; txtIMC.BackColor = Color.WhiteSmoke;
            txtGrado.Enabled = false; txtGrado.BackColor = Color.WhiteSmoke;
            txtFC.Enabled = false; txtFC.BackColor = Color.WhiteSmoke;
            txtFR.Enabled = false; txtFR.BackColor = Color.WhiteSmoke;
            txtPulso.Enabled = false; txtPulso.BackColor = Color.WhiteSmoke;
            txtTA.Enabled = false; txtTA.BackColor = Color.WhiteSmoke;
            txtTemperatura.Enabled = false; txtTemperatura.BackColor = Color.WhiteSmoke;

            txtCraneo.Enabled = false; txtCraneo.BackColor = Color.WhiteSmoke;
            txtOjos.Enabled = false; txtOjos.BackColor = Color.WhiteSmoke;
            txtOidos.Enabled = false; txtOidos.BackColor = Color.WhiteSmoke;
            txtNariz.Enabled = false; txtNariz.BackColor = Color.WhiteSmoke;
            txtBoca.Enabled = false; txtBoca.BackColor = Color.WhiteSmoke;
            txtCuello.Enabled = false; txtCuello.BackColor = Color.WhiteSmoke;
            txtTorax.Enabled = false; txtTorax.BackColor = Color.WhiteSmoke;
            txtAbdomen.Enabled = false; txtAbdomen.BackColor = Color.WhiteSmoke;
            txtGenitourinario.Enabled = false; txtGenitourinario.BackColor = Color.WhiteSmoke;
            txtMusculoEsqueletico.Enabled = false; txtMusculoEsqueletico.BackColor = Color.WhiteSmoke;
            txtNeurologico.Enabled = false; txtNeurologico.BackColor = Color.WhiteSmoke;


            // Deshabilitar los RadioButton específicos
            rbtnHozpitalizaciones.Enabled = false;
            rbtnCirugias.Enabled = false;
            rbtnTransfusiones.Enabled = false;

            // Combos 
            cboxGrupoSanguineo.Visible = false;
            txtGrupoSanguineo.Visible = true;

            cboxConstitucionFisica.Visible = false;
            txtConstitucionFisica.Visible = true;

            cboxGrado.Visible = false;
            txtGrado.Visible = true;
        }

        private void cboxNumExpediente2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            consultaExpediente();
        }

        public void consultaExpediente()
        {
            if (cboxNumExpediente2.SelectedValue == null)
                btnActualizar.Enabled = false;
            else if (cboxNumExpediente2.SelectedValue != null)
                btnActualizar.Enabled = true;

            DataTable t = expedientesCN.consultaExpediente(cboxNumExpediente2.SelectedValue.ToString()).Tables["ConsultaNumExpediente"];

            if (t.Rows.Count > 0)
            {
                DataRow dr = t.Rows[0];

                // Función auxiliar para evitar la repetición de DBNull
                string GetStringValue(object value) => value != DBNull.Value ? value.ToString() : "";

                txtNombreEmpleado.Text = $"{GetStringValue(dr["nombre"])} {GetStringValue(dr["apellido_paterno"])} {GetStringValue(dr["apellido_materno"])}";
                txtIdEmpleado.Text = GetStringValue(dr["idEmpleado"]);
                txtNumeroNomina.Text = GetStringValue(dr["NumNomina"]);
                DateTime fechaModificacion = dr["UltimaFechaActualizacion"] != DBNull.Value ? Convert.ToDateTime(dr["UltimaFechaActualizacion"]) : DateTime.MinValue;
                txtUltimaModificacion.Text = fechaModificacion.ToString("dd-MMMM-yyyy");

                DateTime fechaNacimiento = dr["fecha_nacimiento"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_nacimiento"]) : DateTime.MinValue;
                DateTime fechaIngresoAlPuesto = dr["fecha_ingreso_puesto"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_ingreso_puesto"]) : DateTime.MinValue;
                DateTime fechaActual = DateTime.Now;

                int edad = (fechaNacimiento != DateTime.MinValue) ? fechaActual.Year - fechaNacimiento.Year - (fechaActual < fechaNacimiento.AddYears(fechaActual.Year - fechaNacimiento.Year) ? 1 : 0) : 0;
                txtEdad.Text = edad > 0 ? edad.ToString() : "N/A";

                // Asignar los valores de texto
                txtSexo.Text = GetStringValue(dr["sexo"]);
                txtEstadoCivil.Text = GetStringValue(dr["estado_civil"]);
                txtNSS.Text = GetStringValue(dr["nss"]);
                txtTelefono.Text = GetStringValue(dr["telefono"]);
                txtDomicilio.Text = (dr["domicilio_Calle"] as string ?? "") + " #" +
                     (dr["domicilio_Numero"] as string ?? "") + ", " +
                     (dr["domicilio_Colonia"] as string ?? "") + ", " +
                     (dr["domicilio_Ciudad"] as string ?? "") + ", " +
                     (dr["domicilio_Estado"] as string ?? "");
                txtFechaIngreso.Text = fechaIngresoAlPuesto != DateTime.MinValue ? fechaIngresoAlPuesto.ToString("dd-MMMM-yyyy") : "N/A";
                txtPuesto.Text = GetStringValue(dr["puesto"]);

                // Antecedentes y otros campos
                txtHeredoFamiliar.Text = GetStringValue(dr["Antecedentes_Heredofamiliares"]);
                txtDiagnostico.Text = GetStringValue(dr["Diagnostico_inicial"]);
                txtCasa.Text = GetStringValue(dr["Casa"]);
                txtAlimentacion.Text = GetStringValue(dr["Alimentacion"]);
                txtAnimales.Text = GetStringValue(dr["Animales"]);
                txtInmunizaciones.Text = GetStringValue(dr["Inmunizaciones"]);
                txtToxicomanias.Text = GetStringValue(dr["Toxicomanias"]);
                txtTrabajosYActAnteriores.Text = GetStringValue(dr["Trabajo_actividades_anteriores"]);
                txtDeportesRecreacion.Text = GetStringValue(dr["Deportes"]);
                txtEntornoFamiliar.Text = GetStringValue(dr["Entorno_Familiar"]);
                txtEscolaridad.Text = GetStringValue(dr["Escolaridad"]);

                // Checkboxes
                rbtnHozpitalizaciones.Checked = dr["Hospitalizaciones"] != DBNull.Value && Convert.ToBoolean(dr["Hospitalizaciones"]);
                rbtnCirugias.Checked = dr["Cirugias"] != DBNull.Value && Convert.ToBoolean(dr["Cirugias"]);
                rbtnTransfusiones.Checked = dr["Transfusiones"] != DBNull.Value && Convert.ToBoolean(dr["Transfusiones"]);

                // Sistemas
                txtAlergias.Text = GetStringValue(dr["Alergias"]);
                txtSNerviosoCentral.Text = GetStringValue(dr["SistemaNervioso_Central"]);
                txtSCardiovascular.Text = GetStringValue(dr["SistemaCardiovascular"]);
                txtSRespiratorio.Text = GetStringValue(dr["SistemaRespiratorio"]);
                txtSGastrointestinal.Text = GetStringValue(dr["SistemaGastrointestinal"]);
                txtSEndocrino.Text = GetStringValue(dr["SistemaEndocrinico"]);
                txtSGenitoUrinario.Text = GetStringValue(dr["SistemaGenitourinario"]);
                txtSMusculoEsqueletico.Text = GetStringValue(dr["SistemaMusculoesqueletico"]);
                txtOrganoSentidos.Text = GetStringValue(dr["Organo_Sentidos"]);
                txtGinecoObstetrico.Text = GetStringValue(dr["ginecoObstetricos"]);
                txtGrupoSanguineo.Text = GetStringValue(dr["Grupo_Sanguineo"]);

                // Estudios
                txtEstudiosLaboratorio.Text = GetStringValue(dr["Estudios_Laboratorio"]);
                txtEstudiosRadiologicos.Text = GetStringValue(dr["Estudios_Radiologicos"]);
                txtOtros.Text = GetStringValue(dr["Otros"]);

                // Examen físico
                txtConstitucionFisica.Text = GetStringValue(dr["Constitucion_Fisica"]);
                txtTalla.Text = GetStringValue(dr["Talla"]);
                txtPeso.Text = GetStringValue(dr["Peso"]);
                txtIMC.Text = GetStringValue(dr["IMC"]);
                txtGrado.Text = GetStringValue(dr["Grado"]);
                txtFC.Text = GetStringValue(dr["FC"]);
                txtFR.Text = GetStringValue(dr["FR"]);
                txtPulso.Text = GetStringValue(dr["Pulso"]);
                txtTA.Text = GetStringValue(dr["TA"]);
                txtTemperatura.Text = GetStringValue(dr["Temperatura"]);

                // Otras áreas
                txtCraneo.Text = GetStringValue(dr["Craneo"]);
                txtOjos.Text = GetStringValue(dr["Ojos"]);
                txtOidos.Text = GetStringValue(dr["Oidos"]);
                txtNariz.Text = GetStringValue(dr["Nariz"]);
                txtBoca.Text = GetStringValue(dr["Boca"]);
                txtCuello.Text = GetStringValue(dr["Cuello"]);
                txtTorax.Text = GetStringValue(dr["Torax"]);
                txtAbdomen.Text = GetStringValue(dr["Abdomen"]);
                txtGenitourinario.Text = GetStringValue(dr["Genitourinario"]);
                txtMusculoEsqueletico.Text = GetStringValue(dr["MusculoEsqueletico"]);
                txtNeurologico.Text = GetStringValue(dr["Neurologico"]);
            }

        }
        private void btnGrabarActualizacion_Click(object sender, EventArgs e)
        {
            try
            { 
                string numExpediente = cboxNumExpediente2.SelectedValue.ToString();
                string heredoFamiliar = txtHeredoFamiliar.Text;
                string diagnostico = txtDiagnostico.Text;


                string casa = txtCasa.Text;
                string alimentacion = txtAlimentacion.Text;
                string animales = txtAnimales.Text;
                string inmunizaciones = txtInmunizaciones.Text;
                string toxicomanias = txtToxicomanias.Text;
                string trabajoActividadesAnteriores = txtTrabajosYActAnteriores.Text;
                string deportes = txtDeportesRecreacion.Text;
                string entornoFamiliar = txtEntornoFamiliar.Text;
                string escolaridad = txtEscolaridad.Text;

                Boolean hospitalizaciones = false;
                hospitalizaciones = rbtnHozpitalizaciones.Checked ? true : false;
                Boolean cirugias = false;
                cirugias = rbtnCirugias.Checked ? true : false;
                Boolean transfusiones = false;
                transfusiones = rbtnTransfusiones.Checked ? true : false;
                string alergias = txtAlergias.Text;

                string sistemaNerviosoCentral = txtSNerviosoCentral.Text;
                string sistemaCardiovascular = txtSCardiovascular.Text;
                string sistemaRespiratorio = txtSRespiratorio.Text;
                string sistemaGastrointestinal = txtSGastrointestinal.Text;
                string sistemaEndocrinico = txtSEndocrino.Text;
                string sistemaGenitourinario = txtSGenitoUrinario.Text;
                string sistemaMusculoesqueletico = txtSMusculoEsqueletico.Text;
                string organoSentidos = txtOrganoSentidos.Text;
                string ginecoObstetricos = txtGinecoObstetrico.Text;
                string grupoSanguineo = cboxGrupoSanguineo.Text;


                string estudiosLaboratorio = txtEstudiosLaboratorio.Text;
                string estudiosRadiologicos = txtEstudiosRadiologicos.Text;
                string otros = txtOtros.Text;


                string constitucion_Fisica = cboxConstitucionFisica.Text;
                double talla = Convert.ToDouble(txtTalla.Text);
                double peso = Convert.ToDouble(txtPeso.Text);
                double imc = Convert.ToDouble(txtIMC.Text);
                string grado = cboxGrado.Text;
                double fc = Convert.ToDouble(txtFC.Text);
                double fr = Convert.ToDouble(txtFR.Text);
                int pulso = Convert.ToInt32(txtPulso.Text);
                string ta = txtTA.Text;
                double temperatura = Convert.ToDouble(txtTemperatura.Text);


                string craneo = txtCraneo.Text;
                string ojos = txtOjos.Text;
                string oidos = txtOidos.Text;
                string nariz = txtNariz.Text;
                string boca = txtBoca.Text;
                string cuello = txtCuello.Text;
                string torax = txtTorax.Text;
                string abdomen = txtAbdomen.Text;
                string genitourinario = txtGenitourinario.Text;
                string musculoEsqueletico = txtMusculoEsqueletico.Text;
                string neurologico = txtNeurologico.Text;

                DateTime ultimaActualizacion = DateTime.Now.Date;
            

                ExpedientesCE expediente = new ExpedientesCE
                {
                    NumExpediente = numExpediente,
                    HeredoFamiliar = heredoFamiliar,
                    DiagnosticoInicial = diagnostico,

                    Casa = casa,
                    Alimentacion = alimentacion,
                    Animales = animales,
                    Inmunizaciones = inmunizaciones,
                    Toxicomanias = toxicomanias,
                    TrabajoActividadesAnteriores = trabajoActividadesAnteriores,
                    Deportes = deportes,
                    EntornoFamiliar = entornoFamiliar,
                    Escolaridad = escolaridad,

                    Hospitalizaciones = hospitalizaciones,
                    Cirugias = cirugias,
                    Transfusiones = transfusiones,
                    Alergias = alergias,

                    SistemaNerviosoCentral = sistemaNerviosoCentral,
                    SistemaCardiovascular = sistemaCardiovascular,
                    SistemaRespiratorio = sistemaRespiratorio,
                    SistemaGastrointestinal = sistemaGastrointestinal,
                    SistemaEndocrinico = sistemaEndocrinico,
                    SistemaGenitourinario = sistemaGenitourinario,
                    SistemaMusculoesqueletico = sistemaMusculoesqueletico,
                    OrganoSentidos = organoSentidos,
                    GinecoObstetricos = ginecoObstetricos,
                    GrupoSanguineo = grupoSanguineo,


                    EstudiosLaboratorio = estudiosLaboratorio,
                    EstudiosRadiologicos = estudiosRadiologicos,
                    Otros = otros,


                    Constitucion_Fisica = constitucion_Fisica,
                    Talla = talla,
                    Peso = peso,
                    IMC = imc,
                    Grado = grado,
                    Fc = fc,
                    Fr = fr,
                    Pulso = pulso,
                    Ta = ta,
                    Temperatura = temperatura,


                    Craneo = craneo,
                    Ojos = ojos,
                    Oidos = oidos,
                    Nariz = nariz,
                    Boca = boca,
                    Cuello = cuello,
                    Torax = torax,
                    Abdomen = abdomen,
                    Genitourinario = genitourinario,
                    MusculoEsqueletico = musculoEsqueletico,
                    Neurologico = neurologico,

                    UltimaActualizacion = ultimaActualizacion
                };

                int registro = expedientesCN.actualizarExpediente(expediente);
                if (registro > 0)
                {
                    MostrarPanel(pDatosGenerales);
                    var result = RJMessageBox.Show(" Expediente médico actualizado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Llamada al método para limpiar todos los controles en el formulario
                    //LimpiarControles(this);
                    txtNumeroNomina.Focus();
                    //txtCondicion.Clear(); txtNoAccidente.Clear(); txtNumeroNomina.Clear(); txtNombreEmpleado.Clear(); txtIdEmpleado.Clear(); txtEdad.Clear(); txtPuesto.Clear(); txtAntiguedad.Clear();
                    desactivarCampos();

                }
                else
                {
                    var result = RJMessageBox.Show(" No se han podido grabar los cambios al expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show("Error, al intentar grabar, campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            consultaExpediente();

        }
        public void ValidacionNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back ||
                  e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Enter ||
                  e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Escape ||
                  e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right))
            {
                var result = RJMessageBox.Show("Solo se pueden introducir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true; // Bloquea la entrada de caracteres no permitidos
            }
        }
        public void ValidacionNumerosDecimal(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextPersonalizado;

            // Verifica si es un punto decimal
            if (e.KeyChar == '.')
            {
                if (textBox.Text.Contains("."))
                {
                    RJMessageBox.Show("Solo se permite un punto decimal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // Bloquea la entrada de un segundo punto
                }
                return; // Permite el primer punto y sale de la función
            }

            // Validar otros caracteres permitidos
            if (!(char.IsDigit(e.KeyChar) ||
                  e.KeyChar == (char)Keys.Back ||
                  e.KeyChar == (char)Keys.Delete ||
                  e.KeyChar == (char)Keys.Enter ||
                  e.KeyChar == (char)Keys.Tab ||
                  e.KeyChar == (char)Keys.Escape ||
                  e.KeyChar == (char)Keys.Left ||
                  e.KeyChar == (char)Keys.Right))
            {
                RJMessageBox.Show("Solo se pueden introducir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void CalcularIMC()
        {
            double talla = 0, peso = 0, imc = 0;

            // Verificamos si los valores de peso y talla son válidos
            if (double.TryParse(txtTalla.Text, out talla) && talla > 0 &&
                double.TryParse(txtPeso.Text, out peso) && peso > 0)
            {
                // Calculamos el IMC
                imc = peso / (talla * talla);

                // Mostramos el resultado en txtIMC, redondeando el valor a 2 decimales
                txtIMC.Text = imc.ToString("F2");
            }
            else
            {
                // Si los valores no son válidos, dejamos txtIMC vacío
                txtIMC.Clear();
            }
        }
        private void txtTalla_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTalla.Text))
            {
                return;
            }
            double talla;
            if (double.TryParse(txtTalla.Text, out talla))
            {
                if (talla > 3 || talla < 0.5)
                {
                    var result = RJMessageBox.Show("Por favor, ingresa una talla válida. Recuerda que la talla debe estar en metros y ser un valor positivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTalla.Clear();
                    txtTalla.Focus();
                }
                else
                {
                    CalcularIMC();
                }
            }
            else
            {

                var result = RJMessageBox.Show("Por favor, ingresa un número válido para la talla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTalla.Clear();
                txtTalla.Focus();
            }
        }

        private void txtPeso_Validating(object sender, CancelEventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            if (peso > 300 || peso < 20)
            {
                var result = RJMessageBox.Show("Por favor, ingresa un peso válido. Recuerda que el peso debe estar en kilogramos y ser un valor positivo.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtPeso.Clear();
                txtPeso.Focus();
            }
            else
            {
                CalcularIMC();
            }
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtIMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtFR_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtPulso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);
        }

        private void txtTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }
    }
}
