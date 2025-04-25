using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class HomeCN
    {
        HomeDAO homeDAO = new HomeDAO();

        public DataSet ConcultaNumTrabajadores()
        {
            return homeDAO.ConcultaNumTrabajadores();
        }
        public DataSet ObtenerNumConsultas()
        {
            return homeDAO.ObtenerNumConsultas();
        }
        public DataSet ObtenerNumAccidentes()
        {
            return homeDAO.ObtenerNumAccidentes();
        }
        public DataSet ObtenerNumIncapacidades()
        {
            return homeDAO.ObtenerNumIncapacidades();
        }
        public DataSet ObtenerCausasMasFrecuentes()
        {
            return homeDAO.ObtenerCausasMasFrecuentes();
        }
        public DataSet ObtenerAccidentesTurno()
        { 
            return homeDAO.ObtenerAccidentesTurno();
        }
        public DataSet ObtenerSeccionesConIncidentes()
        {
            return homeDAO.ObtenerSeccionesConIncidentes();
        }
    }
}
