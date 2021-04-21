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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }

        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombreAsignatura = txtNombreAsignatura.Text;
            string aula = txtAula.Text;
            int horas = int.Parse(txtHoras.Text);
            string docente = txtDocente.Text;
            string tipo = txtTipo.Text;
            asignatura1.NombreAsignatura = nombreAsignatura;
            asignatura1.Aula = aula;
            asignatura1.Horas = horas;
            asignatura1.Docente = docente;
            asignatura1.Tipo = tipo;
            MessageBox.Show("Se ha registrado correctamente los datoss de Asignatura 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombreAsignatura = asignatura1.NombreAsignatura;
            string aula = asignatura1.Aula;
            int horas = asignatura1.Horas;
            string docente = asignatura1.Docente;
            string tipo = asignatura1.Tipo;
            MessageBox.Show("Nombre de la asignatura: " + nombreAsignatura + "\nAula: " + aula + "\nHoras: " + horas +
                "\nDocente: " + docente + "\nTipo: " + tipo);
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Aprender());
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Clasificar());
        }
    }
}
