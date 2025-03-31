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
                    rdbAño.Visible = true;
                    rdbTodos.Visible = true;
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
            }
        }

        /*ACCIDENTES POR TURNO*/
        private void obtener_turno()
        {
            DataTable Accidentes_Turno = negocios.ObtenerReporteAccidentes_Turno();

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
            DataTable Accidentes_parte_cuerpo = negocios.ObtenerReporteAccidentes_ParteCuerpo();

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
            DataTable Accidentes_Semanas = negocios.ObtenerReporteAccidentesSemana();

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
            DataTable Accidentes_Secciones = negocios.ObtenerReporteAccidentesPS();

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xSeccion.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_AccidentesSeccion", Accidentes_Secciones));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }

        /*ACCIDENTES POR AÑO*/
        private void Accidentes_x_año()
        {
            // Obtener los datos originales
            DataTable accidentesOriginal = negocios.ObtenerReporteAccidentesBLL();
            cmbAños.Visible = false;

            // Crear una nueva tabla para el gráfico con la estructura esperada por el RDLC
            DataTable accidentesTransformados = TransformarDatos(accidentesOriginal);

            // Configurar el ReportViewer
            ConfigurarReporte(accidentesTransformados, accidentesOriginal);
        }

        private DataTable TransformarDatos(DataTable accidentesOriginal)
        {
            DataTable accidentesTransformados = new DataTable();
            accidentesTransformados.Columns.Add("Año", typeof(int));
            accidentesTransformados.Columns.Add("Mes", typeof(string));
            accidentesTransformados.Columns.Add("Cantidad", typeof(int));

            // Convertir los datos originales en filas individuales por mes
            foreach (DataRow row in accidentesOriginal.Rows)
            {
                if (row["Año"].ToString() == "TOTAL") continue; // Omitir la fila de totales

                int año = Convert.ToInt32(row["Año"]);
                string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

                foreach (string mes in meses)
                {
                    int cantidad = Convert.ToInt32(row[mes]);

                    if (cantidad > 0) // Solo agregar si hay accidentes
                    {
                        accidentesTransformados.Rows.Add(año, mes, cantidad);
                    }
                }
            }

            return accidentesTransformados;
        }

        private void ConfigurarReporte(DataTable datosTransformados, DataTable datosOriginales)
        {
            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xAño.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Usar el DataTable transformado en lugar del DataSet original
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_accidentes_por_año", datosTransformados));
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Auxiliar", datosOriginales));

            // Refrescar el reporte
            rvInvestigacionAccidente.RefreshReport();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Accidentes_x_año();
        }

        private void rdbAño_CheckedChanged(object sender, EventArgs e)
        {
            // Obtener los datos originales
            DataTable accidentesOriginal = negocios.ObtenerReporteAccidentesBLL();
            cmbAños.Visible = true;

            var añosUnicos = accidentesOriginal.AsEnumerable()
                .Where(row => row["Año"].ToString() != "TOTAL") // Excluir "TOTAL"
                .Select(row => row["Año"].ToString())
                .Distinct()
                .OrderBy(año => año) // Ordenar los años
                .ToList();

            cmbAños.DataSource = añosUnicos;
            cmbAños.SelectedIndex = 0;
        }

        private void cmbAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Convertir el año seleccionado a int
            int añoSeleccionado = Convert.ToInt32(cmbAños.SelectedItem.ToString());

            // Filtrar los datos por el año seleccionado
            DataTable datosFiltrados = FiltrarDatosPorAño(añoSeleccionado);

            // Cargar el reporte con los datos filtrados
            CargarReporte(datosFiltrados);
        }

        private DataTable FiltrarDatosPorAño(int año)
        {
            // Obtener los datos originales
            DataTable accidentesOriginal = negocios.ObtenerReporteAccidentesBLL();

            // Crear un nuevo DataTable con la misma estructura
            DataTable datosFiltrados = accidentesOriginal.Clone();

            // Filtrar las filas asegurando que "Año" sea un número válido
            var filasFiltradas = accidentesOriginal.AsEnumerable()
                .Where(row =>
                {
                    if (int.TryParse(row["Año"].ToString(), out int añoFila)) // Verifica si "Año" es un número válido
                    {
                        return añoFila == año; // Filtra por el año deseado
                    }
                    return false; // Ignorar filas no numéricas (como "TOTAL")
                })
                .ToList();

            // Importar las filas filtradas al nuevo DataTable
            foreach (var fila in filasFiltradas)
            {
                datosFiltrados.ImportRow(fila);
            }

            return datosFiltrados;
        }

        private void CargarReporte(DataTable datosFiltrados)
        {
            // Transformar los datos filtrados
            DataTable datosTransformados = TransformarDatos(datosFiltrados);

            // Configurar el ReportViewer
            ConfigurarReporte(datosTransformados, datosFiltrados);
        }

        private void obtener_Tlesion()
        {
            DataTable Accidentes_TLesion = negocios.ObtenerReporteAccidentes_Tlesion();

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
            DataTable Accidentes_IncapDep = negocios.ObtenerReporteAccidentes_IncapDeto();

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
            DataTable Accidentes_Condicion = negocios.ObtenerReporteAccidentes_Condicionn();

            rvInvestigacionAccidente.Reset();
            rvInvestigacionAccidente.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Accidentes_xCondicion.rdlc";
            rvInvestigacionAccidente.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            rvInvestigacionAccidente.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Condicion", Accidentes_Condicion));

            // REFRESCAR EL REPORTE DESPUÉS DE CARGAR LOS DATOS
            rvInvestigacionAccidente.RefreshReport();
        }
    }
}