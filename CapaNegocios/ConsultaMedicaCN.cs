using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class ConsultaMedicaCN
    {
        ConsultaMedicaDAO consultaMedicaDAO = new ConsultaMedicaDAO();

        public DataSet consultaCausas()
        {
            return consultaMedicaDAO.consultaCausas();
        }

        public DataSet consultaTipoCausa(int idCausa)
        {
            return consultaMedicaDAO.consultaTipoCausa(idCausa);
        }

        public DataSet consultaNotaGeneral(string numExpediente)
        {
            return consultaMedicaDAO.consultaNotaGeneral(numExpediente);
        }

        public DataSet consultaNotaNSS(string nss)
        {
            return consultaMedicaDAO.consultaNotaNSS(nss);
        }

        public DataSet consultaExpMedico(string numExpediente)
        {
            return consultaMedicaDAO.consultarExpMedico(numExpediente);
        }

        public DataSet consultaNotaIndividual(int idConsulta)
        {
            return consultaMedicaDAO.consultaNotaIndividual(idConsulta);
        }

        public DataSet consultaEmpleadoNota(string nss)
        {
            return consultaMedicaDAO.consultaEmpleadoNota(nss);
        }

        public bool InsertarConsultaMedica(ConsultaMedica consulta)
        {
            return consultaMedicaDAO.InsertarConsultaMedica(
                consulta.IdEmpleado,
                consulta.NumExpediente,
                consulta.Fecha,
                consulta.Observaciones,
                consulta.Diagnostico,
                consulta.Proceso,
                consulta.IdTipoCausa
            );
        }

        public bool InsertarConsultaMedicaSin(ConsultaMedica consulta)
        {
            return consultaMedicaDAO.InsertarConsultaMedicaSin(
                consulta.IdEmpleado,
                consulta.Fecha,
                consulta.Observaciones,
                consulta.Diagnostico,
                consulta.IdTipoCausa
            );
        }
    }
}
