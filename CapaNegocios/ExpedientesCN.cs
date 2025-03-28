using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ExpedientesCN
    {
        ExpedientesDAO expedientesDAO = new ExpedientesDAO();

        public int insertarExpediente(ExpedientesCE expedientes)
        {
            return expedientesDAO.InsertarExpediente(expedientes);
        }
    }
}
