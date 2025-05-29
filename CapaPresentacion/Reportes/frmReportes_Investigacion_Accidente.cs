using CapaEntidad;
using CapaNegocios;
using MaterialSkin;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmReportes_Investigacion_Accidente : Form
    {
        private AccidentesCN negocios = new AccidentesCN();
        private MaterialSkinManager materialSkinManager;
        public frmReportes_Investigacion_Accidente()
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
        }

        private void frmReportes_Investigacion_Accidente_Load(object sender, EventArgs e)
        {
            this.rvInvestigacionAccidente.RefreshReport();
            LlenarComboAños();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string reporte_seleccionado = cmbReportes.SelectedItem.ToString();

            switch (reporte_seleccionado)
            {
                case "Accidentes general":
                    Accidentes_General();
                    break;
                case "Accidentes por año":
                    Accidentes_x_año();
                    break;
                case "Accidentes por seccion":
                    obtener_Secciones();
                    break;
                case "Accidentes por semana":
                    obtener_Semana();
                    break;
                case "Accidentes por parte del cuerpo":
                    obtener_parte_cuerpo();
                    break;
                case "Accidentes por turno":
                    obtener_turno();
                    break;
                case "Accidentes por T. lesión":
                    obtener_Tlesion();
                    break;
                case "Accidentes por Incapacidad Departamento":
                    obtener_IncapDepto();
                    break;
                case "Accidentes por Condición":
                    obtener_Condici();
                    break;
                case "Accidentes por Edad":
                    obtener_Edad();
                    break;
                case "Accidentes debido A":
                    obtener_Debido();
                    break;
                case "Accidentes por clasificación":
                    obtener_clasificacion();
                    break;
            }
        }
        private void Accidentes_General()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Año = negocios.ObtenerReporteAccidentesBLL(año);
            DataTable Accidentes_Secciones = negocios.ObtenerReporteAccidentesPS(año);
            DataTable Accidentes_Semanas = negocios.ObtenerReporteAccidentesSemana(año);
            DataTable Accidentes_parte_cuerpo = negocios.ObtenerReporteAccidentes_ParteCuerpo(año);
            DataTable Accidentes_Turno = negocios.ObtenerReporteAccidentes_Turno(año);
            DataTable Accidentes_TLesion = negocios.ObtenerReporteAccidentes_Tlesion(año);
            DataTable Accidentes_IncapDep = negocios.ObtenerReporteAccidentes_IncapDeto(año);
            DataTable Accidentes_Condicion = negocios.ObtenerReporteAccidentes_Condicionn(año);
            DataTable Accidentes_Edad = negocios.ObtenerReporteAccidentes_Eda(año);
            DataTable Accidentes_Debido = negocios.ObtenerReporteAccidentes_Debido(año);
            DataTable Accidentes_Clasificacion = negocios.ObtenerReporteAccidentes_Clasificacion(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidente_General.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_AccidentesxAño", Accidentes_Año));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_AccidentesSeccion", Accidentes_Secciones));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Semana", Accidentes_Semanas));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_PC", Accidentes_parte_cuerpo));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Turno", Accidentes_Turno));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Accidentes_TLesion));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", Accidentes_IncapDep));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Condicion", Accidentes_Condicion));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Edad", Accidentes_Edad));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_DebidoA", Accidentes_Debido));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Accidentes_Clasificacion", Accidentes_Clasificacion));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();

        }
        /*ACCIDENTES POR AÑO*/
        private void Accidentes_x_año()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Año = negocios.ObtenerReporteAccidentesBLL(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xAño.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_AccidentesxAño", Accidentes_Año));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();

        }
        /*ACCIDENTES POR TURNO*/
        private void obtener_turno()
        {
            int año =int.Parse(cmbAños.SelectedItem?.ToString());

            DataTable Accidentes_Turno = negocios.ObtenerReporteAccidentes_Turno(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xTurno.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Turno", Accidentes_Turno));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }


        /*ACCIDENTES POR PARTE DEL CUERPO*/
        private void obtener_parte_cuerpo()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_parte_cuerpo = negocios.ObtenerReporteAccidentes_ParteCuerpo(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidente_xParte_Cuerpo.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_PC", Accidentes_parte_cuerpo));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        /*ACCIDENTES POR DIA DE LA SEMANA*/
        private void obtener_Semana()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Semanas = negocios.ObtenerReporteAccidentesSemana(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidente_xSemana.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Semana", Accidentes_Semanas));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        /*ACCIDENTES POR SECCION*/
        private void obtener_Secciones()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Secciones = negocios.ObtenerReporteAccidentesPS(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xSeccion.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_AccidentesSeccion", Accidentes_Secciones));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }



        private void obtener_Tlesion()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_TLesion = negocios.ObtenerReporteAccidentes_Tlesion(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xTLesion.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Accidentes_TLesion));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        private void obtener_IncapDepto()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_IncapDep = negocios.ObtenerReporteAccidentes_IncapDeto(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xIncapDep.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Accidentes_IncapDep));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        private void obtener_Condici()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Condicion = negocios.ObtenerReporteAccidentes_Condicionn(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xCondicion.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Condicion", Accidentes_Condicion));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        private void obtener_Edad()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Edad = negocios.ObtenerReporteAccidentes_Eda(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xEdad.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Edad", Accidentes_Edad));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        private void obtener_Debido()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Debido = negocios.ObtenerReporteAccidentes_Debido(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xDebidoA.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_DebidoA", Accidentes_Debido));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        private void obtener_clasificacion()
        {
            int año = int.Parse(cmbAños.SelectedItem.ToString());

            DataTable Accidentes_Clasificacion = negocios.ObtenerReporteAccidentes_Clasificacion(año);

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidente_Clasificacion.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Accidentes_Clasificacion", Accidentes_Clasificacion));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }


        private void LlenarComboAños()
        {
            int añoActual = DateTime.Now.Year;
            cmbAños.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                cmbAños.Items.Add(añoActual - i);
            }

            cmbAños.SelectedIndex = 0;
        }
    }
}