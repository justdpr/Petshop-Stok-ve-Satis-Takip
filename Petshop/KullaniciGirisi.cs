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

namespace Petshop
{
    public partial class frmKullaniciGirisi : Form
    {
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable KullaniciTablo;
        SqlDataAdapter sqlAdapter;
        string kullaniciadi;
        string sifre;
        string yetki;
        private void KullaniciGetir()
        {
            KullaniciTablo = new DataTable();
            string komut = "SELECT kullaniciadi,sifre,yetki FROM kullanici WHERE kullaniciadi='" + txtKullaniciAdi.Text + "'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(KullaniciTablo);

            if (KullaniciTablo.Rows.Count == 1)
            {
                kullaniciadi = KullaniciTablo.Rows[0]["kullaniciadi"].ToString();
                sifre = KullaniciTablo.Rows[0]["sifre"].ToString();
                yetki = KullaniciTablo.Rows[0]["yetki"].ToString();
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciGetir();
            if(txtKullaniciAdi.Text == kullaniciadi && txtSifre.Text == sifre)
            {
                Ayarlar.yetki = yetki;
                Ayarlar.kullanici = kullaniciadi;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmKullaniciGirisi_Load(object sender, EventArgs e)
        {
            KullaniciTablo = new DataTable();
            string komut = "SELECT kullaniciid FROM kullanici";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(KullaniciTablo);

            if (KullaniciTablo.Rows.Count == 0)
            {
                MessageBox.Show("Kayıtlı kullanıcı bulunamadı.\nYeni kullancı eklemeniz için gerekli alana yönlendiriliyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmKullaniciIslemleri kullaniciEkle = new frmKullaniciIslemleri();
                kullaniciEkle.Text = "KULLANICI EKLE";
                frmKullaniciIslemleri.islem = "KULLANICI EKLE";
                kullaniciEkle.ShowDialog();

                if (kullaniciEkle.DialogResult == DialogResult.OK)
                {
                    KullaniciGetir();
                }
            }
        }
    }
}
