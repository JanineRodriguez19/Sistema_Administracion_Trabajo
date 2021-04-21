using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ppp
    {
        private string carrera;
        private string practicante;
        private string celular;
        private DateTime fechaInicio;
        private string empresa;
        private string areaTrabajo;
        private string asesor;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Practicante
        {
            get { return practicante; }
            set { practicante = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string AreaTrabajo
        {
            get { return areaTrabajo; }
            set {areaTrabajo = value; }
        }
        public string Asesor
        {
            get { return asesor; }
            set { asesor = value; }
        }
        
        public string Clasificar()
        {
            return "No se ha implementado el método Clasificar";
        }
        public string Formar()
        {
            return "No se ha implementado el método Formar";
        }
        public string MostrarResultados()
        {
            return "No se ha implementado el método Mostrar Resultados";
        }
    }
}
