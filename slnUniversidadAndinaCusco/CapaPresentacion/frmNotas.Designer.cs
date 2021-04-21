
namespace CapaPresentacion
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnPromediar = new System.Windows.Forms.Button();
            this.btnMostrarRendimiento = new System.Windows.Forms.Button();
            this.btnPasarSemestre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(226, 73);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(149, 20);
            this.txtEstudiante.TabIndex = 0;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(226, 100);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(149, 20);
            this.txtCarrera.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(226, 127);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(149, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(226, 154);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(149, 20);
            this.txtAsignatura.TabIndex = 3;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(226, 181);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(149, 20);
            this.txtCalificacion.TabIndex = 4;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(435, 84);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 36);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(435, 138);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 36);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnPromediar
            // 
            this.btnPromediar.Location = new System.Drawing.Point(155, 228);
            this.btnPromediar.Name = "btnPromediar";
            this.btnPromediar.Size = new System.Drawing.Size(83, 36);
            this.btnPromediar.TabIndex = 7;
            this.btnPromediar.Text = "Promediar";
            this.btnPromediar.UseVisualStyleBackColor = true;
            this.btnPromediar.Click += new System.EventHandler(this.btnPromediar_Click);
            // 
            // btnMostrarRendimiento
            // 
            this.btnMostrarRendimiento.Location = new System.Drawing.Point(261, 228);
            this.btnMostrarRendimiento.Name = "btnMostrarRendimiento";
            this.btnMostrarRendimiento.Size = new System.Drawing.Size(83, 36);
            this.btnMostrarRendimiento.TabIndex = 8;
            this.btnMostrarRendimiento.Text = "Mostrar Rendimiento";
            this.btnMostrarRendimiento.UseVisualStyleBackColor = true;
            this.btnMostrarRendimiento.Click += new System.EventHandler(this.btnMostrarRendimiento_Click);
            // 
            // btnPasarSemestre
            // 
            this.btnPasarSemestre.Location = new System.Drawing.Point(367, 228);
            this.btnPasarSemestre.Name = "btnPasarSemestre";
            this.btnPasarSemestre.Size = new System.Drawing.Size(83, 36);
            this.btnPasarSemestre.TabIndex = 9;
            this.btnPasarSemestre.Text = "Pasar Semestre";
            this.btnPasarSemestre.UseVisualStyleBackColor = true;
            this.btnPasarSemestre.Click += new System.EventHandler(this.btnPasarSemestre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estudiante: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carrera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad de notas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Asignatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Calificación:";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPasarSemestre);
            this.Controls.Add(this.btnMostrarRendimiento);
            this.Controls.Add(this.btnPromediar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.txtAsignatura);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtEstudiante);
            this.Name = "frmNotas";
            this.Text = "Datos de la Clase Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnPromediar;
        private System.Windows.Forms.Button btnMostrarRendimiento;
        private System.Windows.Forms.Button btnPasarSemestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}