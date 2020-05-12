namespace Pavon.Brian
{
    partial class FrmVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideo));
            this.wmpVideos = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBaby = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSilbidos = new System.Windows.Forms.Button();
            this.btnBlooper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpVideos
            // 
            this.wmpVideos.Enabled = true;
            this.wmpVideos.Location = new System.Drawing.Point(2, 2);
            this.wmpVideos.Name = "wmpVideos";
            this.wmpVideos.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideos.OcxState")));
            this.wmpVideos.Size = new System.Drawing.Size(886, 373);
            this.wmpVideos.TabIndex = 0;
            // 
            // btnBaby
            // 
            this.btnBaby.Location = new System.Drawing.Point(98, 492);
            this.btnBaby.Name = "btnBaby";
            this.btnBaby.Size = new System.Drawing.Size(109, 36);
            this.btnBaby.TabIndex = 1;
            this.btnBaby.Text = "Ver Shark";
            this.btnBaby.UseVisualStyleBackColor = true;
            this.btnBaby.Click += new System.EventHandler(this.btnBaby_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(254, 556);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(350, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSilbidos
            // 
            this.btnSilbidos.Location = new System.Drawing.Point(373, 492);
            this.btnSilbidos.Name = "btnSilbidos";
            this.btnSilbidos.Size = new System.Drawing.Size(103, 36);
            this.btnSilbidos.TabIndex = 3;
            this.btnSilbidos.Text = "Silbidos";
            this.btnSilbidos.UseVisualStyleBackColor = true;
            this.btnSilbidos.Click += new System.EventHandler(this.btnSilbidos_Click);
            // 
            // btnBlooper
            // 
            this.btnBlooper.Location = new System.Drawing.Point(649, 492);
            this.btnBlooper.Name = "btnBlooper";
            this.btnBlooper.Size = new System.Drawing.Size(114, 36);
            this.btnBlooper.TabIndex = 4;
            this.btnBlooper.Text = "Reite un poco";
            this.btnBlooper.UseVisualStyleBackColor = true;
            this.btnBlooper.Click += new System.EventHandler(this.btnBlooper_Click);
            // 
            // FrmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 613);
            this.Controls.Add(this.btnBlooper);
            this.Controls.Add(this.btnSilbidos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBaby);
            this.Controls.Add(this.wmpVideos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vas a ver videos";
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideos;
        private System.Windows.Forms.Button btnBaby;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSilbidos;
        private System.Windows.Forms.Button btnBlooper;
    }
}