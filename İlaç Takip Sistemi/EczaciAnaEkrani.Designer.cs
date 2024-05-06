namespace İlaç_Takip_Sistemi
{
    partial class EczaciAnaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EczaciAnaEkrani));
            this.giris = new System.Windows.Forms.Button();
            this.kayit = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(78, 71);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(278, 80);
            this.giris.TabIndex = 1;
            this.giris.Text = "GİRİŞ YAP";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(78, 198);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(278, 80);
            this.kayit.TabIndex = 2;
            this.kayit.Text = "KAYIT OL";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(184, 314);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(79, 26);
            this.geri.TabIndex = 15;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // EczaciAnaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 363);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EczaciAnaEkrani";
            this.Text = "EczaciAnaEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button geri;
    }
}