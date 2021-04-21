using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //Atributos
        private string nombre;
        private string apellidos;
        private int edad;
        private string dni;
        private string experiencia;
        private string profesion;

        //Propiedades
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
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        //Métodos
        public string Enseñar()
        {
            return "No se ha implementado el método Enseñar";
        }
        public string Guiar()
        {
            return "No se ha implementado el método Guiar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el método Evaluar";
        }
    }
}
