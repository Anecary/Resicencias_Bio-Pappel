using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EmpleadosCE
    {
        public string NumeroNomina { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno {  get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Turno {  get; set; }
        public int IdPuestoActual { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaIngresoPuesto { get; set; }
        public DateTime FechaIngresoEmpresa { get; set; }
        public char Sexo {  get; set; }
        public string EstadoCivil {  get; set; }
        public string NSS { get; set;}
        public string RFC { get; set;}
        public string DomicilioCalle {  get; set;}
        public string DomicilioNumero { get; set;}
        public string DomicilioColonia { get; set;}
        public string DomicilioCP { get; set;}
        public string DomicilioCiudad { get; set;}
        public string DomicilioEstado {  get; set;}
        public string Telefono {  get; set;}
        public char Estado { get; set;}
    }
}
