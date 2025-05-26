using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.EmpleadosDAO;

namespace CapaNegocios
{
    public class EmpleadosCN
    {
        EmpleadosDAO empleadosDAO = new EmpleadosDAO();


        public void InsertarEmpleado(EmpleadosCE empleados)
        {
            try
            {
                // Llama al método de la capa de datos para insertar el empleado
                empleadosDAO.InsertarEmpleado(empleados);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public void altaEmpleado(EmpleadosCE empleado)
        {
            try
            {
                empleadosDAO.altaEmpleado(empleado);
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

        public DataTable ObtenerPuestos()
        {
            try
            {
                // Llama al método de la capa de datos para ejecutar el procedimiento almacenado
                return empleadosDAO.consultaGeneral();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public DataTable consultaGeneralInactivos()
        {
            try
            {
                // Llama al método de la capa de datos para ejecutar el procedimiento almacenado
                return empleadosDAO.consultaGeneralInactivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }
        public DataTable consultaGeneralActivo()
        {
            try
            {
                // Llama al método de la capa de datos para ejecutar el procedimiento almacenado
                return empleadosDAO.consultaGeneralActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }


        public (string nombreCompleto, DateTime fecha_nac, char sexo, string nss, string estado_civil, string domicilio, string domicilio_CP, string telefono, char turno, string puesto, int antiguedad, DateTime fecha_ingreso_empresa) consultaIndividual(string numero_nomina)
        {
            if (string.IsNullOrWhiteSpace(numero_nomina))
            {
                throw new Exception("El NSS no puede estar vacío.");
            }

            // Llama a la capa de datos para obtener los valores
            var datos = empleadosDAO.ConsultaIndivisual(numero_nomina);

            if (string.IsNullOrEmpty(datos.nombreCompleto)) // Si no se encontró un empleado
            {
                throw new Exception("No se encontró un empleado con el NSS proporcionado.");
            }

            return datos;  // Devuelve los datos separados
        }

        public (string nombreCompleto, DateTime fecha_nac, char sexo, string nss, string estado_civil, string domicilio_CP,
            string domicilio_estado, string domicilio_ciudad, string domicilio_colonia, string domicilio_calle, string domicilio_numero, string telefono, char turno, DateTime fecha ,string puesto) ConsultaIndivisualActualizar(string numero_nomina)
        {
            if (string.IsNullOrWhiteSpace(numero_nomina))
            {
                throw new Exception("El numero de nomina no puede estar vacío.");
            }

            // Llama a la capa de datos para obtener los valores
            var datos = empleadosDAO.ConsultaIndivisualActualizar(numero_nomina);

            if (string.IsNullOrEmpty(datos.nombreCompleto)) // Si no se encontró un empleado
            {
                throw new Exception("No se encontró un empleado con el numero de nomina proporcionado.");
            }

            return datos;  // Devuelve los datos separados
        }

        public void actualizarEmpleado(EmpleadosCE empleados)
        {
            try
            {
                empleadosDAO.actualizarEmpleado(empleados);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }

        public DataSet ConsultaEmpleadoNumNomina(string numNomina)
        {
            return empleadosDAO.consultaEmpleadoNumNomina(numNomina);
        }

        public DataSet empleadoExiste(string numNomina)
        {
            return empleadosDAO.empleadoExiste(numNomina);
        }
        public void actualizarEmpleadoReingreso(EmpleadosCE empleadosReingreso)
        {
            try
            {
                empleadosDAO.actualizarEmpleadoReingreso(empleadosReingreso);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocios: " + ex.Message);
            }
        }
    }
}
