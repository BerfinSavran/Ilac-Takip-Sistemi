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
    public partial class Depocuİlac : Form
    {
        public Depocuİlac()
        {
            InitializeComponent();
            depo_isim.Text = "Hoşgeldiniz " + FormManager.depo_name;
            label1.Visible = false;
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Depo_ilac(ilac_name, ilac_price, ilac_stok, depo_id) values(@p1,@p2,@p3,@p4)", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_isim.Text);
            komut.Parameters.AddWithValue("@p2", txt_fiyat.Text);
            komut.Parameters.AddWithValue("@p3", txt_stok.Text);
            komut.Parameters.AddWithValue("@p4", FormManager.depo_id);

            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme  başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_isim.Clear();
            txt_fiyat.Clear();
            txt_stok.Clear();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new AnaGirisEkrani());
        }

        private void listele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Depo_ilac.id, username, ilac_name, ilac_price, ilac_stok from Depo_ilac join Depocu on Depo_ilac.depo_id = Depocu.id where depo_id=@p1", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", FormManager.depo_id);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Depo Name";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Stock";
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Depo_ilac set ilac_name=@p1, ilac_price=@p2, ilac_stok=@p3, depo_id=@p4 where id=@p5", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_isim.Text);
            komut.Parameters.AddWithValue("@p2", txt_fiyat.Text);
            komut.Parameters.AddWithValue("@p3", txt_stok.Text);
            komut.Parameters.AddWithValue("@p4", FormManager.depo_id);
            komut.Parameters.AddWithValue("@p5", label1.Text);

            try 
            { 
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme  başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Depo_ilac where id=@p1", SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", label1.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme  başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
