namespace Pavon.Brian
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNODocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaAmarillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaRojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaVerdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaNaranjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarPruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.cargarDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ejecutarPruebaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Archivo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocenteToolStripMenuItem,
            this.altaNODocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDocenteToolStripMenuItem
            // 
            this.altaDocenteToolStripMenuItem.Name = "altaDocenteToolStripMenuItem";
            this.altaDocenteToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.altaDocenteToolStripMenuItem.Text = "Alta Docente";
            this.altaDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDocenteToolStripMenuItem_Click);
            // 
            // altaNODocenteToolStripMenuItem
            // 
            this.altaNODocenteToolStripMenuItem.Name = "altaNODocenteToolStripMenuItem";
            this.altaNODocenteToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.altaNODocenteToolStripMenuItem.Text = "Alta NO Docente";
            this.altaNODocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNODocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaAmarillaToolStripMenuItem,
            this.salaRojaToolStripMenuItem,
            this.salaVerdeToolStripMenuItem,
            this.salaNaranjaToolStripMenuItem});
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.altaAulaToolStripMenuItem.Text = "Alta Aula";
            // 
            // salaAmarillaToolStripMenuItem
            // 
            this.salaAmarillaToolStripMenuItem.Name = "salaAmarillaToolStripMenuItem";
            this.salaAmarillaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.salaAmarillaToolStripMenuItem.Text = "Sala Amarilla";
            this.salaAmarillaToolStripMenuItem.Click += new System.EventHandler(this.salaAmarillaToolStripMenuItem_Click);
            // 
            // salaRojaToolStripMenuItem
            // 
            this.salaRojaToolStripMenuItem.Name = "salaRojaToolStripMenuItem";
            this.salaRojaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.salaRojaToolStripMenuItem.Text = "Sala Roja";
            this.salaRojaToolStripMenuItem.Click += new System.EventHandler(this.salaRojaToolStripMenuItem_Click);
            // 
            // salaVerdeToolStripMenuItem
            // 
            this.salaVerdeToolStripMenuItem.Name = "salaVerdeToolStripMenuItem";
            this.salaVerdeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.salaVerdeToolStripMenuItem.Text = "Sala Verde";
            this.salaVerdeToolStripMenuItem.Click += new System.EventHandler(this.salaVerdeToolStripMenuItem_Click);
            // 
            // salaNaranjaToolStripMenuItem
            // 
            this.salaNaranjaToolStripMenuItem.Name = "salaNaranjaToolStripMenuItem";
            this.salaNaranjaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.salaNaranjaToolStripMenuItem.Text = "Sala Naranja";
            this.salaNaranjaToolStripMenuItem.Click += new System.EventHandler(this.salaNaranjaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionPadresToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudacionPorAulaToolStripMenuItem,
            this.recaudacionTotalToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // informacionPadresToolStripMenuItem
            // 
            this.informacionPadresToolStripMenuItem.Name = "informacionPadresToolStripMenuItem";
            this.informacionPadresToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.informacionPadresToolStripMenuItem.Text = "Informacion Padres";
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo Docente";
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo No Docente";
            // 
            // recaudacionPorAulaToolStripMenuItem
            // 
            this.recaudacionPorAulaToolStripMenuItem.Name = "recaudacionPorAulaToolStripMenuItem";
            this.recaudacionPorAulaToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.recaudacionPorAulaToolStripMenuItem.Text = "Recaudacion por Aula";
            // 
            // recaudacionTotalToolStripMenuItem
            // 
            this.recaudacionTotalToolStripMenuItem.Name = "recaudacionTotalToolStripMenuItem";
            this.recaudacionTotalToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.recaudacionTotalToolStripMenuItem.Text = "Recaudacion Total";
            // 
            // ejecutarPruebaToolStripMenuItem
            // 
            this.ejecutarPruebaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.cargarDocentesToolStripMenuItem,
            this.cargarNoDocenteToolStripMenuItem});
            this.ejecutarPruebaToolStripMenuItem.Name = "ejecutarPruebaToolStripMenuItem";
            this.ejecutarPruebaToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.ejecutarPruebaToolStripMenuItem.Text = "Ejecutar Prueba";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iniciarToolStripMenuItem.Text = "Cargar Alumnos";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(250, 169);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(46, 17);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "label1";
            // 
            // cargarDocentesToolStripMenuItem
            // 
            this.cargarDocentesToolStripMenuItem.Name = "cargarDocentesToolStripMenuItem";
            this.cargarDocentesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cargarDocentesToolStripMenuItem.Text = "Cargar Docentes";
            this.cargarDocentesToolStripMenuItem.Click += new System.EventHandler(this.cargarDocentesToolStripMenuItem_Click);
            // 
            // cargarNoDocenteToolStripMenuItem
            // 
            this.cargarNoDocenteToolStripMenuItem.Name = "cargarNoDocenteToolStripMenuItem";
            this.cargarNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cargarNoDocenteToolStripMenuItem.Text = "Cargar No Docente";
            this.cargarNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.cargarNoDocenteToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Menu de Administracion";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNODocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaAmarillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaRojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaVerdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaNaranjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarPruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.ToolStripMenuItem cargarDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarNoDocenteToolStripMenuItem;
    }
}