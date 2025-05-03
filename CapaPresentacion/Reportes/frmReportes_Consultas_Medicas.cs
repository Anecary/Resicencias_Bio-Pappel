using CapaNegocios;
using MaterialSkin;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmReportes_Consultas_Medicas : Form
    {
        private ConsultaMedicaCN negocios = new ConsultaMedicaCN();
        private MaterialSkinManager materialSkinManager;
        public frmReportes_Consultas_Medicas()
        {
            InitializeComponent();
        }

        private void frmReportes_Consultas_Medicas_Load(object sender, EventArgs e)
        {
            this.rvNotaMedica.RefreshReport();
            LlenarComboAños();
        }

        private void cmbReportes_Notas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reporte_seleccionado = cmbReportes_Notas.SelectedItem.ToString();

            switch (reporte_seleccionado)
            {
                case "Reporte de Consultas General":
                    cboxAos.Visible = true;
                    ConsultaGeneral();                       
                    break;
                case "Reporte de Consultas Semanales":
                    cboxAos.Visible = true;
                    ConsultasCausas();
                    break;
                case "Reporte de Consultas por Día de la Semana":
                    cboxAos.Visible = true;
                    ConsultasdiaSemana();
                    break;
                case "Reporte de Consultas por Procesos":
                    cboxAos.Visible = true;
                    ConsultasProceso();
                    break;
                case "Reporte de Consultas por Hora":
                    cboxAos.Visible = true;
                    ConsultasxHora();
                    break;
                case "Reporte de Consultas por Año":
                    cboxAos.Visible = false;
                    ConsultasxAño();
                    break;
            }
        }

        private void ConsultaGeneral()
        {
            int año = int.Parse(cboxAos.SelectedItem.ToString());

            DataTable ConsultasMCausas = negocios.ObtenerReporteNotaMedica_Causas(año);
            DataTable ConsultasMdiaSemana = negocios.ObtenerReporteNotaMedica_diaSemana(año);
            DataTable ConsultasMProceso = negocios.ObtenerReporteNotaMedica_Proceso(año);
            DataTable ConsultasMxHora = negocios.ObtenerReporteNotaMedica_Hora(año);
            DataTable ConsultasMxAño = negocios.ObtenerReporteNotaMedica_Año();

            rvNotaMedica.Reset();
            rvNotaMedica.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.NotaMedica_General.rdlc";
            rvNotaMedica.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_Causa", ConsultasMCausas));
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_diaSemana", ConsultasMdiaSemana));
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_Procesos", ConsultasMProceso));
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_Hora", ConsultasMxHora));
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NT_xAño", ConsultasMxAño));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvNotaMedica.RefreshReport();

        }

        private void ConsultasCausas()
        {
            int año = int.Parse(cboxAos.SelectedItem.ToString());

            DataTable ConsultasMCausas = negocios.ObtenerReporteNotaMedica_Causas(año);

            rvNotaMedica.Reset();
            rvNotaMedica.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.NotaMedica_Causas.rdlc";
            rvNotaMedica.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_Causa", ConsultasMCausas));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvNotaMedica.RefreshReport();

        }

        private void ConsultasdiaSemana()
        {
            int año = int.Parse(cboxAos.SelectedItem.ToString());

            DataTable ConsultasMdiaSemana = negocios.ObtenerReporteNotaMedica_diaSemana(año);

            rvNotaMedica.Reset();
            rvNotaMedica.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.NotaMedica_diaSemana.rdlc";
            rvNotaMedica.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_diaSemana", ConsultasMdiaSemana));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvNotaMedica.RefreshReport();

        }

        private void ConsultasProceso()
        {
            int año = int.Parse(cboxAos.SelectedItem.ToString());

            DataTable ConsultasMProceso = negocios.ObtenerReporteNotaMedica_Proceso(año);

            rvNotaMedica.Reset();
            rvNotaMedica.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.NotaMedica_Procesos.rdlc";
            rvNotaMedica.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_Procesos", ConsultasMProceso));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvNotaMedica.RefreshReport();

        }

        private void ConsultasxHora()
        {
            int año = int.Parse(cboxAos.SelectedItem.ToString());

            DataTable ConsultasMxHora = negocios.ObtenerReporteNotaMedica_Hora(año);

            rvNotaMedica.Reset();
            rvNotaMedica.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.NotaMedica_xHora.rdlc";
            rvNotaMedica.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NM_Hora", ConsultasMxHora));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvNotaMedica.RefreshReport();

        }

        private void ConsultasxAño()
        {
            int año = int.Parse(cboxAos.SelectedItem.ToString());

            DataTable ConsultasMxAño = negocios.ObtenerReporteNotaMedica_Año();

            rvNotaMedica.Reset();
            rvNotaMedica.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.NotaMedica_xaño.rdlc";
            rvNotaMedica.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvNotaMedica.LocalReport.DataSources.Add(new ReportDataSource("DataSet_NT_xAño", ConsultasMxAño));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvNotaMedica.RefreshReport();

        }

        private void LlenarComboAños()
        {
            int añoActual = DateTime.Now.Year;
            cboxAos.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                cboxAos.Items.Add(añoActual - i);
            }

            cboxAos.SelectedIndex = 0;
        }
    }
}
