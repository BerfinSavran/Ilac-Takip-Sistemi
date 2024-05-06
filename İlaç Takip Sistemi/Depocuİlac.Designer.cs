namespace İlaç_Takip_Sistemi
{
    partial class Depocuİlac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depocuİlac));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.stok = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.depo_isim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(36, 44);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(58, 16);
            this.isim.TabIndex = 1;
            this.isim.Text = "İlaç İsmi:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(100, 41);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(220, 22);
            this.txt_isim.TabIndex = 2;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(100, 84);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(220, 22);
            this.txt_fiyat.TabIndex = 4;
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Location = new System.Drawing.Point(28, 87);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(66, 16);
            this.fiyat.TabIndex = 3;
            this.fiyat.Text = "İlaç Fiyatı:";
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(100, 129);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(220, 22);
            this.txt_stok.TabIndex = 6;
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(33, 132);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(61, 16);
            this.stok.TabIndex = 5;
            this.stok.Text = "İlaç Stok:";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(377, 41);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(107, 43);
            this.ekle.TabIndex = 7;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(377, 108);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(107, 43);
            this.guncelle.TabIndex = 8;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(526, 41);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(107, 43);
            this.sil.TabIndex = 9;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(526, 108);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(107, 43);
            this.listele.TabIndex = 10;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(661, 74);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(107, 43);
            this.cikis.TabIndex = 11;
            this.cikis.Text = "ÇIKIŞ YAP";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // depo_isim
            // 
            this.depo_isim.AutoSize = true;
            this.depo_isim.Location = new System.Drawing.Point(12, 9);
            this.depo_isim.Name = "depo_isim";
            this.depo_isim.Size = new System.Drawing.Size(78, 16);
            this.depo_isim.TabIndex = 12;
            this.depo_isim.Text = "Hoşgeldiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // Depocuİlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depo_isim);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Depocuİlac";
            this.Text = "Depocuİlac";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label depo_isim;
        private System.Windows.Forms.Label label1;
    }
}