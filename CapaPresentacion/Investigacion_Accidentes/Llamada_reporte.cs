using CapaPresentacion.Datas_Sets;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace CapaPresentacion.Investigacion_Accidentes
{
    public partial class Llamada_reporte : Form
    {
        static string cadenaConexion = "Server=localhost;Database=db_sistemaatenquique;User=root;Password=1234; Convert Zero Datetime=True";
        int _numero_accidente;

        public Llamada_reporte(int numero_accidente)
        {
            InitializeComponent();
            _numero_accidente = numero_accidente;
        }

        private void Llamada_reporte_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            // Obtener los datos de ambas consultas
            DataTable revisiones = obtenerDatosRevision();
            DataTable empleados = obtenerDatosEmpleado(_numero_accidente);
            DataTable accidente = obtenerDatosAccdiente(_numero_accidente);
            DataTable testigo = obtenerDatosTestigos(_numero_accidente);
            DataTable riesgos = obtenerRiesgosAccidente(_numero_accidente);
            DataTable secciones = obtenerSeccionAccidentes(_numero_accidente);
            DataTable Acto_inseguro = obtenerActosInseguros(_numero_accidente);
            DataTable condicion_insegura = obtenerCondicionesInseguras(_numero_accidente);
            DataTable persona_conocimiento = obtenerDatosPersonasConocimiento(_numero_accidente);
            DataTable personal_involucrado = obtenerDatosPersonalInvolucrado(_numero_accidente);
            DataTable detalle_accidente = obtenerDetalleAcciones(_numero_accidente);
            DataTable Diagnostico = obtenerDiagnostico(_numero_accidente);

            // Configurar el ReportViewer
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "ejemploreportViewer.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            // Agregar cada DataTable a su propio DataSet en el ReportViewer
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Revisiones", revisiones));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Empleados", empleados));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Accidentes", accidente));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Testigos", testigo));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Riesgos", riesgos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Secciones", secciones));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_ActoInseguro", Acto_inseguro));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_CondicionesInseguras", condicion_insegura));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_persona_conocimiento", persona_conocimiento));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Personal_Involucrado", personal_involucrado));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_DetInv_Accidente_Acciones", detalle_accidente));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Diagnostico", Diagnostico));

            // Refrescar el reporte
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        public static DataTable obtenerDatosRevision()
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT codigo, fecha_emision, fecha_revision, no_revision FROM revisiones;";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }
        public static DataTable obtenerDatosEmpleado(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT e.numero_nomina, e.nombre,  e.apellido_paterno, e.apellido_materno, e.turno,  TIMESTAMPDIFF(YEAR, e.fecha_nacimiento, CURDATE()) AS edad, p.puesto,  TIMESTAMPDIFF(YEAR, e.fecha_ingreso_puesto, CURDATE()) AS años_en_puesto, TIMESTAMPDIFF(MONTH, e.fecha_ingreso_puesto, CURDATE()) % 12 AS meses_en_puesto " +
                    "FROM Investigacion_Accidente ia " +
                    "JOIN empleados e ON ia.idempleado = e.idEmpleado " +
                    "JOIN puestos p ON e.idPuesto_Actual = p.idPuesto " +
                    "WHERE ia.accidente_no = @accidenteID;";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerDatosTestigos(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT ia.idAccidente, t.nombre, t.apellido_paterno, t.apellido_materno " +
                    "FROM detInv_Accidente_Testigos at " +
                    "JOIN empleados t ON at.id_Empleado_Testigo = t.idEmpleado " +
                    "JOIN Investigacion_Accidente ia ON at.idAccidente = ia.idAccidente " +
                    "WHERE ia.accidente_no = @accidenteID;";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerDatosPersonasConocimiento(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT ia.idAccidente, t.nombre, t.apellido_paterno, t.apellido_materno " +
                    "FROM detInv_Accidente_Conocimiento at " +
                    "JOIN empleados t ON at.id_Empleado_Conocimiento = t.idEmpleado " +
                    "JOIN Investigacion_Accidente ia ON at.idAccidente = ia.idAccidente " +
                    "WHERE ia.accidente_no = @accidenteID;";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerDatosPersonalInvolucrado(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT ia.idAccidente, t.nombre, t.apellido_paterno, t.apellido_materno " +
                    "FROM detInv_Accidente_Involucrados at " +
                    "JOIN empleados t ON at.id_Empleado_Involucrado = t.idEmpleado " +
                    "JOIN Investigacion_Accidente ia ON at.idAccidente = ia.idAccidente " +
                    "WHERE ia.accidente_no = @accidenteID;";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerDatosAccdiente(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT accidente_no, condicion,fecha_registro, tiempo_extra, total_hrs_Extras, dia_Descanso_Previo, trabajo_Desempeñado, tipo_Lesion, parte_cuerpo_afectada, " +
                    "accidentes_previos_30_dias ,accidentes_previos_12_meses, " +
                    "proceso,lugar_Accidente, equipo_Proteccion_usado, causa_Lesion, equipo_Proteccion_Necesario, danosMateriales, pieza_equipo_danada ,sustituiblePor ,trabajo_Realizado_Antes, trabajo_Habitual, trabajo_Programado, trabajo_Necesario, trabajo_Urgente," +
                    "descripcion_accidente,causas_basicas_accidente," +
                    "otro_Riesgo, otro_Acto_Inseguro, Otra_Condicion__Insegura," +
                    "ITRS_Trabajo, herramienta_equipo_adecuado, ubicacion_conocida, supervision," +
                    "fecha_Hora_Accidente, " +
                    "CASE DAYOFWEEK(fecha_Hora_Accidente) " +
                    "WHEN 1 THEN 'Domingo' " +
                    "WHEN 2 THEN 'Lunes' " +
                    "WHEN 3 THEN 'Martes' " +
                    "WHEN 4 THEN 'Miércoles' " +
                    "WHEN 5 THEN 'Jueves' " +
                    "WHEN 6 THEN 'Viernes' " +
                    "WHEN 7 THEN 'Sábado' END AS dia_semana " +  // <-- Espacio agregado antes de "FROM"
                    "FROM Investigacion_Accidente " +
                    "WHERE Investigacion_Accidente.accidente_no = @accidenteID;";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerSeccionAccidentes(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT  s1.seccion AS seccion_A,  s2.seccion AS seccion_B " +
                    "FROM Investigacion_Accidente ia " +
                    "LEFT JOIN secciones s1 ON s1.idSeccion = ia.idSeccion_A " +
                    "LEFT JOIN secciones s2 ON s2.idSeccion = ia.idSeccion_B " +
                    "WHERE ia.accidente_no = @accidenteID";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerDetalleAcciones(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT " +
                  "da.idAccidente, " +
                  "da.acciones_Correctivas_prop, " +
                  "da.quien_accionesC, " +
                  "da.quien_accionesP, " +
                  "da.cuando_accionesC, " +
                  "da.cuando_accionesP, " +
                  "da.seguimiento, " +
                  "da.fecha_hora_Cierre_Acc_Seg, " +
                  "da.acciones_preventivas_prop,  " +
                  "CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', e.apellido_materno) AS empleado " +  // <--- Espacio agregado aquí
                  "FROM DetInv_Accidente_Acciones da " +
                  "LEFT JOIN empleados e " +
                  "ON da.idEmpleadoProcesoSST = e.idEmpleado " +
                  "WHERE da.accidente_no = @accidenteID;";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerDiagnostico(int accidenteID)
        {
            DataTable tabla = new DataTable();

            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT continua_trabajando, enviado_Domicilio, atencion_Medica, otro_diagnostico, diagnostico_final, tratamiento, incapacidad, fecha_Recepcion_Documento from investigacion_accidente WHERE accidente_no = @accidenteID;";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var adaptador = new MySqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable obtenerRiesgosAccidente(int accidenteID)
        {

            // Definir columnas con los nombres EXACTOS que usaste en el RDLC
            Dictionary<string, string> riesgos = new Dictionary<string, string>
            {
                { "Explosión", "Explosión" },
                { "Golpe contra y por objeto", "Golpe" },
                { "Contacto, inhalación, absorción o ingestión de sustancias químicas, tóxicas o corrosivas", "Quimicos" },
                { "Causada por personas", "CausadoPersona" },
                { "Contacto con corriente eléctrica", "Electrocución" },
                { "Proyección de fragmentos o partículas", "Proyección" },
                { "Atropello/ choque por vehículo", "Atropello" },
                { "Sobre esfuerzo/ tensión excesiva/ sobrecarga", "SobreEsfuerzo" },
                { "Contacto con altas temperaturas", "AltasTemperaturas" },
                { "Heridas, cortadas por herramientas/ objetos con filo", "Cortadas" },
                { "Incendio", "Incendio" },
                { "Por caída de objeto", "CaídaObjeto" },
                { "Atrapado por/ entre", "Atrapado" },
                { "Caída al mismo nivel", "CaídaMismoNivel" },
                { "Caída a diferente nivel", "CaídaDiferenteNivel" }
            };

            // Crear DataTable con nombres de RDLC
            DataTable tabla = new DataTable();
            foreach (var riesgo in riesgos.Values)
            {
                tabla.Columns.Add(riesgo, typeof(bool));
            }

            // Crear fila con valores por defecto (false)
            DataRow fila = tabla.NewRow();
            foreach (var riesgo in riesgos.Values)
            {
                fila[riesgo] = false;
            }

            // Consultar la base de datos
            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT r.riesgo FROM detInv_Accidente_Riesgo dar " +
                                  "JOIN riesgos r ON dar.idRiesgo = r.idRiesgo " +
                                  "WHERE dar.accidente_no = @accidenteID;";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string riesgoNombre = lector.GetString(0);

                            // Si el riesgo está en el diccionario, convertirlo al nombre en RDLC
                            if (riesgos.ContainsKey(riesgoNombre))
                            {
                                string nombreRDLC = riesgos[riesgoNombre];
                                fila[nombreRDLC] = true;
                            }
                        }
                    }
                }
            }

            // Agregar la fila al DataTable
            tabla.Rows.Add(fila);
            return tabla;
        }

        public static DataTable obtenerActosInseguros(int accidenteID)
        {
            // Diccionario con los nombres exactos usados en el RDLC
            Dictionary<string, string> actosInseguros = new Dictionary<string, string>
            {
                { "No usar equipo de protección", "No_Proteccion" },
                { "Hacer inoperantes los dispositivos de seguridad", "Dispositivos_Seguridad" },
                { "Reparar equipo vivo o en movimiento", "Reparar_Equipo" },
                { "Adoptar posiciones o actividades inseguras", "Posiciones_Inseguras" },
                { "Ninguno", "Ninguno" },
                { "Operar sin autorización", "Operar_Sin_Autorisacion" },
                { "Uso indebido de equipo", "Mal_Uso" },
                { "Operar a velocidad inadecuada", "Velocidad" },
                { "Manejo inadecuado de materiales", "Materiales" }
            };

            // Crear DataTable con nombres de RDLC
            DataTable tabla = new DataTable();
            foreach (var acto in actosInseguros.Values)
            {
                tabla.Columns.Add(acto, typeof(bool));
            }

            // Crear fila con valores por defecto (false)
            DataRow fila = tabla.NewRow();
            foreach (var acto in actosInseguros.Values)
            {
                fila[acto] = false;
            }

            // Consultar la base de datos
            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT a.acto_Inseguro  " +
                    "FROM detInv_Accidente_ActInseguro da " +
                    "JOIN actos_Inseguros a ON da.idActo_Inseguro = a.idActo_Inseguro " +
                    "WHERE da.accidente_no = @accidenteID;";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string actoNombre = lector.GetString(0);

                            // Si el acto inseguro está en el diccionario, convertirlo al nombre en RDLC
                            if (actosInseguros.ContainsKey(actoNombre))
                            {
                                string nombreRDLC = actosInseguros[actoNombre];
                                fila[nombreRDLC] = true;
                            }
                        }
                    }
                }
            }

            // Agregar la fila al DataTable
            tabla.Rows.Add(fila);
            return tabla;
        }

        public static DataTable obtenerCondicionesInseguras(int accidenteID)
        {
            // Diccionario con los nombres exactos usados en el RDLC
            Dictionary<string, string> actosInseguros = new Dictionary<string, string>
            {
                { "Derrame de productos", "Derrame" },
                { "Ausencia de anuncios preventivos", "Anuncios" },
                { "Iluminación o ventilación inapropiado", "Ventilacion" },
                { "Dispositivos de seguridad inapropiados", "Dispositivos" },
                { "Ninguna", "Ninguna" },
                { "Ropa, accesorios inapropiados", "Ropa" },
                { "Materiales dispersos", "Materiales" },
                { "Condiciones mecánicas o físicas inapropiadas", "Mecanicas" }
            };

            // Crear DataTable con nombres de RDLC
            DataTable tabla = new DataTable();
            foreach (var acto in actosInseguros.Values)
            {
                tabla.Columns.Add(acto, typeof(bool));
            }

            // Crear fila con valores por defecto (false)
            DataRow fila = tabla.NewRow();
            foreach (var acto in actosInseguros.Values)
            {
                fila[acto] = false;
            }

            // Consultar la base de datos
            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT c.condicion_insegura  " +
                    "FROM detInv_Accidente_CondInsegura co " +
                    "JOIN condiciones_inseguras c ON co.idCondicion_insegura = c.idCondicion_insegura " +
                    "WHERE co.accidente_no = @accidenteID;";

                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@accidenteID", accidenteID);
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string actoNombre = lector.GetString(0);

                            // Si el acto inseguro está en el diccionario, convertirlo al nombre en RDLC
                            if (actosInseguros.ContainsKey(actoNombre))
                            {
                                string nombreRDLC = actosInseguros[actoNombre];
                                fila[nombreRDLC] = true;
                            }
                        }
                    }
                }
            }

            // Agregar la fila al DataTable
            tabla.Rows.Add(fila);
            return tabla;
        }
    }
}
