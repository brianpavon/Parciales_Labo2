namespace Pavon.Brian
{
    partial class FrmAlumno
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
            this.lblColorSala = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblValorCuota = new System.Windows.Forms.Label();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(67, 454);
            this.btnAceptar.Size = new System.Drawing.Size(137, 37);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 454);
            this.btnCancelar.Size = new System.Drawing.Size(149, 37);
            this.btnCancelar.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(64, 52);
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(64, 113);
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(64, 157);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Location = new System.Drawing.Point(232, 218);
            this.cmbSexo.Size = new System.Drawing.Size(189, 24);
            // 
            // lblSexo
            // 
            this.lblSexo.Location = new System.Drawing.Point(64, 218);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(232, 157);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(232, 108);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(232, 52);
            // 
            // lblColorSala
            // 
            this.lblColorSala.AutoSize = true;
            this.lblColorSala.Location = new System.Drawing.Point(67, 275);
            this.lblColorSala.Name = "lblColorSala";
            this.lblColorSala.Size = new System.Drawing.Size(81, 17);
            this.lblColorSala.TabIndex = 12;
            this.lblColorSala.Text = "Elija la Sala";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(64, 333);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(117, 17);
            this.lblLegajo.TabIndex = 13;
            this.lblLegajo.Text = "Ingrese el Legajo";
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Items.AddRange(new object[] {
            "Naranja",
            "Rojo",
            "Amarillo",
            "Verde"});
            this.cmbSala.Location = new System.Drawing.Point(232, 275);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(189, 24);
            this.cmbSala.TabIndex = 4;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(232, 333);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(189, 22);
            this.txtLegajo.TabIndex = 5;
            // 
            // lblValorCuota
            // 
            this.lblValorCuota.AutoSize = true;
            this.lblValorCuota.Location = new System.Drawing.Point(64, 393);
            this.lblValorCuota.Name = "lblValorCuota";
            this.lblValorCuota.Size = new System.Drawing.Size(102, 17);
            this.lblValorCuota.TabIndex = 14;
            this.lblValorCuota.Text = "Valor de Cuota";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(232, 393);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.Size = new System.Drawing.Size(189, 22);
            this.txtValorCuota.TabIndex = 6;
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 523);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.lblValorCuota);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblColorSala);
            this.Name = "FrmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de un Alumno";
            this.Load += new System.EventHandler(this.FrmAlumno_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.cmbSexo, 0);
            this.Controls.SetChildIndex(this.lblSexo, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblColorSala, 0);
            this.Controls.SetChildIndex(this.lblLegajo, 0);
            this.Controls.SetChildIndex(this.cmbSala, 0);
            this.Controls.SetChildIndex(this.txtLegajo, 0);
            this.Controls.SetChildIndex(this.lblValorCuota, 0);
            this.Controls.SetChildIndex(this.txtValorCuota, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColorSala;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblValorCuota;
        private System.Windows.Forms.TextBox txtValorCuota;
    }
}