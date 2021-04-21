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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }

        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApelidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string dni = txtDni.Text;
            string experiencia = txtExperiencia.Text;
            string profesion = txtProfesion.Text;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Nombre = nombres;
            jefePractica1.Edad = edad;
            jefePractica1.Dni = dni;
            jefePractica1.Experiencia = experiencia;
            jefePractica1.Profesion = profesion;
            MessageBox.Show("Se ha registrado correctamente los datos de Jefe de Práctica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefePractica1.Apellidos;
            string nombres = jefePractica1.Nombre;
            int edad = jefePractica1.Edad;
            string dni = jefePractica1.Dni;
            string experiencia = jefePractica1.Experiencia;
            string profesion = jefePractica1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + "\nNombres: " + nombres + "\nEdad: " + edad + "\nDNI: " + dni +
                "\nExperiencia: " + experiencia + "\nProfesión: " + profesion);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Enseñar());
        }

        private void btnGuiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Guiar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Evaluar());
        }
    }
}
