using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Restaurar_Y_Respaldar;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace CapaPresentacion.Investigacion_Accidentes
{
    public partial class frmNewAccidente : Form
    {

        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

        EmpleadosCN empleadosCN = new EmpleadosCN();
        AccidentesCN accidentesCN = new AccidentesCN();
        SeccionesCN seccionesCN = new SeccionesCN();

        private readonly Dictionary<Button, List<TextBox>> camposPorBoton = new Dictionary<Button, List<TextBox>>();

        public frmNewAccidente()
        {
            InitializeComponent();
            //pSeguimientoCaso.AutoScrollPosition = new Point(0, 0);

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
            panel5.Paint += new PaintEventHandler(Panel1_Paint);
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
                Pen pen = new Pen(Color.FromArgb(6, 103, 105), 5); // Cambia el color aquí
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
        private void btnMouseEnter(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pSeccionesDatos.Controls.Add(p);
            p.BackColor = Color.FromArgb(247, 167, 62); // Color para el panel
            p.Size = new Size(btn.Width, 5); // Tamaño del panel
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); // Posición debajo del botón
        }
        // Método para eliminar el panel cuando el mouse sale del área del botón
        private void btnMouseLeave(Object sender, EventArgs e)
        {
            pSeccionesDatos.Controls.Remove(p);
        }


        private Dictionary<Button, bool> panelVisitado = new Dictionary<Button, bool>();

        // Variable para almacenar el panel y botón actual
        private Panel panelActual = null;
        private Button botonActual = null;

        private void ActualizarColorBoton(Button boton, Control parentControl)          
        {
            // Si el panel nunca ha sido visitado, mantener el color original
            if (!panelVisitado.ContainsKey(boton)) return;

            bool hayCamposVacíos = HayTextBoxVacios(parentControl);

            // Cambiar propiedad image del boton 
            boton.Image = hayCamposVacíos ? Properties.Resources.senal_de_alerta : null;
            boton.TextImageRelation = TextImageRelation.TextBeforeImage;
        }
        private List<string> excepcionesTextBox = new List<string>
        {
            "txtNumNominaTestigo", "txtNombreTestigo", "txtIdEmpleadoTestigo","txtOtroRiesgo","txtOtroActoInseguro","txtOtraCondicion"// Agrega aquí los nombres que quieras excluir
        };

        private bool HayTextBoxVacios(Control parentControl)
        {
            foreach (Control ctrl in parentControl.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    if (excepcionesTextBox.Contains(txt.Name)) continue; // Ignorar excepciones

                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        Console.WriteLine("Campo vacío detectado: " + txt.Name);
                        return true;
                    }
                        
                }
                else if (ctrl.HasChildren)
                {
                    if (HayTextBoxVacios(ctrl))
                        return true;
                }
            }
            return false;
        }

        // Método recursivo para buscar TextBox dentro de cualquier control (incluidos paneles anidados)
        //private bool HayTextBoxVacios(Control parentControl)
        //{
        //    foreach (Control ctrl in parentControl.Controls)
        //    {
        //        if (ctrl is TextBox txt)
        //        {
        //            if (string.IsNullOrWhiteSpace(txt.Text)) // Si está vacío o solo tiene espacios
        //                return true;
        //        }
        //        else if (ctrl.HasChildren) // Si el control tiene hijos, revisamos dentro de él
        //        {
        //            if (HayTextBoxVacios(ctrl))
        //                return true;
        //        }
        //    }
        //    return false; // No se encontraron campos vacíos
        //}

        private void MostrarPanel(Panel panelAMostrar, Button botonPresionado)
        {
            // Si hay un panel activo, verificar si tiene campos vacíos antes de cambiar
            if (panelActual != null && botonActual != null && panelActual != panelAMostrar)
            {
                ActualizarColorBoton(botonActual, panelActual);
            }

            // Marcar este botón como visitado
            if (!panelVisitado.ContainsKey(botonPresionado))
            {
                panelVisitado[botonPresionado] = true;
            }

            // Ocultar todos los paneles y mostrar el deseado
            pDatosGenerales.Visible = false;
            pDetallesAccidente.Visible = false;
            pFactoresSeguridad.Visible = false;
            pControlAcciones.Visible = false;
            pSeguimientoCaso.Visible = false;

            panelAMostrar.Visible = true;
            panelActual = panelAMostrar;
            botonActual = botonPresionado;
        }

        private void btnDatosGenerales_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDatosGenerales, btnDatosGenerales);
        }

        private void btnDetallesAccidente_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDetallesAccidente, btnDetallesAccidente);
        }

        private void btnFactoresSeguridad_Click(object sender, EventArgs e)
        {
            MostrarPanel(pFactoresSeguridad, btnFactoresSeguridad);
        }

        private void btnSeguimientoCaso_Click(object sender, EventArgs e)
        {
            MostrarPanel(pSeguimientoCaso, btnSeguimientoCaso);
        }

        private void btnControlAcciones_Click(object sender, EventArgs e)
        {
            MostrarPanel(pControlAcciones, btnControlAcciones);
        }

        private void frmNewAccidente_Load(object sender, EventArgs e)
        {
            // Inicializar el diccionario con los botones
            panelVisitado[btnDatosGenerales] = false;
            panelVisitado[btnDetallesAccidente] = false;
            panelVisitado[btnFactoresSeguridad] = false;
            panelVisitado[btnSeguimientoCaso] = false;
            panelVisitado[btnControlAcciones] = false;



            //Código para cargar el Combo de la sección A
            cboxSeccionA.SelectedIndexChanged -= cboxSecciones_SelectedIndexChanged;
            cboxSeccionA.DataSource = seccionesCN.ConcultaGeneral2().Tables["Secciones"];
            cboxSeccionA.DisplayMember = "seccion";
            cboxSeccionA.ValueMember = "idseccion";
            if (cboxSeccionA.Items.Count > 0)
            {
                cboxSeccionA.SelectedIndex = 0;
            }
            cboxSeccionA.SelectedIndexChanged += cboxSecciones_SelectedIndexChanged;

            //Código para cargar el Combo de la sección A
            cboxSeccionB.SelectedIndexChanged -= cboxSeccionesB_SelectedIndexChanged;
            cboxSeccionB.DataSource = seccionesCN.ConcultaGeneral2().Tables["Secciones"];
            cboxSeccionB.DisplayMember = "seccion";
            cboxSeccionB.ValueMember = "idseccion";
            if (cboxSeccionB.Items.Count > 0)
            {
                cboxSeccionB.SelectedIndex = 0;
            }
            cboxSeccionB.SelectedIndexChanged += cboxSeccionesB_SelectedIndexChanged;

            cargarRiesgos();
            cargarActosInseguros();
            cargarCondicionesInseguras();

            panelActual = pDatosGenerales;
            botonActual = btnDatosGenerales;

        }

        public void cargarRiesgos()
        {
            //Combo para cargar Riesgos
            cboxRiesgos.SelectedIndexChanged -= cboxRiesgos_SelectedIndexChanged;
            cboxRiesgos.DataSource = accidentesCN.ConcultaRiesgos().Tables["Riesgos"];
            cboxRiesgos.DisplayMember = "riesgo";
            cboxRiesgos.ValueMember = "idriesgo";
            if (cboxRiesgos.Items.Count > 0)
            {
                cboxRiesgos.SelectedIndex = 0;
            }
            cboxRiesgos.SelectedIndexChanged += cboxRiesgos_SelectedIndexChanged;
        }
        public void cargarActosInseguros()
        {
            //Combo para cargar Actos inseguros
            cboxActoInseguro.SelectedIndexChanged -= cboxActoInseguro_SelectedIndexChanged;
            cboxActoInseguro.DataSource = accidentesCN.ConcultaActosInseguros().Tables["ActosInseguros"];
            cboxActoInseguro.DisplayMember = "acto_inseguro";
            cboxActoInseguro.ValueMember = "idActo_Inseguro";
            if (cboxActoInseguro.Items.Count > 0)
            {
                cboxActoInseguro.SelectedIndex = 0;
            }
            cboxActoInseguro.SelectedIndexChanged += cboxActoInseguro_SelectedIndexChanged;
        }
        public void cargarCondicionesInseguras()
        {
            //Combo para cargar Condiciones inseguras
            cboxCondicionesInseguras.SelectedIndexChanged -= cboxCondicionesInseguras_SelectedIndexChanged;
            cboxCondicionesInseguras.DataSource = accidentesCN.ConcultaCondicionesInseguras().Tables["CondicionesInseguras"];
            cboxCondicionesInseguras.DisplayMember = "condicion_insegura";
            cboxCondicionesInseguras.ValueMember = "idCondicion_insegura";
            if (cboxCondicionesInseguras.Items.Count > 0)
            {
                cboxCondicionesInseguras.SelectedIndex = 0;
            }
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
                        ? fechaActual.Year - fechaNacimiento.Year - (fechaActual < fechaNacimiento.AddYears(edad) ? 1 : 0): 0;

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
                    txtAntiguedad.Text = (antiguedadAnios > 0 || antiguedadMeses > 0) ? $"{antiguedadAnios} año(s) {antiguedadMeses} mes(es)" : "0 meses";
                    
                    txtNumNominaTestigo.Enabled = true;
                    btnBuscarTestigo.Enabled = true;
                }
                else
                {
                    var result = RJMessageBox.Show(" Número de nómina no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNumeroNomina.Focus();
                    txtNombreEmpleado.Clear();
                    txtIdEmpleado.Clear();
                }
            }
            else
            {
                var result = RJMessageBox.Show(" Por favor ingrese un Número de Nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    var result = RJMessageBox.Show("No se encontró ningun empleado con ese número de nómina ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreTestigo.Text = "";
                    txtIdEmpleadoTestigo.Clear();
                    btnAgregarTestigo.Enabled = false;
                }
            }
            else
            {
                var result = RJMessageBox.Show(" Por favor, ingrese el Número de Nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var result = RJMessageBox.Show(" Este testigo ya ha sido registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                var result = RJMessageBox.Show(" Por favor, busque un testigo antes de agregarlo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // Validaciones previas antes de convertir a entero
            if (string.IsNullOrWhiteSpace(txtNoAccidente.Text) ||
                string.IsNullOrWhiteSpace(txtIdEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtidNombreSST.Text))
            {
                var result = RJMessageBox.Show(" Existen campos vacíos, llénelos para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Detiene la ejecución si hay campos vacíos
            }

            DateTime ahora = DateTime.Now;
            DateTime haceUnMes = ahora.AddMonths(-1);

            //Datos Generales
            int noAccidente = Convert.ToInt32(txtNoAccidente.Text);
            string condicion = cboxCondicion.Text;
            DateTime fechaRegistro = dtpFechaRegistro.Value;
            int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            string numnomina = txtNumeroNomina.Text;
            string puesto = txtPuesto.Text;
            string antiguedad = txtAntiguedad.Text;
            string edad = txtEdad.Text;
            string turno = CboxTurno.Text;

            Boolean tiempoExtra = false;
            tiempoExtra = rbtnHrsExtrasSi.Checked ? true : false;
            string totalHrsExtras = txtTotalhrs.Text;
            DateTime DiaDescansoPrevio = dtpDiaDescanso.Value;
            string debidoA = cboxDebidoA.Text;
            string parteCuerpoAfectada = txtParteCuerpoAfectada.Text;
            string trabajoDesempenado = txtTrabajoDesempeñado.Text;
            string tipoLesion = txtTipoLesion.Text;
            DateTime fecha_hora_Accidente = dtpFechaAccidente.Value.Date + dtpHoraAccidente.Value.TimeOfDay;
            string testigosJson = ConvertirTestigosAJson(dgvTestigos);

      
            //Detalle Accidente
            Boolean lesion30Dias = false;
            lesion30Dias = rbtnlesion30DiasSi.Checked ? true : false;
            Boolean lesion12Meses = false;
            lesion12Meses = rbtnlesion12MesesSi.Checked ? true : false;
            string proceso = cboxProceso.Text;
            int idSeccionA = Convert.ToInt32(cboxSeccionA.SelectedValue);
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
            int idSeccionB = Convert.ToInt32(cboxSeccionB.SelectedValue);

            
            //Factores de Seguridad
            Boolean existenITRs = false;
            existenITRs = rbtnExistenItrsSi.Checked ? true : false;
            Boolean equipoAdecuado = false;
            equipoAdecuado = rbtnEquipoAdecuadoSi.Checked ? true : false;
            Boolean conociaTrabajo = false;
            conociaTrabajo = rbtnConociaTrabajoSi.Checked ? true : false;
            Boolean existiaSupervision = false;
            existiaSupervision = rbtnExistiaSupervicionSi.Checked ? true : false;
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
            string accionesCorrectivasPropuestas = txtAccionesCorrectivas.Text;
            string quienCorrectivasPropuesta = txtquienCorrectivas.Text;
            string cuandoCorrectivasPropuestas = txtCuandoCorrectivas.Text;
            string accionesPreventivasPropuestas = txtAccionesPreventivasProp.Text;
            string quienPreventivoPropuesto = txtQuienPreventivas.Text;
            string cuandoPreventivasPropuestas = txtCuandoPreventivas.Text;
            string seguimiento = txtSeguimiento.Text;
            DateTime fecha_Hora_Seguimiento = dtpFechaSeguimiento.Value.Date + dtpHoraSeguimiento.Value.TimeOfDay;
            int empleadoSeguimiento = Convert.ToInt32(txtidNombreSST.Text);
            DateTime fecha_Hora_recepcion = dtpFechaRecepcion.Value.Date + dtpHoraRecepcion.Value.TimeOfDay;


            if (fechaRegistro < haceUnMes || fechaRegistro > ahora)
            {
                RJMessageBox.Show("La fecha de registro debe estar dentro del último mes y no puede ser mayor a hoy.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DiaDescansoPrevio < haceUnMes || DiaDescansoPrevio > ahora)
            {
                RJMessageBox.Show("El último dia de descanso previo debe estar dentro del último mes y no puede ser mayor a hoy.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fecha_hora_Accidente < haceUnMes || fecha_hora_Accidente > ahora)
            {
                RJMessageBox.Show("La fecha del accidente debe estar dentro del último mes y no puede ser mayor a hoy.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fecha_Hora_Seguimiento < haceUnMes || fecha_Hora_Seguimiento > ahora)
            {
                RJMessageBox.Show("La fecha de seguimiento debe estar dentro del último mes y no puede ser mayor a hoy.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar fecha_Hora_recepcion
            if (fecha_Hora_recepcion < haceUnMes || fecha_Hora_recepcion > ahora)
            {
                RJMessageBox.Show("La fecha de recepción debe estar dentro del último mes y no puede ser mayor a hoy.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cboxSeccionA.SelectedValue == null || !int.TryParse(cboxSeccionA.SelectedValue.ToString(), out int idSeccionAB))
            {
                RJMessageBox.Show("Debes seleccionar una sección válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hayCamposVacios =
                string.IsNullOrWhiteSpace(cboxCondicion.Text) ||
                string.IsNullOrWhiteSpace(txtParteCuerpoAfectada.Text) ||
                string.IsNullOrWhiteSpace(txtTrabajoDesempeñado.Text) ||
                string.IsNullOrWhiteSpace(txtTipoLesion.Text) ||
                string.IsNullOrWhiteSpace(txtLugarAccidente.Text) ||
                string.IsNullOrWhiteSpace(txtObjCausanteLesion.Text) ||
                string.IsNullOrWhiteSpace(txtEquipoProteccionUsado.Text) ||
                string.IsNullOrWhiteSpace(txtEquipoProteccionNecesario.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcionAccidente.Text) ||
                string.IsNullOrWhiteSpace(txtEquipoDanado.Text) ||
                string.IsNullOrWhiteSpace(txtSustituiblePor.Text) ||
                string.IsNullOrWhiteSpace(txtOtro.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnosticoFinal.Text) ||
                string.IsNullOrWhiteSpace(txtTratamiento.Text) ||
                string.IsNullOrWhiteSpace(txtIncapacidad.Text) ||
                string.IsNullOrWhiteSpace(txtAccionesCorrectivas.Text) ||
                string.IsNullOrWhiteSpace(txtquienCorrectivas.Text) ||
                string.IsNullOrWhiteSpace(txtCuandoCorrectivas.Text) ||
                string.IsNullOrWhiteSpace(txtAccionesPreventivasProp.Text) ||
                string.IsNullOrWhiteSpace(txtQuienPreventivas.Text) ||
                string.IsNullOrWhiteSpace(txtCuandoPreventivas.Text) ||
                string.IsNullOrWhiteSpace(txtSeguimiento.Text);


            if (hayCamposVacios)
            {
                DialogResult result = RJMessageBox.Show(
                    "Existen otros campos vacíos. ¿Deseas guardar de todos modos?",
                    "Confirmar guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

            }
            AccidentesCE accidente = new AccidentesCE
            {
                NoAccidente = noAccidente,
                Condicion = condicion,
                FechaRegistro = fechaRegistro,
                IdEmpleado = idEmpleado,
                NumNomina = numnomina,
                Puesto = puesto,
                Antiguedad = antiguedad,
                Edad = edad,
                Turno = turno,
                TiempoExtra = tiempoExtra,
                TotalHrsExtras = totalHrsExtras,
                DiaDescansoPrevio = DiaDescansoPrevio,
                DebidoA = debidoA,
                ParteCuerpoAfectada = parteCuerpoAfectada,
                TrabajoDesempenado = trabajoDesempenado,
                TipoLesion = tipoLesion,
                FechaHoraAccidente = fecha_hora_Accidente,
                Lesion30Dias = lesion30Dias,
                Lesion12Meses = lesion12Meses,
                Proceso = proceso,
                IdSeccionA = idSeccionA,
                LugarAccidente = lugarAccidente,
                CausanteLesion = causanteLesion,
                EquipoProteccionUsado = equipoProteccionUsado,
                EquipoProteccionNecesario = equipoProteccionNecesario,
                CausaAccidente = causaAccidente,
                DescripcionAccidente = descripcionAccidente,
                RealizoTrabajoAntes = realizoTrabajoAntes,
                TrabajoHabitual = trabajoHabitual,
                TrabajoProgramado = trabajoProgramado,
                TrabajoNecesario = trabajoNecesario,
                TrabajoUrgente = trabajoUrgente,
                DanosMateriales = danosMateriales,
                EquipoDanado = equipoDanado,
                SustituiblePor = sustituiblePor,
                IdSeccionB = idSeccionB,
                ExistenITRs = existenITRs,
                EquipoAdecuado = equipoAdecuado,
                ConociaTrabajo = conociaTrabajo,
                ExistiaSupervision = existiaSupervision,
                RiesgosJson = riesgosJson,
                ActosInsegurosJson = actosInsegurosJson,
                CondicionesInsegurasJson = condicionesInsegurasJson,
                EmpleadosConocimientoJson = empleadosConocimientoJson,
                EmpleadosInvolucradosJson = empleadosInvolucradosJson,
                ContinuaTrabajando = continuaTrabajando,
                EnviadoDomicilio = enviadoDomicilio,
                EnviadoAtencionMedica = enviadoAtencionMedica,
                Otro = otro,
                DiagnosticoFinal = diagnosticoFinal,
                Tratamiento = tratamiento,
                Incapacidad = incapacidad,
                AccionesCorrectivasPropuestas = accionesCorrectivasPropuestas,
                QuienCorrectivasPropuesta = quienCorrectivasPropuesta,
                CuandoCorrectivasPropuestas = cuandoCorrectivasPropuestas,
                AccionesPreventivasPropuestas = accionesPreventivasPropuestas,
                QuienPreventivoPropuesto = quienPreventivoPropuesto,
                CuandoPreventivasPropuestas = cuandoPreventivasPropuestas,
                Seguimiento = seguimiento,
                FechaHoraSeguimiento = fecha_Hora_Seguimiento,
                EmpleadoSeguimiento = empleadoSeguimiento,
                FechaHoraRecepcion = fecha_Hora_recepcion,
                TestigosJson = testigosJson
            };
            int registro = accidentesCN.InsertarAccidente(accidente);
            if (registro > 0)
            {
                MostrarPanel(pDatosGenerales, btnDatosGenerales);
                var resultado = RJMessageBox.Show(" El Reporte de Accidente se ha guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int numnero_accidente = int.Parse(txtNoAccidente.Text);

                
                LimpiarControles(this);
                LimpiarDateTimePickers();
                txtNumeroNomina.Focus();
                txtNoAccidente.Clear(); txtNumeroNomina.Clear(); txtNombreEmpleado.Clear(); txtIdEmpleado.Clear(); txtEdad.Clear(); txtPuesto.Clear(); txtAntiguedad.Clear();

                var Llamar_reporte = new Llamar_reporte(0);
                Llamar_reporte.Show();
            }
            else
            {
                var resultado = RJMessageBox.Show(" No se ha podido grabar el Reporte de Accidente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                lblotroriesgo.Visible = true;
                txtOtroRiesgo.Visible = true;
                btnGrabarRiesgo.Visible = true;
                btnAgregarRiesgo.Visible = false;
            }
            if (cboxRiesgos.Text != "Otro")
            {
                lblotroriesgo.Visible = false;
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
                lblactoinseguro.Visible = true;
                txtOtroActoInseguro.Visible = true;
                btnGrabarActoInseguro.Visible = true;
                btnAgregarActoInseguro.Visible = false;
            }
            if (cboxActoInseguro.Text != "Otro")
            {
                lblactoinseguro.Visible=false;
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
                lblcondicioninsegura.Visible = true;
                txtOtraCondicion.Visible = true;
                btnAgregarCondicion.Visible = false;
                btnGrabarCondicionInsegura.Visible = true;
            }
            if (cboxCondicionesInseguras.Text != "Otra")
            {
                lblcondicioninsegura.Visible=false;
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
                    var result = RJMessageBox.Show("Error, Este riesgo ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var result = RJMessageBox.Show("El campo 'Otro Riesgo' está vacío, por favor ingrese un riesgo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        //MostrarNotificacion("Alerta", "Este riesgo ya ha sido registrado", Color.FromArgb(255, 152, 0), 3);
                        //labelDialogResult.Text = "Dialog Box Result";
                        var result = RJMessageBox.Show("Este riesgo ya ha sido registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //labelDialogResult.Text = result.ToString() + " Selected";
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
                var result = RJMessageBox.Show("Por favor, seleccione un riesgo válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //labelDialogResult.Text = result.ToString() + " Selected";
                //MostrarNotificacion("Alerta", "Por favor, seleccione un riesgo válido", Color.FromArgb(255, 152, 0), 3);
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
                        var result = RJMessageBox.Show("Este Acto Inseguro ya ha sido Ingresado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //MostrarNotificacion("Alerta", , Color.FromArgb(255, 152, 0), 3);
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
                var result = RJMessageBox.Show("Por favor, seleccione un Acto Inseguro válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGrabarActoInseguro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOtroActoInseguro.Text))
            {
                bool actoInseguroExistente = accidentesCN.VerificarActoInseguroExiste(txtOtroActoInseguro.Text);

                if (actoInseguroExistente)
                {
                    var result = RJMessageBox.Show("Este acto inseguro ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var result = RJMessageBox.Show("El campo 'Otro Acto Inseguro' está vacío, por favor ingrese un acto inseguro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var result = RJMessageBox.Show("Esta Condición Insegura ya ha sido Ingresada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var result = RJMessageBox.Show("Por favor, seleccione una Condición Insegura válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnGrabarCondicionInsegura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOtraCondicion.Text))
            {
                bool condicionInseguraExistente = accidentesCN.VerificarCondicionInseguraExiste(txtOtraCondicion.Text);

                if (condicionInseguraExistente)
                {
                    var result = RJMessageBox.Show("Esta condición insegura ya está registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var result = RJMessageBox.Show("El campo 'Otra Condición Insegura' está vacío, por favor ingrese una condición", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    var result = RJMessageBox.Show("No se encontró ningun empleado con ese número de nómina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreEmpleadoConocimiento.Text="";
                    txtIdEmpleadoConocimiento.Clear();
                    btnAgregarEmpleadoConocimiento.Enabled = false;
                }
            }
            else
            {
                var result = RJMessageBox.Show("Por favor, ingrese el número de nomina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var result = RJMessageBox.Show("Este empleado que tomo conocimiento ya ha sido registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                var result = RJMessageBox.Show("Por favor, busque un empleado antes de agregarlo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                    var result = RJMessageBox.Show("No se encontró ningun empleado con ese número de nómina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreEmpleadoInvolucrado.Text="";
                    txtIdEmpleadoInvolucrado.Clear();
                }
            }
            else
            {
                var result = RJMessageBox.Show("Por favor, ingrese un número de nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var result = RJMessageBox.Show("Este empleado ya ha sido registrado como involucrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                var result = RJMessageBox.Show("Por favor, busque un empleado antes de agregarlo como involucrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back ||
                  e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Enter ||
                  e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Escape ||
                  e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right))
            {
                var result = RJMessageBox.Show("Solo se pueden introducir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true; // Bloquea la entrada de caracteres no permitidos
            }
        }
        public void ValidacionNumerosTextChanged(Control txt)
        {
            if (txt == null) return; // Previene posibles errores de referencia nula

            // Verifica si el control es un MaterialTextBox y obtiene su texto
            if (txt is MaterialSkin.Controls.MaterialTextBox materialTextBox)
            {
                if (!int.TryParse(materialTextBox.Text, out _) && !string.IsNullOrWhiteSpace(materialTextBox.Text))
                {
                    var result = RJMessageBox.Show("Solo se pueden introducir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Deshabilita temporalmente el evento para evitar recursión infinita
                    materialTextBox.TextChanged -= txtNoAccidente_TextChanged;
                    materialTextBox.Clear(); // Limpia el campo
                    materialTextBox.TextChanged += txtNoAccidente_TextChanged; // Reactiva el evento
                }
            }
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
                    var result = RJMessageBox.Show("No se encontró un empleado con ese número de nómina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNombreSST.Clear();
                    txtidNombreSST.Clear();
                }
            }
            else
            {
                var result = RJMessageBox.Show("Por favor ingrese el Número de Nómina para continuar ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtTotalhrs.Focus();
            }
            else
            {
                txtTotalhrs.Text = "8";
                txtTotalhrs.Enabled = false;
            }
        }
        private void LimpiarControles(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear();
                }
                else if (ctrl is ComboBox cbx)
                {
                    cbx.SelectedIndex = 0;
                }
                else if (ctrl is CheckBox chk)
                {
                    chk.Checked = false;
                }
                else if (ctrl is DataGridView dgv)
                {
                    dgv.DataSource = null;
                    dgv.Rows.Clear();
                }
                else
                {
                    // Si el control tiene controles hijos (como Paneles o GroupBox), llamar recursivamente
                    if (ctrl.HasChildren)
                    {
                        LimpiarControles(ctrl);
                    }
                }
            }
        }

        private void LimpiarDateTimePickers()
        {
            DateTime defaultValue = DateTime.Now;

            dtpFechaRegistro.Value = defaultValue;
            dtpDiaDescanso.Value = defaultValue;
            dtpFechaAccidente.Value = defaultValue;
            dtpHoraAccidente.Value = defaultValue;
            dtpFechaSeguimiento.Value = defaultValue;
            dtpHoraSeguimiento.Value = defaultValue;
            dtpFechaRecepcion.Value = defaultValue;
            dtpHoraRecepcion.Value = defaultValue;
        }


        private void txtNoAccidente_TextChanged(object sender, EventArgs e)
        {
            ValidacionNumerosTextChanged((Control)txtNoAccidente);
        }
        private void txtNumeroNomina_TextChanged(object sender, EventArgs e)
        {
            ValidacionNumerosTextChanged((Control)txtTotalhrs);
        }

        private void dgvActoInseguro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Asegurar que es la columna 3 (índice 2)
            {
                // Confirmar antes de eliminar
                var result = RJMessageBox.Show("¿Seguro que quieres eliminar este acto inseguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvActoInseguro.Rows.RemoveAt(e.RowIndex); // Eliminar la fila
                }
            }
        }

        private void dgvRiesgos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Asegurar que es la columna 3 (índice 2)
            {
                // Confirmar antes de eliminar
                var result = RJMessageBox.Show("¿Seguro que quieres eliminar este riesgo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvRiesgos.Rows.RemoveAt(e.RowIndex); // Eliminar la fila
                }
            }
        }

        private void dgvCondicionInsegura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Asegurar que es la columna 3 (índice 2)
            {
                // Confirmar antes de eliminar
                var result = RJMessageBox.Show("¿Seguro que quieres eliminar esta condicion insegura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvCondicionInsegura.Rows.RemoveAt(e.RowIndex); // Eliminar la fila
                }
            }
        }

        private void dgvTestigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) // Asegurar que es la columna 3 (índice 2)
            {
                // Confirmar antes de eliminar
                var result = RJMessageBox.Show("¿Seguro que quieres eliminar a este testigo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvTestigos.Rows.RemoveAt(e.RowIndex); // Eliminar la fila
                }
            }
        }

        private void dgvEmpleadosInvolucrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) 
            {
                var result = RJMessageBox.Show("¿Seguro que quieres eliminar a este colaborador involucrado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvEmpleadosInvolucrados.Rows.RemoveAt(e.RowIndex); 
                }
            }
        }

        private void dgvEmpleadosConocimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3) // Asegurar que es la columna 3 (índice 2)
            {
                // Confirmar antes de eliminar
                var result = RJMessageBox.Show("¿Seguro que quieres eliminar a este colaborador que tomo conocimiento del suceso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvEmpleadosConocimiento.Rows.RemoveAt(e.RowIndex); // Eliminar la fila
                }
            }
        }

        private void pSeguimientoCaso_Paint(object sender, PaintEventArgs e)
        {

        }
        public void validarcaracteresespeciales(KeyPressEventArgs e)
        {
            bool esLetraODigito = char.IsLetterOrDigit(e.KeyChar);
            bool esGuion = e.KeyChar == '-';
            bool esTeclaControl = char.IsControl(e.KeyChar);

            bool esTeclaPermitida = e.KeyChar == (char)Keys.Back ||
                                    e.KeyChar == (char)Keys.Delete ||
                                    e.KeyChar == (char)Keys.Enter ||
                                    e.KeyChar == (char)Keys.Tab ||
                                    e.KeyChar == (char)Keys.Escape ||
                                    e.KeyChar == (char)Keys.Left ||
                                    e.KeyChar == (char)Keys.Right ||
                                    e.KeyChar == (char)Keys.Space;

            if (!(esLetraODigito || esGuion || esTeclaControl || esTeclaPermitida))
            {
                e.Handled = true; // Bloquea la tecla
                SystemSounds.Beep.Play(); // Sonido opcional
            }
        }
        private void txtNumNominaEmpleadoConocimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarcaracteresespeciales(e);
        }

        private void txtNumNominaEmpleadoInvolucrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarcaracteresespeciales(e);
        }

        private void txtNumeroNomina_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarcaracteresespeciales(e);
        }

        private void txtNumNominaTestigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarcaracteresespeciales(e);
        }
    }
}