using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string estudiante = txtEstudiante.Text;
            string carrera = txtCarrera.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            string asignatura = txtAsignatura.Text;
            float calificacion = float.Parse(txtCalificacion.Text);
            notas1.Estudiante = estudiante;
            notas1.Carrera = carrera;
            notas1.Cantidad = cantidad;
            notas1.Asignatura = asignatura;
            notas1.Calificacion = calificacion;
            MessageBox.Show("Se ha registrado correctamente los datos de Notas 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string estudiante = notas1.Estudiante;
            string carrera = notas1.Carrera;
            int cantidad = notas1.Cantidad;
            string asignatura = notas1.Asignatura;
            float calificacion = notas1.Calificacion;
            MessageBox.Show("Estudiante: "+estudiante+ "\nCarrera: " + carrera+ "\nCandidad de notas: " + cantidad+
                "\nAsignatura: " + asignatura+ "\nCalificación: " + calificacion);
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Promediar());
        }

        private void btnMostrarRendimiento_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.MostrarRendimiento());
        }

        private void btnPasarSemestre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.PasarSemestre());
        }
    }
}
