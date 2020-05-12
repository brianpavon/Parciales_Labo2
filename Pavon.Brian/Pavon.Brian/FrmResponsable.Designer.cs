namespace Pavon.Brian
{
    partial class FrmResponsable
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
            this.cmbParentezco = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblParentezco = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(48, 414);
            this.btnAceptar.Size = new System.Drawing.Size(155, 37);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 414);
            this.btnCancelar.Size = new System.Drawing.Size(189, 37);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(67, 53);
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(67, 114);
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(67, 163);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Location = new System.Drawing.Point(235, 219);
            this.cmbSexo.Size = new System.Drawing.Size(189, 24);
            // 
            // lblSexo
            // 
            this.lblSexo.Location = new System.Drawing.Point(67, 222);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(235, 158);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(235, 109);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(235, 53);
            // 
            // cmbParentezco
            // 
            this.cmbParentezco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentezco.FormattingEnabled = true;
            this.cmbParentezco.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Tia",
            "Tio",
            "Abuela",
            "Abuelo",
            "Otro"});
            this.cmbParentezco.Location = new System.Drawing.Point(235, 271);
            this.cmbParentezco.Name = "cmbParentezco";
            this.cmbParentezco.Size = new System.Drawing.Size(189, 24);
            this.cmbParentezco.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(235, 331);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(189, 22);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblParentezco
            // 
            this.lblParentezco.AutoSize = true;
            this.lblParentezco.Location = new System.Drawing.Point(70, 277);
            this.lblParentezco.Name = "lblParentezco";
            this.lblParentezco.Size = new System.Drawing.Size(125, 17);
            this.lblParentezco.TabIndex = 14;
            this.lblParentezco.Text = "Elija el Parentezco";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(73, 335);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(130, 17);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Ingrese el Telefono";
            // 
            // FrmResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 506);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblParentezco);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbParentezco);
            this.Name = "FrmResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de un Responsable";
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
            this.Controls.SetChildIndex(this.cmbParentezco, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.lblParentezco, 0);
            this.Controls.SetChildIndex(this.lblTelefono, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParentezco;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblParentezco;
        private System.Windows.Forms.Label lblTelefono;
    }
}