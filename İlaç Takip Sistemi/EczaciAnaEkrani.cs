using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlaç_Takip_Sistemi
{
    public partial class EczaciAnaEkrani : Form
    {
        public EczaciAnaEkrani()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new EczaciGirisEkrani());
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new EczaciKayitEkrani());
        }

        private void geri_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this, new AnaGirisEkrani());
        }
    }
}
