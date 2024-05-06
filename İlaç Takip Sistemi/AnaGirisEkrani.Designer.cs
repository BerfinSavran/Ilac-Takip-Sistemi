namespace İlaç_Takip_Sistemi
{
    partial class AnaGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaGirisEkrani));
            this.eczaci = new System.Windows.Forms.Button();
            this.depocu = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eczaci
            // 
            this.eczaci.Location = new System.Drawing.Point(78, 71);
            this.eczaci.Name = "eczaci";
            this.eczaci.Size = new System.Drawing.Size(278, 80);
            this.eczaci.TabIndex = 0;
            this.eczaci.Text = "ECZACI";
            this.eczaci.UseVisualStyleBackColor = true;
            this.eczaci.Click += new System.EventHandler(this.eczaci_Click);
            // 
            // depocu
            // 
            this.depocu.Location = new System.Drawing.Point(78, 198);
            this.depocu.Name = "depocu";
            this.depocu.Size = new System.Drawing.Size(278, 80);
            this.depocu.TabIndex = 1;
            this.depocu.Text = "DEPOCU";
            this.depocu.UseVisualStyleBackColor = true;
            this.depocu.Click += new System.EventHandler(this.depocu_Click);
            // 
            // kapat
            // 
            this.kapat.Location = new System.Drawing.Point(169, 308);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(107, 43);
            this.kapat.TabIndex = 23;
            this.kapat.Text = "KAPAT";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // AnaGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 363);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.depocu);
            this.Controls.Add(this.eczaci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaGirisEkrani";
            this.Text = "AnaGirisEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eczaci;
        private System.Windows.Forms.Button depocu;
        private System.Windows.Forms.Button kapat;
    }
}

