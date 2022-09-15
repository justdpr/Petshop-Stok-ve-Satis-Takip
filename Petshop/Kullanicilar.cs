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
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable KullaniciTablo;
        SqlDataAdapter sqlAdapter;
        int islemDurumu = 0;
        SqlCommand sqlcmd = new SqlCommand();
        private void KullaniciGetir()
        {
            KullaniciTablo = new DataTable();
            string komut = "SELECT kullaniciid,kullaniciadi,sifre,yetki FROM kullanici";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(KullaniciTablo);
            dgwKullanici.DataSource = KullaniciTablo;
        }
        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            KullaniciGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            KullaniciTablo = new DataTable();
            string komut = "SELECT kullaniciid,kullaniciadi,sifre,yetki FROM kullanici WHERE kullaniciadi LIKE '%" + txtAra.Text + "%'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(KullaniciTablo);
            dgwKullanici.DataSource = KullaniciTablo;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciIslemleri kullaniciEkle = new frmKullaniciIslemleri();
            kullaniciEkle.Text = "KULLANICI EKLE";
            frmKullaniciIslemleri.islem = "KULLANICI EKLE";
            kullaniciEkle.ShowDialog();

            if (kullaniciEkle.DialogResult == DialogResult.OK)
            {
                KullaniciGetir();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgwKullanici.Rows.Count > 0)
            {
                frmKullaniciIslemleri.kullaniciid = dgwKullanici.CurrentRow.Cells["dgkullaniciid"].Value.ToString();
                frmKullaniciIslemleri kullaniciDuzenle = new frmKullaniciIslemleri();
                kullaniciDuzenle.Text = "KULLANICI DÜZENLE";
                frmKullaniciIslemleri.islem = "KULLANICI DÜZENLE";
                kullaniciDuzenle.ShowDialog();

                if (kullaniciDuzenle.DialogResult == DialogResult.OK)
                {
                    KullaniciGetir();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int yonetici = 0;
            for (int i = 0; i < dgwKullanici.Rows.Count; i++)
            {
                string yetki = dgwKullanici.Rows[i].Cells["dgyetki"].Value.ToString();
                if (yetki == "YÖNETİCİ")
                {
                    yonetici++;
                }
            }

            if ((dgwKullanici.Rows.Count > 1 && yonetici > 1 && Ayarlar.kullanici != dgwKullanici.CurrentRow.Cells["dgkullaniciadi"].Value.ToString()) || (dgwKullanici.Rows.Count > 1 && yonetici == 1 && dgwKullanici.CurrentRow.Cells["dgyetki"].Value.ToString() != "YÖNETİCİ" && Ayarlar.kullanici != dgwKullanici.CurrentRow.Cells["dgkullaniciadi"].Value.ToString()))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Kullanıcı Silme İşlemini Onaylıyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        sqlcmd.Connection = baglanti;
                        sqlcmd.CommandText = "DELETE FROM kullanici WHERE kullaniciid=@kullaniciid";
                        sqlcmd.Parameters.Clear();
                        sqlcmd.Parameters.Add("@kullaniciid", SqlDbType.Int).Value = Convert.ToInt32(dgwKullanici.CurrentRow.Cells["dgkullaniciid"].Value.ToString());
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

                if (islemDurumu == 1)
                {
                    islemDurumu = 0;
                    MessageBox.Show("Kullanıcı Silme İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KullaniciGetir();
                }
            }
        }
    }
}