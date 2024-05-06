namespace İlaç_Takip_Sistemi
{
    partial class Eczaciİlac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eczaciİlac));
            this.cikis = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.siparis = new System.Windows.Forms.Button();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.stok = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eczaci_isim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(661, 74);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(107, 43);
            this.cikis.TabIndex = 22;
            this.cikis.Text = "ÇIKIŞ YAP";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(526, 108);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(107, 43);
            this.listele.TabIndex = 21;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(526, 41);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(107, 43);
            this.sil.TabIndex = 20;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(377, 108);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(107, 43);
            this.guncelle.TabIndex = 19;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // siparis
            // 
            this.siparis.Location = new System.Drawing.Point(377, 41);
            this.siparis.Name = "siparis";
            this.siparis.Size = new System.Drawing.Size(107, 43);
            this.siparis.TabIndex = 18;
            this.siparis.Text = "SİPARİŞ";
            this.siparis.UseVisualStyleBackColor = true;
            this.siparis.Click += new System.EventHandler(this.siparis_Click);
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(100, 95);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(220, 22);
            this.txt_stok.TabIndex = 17;
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(33, 98);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(61, 16);
            this.stok.TabIndex = 16;
            this.stok.Text = "İlaç Stok:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(100, 51);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(220, 22);
            this.txt_isim.TabIndex = 13;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(36, 54);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(58, 16);
            this.isim.TabIndex = 12;
            this.isim.Text = "İlaç İsmi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 240);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // eczaci_isim
            // 
            this.eczaci_isim.AutoSize = true;
            this.eczaci_isim.Location = new System.Drawing.Point(12, 9);
            this.eczaci_isim.Name = "eczaci_isim";
            this.eczaci_isim.Size = new System.Drawing.Size(78, 16);
            this.eczaci_isim.TabIndex = 24;
            this.eczaci_isim.Text = "Hoşgeldiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // Eczaciİlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eczaci_isim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.siparis);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.isim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eczaciİlac";
            this.Text = "EczaciIlac";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button siparis;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label eczaci_isim;
        private System.Windows.Forms.Label label1;
    }
}