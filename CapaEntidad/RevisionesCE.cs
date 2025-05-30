using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class RevisionesCE
    {

        public string codigo { get; set; }

        public string no_revision { get; set;}

        public DateTime fecha_emision { get; set; }

        public DateTime fecha_revision { get; set; }
    }
}
