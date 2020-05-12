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
            this.cargarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.videosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splCtnPrincipal = new System.Windows.Forms.SplitContainer();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splCtnPrincipal)).BeginInit();
            this.splCtnPrincipal.Panel1.SuspendLayout();
            this.splCtnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ejecutarPruebaToolStripMenuItem,
            this.videosToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1060, 28);
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
            this.informacionPadresToolStripMenuItem.Click += new System.EventHandler(this.informacionPadresToolStripMenuItem_Click);
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo Docente";
            this.sueldoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoDocenteToolStripMenuItem_Click);
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo No Docente";
            this.sueldoNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoNoDocenteToolStripMenuItem_Click);
            // 
            // recaudacionPorAulaToolStripMenuItem
            // 
            this.recaudacionPorAulaToolStripMenuItem.Name = "recaudacionPorAulaToolStripMenuItem";
            this.recaudacionPorAulaToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.recaudacionPorAulaToolStripMenuItem.Text = "Recaudacion por Aula";
            this.recaudacionPorAulaToolStripMenuItem.Click += new System.EventHandler(this.recaudacionPorAulaToolStripMenuItem_Click);
            // 
            // recaudacionTotalToolStripMenuItem
            // 
            this.recaudacionTotalToolStripMenuItem.Name = "recaudacionTotalToolStripMenuItem";
            this.recaudacionTotalToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.recaudacionTotalToolStripMenuItem.Text = "Recaudacion Total";
            this.recaudacionTotalToolStripMenuItem.Click += new System.EventHandler(this.recaudacionTotalToolStripMenuItem_Click);
            // 
            // ejecutarPruebaToolStripMenuItem
            // 
            this.ejecutarPruebaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarAlumno,
            this.cargarDocentesToolStripMenuItem,
            this.cargarNoDocenteToolStripMenuItem});
            this.ejecutarPruebaToolStripMenuItem.Name = "ejecutarPruebaToolStripMenuItem";
            this.ejecutarPruebaToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.ejecutarPruebaToolStripMenuItem.Text = "Ejecutar Prueba";
            // 
            // cargarAlumno
            // 
            this.cargarAlumno.Name = "cargarAlumno";
            this.cargarAlumno.Size = new System.Drawing.Size(224, 26);
            this.cargarAlumno.Text = "Cargar Alumnos";
            this.cargarAlumno.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
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
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(12, 29);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(46, 17);
            this.lblSaludo.TabIndex = 1;
            this.lblSaludo.Text = "label1";
            // 
            // videosToolStripMenuItem
            // 
            this.videosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            this.videosToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.videosToolStripMenuItem.Text = "Videos";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // splCtnPrincipal
            // 
            this.splCtnPrincipal.Location = new System.Drawing.Point(0, 31);
            this.splCtnPrincipal.Name = "splCtnPrincipal";
            // 
            // splCtnPrincipal.Panel1
            // 
            this.splCtnPrincipal.Panel1.Controls.Add(this.lblSaludo);
            // 
            // splCtnPrincipal.Panel2
            // 
            this.splCtnPrincipal.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splCtnPrincipal.Panel2.BackgroundImage")));
            this.splCtnPrincipal.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splCtnPrincipal.Size = new System.Drawing.Size(1060, 589);
            this.splCtnPrincipal.SplitterDistance = 228;
            this.splCtnPrincipal.TabIndex = 5;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1060, 620);
            this.Controls.Add(this.splCtnPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Menu de Administracion";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.splCtnPrincipal.Panel1.ResumeLayout(false);
            this.splCtnPrincipal.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splCtnPrincipal)).EndInit();
            this.splCtnPrincipal.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem cargarAlumno;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.ToolStripMenuItem cargarDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splCtnPrincipal;
    }
}