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

        public int ObtenerUltimoId(string nombreTabla, string nombreColumnaId)
        {
            try
            {
                // Obtén el último ID desde la capa de datos
                int ultimoId = puestosDAO.ObtenerUltimoIdInsertado(nombreTabla, nombreColumnaId);

                // Suma 1 al último ID
                int siguienteId = ultimoId + 1;

                return siguienteId;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public DataTable ObtenerPuestos()
        {
            try
            {
                // Llama al método de la capa de datos para ejecutar el procedimiento almacenado
                return puestosDAO.ConsultaGeneral("ObtenerPuestos");
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public void InsertarPuesto(string puesto)
        {
            try
            {
                // Llama al método de la capa de datos para insertar el puesto
                puestosDAO.InsertarPuesto(puesto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public List<string> ObtenerNombresPuestos()
        {
            return puestosDAO.ObtenerNombresPuestos();
        }

        public int ObtenerIdPuestoPorNombre(string nombrePuesto)
        {
            return puestosDAO.ObtenerIdPuestoPorNombre(nombrePuesto);
        }
    }
}
