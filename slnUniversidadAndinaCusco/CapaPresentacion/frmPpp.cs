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
    public partial class frmPpp : Form
    {
        public frmPpp()
        {
            InitializeComponent();
        }
        CapaNegocio.Ppp ppp1 = new CapaNegocio.Ppp();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string carrera = txtCarrera.Text;
            string practicante = txtPracticante.Text;
            string celular = txtCelular.Text;
            DateTime fechaInicio = dateTimeFechaInicio.Value;
            string empresa = txtEmpresa.Text;
            string areaTrabajo = txtAreaTrabajo.Text;
            string asesor = txtAsesor.Text;
            ppp1.Carrera = carrera;
            ppp1.Practicante = practicante;
            ppp1.Celular = celular;
            ppp1.FechaInicio = fechaInicio;
            ppp1.Empresa = empresa;
            ppp1.AreaTrabajo = areaTrabajo;
            ppp1.Asesor = asesor;
            MessageBox.Show("Se ha registrado correctamente los datos de Prácticas Pre Profesionales 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string carrera = ppp1.Carrera;
            string practicante = ppp1.Practicante;
            string celular = ppp1.Celular;
            DateTime fechaInicio = ppp1.FechaInicio;
            string empresa = ppp1.Empresa;
            string areaTrabajo = ppp1.AreaTrabajo;
            string asesor = ppp1.Asesor;
            MessageBox.Show("Nombre del practicante: " + practicante + "\nCarrera: " + carrera + "\nNúmero de celular: "
                + celular + "\nAsesor: " + asesor + "\nEmpresa: " + empresa + "\nÁrea de trabajo: " + areaTrabajo + 
                "\nFecha de inicio: "+ fechaInicio);
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Clasificar());
        }

        private void btnFormar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Formar());
        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.MostrarResultados());
        }
    }
}
