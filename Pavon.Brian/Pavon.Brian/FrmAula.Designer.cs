namespace Pavon.Brian
{
    partial class FrmAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAula));
            this.lbAlumnosAsignados = new System.Windows.Forms.ListBox();
            this.lbAlumnosSinSala = new System.Windows.Forms.ListBox();
            this.lbDocentes = new System.Windows.Forms.ListBox();
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAlumnosAsignados
            // 
            this.lbAlumnosAsignados.FormattingEnabled = true;
            this.lbAlumnosAsignados.ItemHeight = 16;
            this.lbAlumnosAsignados.Location = new System.Drawing.Point(334, 107);
            this.lbAlumnosAsignados.Name = "lbAlumnosAsignados";
            this.lbAlumnosAsignados.Size = new System.Drawing.Size(209, 308);
            this.lbAlumnosAsignados.TabIndex = 0;
            // 
            // lbAlumnosSinSala
            // 
            this.lbAlumnosSinSala.FormattingEnabled = true;
            this.lbAlumnosSinSala.ItemHeight = 16;
            this.lbAlumnosSinSala.Location = new System.Drawing.Point(12, 107);
            this.lbAlumnosSinSala.Name = "lbAlumnosSinSala";
            this.lbAlumnosSinSala.Size = new System.Drawing.Size(206, 308);
            this.lbAlumnosSinSala.TabIndex = 1;
            // 
            // lbDocentes
            // 
            this.lbDocentes.FormattingEnabled = true;
            this.lbDocentes.ItemHeight = 16;
            this.lbDocentes.Location = new System.Drawing.Point(578, 107);
            this.lbDocentes.Name = "lbDocentes";
            this.lbDocentes.Size = new System.Drawing.Size(205, 308);
            this.lbDocentes.TabIndex = 2;
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.Location = new System.Drawing.Point(433, 496);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(167, 41);
            this.btnCrearSala.TabIndex = 3;
            this.btnCrearSala.Text = "Crear Sala";
            this.btnCrearSala.UseVisualStyleBackColor = true;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cmbTurno.Location = new System.Drawing.Point(234, 32);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(169, 24);
            this.cmbTurno.TabIndex = 6;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(76, 33);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(134, 17);
            this.lblTurno.TabIndex = 7;
            this.lblTurno.Text = "Seleccione un turno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(632, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 41);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(578, 33);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(205, 36);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar Lista";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(232, 217);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(85, 36);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 549);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.btnCrearSala);
            this.Controls.Add(this.lbDocentes);
            this.Controls.Add(this.lbAlumnosSinSala);
            this.Controls.Add(this.lbAlumnosAsignados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAula";
            this.Text = "Alta de Aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAlumnosAsignados;
        private System.Windows.Forms.ListBox lbAlumnosSinSala;
        private System.Windows.Forms.ListBox lbDocentes;
        private System.Windows.Forms.Button btnCrearSala;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAsignar;
    }
}