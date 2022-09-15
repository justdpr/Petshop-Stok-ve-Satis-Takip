using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler UrunForm = new frmUrunler();
            UrunForm.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            frmSatis SatisForm = new frmSatis();
            SatisForm.ShowDialog();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler MusteriForm = new frmMusteriler();
            MusteriForm.ShowDialog();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            frmSatislar SatislarForm = new frmSatislar();
            SatislarForm.ShowDialog();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            frmKullaniciGirisi kullaniciGirisForm = new frmKullaniciGirisi();
            kullaniciGirisForm.ShowDialog();
            this.Hide();

            if(kullaniciGirisForm.DialogResult == DialogResult.OK)
            {
                this.Show();
                this.Text = "dpR SATIŞ VE STOK TAKİP - " + Ayarlar.kullanici;
                if (Ayarlar.yetki == "YÖNETİCİ")
                {
                    btnKullanicilar.Enabled = true;
                }
                else
                {
                    btnKullanicilar.Enabled = false;
                    btnKullanicilar.Visible = false;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            frmKullanicilar kullaniciForm = new frmKullanicilar();
            kullaniciForm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
