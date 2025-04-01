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

        public DataSet consultaExpMedico(string numExpediente)
        {
            return consultaMedicaDAO.consultarExpMedico(numExpediente);
        }

        public bool InsertarConsultaMedica(ConsultaMedica consulta)
        {
            return consultaMedicaDAO.InsertarConsultaMedica(
                consulta.NumExpediente,
                consulta.Fecha,
                consulta.Observaciones,
                consulta.Diagnostico,
                consulta.Proceso,
                consulta.IdTipoCausa
            );
        }
    }
}
