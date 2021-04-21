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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }

        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            int añosExperiencia = int.Parse(txtAñosExperiencia.Text);
            string gradoAcademico = txtGradoAcademico.Text;
            string profesion = txtProfesion.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombre = nombres;
            rector1.Edad = edad;
            rector1.AñosExperiencia = añosExperiencia;
            rector1.GradoAcademico = gradoAcademico;
            rector1.Profesion = profesion;
            MessageBox.Show("Se ha registrado correctamente los datos de Rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombre;
            string gradoAcademico = rector1.GradoAcademico;
            int edad = rector1.Edad;
            int añosExperiencia = rector1.AñosExperiencia;
            string profesion = rector1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + "\nNombres: " + nombres + "\nEdad: " + edad +
                "\nProfesión: " + profesion + "\nGrado Académico: " + gradoAcademico + "\nAños de Experiencia: " + añosExperiencia);
        }

        private void btnMotivar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Motivar());
        }

        private void btnPlanear_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Planear());
        }

        private void btnDarSoluciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.DarSoluciones());
        }
    }
}
