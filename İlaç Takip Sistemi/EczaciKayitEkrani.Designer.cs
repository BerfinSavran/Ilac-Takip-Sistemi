namespace İlaç_Takip_Sistemi
{
    partial class EczaciKayitEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EczaciKayitEkrani));
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kayit = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(84, 135);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 13;
            this.password.Text = "Password:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(81, 81);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 16);
            this.username.TabIndex = 12;
            this.username.Text = "Username:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 10;
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(84, 217);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(271, 61);
            this.kayit.TabIndex = 14;
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
            // EczaciKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 363);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EczaciKayitEkrani";
            this.Text = "EczaciKayitEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button geri;
    }
}