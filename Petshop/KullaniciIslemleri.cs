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
    public partial class frmKullaniciIslemleri : Form
    {
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
        }
        public static string kullaniciid;
        public static string islem;
        int islemDurumu = 0;
        SqlConnection baglanti = Ayarlar.baglanti;
        SqlCommand sqlcmd = new SqlCommand();
        DataTable KullaniciTablo;
        SqlDataAdapter sqlAdapter;
        string kullaniciadi;
        string sifre;
        string yetki;
        private void KullaniciGetir()
        {
            if (kullaniciid != null)
            {
                KullaniciTablo = new DataTable();
                string komut = "SELECT kullaniciid,kullaniciadi,sifre,yetki FROM kullanici WHERE kullaniciid='" + kullaniciid + "'";
                sqlAdapter = new SqlDataAdapter(komut, baglanti);
                sqlAdapter.Fill(KullaniciTablo);

                if (KullaniciTablo.Rows.Count == 1)
                {
                    kullaniciadi = KullaniciTablo.Rows[0]["kullaniciadi"].ToString();
                    sifre = KullaniciTablo.Rows[0]["sifre"].ToString();
                    yetki = KullaniciTablo.Rows[0]["yetki"].ToString();
                }
            }
        }
        private void KullaniciEkle()
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && cmbYetki.SelectedIndex <= 1)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    sqlcmd.Connection = baglanti;
                    sqlcmd.CommandText = "INSERT INTO kullanici (kullaniciadi,sifre,yetki) VALUES (@kullaniciadi,@sifre,@yetki)";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add("@kullaniciadi", SqlDbType.VarChar).Value = txtKullaniciAdi.Text;
                    sqlcmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value = txtSifre.Text;
                    sqlcmd.Parameters.Add("@yetki", SqlDbType.VarChar).Value = cmbYetki.Text;
                    islemDurumu = sqlcmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Alanları kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void KullaniciDuzenle()
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && cmbYetki.SelectedIndex >= 0 && kullaniciid != null)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    sqlcmd.Connection = baglanti;
                    sqlcmd.CommandText = "UPDATE kullanici SET kullaniciadi=@kullaniciadi,sifre=@sifre,yetki=@yetki WHERE kullaniciid=@kullaniciid";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add("@kullaniciid", SqlDbType.Int).Value = Convert.ToInt32(kullaniciid);
                    sqlcmd.Parameters.Add("@kullaniciadi", SqlDbType.VarChar).Value = txtKullaniciAdi.Text;
                    sqlcmd.Parameters.Add("@sifre", SqlDbType.VarChar).Value = txtSifre.Text;
                    sqlcmd.Parameters.Add("@yetki", SqlDbType.VarChar).Value = cmbYetki.Text;
                    islemDurumu = sqlcmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Alanları kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            if (islem == "KULLANICI EKLE")
            {
                cmbYetki.SelectedIndex = 0;
            }
            else if (islem == "KULLANICI DÜZENLE")
            {
                KullaniciGetir();
                txtKullaniciAdi.Text = kullaniciadi;
                txtSifre.Text = sifre;
                cmbYetki.SelectedItem = yetki;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (islem == "KULLANICI EKLE")
            {
                KullaniciEkle();
            }
            else if (islem == "KULLANICI DÜZENLE")
            {
                KullaniciDuzenle();
            }

            if (islemDurumu == 1)
            {
                MessageBox.Show("İşlem başarı ile gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
