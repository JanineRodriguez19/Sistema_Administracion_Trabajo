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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer los datos del formulario
            string asignatura = txtAsignatura.Text;
            string instrumentos = txtInstrumentos.Text;
            string aforo = txtAforo.Text;
            DateTime horario = dateTimeHorario.Value;
            string aula = txtAula.Text;
            string docente = txtDocente.Text;
            laboratorio1.Asignatura = asignatura;
            laboratorio1.Instrumentos = instrumentos;
            laboratorio1.Aforo = aforo;
            laboratorio1.Horario = horario;
            laboratorio1.Aula = aula;
            laboratorio1.Docente = docente;
            MessageBox.Show("Se ha registrado correctamente los datos de Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string asignatura = laboratorio1.Asignatura;
            string instrumentos = laboratorio1.Instrumentos;
            string aforo = laboratorio1.Aforo;
            DateTime horario = laboratorio1.Horario;
            string aula = laboratorio1.Aula;
            string docente = laboratorio1.Docente;
            MessageBox.Show("Asignatura: " + asignatura+ "\nDocente: " + docente+ "\nAula: " + aula+ "\nHorario: "
                + horario+ "\nAforo: " + aforo+ "\nInstrumentos: " + instrumentos);
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Experimentar());
        }

        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Investigar());
        }
    }
}
