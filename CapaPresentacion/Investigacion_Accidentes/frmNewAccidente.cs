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
using System.Windows.Navigation;
using CapaNegocios;
using CapaPresentacion.Restaurar_Y_Respaldar;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace CapaPresentacion.Investigacion_Accidentes
{
    public partial class frmNewAccidente : Form
    {

        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

        EmpleadosCN empleadosCN = new EmpleadosCN();
        AccidentesCN accidentesCN = new AccidentesCN();
        SeccionesCN seccionesCN = new SeccionesCN();
        public frmNewAccidente()
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

            panel4.Paint += new PaintEventHandler(Panel1_Paint);
            panel6.Paint += new PaintEventHandler(Panel1_Paint);
            panel7.Paint += new PaintEventHandler(Panel1_Paint);
            panel14.Paint += new PaintEventHandler(Panel1_Paint);
            panel15.Paint += new PaintEventHandler(Panel1_Paint);
            panel17.Paint += new PaintEventHandler(Panel1_Paint);
            panel18.Paint += new PaintEventHandler(Panel1_Paint);
            panel19.Paint += new PaintEventHandler(Panel1_Paint);
            panel20.Paint += new PaintEventHandler(Panel1_Paint);
            panel26.Paint += new PaintEventHandler(Panel1_Paint);
            panel27.Paint += new PaintEventHandler(Panel1_Paint);
            panel28.Paint += new PaintEventHandler(Panel1_Paint);
            panel29.Paint += new PaintEventHandler(Panel1_Paint);
            panel31.Paint += new PaintEventHandler(Panel1_Paint);
            panel32.Paint += new PaintEventHandler(Panel1_Paint);
            panel33.Paint += new PaintEventHandler(Panel1_Paint);
            panel34.Paint += new PaintEventHandler(Panel1_Paint);

            pDatosGenerales.Visible = true;
            pDetallesAccidente.Visible = false;
            pFactoresSeguridad.Visible = false;
            pControlAcciones.Visible = false;
            pSeguimientoCaso.Visible = false;

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
        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesDatos.Controls.Add(p);
            p.BackColor = Color.FromArgb(91, 194, 255); // Color para el panel
            p.Size = new Size(185, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }
        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesDatos.Controls.Remove(p);
        }
        private void MostrarPanel(Panel panelAMostrar)
        {

            pDatosGenerales.Visible = false;
            pDetallesAccidente.Visible = false;
            pFactoresSeguridad.Visible = false;
            pControlAcciones.Visible = false;
            pSeguimientoCaso.Visible = false;

            panelAMostrar.Visible = true;
        }
        private void btnDatosGenerales_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDatosGenerales);
        }
        private void btnDetallesAccidente_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDetallesAccidente);
        }
        private void btnFactoresSeguridad_Click(object sender, EventArgs e)
        {
            MostrarPanel(pFactoresSeguridad);
        }
        private void btnSeguimientoCaso_Click(object sender, EventArgs e)
        {
            MostrarPanel(pSeguimientoCaso);
        }
        private void btnControlAcciones_Click(object sender, EventArgs e)
        {
            MostrarPanel(pControlAcciones);
        }
        private void frmNewAccidente_Load(object sender, EventArgs e)
        {
            //Combo para la seccion A es decir para guardar IdSeccion_A
            cboxSecciones.SelectedIndexChanged -= cboxSecciones_SelectedIndexChanged;
            cboxSecciones.DataSource = seccionesCN.ConcultaGeneral2().Tables["Secciones"];
            cboxSecciones.DisplayMember = "seccion";
            cboxSecciones.ValueMember = "idseccion";
            cboxSecciones.SelectedIndexChanged += cboxSecciones_SelectedIndexChanged;

            //Combo para la seccion B es decir para guardar IdSeccion_B
            cboxSeccionesB.SelectedIndexChanged -= cboxSeccionesB_SelectedIndexChanged;
            cboxSeccionesB.DataSource = seccionesCN.ConcultaGeneral2().Tables["Secciones"];
            cboxSeccionesB.DisplayMember = "seccion";
            cboxSeccionesB.ValueMember = "idseccion";
            cboxSeccionesB.SelectedIndexChanged += cboxSeccionesB_SelectedIndexChanged;

            cargarRiesgos();
            cargarActosInseguros();
            cargarCondicionesInseguras();

        }
        public void cargarRiesgos()
        {
            //Combo para cargar Riesgos
            cboxRiesgos.SelectedIndexChanged -= cboxRiesgos_SelectedIndexChanged;
            cboxRiesgos.DataSource = accidentesCN.ConcultaRiesgos().Tables["Riesgos"];
            cboxRiesgos.DisplayMember = "riesgo";
            cboxRiesgos.ValueMember = "idriesgo";
            cboxRiesgos.SelectedIndexChanged += cboxRiesgos_SelectedIndexChanged;
        }
        public void cargarActosInseguros()
        {
            //Combo para cargar Actos inseguros
            cboxActoInseguro.SelectedIndexChanged -= cboxActoInseguro_SelectedIndexChanged;
            cboxActoInseguro.DataSource = accidentesCN.ConcultaActosInseguros().Tables["ActosInseguros"];
            cboxActoInseguro.DisplayMember = "acto_inseguro";
            cboxActoInseguro.ValueMember = "idActo_Inseguro";
            cboxActoInseguro.SelectedIndexChanged += cboxActoInseguro_SelectedIndexChanged;
        }
        public void cargarCondicionesInseguras()
        {
            //Combo para cargar Condiciones inseguras
            cboxCondicionesInseguras.SelectedIndexChanged -= cboxCondicionesInseguras_SelectedIndexChanged;
            cboxCondicionesInseguras.DataSource = accidentesCN.ConcultaCondicionesInseguras().Tables["CondicionesInseguras"];
            cboxCondicionesInseguras.DisplayMember = "condicion_insegura";
            cboxCondicionesInseguras.ValueMember = "idCondicion_insegura";
            cboxCondicionesInseguras.SelectedIndexChanged += cboxCondicionesInseguras_SelectedIndexChanged;
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

                    // Calcular antigüedad correctamente
                    //int antiguedad = 0;
                    //antiguedad = fechaIngresoAlPuesto != DateTime.MinValue
                    //    ? fechaActual.Year - fechaIngresoAlPuesto.Year - (fechaActual < fechaIngresoAlPuesto.AddYears(antiguedad) ? 1 : 0)
                    //    : 0;


                    int antiguedadAnios = 0;
                    int antiguedadMeses = 0;

                    if (fechaIngresoAlPuesto != DateTime.MinValue)
                    {
                        DateTime fechaIngreso = fechaIngresoAlPuesto;
                        antiguedadAnios = fechaActual.Year - fechaIngreso.Year;
                        if (fechaActual < fechaIngreso.AddYears(antiguedadAnios))
                        {
                            antiguedadAnios--;
                        }
                        antiguedadMeses = fechaActual.Month - fechaIngreso.Month;

                        if (antiguedadMeses < 0)
                        {
                            antiguedadMeses += 12;
                        }
                    }
                    string antiguedad = $"{antiguedadAnios} años {antiguedadMeses} meses";
                    txtEdad.Text = edad > 0 ? edad.ToString() : "N/A";
                    txtPuesto.Text = dr["puesto"] as string ?? "N/A";
                    //txtAntiguedad.Text = antiguedad > 0 ? antiguedad.ToString() : "N/A";
                    txtAntiguedad.Text = (antiguedadAnios > 0 || antiguedadMeses > 0) ? $"{antiguedadAnios} año(s) {antiguedadMeses} mes(es)" : "N/A";
                    txtNumNominaTestigo.Enabled = true;
                    btnBuscarTestigo.Enabled = true;
                }
                else
                {
                    MostrarNotificacion("Alerta", "Número de nómina no encontrado", Color.FromArgb(255, 152, 0), 3);
                    txtNumeroNomina.Focus();
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Número de Nómina' está vacío, llénelo para continuar", Color.FromArgb(255, 152, 0), 3);
                txtNumeroNomina.Focus();
            }



        }
        private void btnBuscarTestigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumNominaTestigo.Text))
            {
                DataTable t = empleadosCN.ConsultaEmpleadoNumNomina(txtNumNominaTestigo.Text).Tables["ConsultaEmpleado"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];

                    txtNombreTestigo.Text =
                        (dr["nombre"] as string ?? "") + " " +
                        (dr["apellido_paterno"] as string ?? "") + " " +
                        (dr["apellido_materno"] as string ?? "");

                    txtIdEmpleadoTestigo.Text = dr["idEmpleado"].ToString();
                    btnAgregarTestigo.Enabled = true; 
                }
                else
                {
                    MostrarNotificacion("Alerta", "No se encontró un empleado con ese número de nómina", Color.FromArgb(255, 152, 0), 3);
                    txtNombreTestigo.Clear();
                    txtIdEmpleadoTestigo.Clear();
                    btnAgregarTestigo.Enabled = false;
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Número de Nómina del Testigo' está vacío, llénelo para continuar", Color.FromArgb(255, 152, 0), 3);
                txtNumNominaTestigo.Focus();
            }

        }

        private void btnAgregarTestigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdEmpleadoTestigo.Text) && !string.IsNullOrWhiteSpace(txtNombreTestigo.Text))
            {
                int idtestigo = Convert.ToInt32(txtIdEmpleadoTestigo.Text);
                bool testigoingresado = false;

                for (int i = 0; i < dgvTestigos.Rows.Count; i++)
                {
                    int idEmpleadoTestigo = Convert.ToInt32(dgvTestigos.Rows[i].Cells["IdEmpleadoTestigo"].Value);

                    if (idtestigo == idEmpleadoTestigo)
                    {
                        testigoingresado = true;
                        MostrarNotificacion("Alerta", "Este testigo ya ha sido registrado", Color.FromArgb(255, 152, 0), 3);
                        break; 
                    }
                }

                if (!testigoingresado)
                {
                    dgvTestigos.Rows.Add(txtNumNominaTestigo.Text, txtNombreTestigo.Text, txtIdEmpleadoTestigo.Text);

                    txtIdEmpleadoTestigo.Text = "";
                    txtNumNominaTestigo.Text = "";
                    txtNombreTestigo.Text = "";
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "Por favor, busque un testigo antes de agregarlo", Color.FromArgb(255, 152, 0), 3);
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Datos Generales
            int noAccidente = Convert.ToInt32(txtNoAccidente.Text);
            string condicion = txtCondicion.Text;
            DateTime fechaRegistro = dtpFechaRegistro.Value;
            int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            int idPuesto = 1;
            Boolean tiempoExtra = false;
            tiempoExtra = rbtnHrsExtrasSi.Checked ? true : false;
            string totalHrsExtras = txtTotalhrs.Text;
            DateTime DiaDescansoPrevio = dtpDiaDescanso.Value;
            string parteCuerpoAfectada = txtParteCuerpoAfectada.Text;
            string trabajoDesempeñado = txtTrabajoDesempeñado.Text;
            string tipoLesion = txtTipoLesion.Text;
            DateTime fecha_hora_Accidente = dtpFechaAccidente.Value.Date + dtpHoraAccidente.Value.TimeOfDay;
            string testigosJson = ConvertirTestigosAJson(dgvTestigos);

            //Detalle Accidente
            Boolean lesion30Dias = false;
            lesion30Dias = rbtnlesion30DiasSi.Checked ? true : false;
            Boolean lesion12Meses = false;
            lesion12Meses = rbtnlesion12MesesSi.Checked ? true : false;
            string proceso = cboxProceso.Text;
            int idSeccionA = Convert.ToInt32(cboxSecciones.SelectedValue);
            string lugarAccidente = txtLugarAccidente.Text;
            string causanteLesion = txtObjCausanteLesion.Text;
            string equipoProteccionUsado = txtEquipoProteccionUsado.Text;
            string equipoProteccionNecesario = txtEquipoProteccionNecesario.Text;
            string causaAccidente = cboxCausasAccidente.Text;
            string descripcionAccidente = txtDescripcionAccidente.Text;
            Boolean realizoTrabajoAntes = false;
            realizoTrabajoAntes = rbtnRealizoTrabajoAntesSi.Checked ? true : false;
            Boolean trabajoHabitual = false;
            trabajoHabitual = rbtnTrabajoHabitualSi.Checked ? true : false;
            Boolean trabajoProgramado = false;
            trabajoProgramado = rbtnTrabajoProgramadoSi.Checked ? true : false;
            Boolean trabajoNecesario = false;
            trabajoNecesario = rbtnTrabajoNeccesarioSi.Checked ? true : false;
            Boolean trabajoUrgente = false;
            trabajoUrgente = rbtnTrabajoUrgenteSi.Checked ? true : false;
            Boolean danosMateriales = false;
            danosMateriales = rbtnDanosMaterialesSi.Checked ? true : false;
            string equipoDanado = txtEquipoDanado.Text;
            string sustituiblePor = txtSustituiblePor.Text;
            int idSeccionB = Convert.ToInt32(cboxSeccionesB.SelectedValue);


            //Factores de Seguridad
            Boolean existenITRs = false;
            existenITRs = rbtnExistenItrsSi.Checked ? true : false;
            Boolean equipoAdecuado = false;
            equipoAdecuado = rbtnEquipoAdecuadoSi.Checked ? true : false;
            Boolean conociaTrabajo = false;
            conociaTrabajo = rbtnConociaTrabajoSi.Checked ? true : false;
            Boolean existiaSupervicion = false;
            existiaSupervicion = rbtnExistiaSupervicionSi.Checked ? true : false;
            string riesgosJson = ConvertirRiesgosAJson(dgvRiesgos);
            //MessageBox.Show(riesgosJson);
            string actosInsegurosJson = ConvertirActosInsegurosAJson(dgvActoInseguro);
            //MessageBox.Show(actosInsegurosJson);
            string condicionesInsegurasJson = ConvertirCondicionesInsegurasAJson(dgvCondicionInsegura);
            //MessageBox.Show(condicionesInsegurasJson);

            //Seguimiento del caso
            string empleadosConocimientoJson = ConvertirEnpleadosConocimientoAJson(dgvEmpleadosConocimiento);
            string empleadosInvolucradosJson = ConvertirEnpleadosInvolucradosAJson(dgvEmpleadosInvolucrados);
            Boolean continuaTrabajando = false;
            continuaTrabajando = rbtnContinuaTrabajando.Checked ? true : false;
            Boolean enviadoDomicilio = false;
            enviadoDomicilio = rbtnEnviadoDomicilio.Checked ? true : false;
            Boolean enviadoAtencionMedica= false;
            enviadoAtencionMedica = rbtnEnviadoAtencionMedica.Checked ? true : false;
            string otro = txtOtro.Text;
            string diagnosticoFinal = txtDiagnosticoFinal.Text;
            string tratamiento = txtTratamiento.Text;
            string incapacidad = txtIncapacidad.Text;

            //Control de Acciones
            string accionesCorrectivasPropuestas = txtAccionesCorrectivasProp.Text;
            string quienCorrectivasPropuesta = txtAccionesCorrectivasProp.Text;
            string cuandoCorrectivasPropuestas = txtAccionesCorrectivasProp.Text;
            string accionesPreventivasPropuestas = txtAccionesPreventivasProp.Text;
            string quienPreventivoPropuesto = txtQuienPreventivas.Text;
            string cuandoPreventivasPropuestas = txtCuandoPreventivas.Text;
            string seguimiento = txtSeguimiento.Text;
            DateTime fecha_Hora_Seguimiento = dtpFechaSeguimiento.Value.Date + dtpHoraSeguimiento.Value.TimeOfDay;
            int empleadoSeguimiento = Convert.ToInt32(txtidNombreSST.Text);
            DateTime fecha_Hora_recepcion = dtpFechaRecepcion.Value.Date + dtpHoraRecepcion.Value.TimeOfDay;
            


            int registro = accidentesCN.InsertarAccidente(noAccidente, condicion, fechaRegistro, tiempoExtra, totalHrsExtras, DiaDescansoPrevio, parteCuerpoAfectada, trabajoDesempeñado, tipoLesion, fecha_hora_Accidente,
                lesion30Dias, lesion12Meses, proceso, idSeccionA, lugarAccidente, causanteLesion, equipoProteccionUsado, equipoProteccionNecesario, causaAccidente, descripcionAccidente, realizoTrabajoAntes, trabajoHabitual, trabajoProgramado, trabajoNecesario, trabajoUrgente, danosMateriales, equipoDanado, sustituiblePor, idSeccionB,
                existenITRs, equipoAdecuado, conociaTrabajo, existiaSupervicion, riesgosJson, actosInsegurosJson, condicionesInsegurasJson,
                empleadosConocimientoJson, empleadosInvolucradosJson, continuaTrabajando, enviadoDomicilio, enviadoAtencionMedica, otro, diagnosticoFinal, tratamiento, incapacidad,
                accionesCorrectivasPropuestas, quienCorrectivasPropuesta, cuandoCorrectivasPropuestas, accionesPreventivasPropuestas, quienPreventivoPropuesto, cuandoPreventivasPropuestas,seguimiento, fecha_Hora_Seguimiento, empleadoSeguimiento, fecha_Hora_recepcion,
                idEmpleado, idPuesto, testigosJson);

            if (registro > 0)
            {
                MessageBox.Show("No se pudo insertar el registro.");
            }
            else
            {                
                MessageBox.Show("Inserción exitosa. Se agregó el registro correctamente.");
            }

        }

        public string ConvertirTestigosAJson(DataGridView dgvTestigos)
        {
            List<Dictionary<string, object>> testigosList = new List<Dictionary<string, object>>();

            for (int i = 0; i < dgvTestigos.Rows.Count; i++)
            {
                if (dgvTestigos.Rows[i].Cells["IdEmpleadoTestigo"].Value != null)
                {
                    Dictionary<string, object> testigo = new Dictionary<string, object>
            {
                { "IdTestigo", Convert.ToInt32(dgvTestigos.Rows[i].Cells["IdEmpleadoTestigo"].Value) }
            };
                    testigosList.Add(testigo);
                }
            }

            return JsonConvert.SerializeObject(testigosList);  // Convertir la lista a JSON
        }
        public string ConvertirRiesgosAJson(DataGridView dgvRiesgos)
        {
            List<Dictionary<string, object>> riesgosList = new List<Dictionary<string, object>>();

            for (int i = 0; i < dgvRiesgos.Rows.Count; i++)
            {
                if (dgvRiesgos.Rows[i].Cells["idRiesgo"].Value != null)
                {
                    Dictionary<string, object> riesgos = new Dictionary<string, object>
            {
                { "IdRiesgo", Convert.ToInt32(dgvRiesgos.Rows[i].Cells["idRiesgo"].Value) }
            };
                    riesgosList.Add(riesgos);
                }
            }

            return JsonConvert.SerializeObject(riesgosList);  // Convertir la lista a JSON
        }
        public string ConvertirActosInsegurosAJson(DataGridView dgvActoInseguro)
        {
            List<Dictionary<string, object>> actosInsegurosList = new List<Dictionary<string, object>>();

            for (int i = 0; i < dgvActoInseguro.Rows.Count; i++)
            {
                if (dgvActoInseguro.Rows[i].Cells["idActoInseguro"].Value != null)
                {
                    Dictionary<string, object> actosInseguros = new Dictionary<string, object>
                    {
                        { "IdActoInseguro", Convert.ToInt32(dgvActoInseguro.Rows[i].Cells["idActoInseguro"].Value) }
                    };
                    actosInsegurosList.Add(actosInseguros);
                }
            }

            return JsonConvert.SerializeObject(actosInsegurosList);  // Convertir la lista a JSON
        }
        public string ConvertirCondicionesInsegurasAJson(DataGridView dgvCondicionesInseguras)
        {
            List<Dictionary<string, object>> condicionesInsegurasList = new List<Dictionary<string, object>>();

            for (int i = 0; i < dgvCondicionesInseguras.Rows.Count; i++)
            {
                if (dgvCondicionesInseguras.Rows[i].Cells["idCondicionInsegura"].Value != null)
                {
                    Dictionary<string, object> condicionesInseguras = new Dictionary<string, object>
                    {
                        { "IdCondicionesInseguras", Convert.ToInt32(dgvCondicionesInseguras.Rows[i].Cells["idCondicionInsegura"].Value) }
                    };
                    condicionesInsegurasList.Add(condicionesInseguras);
                }
            }

            return JsonConvert.SerializeObject(condicionesInsegurasList);  // Convertir la lista a JSON
        }
        public string ConvertirEnpleadosInvolucradosAJson(DataGridView dgvEmpleadosInvolucrados)
        {
            List<Dictionary<string, object>> empleadosInvolucradosList = new List<Dictionary<string, object>>();

            for(int i = 0; i < dgvEmpleadosInvolucrados.Rows.Count; i++)
            {
                if (dgvEmpleadosInvolucrados.Rows[i].Cells["IdEmpleadoInvolucrado"].Value != null)
                {
                    Dictionary<string, object> empleadosInvolucrados = new Dictionary<string, object>
                    {
                        { "IdEmpleadoInvolucrado", Convert.ToInt32(dgvEmpleadosInvolucrados.Rows[i].Cells["IdEmpleadoInvolucrado"].Value) }
                    };
                    empleadosInvolucradosList.Add(empleadosInvolucrados);
                }
            }
            return JsonConvert.SerializeObject(empleadosInvolucradosList);
        }
        public string ConvertirEnpleadosConocimientoAJson(DataGridView dgvEmpleadosConocimiento)
        {
            List<Dictionary<string, object>> empleadosConocimientoList = new List<Dictionary<string, object>>();

            for (int i = 0; i < dgvEmpleadosConocimiento.Rows.Count; i++)
            {
                if (dgvEmpleadosConocimiento.Rows[i].Cells["idEmpleadoConocimiento"].Value != null)
                {
                    Dictionary<string, object> empleadosConocimiento = new Dictionary<string, object>
                    {
                        { "IdEmpleadoConocimiento", Convert.ToInt32(dgvEmpleadosConocimiento.Rows[i].Cells["idEmpleadoConocimiento"].Value) }
                    };
                    empleadosConocimientoList.Add(empleadosConocimiento);
                }
            }
            return JsonConvert.SerializeObject(empleadosConocimientoList);
        }
        private void cboxSecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxSeccionesB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxProceso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxRiesgos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxRiesgos.Text == "Otro")
            {
                txtOtroRiesgo.Visible = true;
                btnGrabarRiesgo.Visible = true;
                btnAgregarRiesgo.Visible = false;
            }
            if (cboxRiesgos.Text != "Otro")
            {
                txtOtroRiesgo.Visible = false;
                txtOtroRiesgo.Text = "";
                btnGrabarRiesgo.Visible = false;
                btnAgregarRiesgo.Visible = true;
            }
        }

        private void cboxActoInseguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxActoInseguro.Text == "Otro")
            {
                txtOtroActoInseguro.Visible = true;
                btnGrabarActoInseguro.Visible = true;
                btnAgregarActoInseguro.Visible = false;
            }
            if (cboxActoInseguro.Text != "Otro")
            {
                txtOtroActoInseguro.Visible = false;
                txtOtroActoInseguro.Text = "";
                btnGrabarActoInseguro.Visible = false;
                btnAgregarActoInseguro.Visible = true;
            }
        }

        private void cboxCondicionesInseguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCondicionesInseguras.Text == "Otra")
            {
                txtOtraCondicion.Visible = true;
                btnAgregarCondicion.Visible = false;
                btnGrabarCondicionInsegura.Visible = true;
            }
            if (cboxCondicionesInseguras.Text != "Otra")
            {
                txtOtraCondicion.Visible = false;
                txtOtraCondicion.Text = "";
                btnGrabarCondicionInsegura.Visible = false;
                btnAgregarCondicion.Visible = true;
            }
        }

        private void btnGrabarRiesgo_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtOtroRiesgo.Text))
            {
                bool riesgoExistente = accidentesCN.VerificarRiesgoExiste(txtOtroRiesgo.Text);

                if (riesgoExistente)
                {
                    MostrarNotificacion("Alerta", "Este riesgo ya está registrado", Color.FromArgb(255, 152, 0), 3);
                }
                else
                {
                    accidentesCN.InsertaNuevoRiesgo(txtOtroRiesgo.Text);

                    txtOtroRiesgo.Text = "";
                    txtOtroRiesgo.Visible = false;

                    btnAgregarRiesgo.Visible = true;
                    btnGrabarRiesgo.Visible = false;

                    cargarRiesgos();
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Otro Riesgo' está vacío, por favor ingrese un riesgo", Color.FromArgb(255, 152, 0), 3);
            }


        }

        private void btnAgregarRiesgo_Click(object sender, EventArgs e)
        {

            if (cboxRiesgos.SelectedValue != null && !string.IsNullOrWhiteSpace(cboxRiesgos.SelectedValue.ToString()))
            {
                int idriesgoSeleccionado = Convert.ToInt32(cboxRiesgos.SelectedValue);
                bool riesgoIngresado = false;
                int idriesgo = 0;

                for (int i = 0; i < dgvRiesgos.Rows.Count; i++)
                {
                    idriesgo = Convert.ToInt32(dgvRiesgos.Rows[i].Cells["idRiesgo"].Value);
                    if (idriesgo == idriesgoSeleccionado)
                    {
                        riesgoIngresado = true;
                        MostrarNotificacion("Alerta", "Este riesgo ya ha sido registrado", Color.FromArgb(255, 152, 0), 3);
                        break;
                    }
                }

                if (!riesgoIngresado)
                {
                    dgvRiesgos.Rows.Add(cboxRiesgos.SelectedValue, cboxRiesgos.Text);
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "Por favor, seleccione un riesgo válido", Color.FromArgb(255, 152, 0), 3);
            }



        }

        private void btnAgregarActoInseguro_Click(object sender, EventArgs e)
        {
            if (cboxActoInseguro.SelectedValue != null && !string.IsNullOrWhiteSpace(cboxActoInseguro.SelectedValue.ToString()))
            {
                int idActoInseguroSeleccionado = Convert.ToInt32(cboxActoInseguro.SelectedValue);
                bool actoInseguroIngresado = false;
                int idActoInseguro = 0;

                for (int i = 0; i < dgvActoInseguro.Rows.Count - 1; i++)
                {
                    idActoInseguro = Convert.ToInt32(dgvActoInseguro.Rows[i].Cells["idActoInseguro"].Value);
                    if (idActoInseguro == idActoInseguroSeleccionado)
                    {
                        actoInseguroIngresado = true;
                        MostrarNotificacion("Alerta", "Este Acto Inseguro ya ha sido Ingresado", Color.FromArgb(255, 152, 0), 3);
                        break;
                    }
                }
                if (!actoInseguroIngresado)
                {
                    dgvActoInseguro.Rows.Add(cboxActoInseguro.SelectedValue, cboxActoInseguro.Text);
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "Por favor, seleccione un Acto Inseguro válido", Color.FromArgb(255, 152, 0), 3);
            }

        }

        private void btnGrabarActoInseguro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOtroActoInseguro.Text))
            {
                bool actoInseguroExistente = accidentesCN.VerificarActoInseguroExiste(txtOtroActoInseguro.Text);

                if (actoInseguroExistente)
                {
                    MostrarNotificacion("Alerta", "Este acto inseguro ya está registrado", Color.FromArgb(255, 152, 0), 3);
                }
                else
                {
                    accidentesCN.InsertaNuevoActoInseguro(txtOtroActoInseguro.Text);

                    txtOtroActoInseguro.Text = "";
                    txtOtroActoInseguro.Visible = false;

                    btnAgregarActoInseguro.Visible = true;
                    btnGrabar.Visible = false;

                    cargarActosInseguros();
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Otro Acto Inseguro' está vacío, por favor ingrese un acto inseguro", Color.FromArgb(255, 152, 0), 3);
            }

        }

        private void btnAgregarCondicion_Click(object sender, EventArgs e)
        {
            if (cboxCondicionesInseguras.SelectedValue != null && !string.IsNullOrWhiteSpace(cboxCondicionesInseguras.SelectedValue.ToString()))
            {
                int idCondicionInseguraSeleccionada = Convert.ToInt32(cboxCondicionesInseguras.SelectedValue);
                bool condicionInseguraIngresada = false;
                int idCondicionInsegura = 0;

                for (int i = 0; i < dgvCondicionInsegura.Rows.Count - 1; i++)
                {
                    idCondicionInsegura = Convert.ToInt32(dgvCondicionInsegura.Rows[i].Cells["idCondicionInsegura"].Value);
                    if (idCondicionInsegura == idCondicionInseguraSeleccionada)
                    {
                        condicionInseguraIngresada = true;
                        MostrarNotificacion("Alerta", "Esta Condición Insegura ya ha sido Ingresada", Color.FromArgb(255, 152, 0), 3);
                        break; 
                    }
                }

                if (!condicionInseguraIngresada)
                {
                    dgvCondicionInsegura.Rows.Add(cboxCondicionesInseguras.SelectedValue, cboxCondicionesInseguras.Text);
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "Por favor, seleccione una Condición Insegura válida", Color.FromArgb(255, 152, 0), 3);
            }

        }

        private void btnGrabarCondicionInsegura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOtraCondicion.Text))
            {
                bool condicionInseguraExistente = accidentesCN.VerificarCondicionInseguraExiste(txtOtraCondicion.Text);

                if (condicionInseguraExistente)
                {
                    MostrarNotificacion("Alerta", "Esta condición insegura ya está registrada", Color.FromArgb(255, 152, 0), 3);
                }
                else
                {
                    accidentesCN.InsertaNuevaCondicionInsegura(txtOtraCondicion.Text);

                    txtOtraCondicion.Text = "";
                    txtOtraCondicion.Visible = false;

                    btnAgregarCondicion.Visible = true;
                    btnGrabarCondicionInsegura.Visible = false;

                    cargarCondicionesInseguras();
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Otra Condición Insegura' está vacío, por favor ingrese una condición", Color.FromArgb(255, 152, 0), 3);
            }

        }

        private void btnBuscarEmpleadoConocimiento_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumNominaEmpleadoConocimiento.Text))
            {
                DataTable t = empleadosCN.ConsultaEmpleadoNumNomina(txtNumNominaEmpleadoConocimiento.Text).Tables["ConsultaEmpleado"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];

                    txtNombreEmpleadoConocimiento.Text =
                        (dr["nombre"] as string ?? "") + " " +
                        (dr["apellido_paterno"] as string ?? "") + " " +
                        (dr["apellido_materno"] as string ?? "");

                    txtIdEmpleadoConocimiento.Text = dr["idEmpleado"] != DBNull.Value ? dr["idEmpleado"].ToString() : "N/A";

                    btnAgregarEmpleadoConocimiento.Enabled = true;
                }
                else
                {
                    MostrarNotificacion("Alerta", "No se encontró un empleado con ese número de nómina", Color.FromArgb(255, 152, 0), 3);
                    txtNombreEmpleadoConocimiento.Clear();
                    txtIdEmpleadoConocimiento.Clear();
                    btnAgregarEmpleadoConocimiento.Enabled = false;
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Número de Nómina' está vacío, llénelo para continuar", Color.FromArgb(255, 152, 0), 3);
                txtNumNominaEmpleadoConocimiento.Focus();
            }

        }

        private void btnAgregarEmpleadoConocimiento_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdEmpleadoConocimiento.Text) && !string.IsNullOrWhiteSpace(txtNombreEmpleadoConocimiento.Text))
            {
                int idEmpleadoConocimiento = Convert.ToInt32(txtIdEmpleadoConocimiento.Text);
                bool testigoIngresado = false;

                for (int i = 0; i < dgvEmpleadosConocimiento.Rows.Count; i++)
                {
                    int idEnDataGrid = Convert.ToInt32(dgvEmpleadosConocimiento.Rows[i].Cells["idEmpleadoConocimiento"].Value);
                    if (idEmpleadoConocimiento == idEnDataGrid)
                    {
                        testigoIngresado = true;
                        MostrarNotificacion("Alerta", "Este empleado que tomo conocimiento ya ha sido registrado", Color.FromArgb(255, 152, 0), 3);
                        break;
                    }
                }

                if (!testigoIngresado)
                {
                    dgvEmpleadosConocimiento.Rows.Add(txtNumNominaEmpleadoConocimiento.Text, txtNombreEmpleadoConocimiento.Text, txtIdEmpleadoConocimiento.Text);

                    txtIdEmpleadoConocimiento.Text = "";
                    txtNombreEmpleadoConocimiento.Text = "";
                    txtNumNominaEmpleadoConocimiento.Text = "";
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "Por favor, busque un empleado antes de agregarlo", Color.FromArgb(255, 152, 0), 3);
            }

        }

        private void btnBuscarEmpleadoInvolucrado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumNominaEmpleadoInvolucrado.Text))
            {
                DataTable t = empleadosCN.ConsultaEmpleadoNumNomina(txtNumNominaEmpleadoInvolucrado.Text).Tables["ConsultaEmpleado"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];

                    txtNombreEmpleadoInvolucrado.Text =
                        (dr["nombre"] != DBNull.Value ? dr["nombre"].ToString() : "") + " " +
                        (dr["apellido_paterno"] != DBNull.Value ? dr["apellido_paterno"].ToString() : "") + " " +
                        (dr["apellido_materno"] != DBNull.Value ? dr["apellido_materno"].ToString() : "");

                    txtIdEmpleadoInvolucrado.Text = dr["idEmpleado"] != DBNull.Value ? dr["idEmpleado"].ToString() : "N/A";
                }
                else
                {
                    MostrarNotificacion("Alerta", "No se encontró un empleado con ese número de nómina", Color.FromArgb(255, 152, 0), 3);
                    txtNombreEmpleadoInvolucrado.Clear();
                    txtIdEmpleadoInvolucrado.Clear();
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Número de Nómina' está vacío, llénelo para continuar", Color.FromArgb(255, 152, 0), 3);
                txtNumNominaEmpleadoInvolucrado.Focus();
            }

        }

        private void btnAgregarEmpleadoInvolucrado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdEmpleadoInvolucrado.Text) && !string.IsNullOrWhiteSpace(txtNombreEmpleadoInvolucrado.Text))
            {
                int idEmpleadoInvolucrado = Convert.ToInt32(txtIdEmpleadoInvolucrado.Text);
                bool testigoIngresado = false;

                for (int i = 0; i < dgvEmpleadosInvolucrados.Rows.Count; i++)
                {
                    int idEnDataGrid = Convert.ToInt32(dgvEmpleadosInvolucrados.Rows[i].Cells["IdEmpleadoInvolucrado"].Value);
                    if (idEmpleadoInvolucrado == idEnDataGrid)
                    {
                        testigoIngresado = true;
                        MostrarNotificacion("Alerta", "Este empleado ya ha sido registrado como involucrado", Color.FromArgb(255, 152, 0), 3);
                        break;
                    }
                }

                if (!testigoIngresado)
                {
                    dgvEmpleadosInvolucrados.Rows.Add(txtNumNominaEmpleadoInvolucrado.Text, txtNombreEmpleadoInvolucrado.Text, txtIdEmpleadoInvolucrado.Text);

                    txtIdEmpleadoInvolucrado.Text = "";
                    txtNombreEmpleadoInvolucrado.Text = "";
                    txtNumNominaEmpleadoInvolucrado.Text = "";
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "Por favor, busque un empleado antes de agregarlo como involucrado", Color.FromArgb(255, 152, 0), 3);
            }

        }

        private void rbtnOtro_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Visible = rbtnOtro.Checked;
            if (!rbtnOtro.Checked)
            {
                txtOtro.Text = ""; // Se limpia solo cuando el RadioButton se desmarca
            }
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtOtro.Text);
        }
        public void ValidacionNumeros(KeyPressEventArgs e)
        {
            // Permitir números del 0 al 9 y la tecla de retroceso
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MostrarNotificacion("Alerta", "Solo se pueden introducir números", Color.FromArgb(255, 152, 0), 3);
                e.Handled = true; // Bloquea la entrada de caracteres no permitidos
            }
        }

        
        public void MostrarNotificacion(string titulo, string mensaje, Color color, int icono)
        {
            frmNotificacion c = new frmNotificacion("Bio-Pappel", titulo, mensaje, color, icono);
            c.ShowDialog();
        }

        private void txtNoAccidente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);
        }

        private void txtTotalhrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);
        }

        private void btnBuscarEmpleadoSST_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumNomminaSST.Text))
            {
                DataTable t = empleadosCN.ConsultaEmpleadoNumNomina(txtNumNomminaSST.Text).Tables["ConsultaEmpleado"];

                if (t.Rows.Count > 0)
                {
                    DataRow dr = t.Rows[0];

                    txtNombreSST.Text =
                        (dr["nombre"] as string ?? "") + " " +
                        (dr["apellido_paterno"] as string ?? "") + " " +
                        (dr["apellido_materno"] as string ?? "");

                    txtidNombreSST.Text = dr["idEmpleado"] != DBNull.Value ? dr["idEmpleado"].ToString() : "N/A";

                }
                else
                {
                    MostrarNotificacion("Alerta", "No se encontró un empleado con ese número de nómina", Color.FromArgb(255, 152, 0), 3);
                    txtNombreSST.Clear();
                    txtidNombreSST.Clear();
                }
            }
            else
            {
                MostrarNotificacion("Alerta", "El campo 'Número de Nómina' está vacío, llénelo para continuar", Color.FromArgb(255, 152, 0), 3);
                txtNumNomminaSST.Focus();
            }
        }

        private void rbtnHrsExtrasSi_CheckedChanged(object sender, EventArgs e)
        {
            bool tiempoExtra = rbtnHrsExtrasSi.Checked;

            if (tiempoExtra)
            {
                txtTotalhrs.Enabled = true;
                txtTotalhrs.Clear();
            }
            else
            {
                txtTotalhrs.Text = "8";
                txtTotalhrs.Enabled = false;
            }
        }
    }
}
