using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class AccidentesCN
    {
        AccidentesDAO accidentesDAO = new AccidentesDAO();
        public int InsertarAccidente(AccidentesCE accidentes)
        {
            return accidentesDAO.InsertarAccidente(accidentes);
        }
        //public int InsertarAccidente(int noAccidente, string condicion, DateTime fechaRegistro, int idEmpleado, string numNomina, string puesto, string antiguedad, string edad, string turno, Boolean tiempoExtra, string totalHrsExtras, DateTime DiaDescansoPrevio, string parteCuerpoAfectada, string trabajoDesempeñado, string tipoLesion, DateTime fecha_hora_Accidente,
        //    Boolean lesion30Dias, Boolean lesion12Meses, string proceso, int idSeccionA, string lugarAccidente, string causanteLesion, string equipoProteccionUsado, string equipoProteccionNecesario, string causaAccidente, string descripcionAccidente, Boolean realizoTrabajoAntes, Boolean trabajoHabitual, Boolean trabajoProgramado, Boolean trabajoNecesario, Boolean trabajoUrgente, Boolean danosMateriales, string equipoDanado, string sustituiblePor, int idSeccionB,
        //    Boolean existenITRs, Boolean equipoAdecuado, Boolean conociaTrabajo, Boolean existiaSupervicion, string riesgosJson, string actosInsegurosJson, string condicionesInsegurasJson,
        //    string empleadosConocimientoJson, string empleadosInvolucradosJson, Boolean continuaTrabajando, Boolean enviadoDomicilio, Boolean enviadoAtencionMedica, string otro,string diagnosticoFinal, string tratamiento,string incapacidad,
        //    string accionesCorrectivasPropuestas, string quienCorrectivasPropuesta, string cuandoCorrectivasPropuestas, string accionesPreventivasPropuestas, string quienPreventivoPropuesto, string cuandoPreventivasPropuestas, string seguimiento, DateTime fecha_Hora_Seguimiento, int empleadoSeguimiento, DateTime fecha_Hora_recepcion,
        //    string testigosJson)
        //{
        //    return accidentesDAO.InsertarAccidente(noAccidente, condicion, fechaRegistro, idEmpleado, numNomina, puesto, antiguedad, edad, turno, tiempoExtra, totalHrsExtras, DiaDescansoPrevio, parteCuerpoAfectada, trabajoDesempeñado, tipoLesion, fecha_hora_Accidente,
        //        lesion30Dias, lesion12Meses, proceso, idSeccionA, lugarAccidente, causanteLesion, equipoProteccionUsado, equipoProteccionNecesario, causaAccidente, descripcionAccidente, realizoTrabajoAntes, trabajoHabitual, trabajoProgramado, trabajoNecesario, trabajoUrgente, danosMateriales, equipoDanado, sustituiblePor, idSeccionB,
        //        existenITRs, equipoAdecuado, conociaTrabajo, existiaSupervicion, riesgosJson, actosInsegurosJson, condicionesInsegurasJson,
        //        empleadosConocimientoJson, empleadosInvolucradosJson, continuaTrabajando, enviadoDomicilio, enviadoAtencionMedica, otro, diagnosticoFinal, tratamiento, incapacidad,
        //        accionesCorrectivasPropuestas, quienCorrectivasPropuesta, cuandoCorrectivasPropuestas, accionesPreventivasPropuestas, quienPreventivoPropuesto, cuandoPreventivasPropuestas, seguimiento, fecha_Hora_Seguimiento, empleadoSeguimiento, fecha_Hora_recepcion,
        //         testigosJson);
        //}

        public DataSet ConcultaRiesgos()
        {
            return accidentesDAO.ConcultaRiesgos();
        }
        public DataSet ConcultaActosInseguros()
        { 
            return accidentesDAO.ConcultaActosInseguros();
        }
        public DataSet ConcultaCondicionesInseguras()
        {
            return accidentesDAO.ConcultaCondicionesInseguras();
        }
        public int InsertaNuevoRiesgo(string nuevoRiesgo)
        {
            return accidentesDAO.InsertaNuevoRiesgo(nuevoRiesgo);
        }
        public int InsertaNuevoActoInseguro(string nuevoActoInseguro)
        {
            return accidentesDAO.InsertaNuevoActoInseguro(nuevoActoInseguro);
        }
        public int InsertaNuevaCondicionInsegura(string nuevaCondicionInsegura)
        {
            return accidentesDAO.InsertaNuevaCondicionInsegura(nuevaCondicionInsegura);
        }
        public bool VerificarRiesgoExiste(string riesgo)
        {
            return accidentesDAO.VerificarRiesgoExiste(riesgo);
        }
        public bool VerificarCondicionInseguraExiste(string condicionInsegura)
        {
            return accidentesDAO.VerificarCondicionInseguraExiste(condicionInsegura);
        }
        public bool VerificarActoInseguroExiste(string actoInseguro)
        {
            return accidentesDAO.VerificarActoInseguroExiste(actoInseguro);
        }

        public DataSet consultaFechasAccidentesPorEmpleado(int idEmpleado)
        {
            return accidentesDAO.consultaFechasAccidentesPorEmpleado(idEmpleado);   
        }
        public DataSet consultarDetalleInvAccidente_ActosInseguros(int idAccidente)
        {
            return accidentesDAO.consultarDetalleInvAccidente_ActosInseguros(idAccidente);
        }
        public DataSet consultarDetalleInvAccidente_CondicionesInseguras(int idAccidente)
        {
            return accidentesDAO.consultarDetalleInvAccidente_CondicionesInseguras (idAccidente);
        }
        public DataSet consultarDetalleInvAccidente_Riesgos(int idAccidente)
        {
            return accidentesDAO.consultarDetalleInvAccidente_Riesgos (idAccidente);
        }
        public DataSet consultarDetalleInvAccidente_EmpleadosConocimiento(int idAccidente)
        {
            return accidentesDAO.consultarDetalleInvAccidente_EmpleadosConocimiento (idAccidente);  
        }
        public DataSet consultarDetalleInvAccidente_EmpleadosInvolucrados(int idAccidente)
        {
            return accidentesDAO.consultarDetalleInvAccidente_EmpleadosInvolucrados (idAccidente);
        }
        public DataSet consultarDetalleInvAccidente_EmpleadosTestigos(int idAccidente)
        {
            return accidentesDAO.consultarDetalleInvAccidente_EmpleadosTestigos (idAccidente);
        }
        public DataSet consultarInvAccidentePorID(int idAccidente)
        {
            return accidentesDAO.consultarInvAccidentePorID (idAccidente);
        }
        public DataSet consultarInvAccidentesAcciones(int idAccidente)
        {
            return accidentesDAO.consultarInvAccidentesAcciones (idAccidente);
        }
        public DataTable ObtenerReporteAccidentesBLL(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentesPS(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_Secciones(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }
        public DataTable ObtenerReporteAccidentesSemana(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_Semana(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_ParteCuerpo(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_parteCuerpo(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_Turno(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_Turno(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_Tlesion(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_TLesion(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_IncapDeto(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_IncapDepto(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_Condicionn(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_Condicion(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_Eda(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_Edad(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_Debido(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_DebidoA(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteAccidentes_Clasificacion(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = accidentesDAO.ObtenerReporteAccidentes_Clasificacion(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }
    }
}
