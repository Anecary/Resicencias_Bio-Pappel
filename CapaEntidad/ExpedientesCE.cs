using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ExpedientesCE
    {
        public string NumExpediente {  get; set; }
        public int IdEmpleado {  get; set; }
        public string NumNomina { get; set; }
        public DateTime FechaApertura { get; set; }
        public string HeredoFamiliar {  get; set; }
        public string DiagnosticoInicial {  get; set; }
        public string Casa { get; set; }
        public string Alimentacion { get; set; }
        public string Animales { get; set; }
        public string Inmunizaciones {  get; set; }
        public string Toxicomanias {  get; set; }
        public string TrabajoActividadesAnteriores { get; set;}
        public string Deportes { get; set; }
        public string EntornoFamiliar { get; set;}
        public string Escolaridad { get; set; }



        public bool Hospitalizaciones { get; set; }
        public bool Cirugias { get; set;}
        public bool Transfusiones { get; set; }
        public string Alergias { get; set; }



        public string SistemaNerviosoCentral { get; set; }
        public string SistemaCardiovascular { get; set; }
        public string SistemaRespiratorio { get; set; }
        public string SistemaGastrointestinal { get; set; }
        public string SistemaEndocrinico { get; set; }
        public string SistemaGenitourinario { get; set; }
        public string SistemaMusculoesqueletico { get; set; }
        public string OrganoSentidos { get; set; }
        public string GinecoObstetricos {  get; set; }
        public string GrupoSanguineo { get; set; }


        public string EstudiosLaboratorio { get; set; }
        public string EstudiosRadiologicos { get; set; }
        public string Otros { get; set; }


        public string Constitucion_Fisica { get; set; }
        public double Talla {  get; set; }
        public double Peso {  get; set; }
        public double IMC {  get; set; }
        public string Grado { get; set; }
        public double Fc {  get; set; }
        public double Fr {  get; set; }
        public int Pulso { get; set; }
        public string Ta { get; set; }
        public double Temperatura { get; set; }



        public string Craneo { get; set; }
        public string Ojos { get; set; }
        public string Oidos { get; set; }
        public string Nariz { get; set; }
        public string Boca { get; set; }
        public string Cuello { get; set; }
        public string Torax { get; set; }
        public string Abdomen { get; set; }
        public string Genitourinario { get; set; }
        public string MusculoEsqueletico { get; set; }
        public string Neurologico { get; set; }




        public DateTime UltimaActualizacion { get; set; }
    }
}
