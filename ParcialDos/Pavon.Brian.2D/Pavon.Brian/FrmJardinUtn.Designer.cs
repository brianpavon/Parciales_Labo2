namespace Pavon.Brian
{
    partial class FrmJardinUtn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJardinUtn));
            this.lblAvisoRecreo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.DataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.rchDocentes = new System.Windows.Forms.RichTextBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblDocentes = new System.Windows.Forms.Label();
            this.tmrTotalEvaluacion = new System.Windows.Forms.Timer(this.components);
            this.lblCronometro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvisoRecreo
            // 
            this.lblAvisoRecreo.AutoSize = true;
            this.lblAvisoRecreo.BackColor = System.Drawing.Color.Transparent;
            this.lblAvisoRecreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoRecreo.Location = new System.Drawing.Point(261, 18);
            this.lblAvisoRecreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvisoRecreo.Name = "lblAvisoRecreo";
            this.lblAvisoRecreo.Size = new System.Drawing.Size(0, 38);
            this.lblAvisoRecreo.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(445, 419);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(222, 71);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar las evaluaciones";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // DataGridAlumnos
            // 
            this.DataGridAlumnos.AllowUserToAddRows = false;
            this.DataGridAlumnos.AllowUserToDeleteRows = false;
            this.DataGridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAlumnos.ColumnHeadersVisible = false;
            this.DataGridAlumnos.Location = new System.Drawing.Point(56, 118);
            this.DataGridAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridAlumnos.Name = "DataGridAlumnos";
            this.DataGridAlumnos.ReadOnly = true;
            this.DataGridAlumnos.RowHeadersVisible = false;
            this.DataGridAlumnos.RowHeadersWidth = 51;
            this.DataGridAlumnos.Size = new System.Drawing.Size(529, 262);
            this.DataGridAlumnos.TabIndex = 1;
            // 
            // rchDocentes
            // 
            this.rchDocentes.Location = new System.Drawing.Point(619, 117);
            this.rchDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.rchDocentes.Name = "rchDocentes";
            this.rchDocentes.ReadOnly = true;
            this.rchDocentes.Size = new System.Drawing.Size(412, 261);
            this.rchDocentes.TabIndex = 2;
            this.rchDocentes.Text = "";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.Location = new System.Drawing.Point(117, 70);
            this.lblAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(113, 29);
            this.lblAlumnos.TabIndex = 4;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // lblDocentes
            // 
            this.lblDocentes.AutoSize = true;
            this.lblDocentes.BackColor = System.Drawing.Color.Transparent;
            this.lblDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocentes.Location = new System.Drawing.Point(640, 70);
            this.lblDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocentes.Name = "lblDocentes";
            this.lblDocentes.Size = new System.Drawing.Size(123, 29);
            this.lblDocentes.TabIndex = 5;
            this.lblDocentes.Text = "Docentes";
            // 
            // tmrTotalEvaluacion
            // 
            this.tmrTotalEvaluacion.Interval = 1000;
            this.tmrTotalEvaluacion.Tick += new System.EventHandler(this.tmrTotalEvaluacion_Tick);
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.Location = new System.Drawing.Point(25, 472);
            this.lblCronometro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(0, 18);
            this.lblCronometro.TabIndex = 6;
            // 
            // FrmJardinUtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Pavon.Brian.Properties.Resources.descarga__15_;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.lblDocentes);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.rchDocentes);
            this.Controls.Add(this.DataGridAlumnos);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblAvisoRecreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJardinUtn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Modulo de Evaluacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JardinUtn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvisoRecreo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridView DataGridAlumnos;
        private System.Windows.Forms.RichTextBox rchDocentes;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblDocentes;
        private System.Windows.Forms.Timer tmrTotalEvaluacion;
        private System.Windows.Forms.Label lblCronometro;
    }
}

