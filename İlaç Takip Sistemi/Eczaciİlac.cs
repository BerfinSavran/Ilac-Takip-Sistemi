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
    public partial class Eczaciİlac : Form
    {
        public Eczaciİlac()
        {
            InitializeComponent();
            eczaci_isim.Text = "Hoşgeldiniz " + FormManager.ecza_name;
            label1.Visible = false;
        }


        private void siparis_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new EczaciSiparis());
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ecza_ilac set ilac_name=@p1, ilac_stok=@p2, ecza_id=@p3 where id=@p4", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_isim.Text);
            komut.Parameters.AddWithValue("@p2", txt_stok.Text);
            komut.Parameters.AddWithValue("@p3", FormManager.ecza_id);
            komut.Parameters.AddWithValue("@p4", label1.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new AnaGirisEkrani());
        }

        private void listele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Ecza_ilac.id, username, ilac_name, ilac_stok from Ecza_ilac join Eczaci on Ecza_ilac.ecza_id = Eczaci.id where Ecza_id=@p1", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", FormManager.ecza_id);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Eczacı Name";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Stock";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_stok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Ecza_ilac where id=@p1", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", label1.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
