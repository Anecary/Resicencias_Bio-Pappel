using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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



        public DataSet ObtenerNumConsultasMesPasado()
        {
            return homeDAO.ObtenerNumConsultasMesPasado();
        }
        public DataSet ObtenerNumAccidentesMesPasado()
        {
            return homeDAO.ObtenerNumAccidentesMesPasado();
        }
        public DataSet ObtenerNumIncapacidadesMesPasado()
        {
            return homeDAO.ObtenerNumIncapacidadesMesPasado();
        }
        public DataSet ObtenerCausasMasFrecuentesMesPasado()
        {
            return homeDAO.ObtenerCausasMasFrecuentesMesPasado();
        }
        public DataSet ObtenerAccidentesTurnoMesPasado()
        {
            return homeDAO.ObtenerAccidentesTurnoMesPasado();
        }
        public DataSet ObtenerSeccionesConIncidentesMesPasado()
        {
            return homeDAO.ObtenerSeccionesConIncidentesMesPasado();
        }






        public DataSet ObtenerAccidentesTurnoPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            return homeDAO.ObtenerAccidentesTurnoPorRango(fechaInicio, fechaFin);
        }
        public DataSet ObtenerTotalConsultasPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            return homeDAO.ObtenerTotalConsultasPorRango(fechaInicio, fechaFin);
        }

        public DataSet ObtenerNumAccidentesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            return homeDAO.ObtenerNumAccidentesPorRango(fechaInicio, fechaFin);
        }
        public DataSet ObtenerNumIncapacidadesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            return homeDAO.ObtenerNumIncapacidadesPorRango(fechaInicio, fechaFin);
        }
        public DataSet ObtenerSeccionesConIncidentesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            return homeDAO.ObtenerSeccionesConIncidentesPorRango(fechaInicio,fechaFin); 
        }
        public DataSet ObtenerCausasMasFrecuentesPorRango(DateTime fechaInicio, DateTime fechaFin)
        {
            return homeDAO.ObtenerCausasMasFrecuentesPorRango(fechaInicio, fechaFin);
        }
    }
}
