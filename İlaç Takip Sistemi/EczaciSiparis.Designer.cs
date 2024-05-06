namespace İlaç_Takip_Sistemi
{
    partial class EczaciSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EczaciSiparis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.stok = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.isim = new System.Windows.Forms.Label();
            this.listele = new System.Windows.Forms.Button();
            this.siparis = new System.Windows.Forms.Button();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.geri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(256, 129);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(220, 22);
            this.txt_stok.TabIndex = 30;
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(189, 132);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(61, 16);
            this.stok.TabIndex = 29;
            this.stok.Text = "İlaç Stok:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(256, 84);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(220, 22);
            this.txt_fiyat.TabIndex = 28;
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Location = new System.Drawing.Point(184, 87);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(66, 16);
            this.fiyat.TabIndex = 27;
            this.fiyat.Text = "İlaç Fiyatı:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(256, 41);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(220, 22);
            this.txt_isim.TabIndex = 26;
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Location = new System.Drawing.Point(192, 44);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(58, 16);
            this.isim.TabIndex = 25;
            this.isim.Text = "İlaç İsmi:";
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(38, 53);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(107, 43);
            this.listele.TabIndex = 31;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // siparis
            // 
            this.siparis.Location = new System.Drawing.Point(602, 108);
            this.siparis.Name = "siparis";
            this.siparis.Size = new System.Drawing.Size(107, 43);
            this.siparis.TabIndex = 32;
            this.siparis.Text = "SİPARİŞ VER";
            this.siparis.UseVisualStyleBackColor = true;
            this.siparis.Click += new System.EventHandler(this.siparis_Click);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(577, 63);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(163, 22);
            this.txt_adet.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "İlaç Adeti:";
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(51, 132);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(79, 26);
            this.geri.TabIndex = 35;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "label3";
            // 
            // EczaciSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.siparis);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EczaciSiparis";
            this.Text = "EczaciSiparis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button siparis;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}