using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        // Atributos
        private string nombreAsignatura;
        private string aula;
        private int horas;
        private string docente;
        private string tipo;

        // Propiedades
        public string NombreAsignatura
        {
            get { return nombreAsignatura; }
            set { nombreAsignatura = value; }
        }
        public string Aula
        { 
            get { return aula; }
            set { aula = value; }
        }
        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        //Metodos
        public string Aprender()
        {
            return "No se ha implementado el método Aprender";
        }
        public string Clasificar()
        {
            return "No se ha impelmetado el método Clasificar";
        }
    }
}
