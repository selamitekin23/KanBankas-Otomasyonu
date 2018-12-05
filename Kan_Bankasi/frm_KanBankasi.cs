using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kan_Bankasi
{
    public partial class frm_KanBankasi : Form
    {
        public frm_KanBankasi()
        {
            InitializeComponent();
        }

        private void timer_BİLGİ_Tick(object sender, EventArgs e)
        {
            frm_Kullanici_girisi KullaniciGiris = new frm_Kullanici_girisi();
            KullaniciGiris.Show();
            timer_BİLGİ.Stop();
            timer_BİLGİ.Enabled = false;
            this.Close();
           
           
        }

        private void frm_KanBankasi_Load(object sender, EventArgs e)
        {
            timer_BİLGİ.Enabled = true;
        }
    }
}
