using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class PuestosCN
    {
        private PuestosDAO puestosDAO = new PuestosDAO();

        public DataSet SubePuestos()
        {
            return puestosDAO.SubePuestos();
        }
    }
}
