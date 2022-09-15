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
    public partial class frmMusteriIslemleri : Form
    {
        public frmMusteriIslemleri()
        {
            InitializeComponent();
        }
        public static string islem;
        public static string tc;
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable MusteriTablo;
        SqlDataAdapter sqlAdapter;
        int islemDurumu = 0;
        SqlCommand sqlcmd = new SqlCommand();

        private void MusteriEkle()
        {
            if (txtTc.Text != "" && txtAdi.Text != "" && txtSoyadi.Text != "" && txtTelefon.Text != "")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    sqlcmd.Connection = baglanti;
                    sqlcmd.CommandText = "INSERT INTO musteri (tc,adi,soyadi,telefon,adres,borc) VALUES (@tc,@adi,@soyadi,@telefon,@adres,@borc)";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add("@tc", SqlDbType.Char).Value = txtTc.Text;
                    sqlcmd.Parameters.Add("@adi", SqlDbType.VarChar).Value = txtAdi.Text;
                    sqlcmd.Parameters.Add("@soyadi", SqlDbType.VarChar).Value = txtSoyadi.Text;
                    sqlcmd.Parameters.Add("@telefon", SqlDbType.Char).Value = txtTelefon.Text;
                    sqlcmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = txtAdres.Text;
                    sqlcmd.Parameters.Add("@borc", SqlDbType.Money).Value = 0;
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

        private void MusteriDuzenle()
        {
            if (txtTc.Text != "" && txtAdi.Text != "" && txtSoyadi.Text != "" && txtTelefon.Text != "")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    sqlcmd.Connection = baglanti;
                    sqlcmd.CommandText = "UPDATE musteri SET adi=@adi,soyadi=@soyadi,telefon=@telefon,adres=@adres WHERE tc=@tc";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add("@tc", SqlDbType.Char).Value = txtTc.Text;
                    sqlcmd.Parameters.Add("@adi", SqlDbType.VarChar).Value = txtAdi.Text;
                    sqlcmd.Parameters.Add("@soyadi", SqlDbType.VarChar).Value = txtSoyadi.Text;
                    sqlcmd.Parameters.Add("@telefon", SqlDbType.Char).Value = txtTelefon.Text;
                    sqlcmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = txtAdres.Text;
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
        private void MusteriGetir()
        {
            MusteriTablo = new DataTable();
            string komut = "SELECT tc,adi,soyadi,telefon,adres FROM musteri WHERE tc='" + tc + "'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(MusteriTablo);

            txtTc.Text = MusteriTablo.Rows[0]["tc"].ToString();
            txtAdi.Text = MusteriTablo.Rows[0]["adi"].ToString();
            txtSoyadi.Text = MusteriTablo.Rows[0]["soyadi"].ToString();
            txtTelefon.Text = MusteriTablo.Rows[0]["telefon"].ToString();
            txtAdres.Text = MusteriTablo.Rows[0]["adres"].ToString();
        }
        private void frmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            if (islem == "MÜŞTERİ DÜZENLE")
            {
                txtTc.Enabled = false;
                MusteriGetir();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (islem == "MÜŞTERİ EKLE")
            {
                MusteriEkle();
            }
            else if (islem == "MÜŞTERİ DÜZENLE")
            {
                MusteriDuzenle();
            }
            else if (islem == "MÜŞTERİ EKLE SATIŞ")
            {
                MusteriEkle();
                if (islemDurumu == 1)
                    frmSatis.tc = txtTc.Text;
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
