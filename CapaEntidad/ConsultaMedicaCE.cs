using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ConsultaMedica
    {
        public int IdEmpleado {  get; set; }
        public int IdConsulta { get; set; }
        public string NumExpediente { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public string Diagnostico { get; set; }
        public string Proceso { get; set; }
        public int IdTipoCausa { get; set; }
    }
}
