using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AccidentesCE
    {
        public int NoAccidente { get; set; }
        public string Condicion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdEmpleado { get; set; }
        public string NumNomina { get; set; }
        public string Puesto { get; set; }
        public string Antiguedad { get; set; }
        public string Edad {  get; set; }
        public string Turno { get; set; }
        public bool TiempoExtra { get; set; }
        public string TotalHrsExtras { get; set; } 
        public DateTime DiaDescansoPrevio { get; set; }
        public string ParteCuerpoAfectada { get; set; }
        public string TrabajoDesempenado { get; set; }
        public string TipoLesion { get; set; }
        public DateTime FechaHoraAccidente { get; set; }
        public string TestigosJson { get; set; }
        public bool Lesion30Dias { get; set; }
        public bool Lesion12Meses { get; set; }
        public string Proceso { get; set; }
        public int IdSeccionA { get; set; }
        public string LugarAccidente { get; set; }
        public string CausanteLesion { get; set; }
        public string EquipoProteccionUsado { get; set; }
        public string EquipoProteccionNecesario { get; set; }
        public string CausaAccidente { get; set; }
        public string DescripcionAccidente { get; set; }
        public bool RealizoTrabajoAntes { get; set; }
        public bool TrabajoHabitual { get; set; }
        public bool TrabajoProgramado { get; set; }
        public bool TrabajoNecesario { get; set; }
        public bool TrabajoUrgente { get; set; }
        public bool DanosMateriales { get; set; }
        public string EquipoDanado { get; set; }
        public string SustituiblePor { get; set; }
        public int IdSeccionB { get; set; }
        public bool ExistenITRs { get; set; }
        public bool EquipoAdecuado { get; set; }
        public bool ConociaTrabajo { get; set; }
        public bool ExistiaSupervision { get; set; } // Corrección de ortografía
        public string RiesgosJson { get; set; }
        public string ActosInsegurosJson { get; set; }
        public string CondicionesInsegurasJson { get; set; }
        public string EmpleadosConocimientoJson { get; set; }
        public string EmpleadosInvolucradosJson { get; set; }
        public bool ContinuaTrabajando { get; set; }
        public bool EnviadoDomicilio { get; set; }
        public bool EnviadoAtencionMedica { get; set; }
        public string Otro { get; set; }
        public string DiagnosticoFinal { get; set; }
        public string Tratamiento { get; set; }
        public string Incapacidad { get; set; }
        public string AccionesCorrectivasPropuestas { get; set; }
        public string QuienCorrectivasPropuesta { get; set; }
        public string CuandoCorrectivasPropuestas { get; set; }
        public string AccionesPreventivasPropuestas { get; set; }
        public string QuienPreventivoPropuesto { get; set; }
        public string CuandoPreventivasPropuestas { get; set; }
        public string Seguimiento { get; set; }
        public DateTime FechaHoraSeguimiento { get; set; }
        public int EmpleadoSeguimiento { get; set; }
        public DateTime FechaHoraRecepcion { get; set; }
    }
}
