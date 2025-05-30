using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.RevisionesDAO;

namespace CapaNegocios
{
    
    public class RevisionesCN
    {
        RevisionesDAO reviosnesDAO = new RevisionesDAO();

        public DataTable consultaGeneralRevisiones() 
        {
            DataTable dataTable = reviosnesDAO.consultaGeneralRevisiones();

            return dataTable;
        }

        public int insertarRevision(RevisionesCE revisiones)
        {
            return reviosnesDAO.InsertarRevision(revisiones);
        }
    }
}
