using CapaEntidad;
using CapaNegocios;
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

        public frmReportes_Investigacion_Accidente()
        {
            InitializeComponent();
        }

        private void frmReportes_Investigacion_Accidente_Load(object sender, EventArgs e)
        {
            this.rvInvestigacionAccidente.RefreshReport();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string reporte_seleccionado = cmbReportes.SelectedItem.ToString();

            switch (reporte_seleccionado)
            {
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
                case "Accidentes por Condicion":
                    obtener_Condici();
                    break;
                case "Accidentes por Edad":
                    obtener_Edad();
                    break;
                case "Accidentes Debido A":
                    obtener_Debido();
                    break;
            }
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
    }
}