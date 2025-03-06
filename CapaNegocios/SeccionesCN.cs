using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class SeccionesCN
    {
        private SeccionesDAO seccionDAO = new SeccionesDAO();

        public int ObtenerUltimoId(string nombreTabla, string nombreColumnaId)
        {
            try
            {
                // Obtén el último ID desde la capa de datos
                int ultimoId = seccionDAO.ObtenerUltimoIdInsertado(nombreTabla, nombreColumnaId);

                // Suma 1 al último ID
                int siguienteId = ultimoId + 1;

                return siguienteId;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public DataTable ObtenerSecciones()
        {
            try
            {
                // Llama al método de la capa de datos para ejecutar el procedimiento almacenado
                return seccionDAO.ConsultaGeneral("ObtenerSecciones");
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public void InsertarSecciones(string seccion)
        {
            try
            {
                // Llama al método de la capa de datos para insertar el puesto
                seccionDAO.InsertarSeccion(seccion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }
        public DataSet ConcultaGeneral2()
        {
            return seccionDAO.ConcultaGeneral2();
        }
    }
}
