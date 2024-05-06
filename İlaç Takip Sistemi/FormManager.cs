using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlaç_Takip_Sistemi
{
    public static class FormManager
    {
        public static int ecza_id;
        public static string ecza_name;
        public static int depo_id;
        public static string depo_name;
        public static void formOpen(Form currentForm,Form newForm)
        {
            
            currentForm.Hide();
            newForm.ShowDialog();
            currentForm.Close();
            
        }


      
    }
}
