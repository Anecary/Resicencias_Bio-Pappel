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
using System.Windows.Navigation;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;
using CapaEntidad;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace CapaPresentacion.Expediente
{
    public partial class frmExpedienteMedico : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

        EmpleadosCN empleadosCN = new EmpleadosCN();
        ExpedientesCN expedientesCN = new ExpedientesCN();
        public frmExpedienteMedico()
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
            panel3.Paint += new PaintEventHandler(Panel1_Paint);
            panel4.Paint += new PaintEventHandler(Panel1_Paint);
            panel6.Paint += new PaintEventHandler(Panel1_Paint);
            panel7.Paint += new PaintEventHandler(Panel1_Paint);
            panel8.Paint += new PaintEventHandler(Panel1_Paint);
            panel9.Paint += new PaintEventHandler(Panel1_Paint);


            pDatosGenerales.Visible = true;
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;
        }
        private void frmExpedienteMedico_Load(object sender, EventArgs e)
        {
            panelVisitado[btnDatosGenerales] = false;
            panelVisitado[btnNoPatologicos] = false;
            panelVisitado[btnPatologicos] = false;
            panelVisitado[btnExploracionFisica] = false;
            panelVisitado[btnEstudiosParaclinicos] = false;


            panelActual = pDatosGenerales;
            botonActual = btnDatosGenerales;
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

        private Dictionary<Button, bool> panelVisitado = new Dictionary<Button, bool>();

        // Variable para almacenar el panel y botón actual
        private Panel panelActual = null;
        private Button botonActual = null;

        private void ActualizarColorBoton(Button boton, Control parentControl)
        {
            // Si el panel nunca ha sido visitado, mantener el color original
            if (!panelVisitado.ContainsKey(boton)) return;

            bool hayCamposVacíos = HayTextBoxVacios(parentControl);

            // Cambiar color solo si el panel ya se visitó
            // boton.BackColor = hayCamposVacíos ? Color.Red : Color.FromArgb(27, 77, 141);
            //boton.ForeColor = hayCamposVacíos ? Color.Red : Color.White;
            boton.Image = hayCamposVacíos ? Properties.Resources.senal_de_alerta : null;
            boton.TextImageRelation = TextImageRelation.TextBeforeImage;
        }

        // Método recursivo para buscar TextBox dentro de cualquier control (incluidos paneles anidados)
        private bool HayTextBoxVacios(Control parentControl)
        {
            foreach (Control ctrl in parentControl.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text)) // Si está vacío o solo tiene espacios
                        return true;
                }
                else if (ctrl.HasChildren) // Si el control tiene hijos, revisamos dentro de él
                {
                    if (HayTextBoxVacios(ctrl))
                        return true;
                }
            }
            return false; // No se encontraron campos vacíos
        }
       

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
            pNoPatologicos.Visible = false;
            pPatologicos.Visible = false;
            pExploracionFisica.Visible = false;
            pEstudiosParaclinicos.Visible = false;

            panelAMostrar.Visible = true;
            panelActual = panelAMostrar;
            botonActual = botonPresionado;
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
                    txtNSS.Text = dr["nss"].ToString();
                    txtTelefono.Text = dr["telefono"].ToString();
                    txtDomicilio.Text = (dr["domicilio_Calle"] as string ?? "") + " #" +
                        (dr["domicilio_Numero"] as string ?? "") + ", " +
                        (dr["domicilio_Colonia"] as string ?? "") + ", " +
                        (dr["domicilio_Ciudad"] as string ?? "") + ", " +
                        (dr["domicilio_Estado"] as string ?? "");
                    txtFechaIngreso.Text = fechaIngresoAlPuesto.ToString("dd-MMMM-yyyy");
                    txtPuesto.Text = dr["puesto"] as string ?? "N/A";

                    string nombre = txtNombreEmpleado.Text;
                    string nomenclarura = ObtenerNomenclatura(nombre);
                    txtNoExpediente.Text = nomenclarura + "-" + txtNumeroNomina.Text;
                }
                else
                {
                    var result = RJMessageBox.Show(" Número de nómina no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                var result = RJMessageBox.Show(" Por favor ingrese un Número de Nómina para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroNomina.Focus();
            }
        }
        static string ObtenerNomenclatura(string nombre)
        {
            return string.Concat(nombre.Split(' ').Select(palabra => palabra[0]));
        }
        private void btnDatosGenerales_Click(object sender, EventArgs e)
        {
            MostrarPanel(pDatosGenerales, btnDatosGenerales);
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

        private void btnEstudiosParaclinicos_Click(object sender, EventArgs e)
        {
            MostrarPanel(pEstudiosParaclinicos, btnEstudiosParaclinicos);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ahora = DateTime.Now;
                DateTime haceUnMes = ahora.AddMonths(-1);

                string numExpediente = txtNoExpediente.Text;
                int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                string numNomina = txtNumeroNomina.Text;
                DateTime fechaApertura = dtpFechaApertura.Value;
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



                if (fechaApertura < haceUnMes || fechaApertura > ahora)
                {
                    RJMessageBox.Show("La fecha de seguimiento debe estar dentro del último mes y no puede ser mayor a hoy.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                ExpedientesCE expediente = new ExpedientesCE
                {
                    NumExpediente = numExpediente,
                    IdEmpleado = idEmpleado,
                    NumNomina = numNomina,
                    FechaApertura = fechaApertura,
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

                    UltimaActualizacion = fechaApertura
                };

                int registro = expedientesCN.insertarExpediente(expediente);
                if (registro > 0)
                {
                    MostrarPanel(pDatosGenerales, btnDatosGenerales);
                    var result = RJMessageBox.Show(" El expediente médico se ha guardado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    // Llamada al método para limpiar todos los controles en el formulario
                    //LimpiarControles(this);
                    txtNumeroNomina.Focus();
                    limiarFormulario();
                    //txtCondicion.Clear(); txtNoAccidente.Clear(); txtNumeroNomina.Clear(); txtNombreEmpleado.Clear(); txtIdEmpleado.Clear(); txtEdad.Clear(); txtPuesto.Clear(); txtAntiguedad.Clear();
                }
                else
                {
                    var result = RJMessageBox.Show(" No se ha podido grabar el expediente médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
                {
                RJMessageBox.Show(" No se ha podido grabar el expediente médico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void limiarFormulario()
        {
            // Limpiar TextBox
            // Limpiar TextBoxes con .Text = ""
            txtNoExpediente.Text = "";
            txtIdEmpleado.Text = "";
            txtNumeroNomina.Text = "";
            txtHeredoFamiliar.Text = "";
            txtDiagnostico.Text = "";

            txtCasa.Text = "";
            txtAlimentacion.Text = "";
            txtAnimales.Text = "";
            txtInmunizaciones.Text = "";
            txtToxicomanias.Text = "";
            txtTrabajosYActAnteriores.Text = "";
            txtDeportesRecreacion.Text = "";
            txtEntornoFamiliar.Text = "";
            txtEscolaridad.Text = "";

            txtAlergias.Text = "";

            txtSNerviosoCentral.Text = "";
            txtSCardiovascular.Text = "";
            txtSRespiratorio.Text = "";
            txtSGastrointestinal.Text = "";
            txtSEndocrino.Text = "";
            txtSGenitoUrinario.Text = "";
            txtSMusculoEsqueletico.Text = "";
            txtOrganoSentidos.Text = "";
            txtGinecoObstetrico.Text = "";

            txtEstudiosLaboratorio.Text = "";
            txtEstudiosRadiologicos.Text = "";
            txtOtros.Text = "";

            txtTalla.Text = "";
            txtPeso.Text = "";
            txtIMC.Text = "";
            txtFC.Text = "";
            txtFR.Text = "";
            txtPulso.Text = "";
            txtTA.Text = "";
            txtTemperatura.Text = "";

            txtCraneo.Text = "";
            txtOjos.Text = "";
            txtOidos.Text = "";
            txtNariz.Text = "";
            txtBoca.Text = "";
            txtCuello.Text = "";
            txtTorax.Text = "";
            txtAbdomen.Text = "";
            txtGenitourinario.Text = "";
            txtMusculoEsqueletico.Text = "";
            txtNeurologico.Text = "";

            // Limpiar ComboBoxes
            cboxGrupoSanguineo.Text = "";
            cboxConstitucionFisica.Text = "";
            cboxGrado.Text = "";

            // Reiniciar DateTimePicker
            dtpFechaApertura.Value = DateTime.Now;

            // Limpiar ComboBox
            cboxGrupoSanguineo.SelectedIndex = -1;
            cboxConstitucionFisica.SelectedIndex = -1;
            cboxGrado.SelectedIndex = -1;


            // Desmarcar RadioButtons
            rbtnHozpitalizaciones.Checked = false;
            rbtnCirugias.Checked = false;
            rbtnTransfusiones.Checked = false;

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
       
        private void txtPulso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumeros(e);
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

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionNumerosDecimal(sender, e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, retroceso, eliminar, enter, tab, escape, y las flechas
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back ||
                  e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Enter ||
                  e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Escape ||
                  e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == '.' || e.KeyChar == '/'))
            {
                var result = RJMessageBox.Show("Solo se pueden introducir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Bloquea la entrada de caracteres no permitidos
            }
            else if (e.KeyChar == '.')
            {
                // Verifica si ya existe un punto en el texto
                var textBox = sender as MaterialSkin.Controls.MaterialTextBox;

                if (textBox.Text.Contains("."))
                {
                    var result = RJMessageBox.Show("Solo se permite un punto decimal", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true; // Bloquea la entrada de un segundo punto
                }
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

        private void txtPeso_Validating(object sender, CancelEventArgs e)
        {
            // Verifica si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                return;  // Permite que el control pase sin hacer nada si el campo está vacío
            }
            // Intentar convertir solo si no está vacío
            double peso;
            if (double.TryParse(txtPeso.Text, out peso)) // Usa TryParse para evitar excepciones
            {
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
            else
            {
                // Si la conversión falla (no es un número válido)
                var result = RJMessageBox.Show("Por favor, ingresa un número válido para el peso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPeso.Clear();
                txtPeso.Focus();
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
                if (talla > 5 || talla < 0.5)
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

    }
}
