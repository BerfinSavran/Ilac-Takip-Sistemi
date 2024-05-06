using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlaç_Takip_Sistemi
{
    public static class SqlBaglantisi
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=Berfin\SQLEXPRESS;Initial Catalog=IlacTakipSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
