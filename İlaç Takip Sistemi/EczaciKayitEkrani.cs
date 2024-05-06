using System;
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
    public partial class EczaciKayitEkrani : Form
    {
        public EczaciKayitEkrani()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Eczaci(username, password) values(@p1, @p2)", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormManager.formOpen(this, new EczaciGirisEkrani());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı adı hatalı...","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlBaglantisi.baglanti().Close();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new EczaciAnaEkrani());
        }
    }
}
