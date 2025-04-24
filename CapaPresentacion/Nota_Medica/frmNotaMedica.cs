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

namespace CapaPresentacion.Nota_Medica
{
    public partial class frmNotaMedica : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();
        ConsultaMedicaCN consultaMedicaCN = new ConsultaMedicaCN(); 
        EmpleadosCN empleadosCN = new EmpleadosCN();

        // Array para guardar las idTipoCausa
        List<int> idTipoCausaList = new List<int>();

        public frmNotaMedica()
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

            panel3.Paint += new PaintEventHandler(Panel1_Paint);
            panel4.Paint += new PaintEventHandler(Panel1_Paint);
            panel7.Paint += new PaintEventHandler(Panel1_Paint);
            panel8.Paint += new PaintEventHandler(Panel1_Paint);
            panel9.Paint += new PaintEventHandler(Panel1_Paint);
            panel10.Paint += new PaintEventHandler(Panel1_Paint);
            panel12.Paint += new PaintEventHandler(Panel1_Paint);
            panel6.Paint += new PaintEventHandler(Panel1_Paint);

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

        private void CargarCausasConsulta()
        {
            // Obtener los datos desde la capa de negocios
            DataSet ds = consultaMedicaCN.consultaCausas();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cboxCausaConsulta.DataSource = ds.Tables[0];
                cboxCausaConsulta.DisplayMember = "causas"; // Nombre de la columna en la BD
                cboxCausaConsulta.ValueMember = "causas";  // Puede ser un ID si lo deseas
            }
            else
            {
                RJMessageBox.Show("No se encontraron causas de consulta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
 

        private void CargarTipoCausa(int idCausa)
        {
            // Obtener los datos de tipo de causa basado en el idCausa
            DataSet ds = consultaMedicaCN.consultaTipoCausa(idCausa + 1);

            // Limpiar la lista de idTipoCausa en cada llamada
            idTipoCausaList.Clear();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Limpiar la ComboBox antes de agregar nuevos elementos
                cboxTipoCausa.DataSource = null;

                // Añadir los datos a la ComboBox
                cboxTipoCausa.DataSource = ds.Tables[0];
                cboxTipoCausa.DisplayMember = "tipoCausa"; // Nombre de la columna visible
                cboxTipoCausa.ValueMember = "idTipoCausa";  // Valor asociado, que es el idTipoCausa

                // Llenar la lista de idTipoCausa
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int idTipoCausa = Convert.ToInt32(row["idTipoCausa"]);
                    idTipoCausaList.Add(idTipoCausa); // Guardamos los idTipoCausa en la lista
                }
            }
            else
            {
                cboxTipoCausa.DataSource = null;
                RJMessageBox.Show("No se encontraron tipos de causa para la causa seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesDatos.Controls.Add(p);
            p.BackColor = Color.FromArgb(91, 194, 255); // Color para el panel
            p.Size = new Size(187, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }

        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesDatos.Controls.Remove(p);
        }

        private Dictionary<Button, bool> panelVisitado = new Dictionary<Button, bool>();

        private void MostrarPanel(Panel panelAMostrar, Button botonPresionado)
        {
            // Marcar este botón como visitado
            if (!panelVisitado.ContainsKey(botonPresionado))
            {
                panelVisitado[botonPresionado] = true;
            }

            // Ocultar todos los paneles y mostrar el deseado
            pDatosGenerales.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;

            panelAMostrar.Visible = true;
        }


        private void frmNotaMedica_Load(object sender, EventArgs e)
        {
            CargarCausasConsulta();

            pDatosGenerales.Visible = true;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            MostrarPanel(pAntecedentes, btnAntecedentes);
        }

        private void btnEstudiosParaclinicos_Click(object sender, EventArgs e)
        {
            MostrarPanel(pEstudiosParaclinicos, btnEstudiosParaclinicos);
        }

        private void btnNuevaNotaMedica_Click(object sender, EventArgs e)
        {
            btnAntecedentes.Visible = false;
            btnNoPatologicos.Visible = false;
            btnPatologicos.Visible = false;
            btnExploracionFisica.Visible = false;
            btnEstudiosParaclinicos.Visible = false;
            btnNuevaNotaMedica.Visible = false;
            labelExp.Visible = false;
            MostrarPanel(pDatosGenerales, btnNuevaNotaMedica);
        }

        private void btnNoPatologicos_Click(object sender, EventArgs e)
        {
            MostrarPanel(pNoPatologicos, btnNoPatologicos);
        }

        private void btnPatologicos_Click(object sender, EventArgs e)
        {
            MostrarPanel(pPatologicos, btnPatologicos);
        }

        private void btnExploracionFisica_Click(object sender, EventArgs e)
        {
            MostrarPanel(pExploracionFisica, btnExploracionFisica);
        }

        private void cboxCausaConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCausaConsulta.SelectedValue != null)
            {
                int idCausa = cboxCausaConsulta.SelectedIndex;
                CargarTipoCausa(idCausa);
            }
        }

        static string ObtenerNomenclatura(string nombre)
        {
            return string.Concat(nombre.Split(' ').Select(palabra => palabra[0]));
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumeroNomina.Text))
            {
                DataTable t = empleadosCN.ConsultaEmpleadoNumNomina(txtNumeroNomina.Text).Tables["ConsultaEmpleado"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];

                    txtNombreEmpleado.Text =
                        (dr["nombre"] as string ?? "") + " " +
                        (dr["apellido_paterno"] as string ?? "") + " " +
                        (dr["apellido_materno"] as string ?? "");

                    txtIdEmpleado.Text = dr["idEmpleado"].ToString();

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
                    txtIMSS.Text = dr["nss"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtDomicilio.Text = (dr["domicilio_Calle"] as string ?? "") + " #" +
                        (dr["domicilio_Numero"] as string ?? "") + ", " +
                        (dr["domicilio_Colonia"] as string ?? "") + ", " +
                        (dr["domicilio_Ciudad"] as string ?? "") + ", " +
                        (dr["domicilio_Estado"] as string ?? "");
                    txtPuesto.Text = dr["puesto"] as string ?? "N/A";
                    txtFechaIngreso.Text = fechaIngresoAlPuesto.ToString("dd-MMMM-yyyy");
                    string nombre = txtNombreEmpleado.Text;
                    string nomenclarura = ObtenerNomenclatura(nombre);
                    txtNoExpediente.Text = nomenclarura + "-" + txtNumeroNomina.Text;
                }
                else
                {
                    RJMessageBox.Show(" Número de nómina no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                RJMessageBox.Show(" Por favor ingrese un Número de Nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroNomina.Focus();
            }
        }

        private void LimpiarCampos()
        {
            txtNumeroNomina.Clear();
            txtNoExpediente.Clear();
            txtNombreEmpleado.Clear();
            txtIdEmpleado.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
            txtPuesto.Clear();
            txtEstadoCivil.Clear();
            txtIMSS.Clear();
            txtFechaIngreso.Clear();
            cboxProceso.SelectedIndex = 0;
            cboxCausaConsulta.SelectedIndex = 0;
            cboxTipoCausa.SelectedIndex = 0;
            txtObservaciones.Clear();
            txtDiagnostico.Clear();
            dtpFechaConsulta.Value = DateTime.Now;

            txtConstitucionFisica.Clear();
            txtTalla.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
            txtGrado.Clear();
            txtFC.Clear();
            txtFR.Clear();
            txtPulso.Clear();
            txtTA.Clear();
            txtTemperatura.Clear();
            txtCraneo.Clear();
            txtOjos.Clear();
            txtOidos.Clear();
            txtNariz.Clear();   
            txtBoca.Clear();    
            txtCuello.Clear();  
            txtTorax.Clear();
            txtAbdomen.Clear();
            txtGenitourinario.Clear();
            txtMusculoEsqueletico.Clear();
            txtNeurologico.Clear();
            txtAlergias.Clear();
            txtSNerviosoCentral.Clear();
            txtSCardiovascular.Clear();
            txtSRespiratorio.Clear();
            txtSGastrointestinal.Clear();
            txtSEndocrino.Clear();
            txtSGenitoUrinario.Clear();
            txtSMusculoEsqueletico.Clear();
            txtOrganoSentidos.Clear();
            txtGinecoObstetrico.Clear();
            txtGrupoSanguineo.Clear();
            txtEstudiosLaboratorio.Clear();
            txtEstudiosRadiologicos.Clear();
            txtOtros.Clear();
            txtDiagnosticoExp.Clear();
            txtHeredoFamiliar.Clear();
            txtCasa.Clear();
            txtAlimentacion.Clear();
            txtAnimales.Clear();
            txtInmunizaciones.Clear();
            txtToxicomanias.Clear();
            txtTrabajosYActAnteriores.Clear();
            txtDeportesRecreacion.Clear();
            txtEntornoFamiliar.Clear();
            txtEscolaridad.Clear();

            rbtnHozpitalizaciones.Checked = false;
            rbtnCirugias.Checked = false;
            rbtnTransfusiones.Checked = false;
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos no están vacíos (agrega validaciones previas)
                if (string.IsNullOrEmpty(txtNoExpediente.Text) || string.IsNullOrEmpty(txtObservaciones.Text) || string.IsNullOrEmpty(txtDiagnostico.Text) || string.IsNullOrEmpty(cboxProceso.Text) || cboxTipoCausa.SelectedIndex == -1)
                {
                    RJMessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el idTipoCausa de la lista utilizando el índice seleccionado
                int idTipoCausa = idTipoCausaList[cboxTipoCausa.SelectedIndex];

                // Crear la entidad con los valores que vas a insertar
                ConsultaMedica consulta = new ConsultaMedica
                {
                    NumExpediente = txtNoExpediente.Text,
                    Fecha = dtpFechaConsulta.Value,
                    Observaciones = txtObservaciones.Text,
                    Diagnostico = txtDiagnostico.Text,
                    Proceso = cboxProceso.Text,
                    IdTipoCausa = idTipoCausa
                };

                // Llamar al método de la capa de negocios para insertar los datos
                bool resultado = consultaMedicaCN.InsertarConsultaMedica(consulta);
                    if (resultado)
                    {
                        RJMessageBox.Show("Consulta médica registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        RJMessageBox.Show("Hubo un error al registrar la consulta médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarExpediente_Click(object sender, EventArgs e)
        {
            string numExpediente = txtNoExpediente.Text.Trim();
            if (string.IsNullOrEmpty(numExpediente))
            {
                RJMessageBox.Show("Por favor, ingrese un número de expediente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet ds = consultaMedicaCN.consultaExpMedico(numExpediente);
            if (ds.Tables["consultarExpMedico"].Rows.Count > 0)
            {
                DataRow row = ds.Tables["consultarExpMedico"].Rows[0];

                txtConstitucionFisica.Text = row["Constitucion_Fisica"]?.ToString() ?? "";
                txtTalla.Text = row["Talla"]?.ToString() ?? "";
                txtPeso.Text = row["Peso"]?.ToString() ?? "";
                txtIMC.Text = row["IMC"]?.ToString() ?? "";
                txtGrado.Text = row["Grado"]?.ToString() ?? "";
                txtFC.Text = row["FC"]?.ToString() ?? "";
                txtFR.Text = row["FR"]?.ToString() ?? "";
                txtPulso.Text = row["Pulso"]?.ToString() ?? "";
                txtTA.Text = row["TA"]?.ToString() ?? "";
                txtTemperatura.Text = row["Temperatura"]?.ToString() ?? "";
                txtCraneo.Text = row["Craneo"]?.ToString() ?? "";
                txtOjos.Text = row["Ojos"]?.ToString() ?? "";
                txtOidos.Text = row["Oidos"]?.ToString() ?? "";
                txtNariz.Text = row["Nariz"]?.ToString() ?? "";
                txtBoca.Text = row["Boca"]?.ToString() ?? "";
                txtCuello.Text = row["Cuello"]?.ToString() ?? "";
                txtTorax.Text = row["Torax"]?.ToString() ?? "";
                txtAbdomen.Text = row["Abdomen"]?.ToString() ?? "";
                txtGenitourinario.Text = row["Genitourinario"]?.ToString() ?? "";
                txtMusculoEsqueletico.Text = row["MusculoEsqueletico"]?.ToString() ?? "";
                txtNeurologico.Text = row["Neurologico"]?.ToString() ?? "";
                txtAlergias.Text = row["Alergias"]?.ToString() ?? "";
                txtSNerviosoCentral.Text = row["SistemaNervioso_Central"]?.ToString() ?? "";
                txtSCardiovascular.Text = row["SistemaCardiovascular"]?.ToString() ?? "";
                txtSRespiratorio.Text = row["SistemaRespiratorio"]?.ToString() ?? "";
                txtSGastrointestinal.Text = row["SistemaGastrointestinal"]?.ToString() ?? "";
                txtSEndocrino.Text = row["SistemaEndocrinico"]?.ToString() ?? "";
                txtSGenitoUrinario.Text = row["SistemaGenitourinario"]?.ToString() ?? "";
                txtSMusculoEsqueletico.Text = row["SistemaMusculoesqueletico"]?.ToString() ?? "";
                txtOrganoSentidos.Text = row["Organo_Sentidos"]?.ToString() ?? "";
                txtGinecoObstetrico.Text = row["Grupo_Sanguineo"]?.ToString() ?? "";
                txtGrupoSanguineo.Text = row["Grupo_Sanguineo"]?.ToString() ?? "";
                txtEstudiosLaboratorio.Text = row["Estudios_Laboratorio"]?.ToString() ?? "";
                txtEstudiosRadiologicos.Text = row["Estudios_Radiologicos"]?.ToString() ?? "";
                txtOtros.Text = row["Otros"]?.ToString() ?? "";
                txtDiagnosticoExp.Text = row["Diagnostico_inicial"]?.ToString() ?? "";
                txtHeredoFamiliar.Text = row["Antecedentes_Heredofamiliares"]?.ToString() ?? "";
                txtCasa.Text = row["Casa"]?.ToString() ?? "";
                txtAlimentacion.Text = row["Alimentacion"]?.ToString() ?? "";
                txtAnimales.Text = row["Animales"]?.ToString() ?? "";
                txtInmunizaciones.Text = row["Inmunizaciones"]?.ToString() ?? "";
                txtToxicomanias.Text = row["Toxicomanias"]?.ToString() ?? "";
                txtTrabajosYActAnteriores.Text = row["Trabajo_actividades_anteriores"]?.ToString() ?? "";
                txtDeportesRecreacion.Text = row["Deportes"]?.ToString() ?? "";
                txtEntornoFamiliar.Text = row["Entorno_Familiar"]?.ToString() ?? "";
                txtEscolaridad.Text = row["Escolaridad"]?.ToString() ?? "";
                rbtnHozpitalizaciones.Checked = row["Hospitalizaciones"] != DBNull.Value && Convert.ToInt32(row["Hospitalizaciones"]) == 1;
                rbtnCirugias.Checked = row["Cirugias"] != DBNull.Value && Convert.ToInt32(row["Cirugias"]) == 1;
                rbtnTransfusiones.Checked = row["Transfusiones"] != DBNull.Value && Convert.ToInt32(row["Transfusiones"]) == 1;

                btnAntecedentes.Visible = true;
                btnNoPatologicos.Visible = true;
                btnPatologicos.Visible = true;
                btnExploracionFisica.Visible = true;
                btnEstudiosParaclinicos.Visible = true;
                btnNuevaNotaMedica.Visible = true;
                labelExp.Visible = true;

                MostrarPanel(pAntecedentes, btnAntecedentes);
            }
            else
            {
                RJMessageBox.Show("No se encontró el expediente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {

        }
    }
}
