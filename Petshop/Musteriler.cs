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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable MusteriTablo;
        SqlDataAdapter sqlAdapter;
        private void MusteriGetir()
        {
            MusteriTablo = new DataTable();
            string komut = "SELECT tc,adi,soyadi,telefon,adres,borc FROM musteri";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(MusteriTablo);
            dgwMusteriler.DataSource = MusteriTablo;
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMusteriIslemleri musteriEkle = new frmMusteriIslemleri();
            musteriEkle.Text = "MÜŞTERİ EKLE";
            frmMusteriIslemleri.islem = "MÜŞTERİ EKLE";
            musteriEkle.ShowDialog();

            if (musteriEkle.DialogResult == DialogResult.OK)
            {
                MusteriGetir();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgwMusteriler.Rows.Count > 0)
            {
                frmMusteriIslemleri.tc = dgwMusteriler.CurrentRow.Cells["dgtc"].Value.ToString();
                frmMusteriIslemleri musteriDuzenle = new frmMusteriIslemleri();
                musteriDuzenle.Text = "MÜŞTERİ DÜZENLE";
                frmMusteriIslemleri.islem = "MÜŞTERİ DÜZENLE";
                musteriDuzenle.ShowDialog();

                if (musteriDuzenle.DialogResult == DialogResult.OK)
                {
                    MusteriGetir();
                }
            }
        }

        private void btnBorcOde_Click(object sender, EventArgs e)
        {
            if (dgwMusteriler.Rows.Count > 0)
            {
                double borc = Convert.ToDouble(dgwMusteriler.CurrentRow.Cells["dgborc"].Value.ToString());

                if (borc > 0)
                {
                    frmBorcOde.musteri = dgwMusteriler.CurrentRow.Cells["dgadi"].Value.ToString() + " " + dgwMusteriler.CurrentRow.Cells["dgsoyadi"].Value.ToString();
                    frmBorcOde.borc = dgwMusteriler.CurrentRow.Cells["dgborc"].Value.ToString();
                    frmBorcOde.tc = dgwMusteriler.CurrentRow.Cells["dgtc"].Value.ToString();
                    frmBorcOde borcOde = new frmBorcOde();
                    borcOde.ShowDialog();

                    if (borcOde.DialogResult == DialogResult.OK)
                    {
                        MusteriGetir();
                    }
                }
                else
                {
                    MessageBox.Show("Borç bilgisi bulunamamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            MusteriTablo = new DataTable();
            string komut = "SELECT tc,adi,soyadi,telefon,adres,borc FROM musteri WHERE tc LIKE '%" + txtAra.Text + "%'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(MusteriTablo);
            dgwMusteriler.DataSource = MusteriTablo;
        }

        private void btnOdenenBorclar_Click(object sender, EventArgs e)
        {
            if (dgwMusteriler.Rows.Count > 0)
            {
                frmOdenenBorclar.musteri = dgwMusteriler.CurrentRow.Cells["dgadi"].Value.ToString() + " " + dgwMusteriler.CurrentRow.Cells["dgsoyadi"].Value.ToString();
                frmOdenenBorclar.tc = dgwMusteriler.CurrentRow.Cells["dgtc"].Value.ToString();
                frmOdenenBorclar OdenenBorclar = new frmOdenenBorclar();
                OdenenBorclar.ShowDialog();
            }
        }
    }
}