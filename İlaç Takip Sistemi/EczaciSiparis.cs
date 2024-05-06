using System;
using System.Collections;
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
    public partial class EczaciSiparis : Form
    {
        public EczaciSiparis()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
        }

        int adet = 0;
        int newstock;

        private void listele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Depo_ilac.id, username, ilac_name, ilac_price, ilac_stok from Depo_ilac join Depocu on Depo_ilac.depo_id = Depocu.id", SqlBaglantisi.baglanti());
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

        private void geri_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new Eczaciİlac());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void siparis_Click(object sender, EventArgs e)
        {
            try
            {
                depoGuncelle();
                siparisEkle();
                MessageBox.Show("Sipariş başarılı...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public void siparisEkle()
        {
            SqlCommand kontrol = new SqlCommand("select * from Ecza_ilac where ilac_name=@ilac_name and ecza_id=@ecza_id",SqlBaglantisi.baglanti());
            kontrol.Parameters.AddWithValue("@ilac_name", txt_isim.Text);
            kontrol.Parameters.AddWithValue("@ecza_id", FormManager.ecza_id);
            SqlDataReader rd = kontrol.ExecuteReader();

            if(rd.Read())
            {
                int mevcutStok = Convert.ToInt32(rd["ilac_stok"]);
                int yeniStok = Convert.ToInt32(txt_adet.Text) + mevcutStok;
                
                SqlCommand guncelle = new SqlCommand("update Ecza_ilac set ilac_stok=@p1 where ilac_name=@p2 and ecza_id=@p3", SqlBaglantisi.baglanti());
                guncelle.Parameters.AddWithValue("@p1", yeniStok);
                guncelle.Parameters.AddWithValue("@p2", rd["ilac_name"]);
                guncelle.Parameters.AddWithValue("@p3", FormManager.ecza_id);
                guncelle.ExecuteNonQuery();
            }
            else
            {
                rd.Close();
                SqlCommand komutekle = new SqlCommand("insert into Ecza_ilac(ilac_name, ilac_stok, ecza_id) values(@p1, @p2, @p3)", SqlBaglantisi.baglanti());
                komutekle.Parameters.AddWithValue("@p1", txt_isim.Text);
                komutekle.Parameters.AddWithValue("@p2", txt_adet.Text);
                komutekle.Parameters.AddWithValue("@p3", FormManager.ecza_id);
                try
                {
                    komutekle.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            txt_isim.Clear();
            txt_fiyat.Clear();
            txt_stok.Clear();
            txt_adet.Clear();
        }

        public void depoGuncelle()
        {
            adet = Convert.ToInt32(txt_adet.Text);
            newstock = Convert.ToInt32(txt_stok.Text) - adet;

            SqlCommand depoguncel = new SqlCommand("update Depo_ilac set ilac_stok=@p1 where id=@p2 and depo_id=@p3", SqlBaglantisi.baglanti());
            depoguncel.Parameters.AddWithValue("@p1", newstock);
            depoguncel.Parameters.AddWithValue("@p2", label1.Text);
            depoguncel.Parameters.AddWithValue("@p3", label2.Text);
            try
            {
                depoguncel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
