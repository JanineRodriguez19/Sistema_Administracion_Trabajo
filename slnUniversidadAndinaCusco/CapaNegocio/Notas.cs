using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        private string estudiante;
        private string carrera;
        private int cantidad;
        private string asignatura;
        private float calificacion;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }
        public float Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public string Promediar()
        {
            return "No se ha implementado el método Promediar"; 
        }
        public string MostrarRendimiento()
        {
            return "No se ha implementado el método Mostrar Rendimiento";
        }
        public string PasarSemestre()
        {
            return "No se ha implementado el método Pasar Semestre";
        }
    }
}
