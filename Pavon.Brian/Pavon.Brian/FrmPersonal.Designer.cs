namespace Pavon.Brian
{
    partial class FrmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonal));
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.cmbHoraIngreso = new System.Windows.Forms.ComboBox();
            this.cmbHoraSalida = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(63, 490);
            this.btnAceptar.Size = new System.Drawing.Size(174, 37);
            this.btnAceptar.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(262, 490);
            this.btnCancelar.Size = new System.Drawing.Size(189, 37);
            this.btnCancelar.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(60, 65);
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(60, 121);
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(60, 170);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Location = new System.Drawing.Point(262, 221);
            this.cmbSexo.Size = new System.Drawing.Size(189, 24);
            // 
            // lblSexo
            // 
            this.lblSexo.Location = new System.Drawing.Point(60, 221);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(262, 170);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(262, 121);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(262, 65);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(60, 274);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(91, 17);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "Elija el Cargo";
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Location = new System.Drawing.Point(60, 327);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(177, 17);
            this.lblHoraIngreso.TabIndex = 13;
            this.lblHoraIngreso.Text = "Ingrese Horario de Ingreso";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Location = new System.Drawing.Point(60, 426);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(177, 17);
            this.lblValorHora.TabIndex = 14;
            this.lblValorHora.Text = "Ingrese el Valor de la Hora";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(60, 378);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(184, 17);
            this.lblHoraSalida.TabIndex = 15;
            this.lblHoraSalida.Text = "Ingrese el Horario de Salida";
            // 
            // cmbHoraIngreso
            // 
            this.cmbHoraIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraIngreso.FormattingEnabled = true;
            this.cmbHoraIngreso.Items.AddRange(new object[] {
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "12:00",
            "12:30",
            "13:00",
            ""});
            this.cmbHoraIngreso.Location = new System.Drawing.Point(262, 327);
            this.cmbHoraIngreso.Name = "cmbHoraIngreso";
            this.cmbHoraIngreso.Size = new System.Drawing.Size(189, 24);
            this.cmbHoraIngreso.TabIndex = 5;
            // 
            // cmbHoraSalida
            // 
            this.cmbHoraSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraSalida.FormattingEnabled = true;
            this.cmbHoraSalida.Items.AddRange(new object[] {
            "12:00",
            "12:30",
            "13:00",
            "14:00",
            "16:00",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "20:00"});
            this.cmbHoraSalida.Location = new System.Drawing.Point(262, 378);
            this.cmbHoraSalida.Name = "cmbHoraSalida";
            this.cmbHoraSalida.Size = new System.Drawing.Size(189, 24);
            this.cmbHoraSalida.TabIndex = 6;
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Porteria",
            "Cocina",
            "Secretaria",
            "Tesoreria",
            "Direccion"});
            this.cmbCargo.Location = new System.Drawing.Point(262, 274);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(189, 24);
            this.cmbCargo.TabIndex = 4;
            this.cmbCargo.Text = "Seleccione Cargo";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(262, 426);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(189, 22);
            this.txtValorHora.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(174, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 17);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "ALTAS EMPLEADOS";
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 555);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.cmbHoraSalida);
            this.Controls.Add(this.cmbHoraIngreso);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.lblHoraIngreso);
            this.Controls.Add(this.lblCargo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonal";
            this.Text = "FrmPersonal";
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
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.lblHoraIngreso, 0);
            this.Controls.SetChildIndex(this.lblValorHora, 0);
            this.Controls.SetChildIndex(this.lblHoraSalida, 0);
            this.Controls.SetChildIndex(this.cmbHoraIngreso, 0);
            this.Controls.SetChildIndex(this.cmbHoraSalida, 0);
            this.Controls.SetChildIndex(this.cmbCargo, 0);
            this.Controls.SetChildIndex(this.txtValorHora, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCargo;
        protected System.Windows.Forms.Label lblHoraIngreso;
        protected System.Windows.Forms.Label lblValorHora;
        protected System.Windows.Forms.Label lblHoraSalida;
        protected System.Windows.Forms.ComboBox cmbHoraIngreso;
        protected System.Windows.Forms.ComboBox cmbHoraSalida;
        protected System.Windows.Forms.ComboBox cmbCargo;
        protected System.Windows.Forms.TextBox txtValorHora;
        protected System.Windows.Forms.Label lblTitulo;
    }
}