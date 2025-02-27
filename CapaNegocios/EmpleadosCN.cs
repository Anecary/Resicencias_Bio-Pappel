using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class EmpleadosCN
    {
        EmpleadosDAO EmpleadosDAO = new EmpleadosDAO();


        public void InsertarEmpleado(
           string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento,
           char sexo, string estadoCivil, string nss, string rfc, string domicilioCalle,
           int domicilioNumero, string domicilioColonia, string domicilioCP, string domicilioCiudad,
           string domicilioEstado, string telefono)
        {
            try
            {
                // Llama al método de la capa de datos para insertar el empleado
                EmpleadosDAO.InsertarEmpleado(
                    nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, sexo,
                    estadoCivil, nss, rfc, domicilioCalle, domicilioNumero,
                    domicilioColonia, domicilioCP, domicilioCiudad, domicilioEstado, telefono);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

    }
}
