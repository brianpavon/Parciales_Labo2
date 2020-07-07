namespace Pavon.Brian
{
    partial class FrmProximoLlamado
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
            this.SuspendLayout();
            // 
            // rchDatosAlumno
            // 
            this.rchDatosAlumno.Margin = new System.Windows.Forms.Padding(5);
            this.rchDatosAlumno.Size = new System.Drawing.Size(301, 173);
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(380, 145);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(5);
            // 
            // lblAlumnoEvaluado
            // 
            this.lblAlumnoEvaluado.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoEvaluado.Location = new System.Drawing.Point(32, 47);
            this.lblAlumnoEvaluado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAlumnoEvaluado.Size = new System.Drawing.Size(253, 21);
            this.lblAlumnoEvaluado.Text = "Siguiente Alumno, a evaluar:";
            // 
            // lblDocenteEvaluador
            // 
            this.lblDocenteEvaluador.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocenteEvaluador.Location = new System.Drawing.Point(376, 104);
            this.lblDocenteEvaluador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDocenteEvaluador.Size = new System.Drawing.Size(245, 21);
            this.lblDocenteEvaluador.Text = "El Docente que evaluara es:";
            // 
            // lblAlRecreo
            // 
            this.lblAlRecreo.Location = new System.Drawing.Point(198, 296);
            // 
            // rctAlumnosEnRecreo
            // 
            this.rctAlumnosEnRecreo.Location = new System.Drawing.Point(201, 334);
            // 
            // FrmProximoLlamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 339);
            this.ControlBox = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProximoLlamado";
            this.Text = "Sala de Espera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProximoLlamado_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}