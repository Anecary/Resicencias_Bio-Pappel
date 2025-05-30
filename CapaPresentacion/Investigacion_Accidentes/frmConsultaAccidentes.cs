using CapaNegocios;
using CapaPresentacion.Restaurar_Y_Respaldar;
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

namespace CapaPresentacion.Investigacion_Accidentes
{
    public partial class frmConsultaAccidentes : Form
    {
        private MaterialSkinManager materialSkinManager;
        private Panel p = new Panel();

        AccidentesCN accidentesCN = new AccidentesCN();
        EmpleadosCN empleadosCN = new EmpleadosCN();
        public frmConsultaAccidentes()
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
                    //txtEdad.Text = edad > 0 ? edad.ToString() : "N/A";
                    //txtPuesto.Text = dr["puesto"] as string ?? "N/A";
                    ////txtAntiguedad.Text = antiguedad > 0 ? antiguedad.ToString() : "N/A";
                    //txtAntiguedad.Text = (antiguedadAnios > 0 || antiguedadMeses > 0) ? $"{antiguedadAnios} año(s) {antiguedadMeses} mes(es)" : "N/A";
                    //txtNumNominaTestigo.Enabled = true;
                    //btnBuscarTestigo.Enabled = true;
                    cboxFechasAccidentes.SelectedIndexChanged -= cboxFechasAccidentes_SelectedIndexChanged;

                    // Obtener la tabla de accidentes
                    DataTable dtAccidentes = accidentesCN.consultaFechasAccidentesPorEmpleado(Convert.ToInt32(txtIdEmpleado.Text)) ?.Tables["ConsultaAccidentesXFecha"];

                    if (dtAccidentes != null && dtAccidentes.Rows.Count > 0)
                    {
                        // Verificar si la columna formateada ya existe
                        if (!dtAccidentes.Columns.Contains("fecha_Formateada"))
                        {
                            dtAccidentes.Columns.Add("fecha_Formateada", typeof(string));

                            // Formatear cada fila
                            foreach (DataRow row in dtAccidentes.Rows)
                            {
                                if (row["fecha_Registro"] != DBNull.Value)
                                {
                                    DateTime fecha = Convert.ToDateTime(row["fecha_Registro"]);
                                    row["fecha_Formateada"] = fecha.ToString("dd-MM-yyyy");
                                }
                                else
                                {
                                    row["fecha_Formateada"] = "Fecha no disponible";
                                }
                            }
                        }

                        cboxFechasAccidentes.DataSource = dtAccidentes;
                        cboxFechasAccidentes.DisplayMember = "fecha_Formateada"; // Mostrar la fecha formateada
                        cboxFechasAccidentes.ValueMember = "idAccidente"; // Mantener el ID real
                    }
                    else
                    {
                        cboxFechasAccidentes.DataSource = null;
                        var result = RJMessageBox.Show("Este empleado no tiene accidentes registrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }

                    cboxFechasAccidentes.SelectedIndexChanged += cboxFechasAccidentes_SelectedIndexChanged;
                }
                else
                {
                    var result = RJMessageBox.Show(" Número de nómina no encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    txtNumeroNomina.Focus();
                    txtNombreEmpleado.Clear();
                    txtIdEmpleado.Clear();
                }
            }
            else
            {
                var result = RJMessageBox.Show("El campo 'Número de Nómina' está vacío, llénelo para continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroNomina.Focus();
            }
        }


        private void frmConsultaAccidentes_Load(object sender, EventArgs e)
        {
            
        }

        private void cboxFechasAccidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable t = accidentesCN.consultarInvAccidentePorID(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["InvestigacionAccidentePorID"];

            if (t.Rows.Count > 0)
            {
                DataRow dr = t.Rows[0];

                txtCondicion.Text = dr["condicion"].ToString();
                txtNumAccidente.Text = dr["accidente_no"].ToString();
                if (dr["tiempo_extra"] != DBNull.Value)
                {
                    rbtnTiempoExtra.Checked = Convert.ToBoolean(dr["tiempo_extra"]);
                }
                else
                {
                    rbtnTiempoExtra.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                txtTotalHrs.Text = dr["total_hrs_Extras"].ToString();
                if (dr["dia_descanso_Previo"] != DBNull.Value)
                {
                    DateTime fecha = Convert.ToDateTime(dr["dia_descanso_Previo"]);
                    txtDiaDescansoPrevio.Text = fecha.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("es-ES"));
                }
                else
                {
                    txtDiaDescansoPrevio.Text = "Sin fecha"; // O cualquier otro valor predeterminado
                }
                txtDebidoA.Text = dr["debido_a"].ToString();
                
                txtParteCuerpoAfectada.Text = dr["parte_cuerpo_afectada"].ToString();
                txtTrabajoDesempenado.Text = dr["trabajo_Desempeñado"].ToString();
                txtTipoLesion.Text = dr["tipo_Lesion"].ToString();

                if (dr["accidentes_previos_30_dias"] != DBNull.Value)
                {
                    rbtnlesion30DiasSi.Checked = Convert.ToBoolean(dr["accidentes_previos_30_dias"]);
                }
                else
                {
                    rbtnlesion30DiasSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["accidentes_previos_12_meses"] != DBNull.Value)
                {
                    rbtnlesion12MesesSi.Checked = Convert.ToBoolean(dr["accidentes_previos_12_meses"]);
                }
                else
                {
                    rbtnlesion12MesesSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                txtProceso.Text = dr["proceso"].ToString();
                txtSeccionA.Text = dr["seccion_A"].ToString();
                txtLugarAccidente.Text = dr["lugar_Accidente"].ToString();
                txtObjCausanteLesion.Text = dr["tipo_Lesion"].ToString();
                txtEquipoProteccionUsado.Text = dr["equipo_Proteccion_usado"].ToString();
                txtEquipoProteccionNecesario.Text = dr["equipo_Proteccion_Necesario"].ToString();
                txtDescripcionAccidente.Text = dr["descripcion_accidente"].ToString();
                txtCausaAccidente.Text = dr["causas_basicas_accidente"].ToString();
                label6.Text = dr["numRevisionHistorico"].ToString();
                var datos = accidentesCN.ObtenerDatosRevisionPorNumero(int.Parse(label6.Text.ToString()));
                label8.Text = datos.fechaRevision.ToString();
                label7.Text = datos.fechaEmision.ToString();
                label9.Text = datos.codigo.ToString();
                if (dr["trabajo_Realizado_Antes"] != DBNull.Value)
                {
                    rbtnRealizoTrabajoAntesSi.Checked = Convert.ToBoolean(dr["trabajo_Realizado_Antes"]);
                }
                else
                {
                    rbtnRealizoTrabajoAntesSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["trabajo_Habitual"] != DBNull.Value)
                {
                    rbtnTrabajoHabitualSi.Checked = Convert.ToBoolean(dr["trabajo_Habitual"]);
                }
                else
                {
                    rbtnTrabajoHabitualSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["trabajo_Programado"] != DBNull.Value)
                {
                    rbtnTrabajoProgramadoSi.Checked = Convert.ToBoolean(dr["trabajo_Programado"]);
                }
                else
                {
                    rbtnTrabajoProgramadoSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["trabajo_Necesario"] != DBNull.Value)
                {
                    rbtnTrabajoNeccesarioSi.Checked = Convert.ToBoolean(dr["trabajo_Necesario"]);
                }
                else
                {
                    rbtnTrabajoNeccesarioSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["trabajo_Urgente"] != DBNull.Value)
                {
                    rbtnTrabajoUrgenteSi.Checked = Convert.ToBoolean(dr["trabajo_Urgente"]);
                }
                else
                {
                    rbtnTrabajoUrgenteSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["danosMateriales"] != DBNull.Value)
                {
                    rbtnDanosMateriales.Checked = Convert.ToBoolean(dr["danosMateriales"]);
                }
                else
                {
                    rbtnDanosMateriales.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                txtEquipoDanado.Text = dr["pieza_equipo_danada"].ToString();
                txtSustituiblePor.Text = dr["sustituiblePor"].ToString();
                txtSeccionB.Text = dr["seccion_B"].ToString();
                if (dr["ITRS_Trabajo"] != DBNull.Value)
                {
                    rbtnExistenItrsSi.Checked = Convert.ToBoolean(dr["ITRS_Trabajo"]);
                }
                else
                {
                    rbtnExistenItrsSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["herramienta_equipo_adecuado"] != DBNull.Value)
                {
                    rbtnEquipoAdecuadoSi.Checked = Convert.ToBoolean(dr["herramienta_equipo_adecuado"]);
                }
                else
                {
                    rbtnEquipoAdecuadoSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["ubicacion_conocida"] != DBNull.Value)
                {
                    rbtnConociaTrabajoSi.Checked = Convert.ToBoolean(dr["ubicacion_conocida"]);
                }
                else
                {
                    rbtnConociaTrabajoSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                if (dr["supervision"] != DBNull.Value)
                {
                    rbtnExistiaSupervicionSi.Checked = Convert.ToBoolean(dr["supervision"]);
                }
                else
                {
                    rbtnExistiaSupervicionSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                //-------------------------------------------------------------------------------------------------
                if (dr["continua_trabajando"] != DBNull.Value)
                {
                    rbtnContinuaTrabajando.Checked = Convert.ToBoolean(dr["continua_trabajando"]);
                }
                else
                {
                    rbtnContinuaTrabajando.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }

                if (dr["enviado_Domicilio"] != DBNull.Value)
                {
                    rbtnEnviadoDomicilio.Checked = Convert.ToBoolean(dr["enviado_Domicilio"]);
                }
                else
                {
                    rbtnEnviadoDomicilio.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }

                if (dr["atencion_Medica"] != DBNull.Value)
                {
                    rbtnAtencionMedica.Checked = Convert.ToBoolean(dr["atencion_Medica"]);
                }
                else
                {
                    rbtnAtencionMedica.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }

                if (dr["otro_diagnostico"] != DBNull.Value)
                {
                    txtOtro.Text = dr["otro_diagnostico"].ToString();
                    txtOtro.Enabled = true;
                    rbtnExistiaSupervicionSi.Checked = true;
                }
                else
                {
                    rbtnExistiaSupervicionSi.Checked = false; // Opcional, en caso de que el valor sea nulo.
                }
                txtDiagnosticoFinal.Text = dr["diagnostico_final"].ToString();
                txtTratamiento.Text = dr["tratamiento"].ToString();
                txtincapacidad.Text = dr["incapacidad"].ToString();
                txtFechaRecepcion.Text = Convert.ToDateTime(dr["fecha_Recepcion_Documento"]).ToString("dd/MMMM/yyyy");




            }
           
            dgvDetalleRiesgos.DataSource = accidentesCN.consultarDetalleInvAccidente_Riesgos(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["Detalle_InvAccidenteRiesgos"];
            dgvDetalleActosInseguros.DataSource = accidentesCN.consultarDetalleInvAccidente_ActosInseguros(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["Detalle_InvAccidenteActosInseguros"];
            dgvDetalleCondicionesInseguras.DataSource = accidentesCN.consultarDetalleInvAccidente_CondicionesInseguras(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["Detalle_InvAccidenteCondicionesInseguras"];
            dgvTestigos.DataSource = accidentesCN.consultarDetalleInvAccidente_EmpleadosTestigos(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["Detalle_InvAccidenteEmpleadosTestigos"];
            dgvEmpleadoConocimiento.DataSource = accidentesCN.consultarDetalleInvAccidente_EmpleadosConocimiento(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["Detalle_InvAccidenteEmpleadosConocimiento"];
            dgvEmpleadosInvolucrados.DataSource = accidentesCN.consultarDetalleInvAccidente_EmpleadosInvolucrados(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["Detalle_InvAccidenteEmpleadosInvolucrados"];

            DataTable t2 = accidentesCN.consultarInvAccidentesAcciones(Convert.ToInt32(cboxFechasAccidentes.SelectedValue)).Tables["InvestigacionAccidenteAcciones"];

            if (t2.Rows.Count > 0)
            {
                DataRow dr2 = t2.Rows[0];

                txtAccionesCorrectivas.Text = dr2["acciones_Correctivas_prop"].ToString();
                txtquienCorrectivas.Text = dr2["quien_accionesC"].ToString();
                txtCuandoCorrectivas.Text = dr2["cuando_accionesC"].ToString();
                txtAccionesPreventivas.Text = dr2["acciones_preventivas_prop"].ToString();
                txtQuienPreventivas.Text = dr2["quien_accionesP"].ToString();
                txtCuandoPreventivas.Text = dr2["cuando_accionesP"].ToString();

                txtSeguimiento.Text = dr2["seguimiento"].ToString();
                txtFechaHoraCierreAcciones.Text =Convert.ToDateTime( dr2["fecha_hora_Cierre_Acc_Seg"]).ToString("dd/MMMM/yyyy");
                txtNombreProcesoSST.Text = dr2["Nombre"].ToString();
            }
        }

        private void txtProceso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeccionA_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnlesion30DiasSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnlesion12MesesSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimirReporte_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cboxFechasAccidentes.SelectedValue.ToString());
            int noR = int.Parse(label6.Text.ToString());
            var Llamar_reporte = new Llamar_reporte(id, noR);
            Llamar_reporte.Show();
        }
    }
}
