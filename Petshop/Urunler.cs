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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable UrunTablo;
        SqlDataAdapter sqlAdapter;
        private void UrunGetir()
        {
            UrunTablo = new DataTable();
            string komut = "SELECT barkod,tanim,firma,adet FROM urun INNER JOIN stok ON urun.stok=stok.id";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(UrunTablo);
            dgwUrunler.DataSource = UrunTablo;
        }
        private void frmUrunler_Load(object sender, EventArgs e)
        {
            UrunGetir();
            if (Ayarlar.yetki != "YÖNETİCİ")
            {
                btnEkle.Enabled = false;
                btnDuzenle.Enabled = false;
                btnStokEkle.Enabled = false;
                btnEkle.Visible = false;
                btnDuzenle.Visible = false;
                btnStokEkle.Visible = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmUrunIslemleri urunEkle = new frmUrunIslemleri();
            urunEkle.Size = new Size(480, 345);
            urunEkle.Text = "ÜRÜN EKLE";
            frmUrunIslemleri.islem = "ÜRÜN EKLE";
            urunEkle.ShowDialog();

            if (urunEkle.DialogResult == DialogResult.OK)
            {
                UrunGetir();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgwUrunler.Rows.Count > 0)
            {
                frmUrunIslemleri.barkod = dgwUrunler.CurrentRow.Cells["dgbarkod"].Value.ToString();
                frmUrunIslemleri.tanim = dgwUrunler.CurrentRow.Cells["dgtanim"].Value.ToString();
                frmUrunIslemleri.firma = dgwUrunler.CurrentRow.Cells["dgfirma"].Value.ToString();
                frmUrunIslemleri urunDuzenle = new frmUrunIslemleri();
                urunDuzenle.Size = new Size(480, 180);
                urunDuzenle.Text = "ÜRÜN DÜZENLE";
                frmUrunIslemleri.islem = "ÜRÜN DÜZENLE";
                urunDuzenle.ShowDialog();

                if (urunDuzenle.DialogResult == DialogResult.OK)
                {
                    UrunGetir();
                }
            }
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            if (dgwUrunler.Rows.Count > 0)
            {
                frmStok.barkod = dgwUrunler.CurrentRow.Cells["dgbarkod"].Value.ToString();
                frmStok stokEkle = new frmStok();
                stokEkle.ShowDialog();

                if (stokEkle.DialogResult == DialogResult.OK)
                {
                    UrunGetir();
                }
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            UrunTablo = new DataTable();
            string komut = "SELECT barkod,tanim,firma,adet FROM urun INNER JOIN stok ON urun.stok=stok.id WHERE tanim LIKE '%" + txtAra.Text + "%'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(UrunTablo);
            dgwUrunler.DataSource = UrunTablo;
        }
    }
}
