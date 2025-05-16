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
        ExpedientesCN expedientesCN = new ExpedientesCN();

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
            panelSin.Paint += new PaintEventHandler(Panel1_Paint);
            panel14.Paint += new PaintEventHandler(Panel1_Paint);
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

        private void CargarCausasConsultaSin()
        {
            // Obtener los datos desde la capa de negocios
            DataSet ds = consultaMedicaCN.consultaCausas();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                cboxCausaConsultaSin.DataSource = ds.Tables[0];
                cboxCausaConsultaSin.DisplayMember = "causas"; // Nombre de la columna en la BD
                cboxCausaConsultaSin.ValueMember = "causas";  // Puede ser un ID si lo deseas  
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

        private void CargarTipoCausaSin(int idCausa)
        {
            // Obtener los datos de tipo de causa basado en el idCausa
            DataSet ds = consultaMedicaCN.consultaTipoCausa(idCausa + 1);

            // Limpiar la lista de idTipoCausa en cada llamada
            idTipoCausaList.Clear();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Limpiar la ComboBox antes de agregar nuevos elementos
                cboxTipoCausaSin.DataSource = null;

                // Añadir los datos a la ComboBox
                cboxTipoCausaSin.DataSource = ds.Tables[0];
                cboxTipoCausaSin.DisplayMember = "tipoCausa"; // Nombre de la columna visible
                cboxTipoCausaSin.ValueMember = "idTipoCausa";  // Valor asociado, que es el idTipoCausa

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
            p.BackColor = Color.FromArgb(247, 167, 62); // Color para el panel
            p.Size = new Size(187, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }

        private void btnMouseEnterPanel(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesDatos.Controls.Add(p);
            p.BackColor = Color.FromArgb(247, 167, 62); // Color para el panel
            p.Size = new Size(248, 5); // Tamaño del panel
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
            pDatosSinExpediente.Visible = false;
            pAntecedentes.Visible = false;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;

            panelAMostrar.Visible = true;
        }


        private void frmNotaMedica_Load(object sender, EventArgs e)
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

            CargarCausasConsulta();
            CargarCausasConsultaSin();

            pDatosGenerales.Visible = true;
            pDatosSinExpediente.Visible = false;
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnPanelNotaConExp.Visible = true;
            btnPanelNotaSinExp.Visible = true;
            btnAntecedentes.Visible = false;
            btnNoPatologicos.Visible = false;
            btnPatologicos.Visible = false;
            btnExploracionFisica.Visible = false;
            btnEstudiosParaclinicos.Visible = false;
            btnRegresar.Visible = false;
            labelExp.Visible = false;
            btnMouseLeave(sender, e);
            MostrarPanel(pDatosGenerales, btnRegresar);
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

        private void btnPanelNotaConExp_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDatosGenerales, btnPanelNotaConExp);
        }

        private void btnPanelNotaSinExp_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDatosSinExpediente, btnPanelNotaSinExp);
        }

        private void cboxCausaConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCausaConsulta.SelectedValue != null)
            {
                int idCausa = cboxCausaConsulta.SelectedIndex;
                CargarTipoCausa(idCausa);
            }
        }

        private void LimpiarCampos()
        {
            txtNumeroNomina.Clear();
            cboxNumExpediente2.SelectedIndex = 0;
            txtNombreEmpleado.Clear();
            txtIdEmpleado.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
            txtPuesto.Clear();
            txtEstadoCivil.Clear();
            txtNSS.Clear();
            txtFechaIngreso.Clear();
            cboxProceso.SelectedIndex = 0;
            cboxCausaConsulta.SelectedIndex = 0;
            cboxTipoCausa.SelectedIndex = 0;
            txtObservaciones.Clear();
            txtDiagnostico.Clear();
            dtpFechaConsulta.Value = DateTime.Now;

            txtNombreEmpleadoSin.Clear();
            txtIdEmpleadoSin.Clear();
            txtDomicilioSin.Clear();
            txtTelefonoSin.Clear();
            txtNoSS.Clear();
            cboxCausaConsultaSin.SelectedIndex = 0;
            cboxTipoCausaSin.SelectedIndex = 0;
            txtObservacionesSin.Clear();
            txtDiagnosticoSin.Clear();
            dtpFechaConsultaSin.Value = DateTime.Now;

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
                if (string.IsNullOrEmpty(txtIdEmpleado.Text) || 
                    string.IsNullOrEmpty(cboxNumExpediente2.Texts) || 
                    string.IsNullOrEmpty(txtObservaciones.Text) || 
                    string.IsNullOrEmpty(txtDiagnostico.Text) || 
                    string.IsNullOrEmpty(cboxProceso.Text) || 
                    cboxTipoCausa.SelectedIndex == -1)
                {
                    RJMessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar si la fecha de emisión no es una fecha futura
                if (dtpFechaConsulta.Value > DateTime.Now)
                {
                    RJMessageBox.Show("Por favor, ingresa una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el idTipoCausa de la lista utilizando el índice seleccionado
                int idTipoCausa = idTipoCausaList[cboxTipoCausa.SelectedIndex];

                // Crear la entidad con los valores que vas a insertar
                ConsultaMedica consulta = new ConsultaMedica
                {
                    IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text),
                    NumExpediente = cboxNumExpediente2.SelectedValue.ToString(),
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
                        LimpiarCampos();
                    }
                    else
                    {
                        RJMessageBox.Show("Hubo un error al registrar la consulta médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabarSin_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos no están vacíos (agrega validaciones previas)
                if (string.IsNullOrEmpty(txtIdEmpleadoSin.Text) || 
                    string.IsNullOrEmpty(txtObservacionesSin.Text) || 
                    string.IsNullOrEmpty(txtDiagnosticoSin.Text) ||
                    string.IsNullOrEmpty(cboxProcesoSin.Text) ||
                    cboxTipoCausaSin.SelectedIndex == -1)
                {
                    RJMessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar si la fecha de emisión no es una fecha futura
                if (dtpFechaConsultaSin.Value > DateTime.Now)
                {
                    RJMessageBox.Show("Por favor, ingresa una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el idTipoCausa de la lista utilizando el índice seleccionado
                int idTipoCausa = idTipoCausaList[cboxTipoCausaSin.SelectedIndex];

                // Crear la entidad con los valores que vas a insertar
                ConsultaMedica consulta = new ConsultaMedica
                {
                    IdEmpleado = Convert.ToInt32(txtIdEmpleadoSin.Text),
                    Fecha = dtpFechaConsultaSin.Value,
                    Observaciones = txtObservacionesSin.Text,
                    Diagnostico = txtDiagnosticoSin.Text,
                    Proceso = cboxProcesoSin.Text,
                    IdTipoCausa = idTipoCausa
                };

                // Llamar al método de la capa de negocios para insertar los datos
                bool resultado = consultaMedicaCN.InsertarConsultaMedicaSin(consulta);
                if (resultado)
                {
                    RJMessageBox.Show("Consulta médica registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    RJMessageBox.Show("Hubo un error al registrar la consulta médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {
            string numExpediente = cboxNumExpediente2.SelectedValue.ToString();
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

                btnPanelNotaSinExp.Visible = false;
                btnPanelNotaConExp.Visible = false;
                btnAntecedentes.Visible = true;
                btnNoPatologicos.Visible = true;
                btnPatologicos.Visible = true;
                btnExploracionFisica.Visible = true;
                btnEstudiosParaclinicos.Visible = true;
                btnRegresar.Visible = true;
                labelExp.Visible = true;

                MostrarPanel(pAntecedentes, btnAntecedentes);
            }
            else
            {
                RJMessageBox.Show("No se encontró el expediente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                txtDiagnosticoExp.Text = GetStringValue(dr["Diagnostico_inicial"]);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelarSin_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string nss = txtNoSS.Text;
            if (string.IsNullOrEmpty(nss))
            {
                RJMessageBox.Show("Por favor, ingrese un número de seguro social.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet ds = consultaMedicaCN.consultaEmpleadoNota(nss);
            if (ds.Tables["consultarEmpleadoNota"].Rows.Count > 0)
            {
                DataRow row = ds.Tables["consultarEmpleadoNota"].Rows[0];

                txtIdEmpleadoSin.Text = row["idEmpleado"]?.ToString() ?? "";
                txtNombreEmpleadoSin.Text = row["nombre_completo"]?.ToString() ?? "";
                txtDomicilioSin.Text = row["domicilio_completo"]?.ToString() ?? "";
                txtTelefonoSin.Text = row["telefono"]?.ToString() ?? "";
            }
            else
            {
                RJMessageBox.Show("No se encontró el empleado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboxCausaConsultaSin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCausaConsultaSin.SelectedValue != null)
            {
                int idCausa = cboxCausaConsultaSin.SelectedIndex;
                CargarTipoCausaSin(idCausa);
            }
        }
    }
}
