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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProximoLlamado));
            this.SuspendLayout();
            // 
            // rchDatosAlumno
            // 
            this.rchDatosAlumno.Location = new System.Drawing.Point(14, 73);
            this.rchDatosAlumno.Margin = new System.Windows.Forms.Padding(5);
            this.rchDatosAlumno.Size = new System.Drawing.Size(301, 163);
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(382, 191);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(5);
            // 
            // lblAlumnoEvaluado
            // 
            this.lblAlumnoEvaluado.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoEvaluado.Location = new System.Drawing.Point(35, 35);
            this.lblAlumnoEvaluado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAlumnoEvaluado.Size = new System.Drawing.Size(253, 21);
            this.lblAlumnoEvaluado.Text = "Siguiente Alumno, a evaluar:";
            // 
            // lblDocenteEvaluador
            // 
            this.lblDocenteEvaluador.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocenteEvaluador.Location = new System.Drawing.Point(378, 150);
            this.lblDocenteEvaluador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDocenteEvaluador.Size = new System.Drawing.Size(245, 21);
            this.lblDocenteEvaluador.Text = "El Docente que evaluara es:";
            // 
            // lblAlRecreo
            // 
            this.lblAlRecreo.Location = new System.Drawing.Point(198, 296);
            this.lblAlRecreo.Visible = false;
            // 
            // rctAlumnosEnRecreo
            // 
            this.rctAlumnosEnRecreo.Location = new System.Drawing.Point(201, 334);
            this.rctAlumnosEnRecreo.Visible = false;
            // 
            // FrmProximoLlamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pavon.Brian.Properties.Resources.IMG_20160407_083647260;
            this.ClientSize = new System.Drawing.Size(660, 342);
            this.ControlBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(30, 250);
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