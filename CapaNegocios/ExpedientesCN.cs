using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public DataSet consultaExpediente(string numExpediente)
        {
            return expedientesDAO.consultaExpediente(numExpediente);
        }

        public DataSet ConcultaNumExpedientes()
        { 
            return expedientesDAO.ConcultaNumExpedientes();
        }
        public int actualizarExpediente(ExpedientesCE expediente)
        {
            return expedientesDAO.ActualizarExpediente(expediente);
        }
        public DataSet verificarExpedienteExiste(string numNomina)
        {
            return expedientesDAO.verificarExpedienteExiste(numNomina);
        }
        public DataSet verificarExpedienteExisteNSS(string nss)
        {
            return expedientesDAO.verificarExpedienteExisteNSS(nss);
        }
        public int actualizarNumExpediente(ExpedientesCE expedientes)
        {
            return expedientesDAO.actualizarNumeroExpediente(expedientes);
        }
        public DataSet CargaDataGridVista()
        {
            return expedientesDAO.CargaDataGridVista();
        }
        public DataSet consultaCamposDinamico(string columnas)
        {
            return expedientesDAO.consultaCamposDinamico(columnas);
        }
    }
}
