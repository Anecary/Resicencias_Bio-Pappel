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

        public DataSet consultaNotaNull(int idEmpleado)
        {
            return consultaMedicaDAO.consultaNotaNull(idEmpleado);
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
            return consultaMedicaDAO.InsertarConsultaMedica(consulta);
        }

        public bool InsertarConsultaMedicaSin(ConsultaMedica consulta)
        {
            return consultaMedicaDAO.InsertarConsultaMedicaSin(consulta);
        }

        public bool ActualizarNumExpediente(ConsultaMedica consulta)
        {
            return consultaMedicaDAO.ActualizarNumExpediente(
                consulta.IdConsulta,
                consulta.NumExpediente
            );
        }

        public DataTable ObtenerReporteNotaMedica_Causas(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = consultaMedicaDAO.ObtenerReporteNotaMedica_Causas(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteNotaMedica_diaSemana(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = consultaMedicaDAO.ObtenerReporteNotaMedica_diaSemana(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteNotaMedica_Proceso(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = consultaMedicaDAO.ObtenerReporteNotaMedica_Proceso(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteNotaMedica_Hora(int año)
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = consultaMedicaDAO.ObtenerReporteNotaMedica_Hora(año);

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }

        public DataTable ObtenerReporteNotaMedica_Año()
        {
            // Llama al método de la capa de datos.
            DataTable dtReporte = consultaMedicaDAO.ObtenerReporteNotaMedica_Año();

            // Aquí podrías realizar validaciones o transformaciones si es necesario.

            return dtReporte;
        }
    }
}
