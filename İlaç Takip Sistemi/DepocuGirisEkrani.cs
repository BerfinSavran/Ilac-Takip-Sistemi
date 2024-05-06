﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlaç_Takip_Sistemi
{
    public partial class DepocuGirisEkrani : Form
    {
        public DepocuGirisEkrani()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Depocu where username=@p1 and password=@p2", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormManager.depo_id = Convert.ToInt32(dr["id"]);
                FormManager.depo_name = Convert.ToString(dr["username"]);
                MessageBox.Show("Giriş Başarılı...","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormManager.formOpen(this, new Depocuİlac());
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            SqlBaglantisi.baglanti().Close();  
        }

        private void geri_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new AnaGirisEkrani());
        }
    }
}
