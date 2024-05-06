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
    public partial class AnaGirisEkrani : Form
    {
        public AnaGirisEkrani()
        {
            InitializeComponent();
        }

        private void eczaci_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this,new EczaciAnaEkrani());
        }

        private void depocu_Click(object sender, EventArgs e)
        {
            FormManager.formOpen(this,new DepocuGirisEkrani());
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
