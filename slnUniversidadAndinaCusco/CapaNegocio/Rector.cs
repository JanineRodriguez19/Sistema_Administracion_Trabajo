using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private int añosExperiencia;
        private string gradoAcademico;
        private string profesion;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int AñosExperiencia
        {
            get { return añosExperiencia; }
            set { añosExperiencia = value; }
        }
        public string GradoAcademico
        {
            get { return gradoAcademico; }
            set { gradoAcademico = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        public string Motivar()
        {
            return "No se ha implementado el método Motivar";
        }
        public string Planear()
        {
            return "No se ha implementado el método Planear";
        }
        public string DarSoluciones()
        {
            return "No se ha implementado el método Dar Soluciones";
        }
    }
}
