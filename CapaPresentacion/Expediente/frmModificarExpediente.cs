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
                Pen pen = new Pen(Color.FromArgb(27, 77, 141), 5); // Cambia el color aquí
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
            txtHeredoFamiliar.Enabled = true;
            txtDiagnostico.Enabled = true;
            txtCasa.Enabled = true;
            txtAlimentacion.Enabled = true;
            txtAnimales.Enabled = true;
            txtInmunizaciones.Enabled = true;
            txtToxicomanias.Enabled = true;
            txtTrabajosYActAnteriores.Enabled = true;
            txtDeportesRecreacion.Enabled = true;
            txtEntornoFamiliar.Enabled = true;
            txtEscolaridad.Enabled = true;

            txtAlergias.Enabled = true;
            txtSNerviosoCentral.Enabled = true;
            txtSCardiovascular.Enabled = true;
            txtSRespiratorio.Enabled = true;
            txtSGastrointestinal.Enabled = true;
            txtSEndocrino.Enabled = true;
            txtSGenitoUrinario.Enabled = true;
            txtSMusculoEsqueletico.Enabled = true;
            txtOrganoSentidos.Enabled = true;
            txtGrupoSanguineo.Visible=false;

            txtEstudiosLaboratorio.Enabled = true;
            txtEstudiosRadiologicos.Enabled = true;
            txtOtros.Enabled = true;

            txtConstitucionFisica.Enabled = true;
            txtTalla.Enabled = true;
            txtPeso.Enabled = true;
            txtIMC.Enabled = true;
            txtGrado.Enabled = true;
            txtFC.Enabled = true;
            txtFR.Enabled = true;
            txtPulso.Enabled = true;
            txtTA.Enabled = true;
            txtTemperatura.Enabled = true;

            txtCraneo.Enabled = true;
            txtOjos.Enabled = true;
            txtOidos.Enabled = true;
            txtNariz.Enabled = true;
            txtBoca.Enabled = true;
            txtCuello.Enabled = true;
            txtTorax.Enabled = true;
            txtAbdomen.Enabled = true;
            txtGenitourinario.Enabled = true;
            txtMusculoEsqueletico.Enabled = true;
            txtNeurologico.Enabled = true;

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
            txtHeredoFamiliar.Enabled = false;
            txtDiagnostico.Enabled = false;
            txtCasa.Enabled = false;
            txtAlimentacion.Enabled = false;
            txtAnimales.Enabled = false;
            txtInmunizaciones.Enabled = false;
            txtToxicomanias.Enabled = false;
            txtTrabajosYActAnteriores.Enabled = false;
            txtDeportesRecreacion.Enabled = false;
            txtEntornoFamiliar.Enabled = false;
            txtEscolaridad.Enabled = false;

            txtAlergias.Enabled = false;
            txtSNerviosoCentral.Enabled = false;
            txtSCardiovascular.Enabled = false;
            txtSRespiratorio.Enabled = false;
            txtSGastrointestinal.Enabled = false;
            txtSEndocrino.Enabled = false;
            txtSGenitoUrinario.Enabled = false;
            txtSMusculoEsqueletico.Enabled = false;
            txtOrganoSentidos.Enabled = false;
            txtGrupoSanguineo.Visible = true;

            txtEstudiosLaboratorio.Enabled = false;
            txtEstudiosRadiologicos.Enabled = false;
            txtOtros.Enabled = false;

            txtConstitucionFisica.Enabled = false;
            txtTalla.Enabled = false;
            txtPeso.Enabled = false;
            txtIMC.Enabled = false;
            txtGrado.Enabled = false;
            txtFC.Enabled = false;
            txtFR.Enabled = false;
            txtPulso.Enabled = false;
            txtTA.Enabled = false;
            txtTemperatura.Enabled = false;

            txtCraneo.Enabled = false;
            txtOjos.Enabled = false;
            txtOidos.Enabled = false;
            txtNariz.Enabled = false;
            txtBoca.Enabled = false;
            txtCuello.Enabled = false;
            txtTorax.Enabled = false;
            txtAbdomen.Enabled = false;
            txtGenitourinario.Enabled = false;
            txtMusculoEsqueletico.Enabled = false;
            txtNeurologico.Enabled = false;

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
            
                DataTable t = expedientesCN.consultaExpediente(cboxNumExpediente2.SelectedValue.ToString()).Tables["ConsultaNumExpediente"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];

                    // Función auxiliar para evitar la repetición de DBNull
                    string GetStringValue(object value) => value != DBNull.Value ? value.ToString() : "";

                    txtNombreEmpleado.Text = $"{GetStringValue(dr["nombre"])} {GetStringValue(dr["apellido_paterno"])} {GetStringValue(dr["apellido_materno"])}";
                    txtIdEmpleado.Text = GetStringValue(dr["idEmpleado"]);
                    txtNumeroNomina.Text = GetStringValue(dr["NumNomina"]);

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
                var result = RJMessageBox.Show(" El Reporte de Accidente se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Llamada al método para limpiar todos los controles en el formulario
                //LimpiarControles(this);
                txtNumeroNomina.Focus();
                //txtCondicion.Clear(); txtNoAccidente.Clear(); txtNumeroNomina.Clear(); txtNombreEmpleado.Clear(); txtIdEmpleado.Clear(); txtEdad.Clear(); txtPuesto.Clear(); txtAntiguedad.Clear();
                desactivarCampos();

            }
            else
            {
                var result = RJMessageBox.Show(" No se ha podido grabar el Reporte de Accidente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
