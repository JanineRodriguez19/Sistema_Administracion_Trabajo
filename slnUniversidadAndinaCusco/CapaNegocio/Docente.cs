﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        // Atributos
        private string apellidos;
        private string nombres;
        private string dni;
        private DateTime fechaNacimiento;
        private string profesion;

        //Propiedades
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        //Métodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el método enseñar";
        }
        public string Matricular()
        {
            return "No se ha implementado el método matricular";
        }
        public string Aprobar()
        {
            return "No se ha implementado el método aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el método desaprobar";
        }
    }
}
