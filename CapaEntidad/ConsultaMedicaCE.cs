using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ConsultaMedica
    {
        public int IdEmpleado {  get; set; }       // p_idEmpleado
        public string NumExpediente { get; set; }  // p_numExpediente
        public DateTime Fecha { get; set; }        // p_fecha
        public string Observaciones { get; set; }  // p_observaciones
        public string Diagnostico { get; set; }    // p_diagnostico
        public string Proceso { get; set; }        // p_proceso
        public int IdTipoCausa { get; set; }       // p_idTipoCausa
    }
}
