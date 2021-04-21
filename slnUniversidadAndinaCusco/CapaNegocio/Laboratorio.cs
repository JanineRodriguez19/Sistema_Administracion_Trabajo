using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //Atributos
        private string instrumentos;
        private string asignatura;
        private string aforo;
        private DateTime horario;
        private string aula;
        private string docente;

        //Propiedades
        public string Instrumentos
        {
            get { return instrumentos; }
            set { instrumentos = value; }
        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        public string Aforo
        {
            get { return aforo; }
            set { aforo = value; }
        }
        public DateTime Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }

        //Métodos u operaciones
        public string Experimentar()
        {
            return "No se ha implementado el método experimentar";
        }
        public string Investigar()
        {
            return "No se ha implementado el método investigar";
        }
    }
}
