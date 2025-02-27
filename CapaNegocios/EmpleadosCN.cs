using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.EmpleadosDAO;

namespace CapaNegocios
{
    public class EmpleadosCN
    {
        EmpleadosDAO empleadosDAO = new EmpleadosDAO();


        public void InsertarEmpleado(
           string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento,
           char sexo, string estadoCivil, string nss, string rfc, string domicilioCalle,
           int domicilioNumero, string domicilioColonia, string domicilioCP, string domicilioCiudad,
           string domicilioEstado, string telefono)
        {
            try
            {
                // Llama al método de la capa de datos para insertar el empleado
                empleadosDAO.InsertarEmpleado(
                    nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, sexo,
                    estadoCivil, nss, rfc, domicilioCalle, domicilioNumero,
                    domicilioColonia, domicilioCP, domicilioCiudad, domicilioEstado, telefono);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public (string nombreCompleto, string telefono, string domicilio, string estado) ObtenerEmpleadoPorNSS(string nss)
        {
            if (string.IsNullOrWhiteSpace(nss))
            {
                throw new Exception("El NSS no puede estar vacío.");
            }

            // Llama a la capa de datos para obtener los valores
            var datos = empleadosDAO.BusquedaParaActualizar(nss);

            if (string.IsNullOrEmpty(datos.nombreCompleto)) // Si no se encontró un empleado
            {
                throw new Exception("No se encontró un empleado con el NSS proporcionado.");
            }

            return datos;  // Devuelve los datos separados
        }
    }
}
