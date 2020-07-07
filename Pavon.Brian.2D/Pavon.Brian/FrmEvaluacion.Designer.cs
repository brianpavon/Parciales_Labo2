namespace Pavon.Brian
{
    partial class FrmEvaluacion
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
            this.rchDatosAlumno = new System.Windows.Forms.RichTextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.lblAlumnoEvaluado = new System.Windows.Forms.Label();
            this.lblDocenteEvaluador = new System.Windows.Forms.Label();
            this.lblAlRecreo = new System.Windows.Forms.Label();
            this.rctAlumnosEnRecreo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchDatosAlumno
            // 
            this.rchDatosAlumno.Location = new System.Drawing.Point(16, 76);
            this.rchDatosAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.rchDatosAlumno.Name = "rchDatosAlumno";
            this.rchDatosAlumno.ReadOnly = true;
            this.rchDatosAlumno.Size = new System.Drawing.Size(325, 130);
            this.rchDatosAlumno.TabIndex = 0;
            this.rchDatosAlumno.Text = "";
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(353, 141);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(227, 22);
            this.txtDocente.TabIndex = 1;
            // 
            // lblAlumnoEvaluado
            // 
            this.lblAlumnoEvaluado.AutoSize = true;
            this.lblAlumnoEvaluado.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoEvaluado.Location = new System.Drawing.Point(12, 42);
            this.lblAlumnoEvaluado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnoEvaluado.Name = "lblAlumnoEvaluado";
            this.lblAlumnoEvaluado.Size = new System.Drawing.Size(321, 24);
            this.lblAlumnoEvaluado.TabIndex = 2;
            this.lblAlumnoEvaluado.Text = "El Alumno que está siendo evaluado es:";
            // 
            // lblDocenteEvaluador
            // 
            this.lblDocenteEvaluador.AutoSize = true;
            this.lblDocenteEvaluador.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocenteEvaluador.Location = new System.Drawing.Point(349, 101);
            this.lblDocenteEvaluador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocenteEvaluador.Name = "lblDocenteEvaluador";
            this.lblDocenteEvaluador.Size = new System.Drawing.Size(241, 20);
            this.lblDocenteEvaluador.TabIndex = 3;
            this.lblDocenteEvaluador.Text = "El Docente que está evaluando es:";
            // 
            // lblAlRecreo
            // 
            this.lblAlRecreo.AutoSize = true;
            this.lblAlRecreo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlRecreo.Location = new System.Drawing.Point(137, 222);
            this.lblAlRecreo.Name = "lblAlRecreo";
            this.lblAlRecreo.Size = new System.Drawing.Size(270, 24);
            this.lblAlRecreo.TabIndex = 5;
            this.lblAlRecreo.Text = "Alumnos que pueden ir al Recreo";
            // 
            // rctAlumnosEnRecreo
            // 
            this.rctAlumnosEnRecreo.Location = new System.Drawing.Point(150, 268);
            this.rctAlumnosEnRecreo.Name = "rctAlumnosEnRecreo";
            this.rctAlumnosEnRecreo.ReadOnly = true;
            this.rctAlumnosEnRecreo.Size = new System.Drawing.Size(244, 200);
            this.rctAlumnosEnRecreo.TabIndex = 6;
            this.rctAlumnosEnRecreo.Text = "";
            // 
            // FrmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 505);
            this.ControlBox = false;
            this.Controls.Add(this.rctAlumnosEnRecreo);
            this.Controls.Add(this.lblAlRecreo);
            this.Controls.Add(this.lblDocenteEvaluador);
            this.Controls.Add(this.lblAlumnoEvaluado);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.rchDatosAlumno);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Evaluacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Evaluacion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.RichTextBox rchDatosAlumno;
        protected System.Windows.Forms.TextBox txtDocente;
        protected System.Windows.Forms.Label lblAlumnoEvaluado;
        protected System.Windows.Forms.Label lblDocenteEvaluador;
        protected System.Windows.Forms.Label lblAlRecreo;
        protected System.Windows.Forms.RichTextBox rctAlumnosEnRecreo;
    }
}