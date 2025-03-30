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

        private void btnBuscarExpediente_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNoExpediente.Text))
            {


                DataTable t = expedientesCN.consultaExpediente(txtNoExpediente.Text).Tables["ConsultaNumExpediente"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];
                    txtNombreEmpleado.Text =
                            (dr["nombre"] as string ?? "") + " " +
                            (dr["apellido_paterno"] as string ?? "") + " " +
                            (dr["apellido_materno"] as string ?? "");

                    txtIdEmpleado.Text = dr["idEmpleado"].ToString();

                    txtNumeroNomina.Text = dr["NumNomina"].ToString();


                    DateTime fechaNacimiento = dr["fecha_nacimiento"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_nacimiento"]) : DateTime.MinValue;
                    DateTime fechaIngresoAlPuesto = dr["fecha_ingreso_puesto"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_ingreso_puesto"]) : DateTime.MinValue;
                    DateTime fechaActual = DateTime.Now;

                    int edad = 0;
                    edad = fechaNacimiento != DateTime.MinValue
                        ? fechaActual.Year - fechaNacimiento.Year - (fechaActual < fechaNacimiento.AddYears(edad) ? 1 : 0)
                        : 0;
                    txtEdad.Text = edad > 0 ? edad.ToString() : "N/A";
                    txtSexo.Text = dr["sexo"].ToString();
                    txtEstadoCivil.Text = dr["estado_civil"].ToString();
                    txtNSS.Text = dr["nss"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtDomicilio.Text = (dr["domicilio_Calle"] as string ?? "") + " #" +
                        (dr["domicilio_Numero"] as string ?? "") + ", " +
                        (dr["domicilio_Colonia"] as string ?? "") + ", " +
                        (dr["domicilio_Ciudad"] as string ?? "") + ", " +
                        (dr["domicilio_Estado"] as string ?? "");
                    txtFechaIngreso.Text = fechaIngresoAlPuesto.ToString("dd-MMMM-yyyy");
                    txtPuesto.Text = dr["puesto"] as string ?? "N/A";



                    txtHeredoFamiliar.Text = dr["Antecedentes_Heredofamiliares"].ToString();
                    txtDiagnostico.Text = dr["Diagnostico_inicial"].ToString();

                    txtCasa.Text = dr["Casa"].ToString();
                    txtAlimentacion.Text = dr["Alimentacion"].ToString();
                    txtAnimales.Text= dr["Animales"].ToString();
                    txtInmunizaciones.Text = dr["Inmunizaciones"].ToString();
                    txtToxicomanias.Text  = dr["Toxicomanias"].ToString();
                    txtTrabajosYActAnteriores.Text= dr["Trabajo_actividades_anteriores"].ToString();
                    txtDeportesRecreacion.Text = dr["Deportes"].ToString();
                    txtEntornoFamiliar.Text = dr["Entorno_Familiar"].ToString();
                    txtEscolaridad.Text = dr["Escolaridad"].ToString();

                    if (dr["Hospitalizaciones"] != DBNull.Value)
                    {
                        rbtnHozpitalizaciones.Checked = Convert.ToBoolean(dr["Hospitalizaciones"]);
                    }
                    else
                    {
                        rbtnHozpitalizaciones.Checked = false; 
                    }
                    if (dr["Cirugias"] != DBNull.Value)
                    {
                        rbtnCirugias.Checked = Convert.ToBoolean(dr["Cirugias"]);
                    }
                    else
                    {
                        rbtnCirugias.Checked = false;
                    }
                    if (dr["Transfusiones"] != DBNull.Value)
                    {
                        rbtnTransfusiones.Checked = Convert.ToBoolean(dr["Transfusiones"]);
                    }
                    else
                    {
                        rbtnTransfusiones.Checked = false;
                    }

                    txtAlergias.Text = dr["Alergias"].ToString();
                    txtSNerviosoCentral.Text = dr["SistemaNervioso_Central"].ToString();
                    txtSCardiovascular.Text = dr["SistemaCardiovascular"].ToString();
                    txtSRespiratorio.Text = dr["SistemaRespiratorio"].ToString();
                    txtSGastrointestinal.Text = dr["SistemaGastrointestinal"].ToString();
                    txtSEndocrino.Text = dr["SistemaEndocrinico"].ToString();
                    txtSGenitoUrinario.Text = dr["SistemaGenitourinario"].ToString();
                    txtSMusculoEsqueletico.Text = dr["SistemaMusculoesqueletico"].ToString();
                    txtOrganoSentidos.Text = dr["Organo_Sentidos"].ToString();
                    txtGrupoSanguineo.Text = dr["Grupo_Sanguineo"].ToString();

                    txtEstudiosLaboratorio.Text = dr["Estudios_Laboratorio"].ToString();
                    txtEstudiosRadiologicos.Text = dr["Estudios_Radiologicos"].ToString();
                    txtOtros.Text = dr["Otros"].ToString();

                    txtConstitucionFisica.Text = dr["Constitucion_Fisica"].ToString();
                    txtTalla.Text = dr["Talla"].ToString();
                    txtPeso.Text = dr["Peso"].ToString();
                    txtIMC.Text = dr["IMC"].ToString();
                    txtGrado.Text = dr["Grado"].ToString();
                    txtFC.Text = dr["FC"].ToString();
                    txtFR.Text = dr["FR"].ToString();
                    txtPulso.Text = dr["Pulso"].ToString();
                    txtTA.Text = dr["TA"].ToString();
                    txtTemperatura.Text = dr["Temperatura"].ToString();
                    
                    
                    txtCraneo.Text  = dr["Craneo"].ToString();
                    txtOjos.Text = dr["Ojos"].ToString();
                    txtOidos.Text = dr["Oidos"].ToString();
                    txtNariz.Text = dr["Nariz"].ToString();
                    txtBoca.Text = dr["Boca"].ToString();
                    txtCuello.Text = dr["Cuello"].ToString();
                    txtTorax.Text = dr["Torax"].ToString();
                    txtAbdomen.Text = dr["Abdomen"].ToString();
                    txtGenitourinario.Text = dr["Genitourinario"].ToString();
                    txtMusculoEsqueletico.Text = dr["MusculoEsqueletico"].ToString();
                    txtNeurologico.Text = dr["Neurologico"].ToString();
                    


                }
            }

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
            txtSEndocrino.Enabled = true;
            txtSGenitoUrinario.Enabled = true;
            txtSMusculoEsqueletico.Enabled = true;
            txtOrganoSentidos.Enabled = true;
            cboxGrupoSanguineo.Visible = true;
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
        }
    }
}
