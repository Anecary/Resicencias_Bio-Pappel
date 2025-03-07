using CapaDatos;
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
        public int InsertarAccidente(int noAccidente, string condicion, DateTime fechaRegistro, Boolean tiempoExtra, string totalHrsExtras, DateTime DiaDescansoPrevio, string parteCuerpoAfectada, string trabajoDesempeñado, string tipoLesion, DateTime fecha_hora_Accidente,
            Boolean lesion30Dias, Boolean lesion12Meses, string proceso, int idSeccionA, string lugarAccidente, string causanteLesion, string equipoProteccionUsado, string equipoProteccionNecesario, string causaAccidente, string descripcionAccidente, Boolean realizoTrabajoAntes, Boolean trabajoHabitual, Boolean trabajoProgramado, Boolean trabajoNecesario, Boolean trabajoUrgente, Boolean danosMateriales, string equipoDanado, string sustituiblePor, int idSeccionB,
            Boolean existenITRs, Boolean equipoAdecuado, Boolean conociaTrabajo, Boolean existiaSupervicion, string riesgosJson, string actosInsegurosJson, string condicionesInsegurasJson,
            string empleadosConocimientoJson, string empleadosInvolucradosJson, Boolean continuaTrabajando, Boolean enviadoDomicilio, Boolean enviadoAtencionMedica, string otro,string diagnosticoFinal, string tratamiento,string incapacidad,
            string accionesCorrectivasPropuestas, string quienCorrectivasPropuesta, string cuandoCorrectivasPropuestas, string accionesPreventivasPropuestas, string quienPreventivoPropuesto, string cuandoPreventivasPropuestas, string seguimiento, DateTime fecha_Hora_Seguimiento, int empleadoSeguimiento, DateTime fecha_Hora_recepcion,
           int idEmpleado, int idPuesto,  string testigosJson)
        {
            return accidentesDAO.InsertarAccidente(noAccidente, condicion, fechaRegistro, tiempoExtra, totalHrsExtras, DiaDescansoPrevio, parteCuerpoAfectada, trabajoDesempeñado, tipoLesion, fecha_hora_Accidente,
                lesion30Dias, lesion12Meses, proceso, idSeccionA, lugarAccidente, causanteLesion, equipoProteccionUsado, equipoProteccionNecesario, causaAccidente, descripcionAccidente, realizoTrabajoAntes, trabajoHabitual, trabajoProgramado, trabajoNecesario, trabajoUrgente, danosMateriales, equipoDanado, sustituiblePor, idSeccionB,
                existenITRs, equipoAdecuado, conociaTrabajo, existiaSupervicion, riesgosJson, actosInsegurosJson, condicionesInsegurasJson,
                empleadosConocimientoJson, empleadosInvolucradosJson, continuaTrabajando, enviadoDomicilio, enviadoAtencionMedica, otro, diagnosticoFinal, tratamiento, incapacidad,
                accionesCorrectivasPropuestas, quienCorrectivasPropuesta, cuandoCorrectivasPropuestas, accionesPreventivasPropuestas, quienPreventivoPropuesto, cuandoPreventivasPropuestas, seguimiento, fecha_Hora_Seguimiento, empleadoSeguimiento, fecha_Hora_recepcion,
                idEmpleado, idPuesto, testigosJson);
        }

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

    }
}
