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
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable SatisTablo;
        DataTable SepetTablo = new DataTable();
        SqlDataAdapter sqlAdapter;
        private void SatisGetir()
        {
            SepetTablo.Clear();
            dgwSepet.DataSource = SepetTablo;
            SatisTablo = new DataTable();
            string komut = "SELECT tc,adi,soyadi,telefon,borc,tarih,sepet,satisyapan FROM satis INNER JOIN musteri ON satis.musteri=musteri.tc";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(SatisTablo);
            dgwSatislar.DataSource = SatisTablo;
        }
        private void SepetGetir()
        {
            SepetTablo.Clear();
            dgwSepet.DataSource = SepetTablo;
            string komut = "SELECT tanim,adet,fiyat FROM sepet INNER JOIN urun ON sepet.urun=urun.barkod WHERE sepetid='" + Guid.Parse(dgwSatislar.CurrentRow.Cells["dgsepet"].Value.ToString()) + "'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(SepetTablo);
            dgwSepet.DataSource = SepetTablo;
        }
        private void frmSatislar_Load(object sender, EventArgs e)
        {
            SatisGetir();
        }

        private void dgwSatislar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwSatislar.Rows.Count > 0)
            {
                if (dgwSatislar.CurrentRow.Cells["dgsepet"].Value.ToString() != null)
                {
                    SepetGetir();
                }
                else
                {
                    SepetTablo.Clear();
                    dgwSepet.DataSource = SepetTablo;
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (chcBorc.Checked == true)
            {
                SepetTablo.Clear();
                dgwSepet.DataSource = SepetTablo;
                SatisTablo = new DataTable();
                string komut = "SELECT tc,adi,soyadi,telefon,borc,tarih,sepet FROM satis INNER JOIN musteri ON satis.musteri=musteri.tc WHERE tarih BETWEEN @tarihOnce AND @tarihSonra AND borc>0 AND tc LIKE '%" + txtTc.Text + "%'";
                sqlAdapter = new SqlDataAdapter(komut, baglanti);
                sqlAdapter.SelectCommand.Parameters.Add("@tc", SqlDbType.Char).Value = txtTc.Text;
                sqlAdapter.SelectCommand.Parameters.Add("@tarihOnce", SqlDbType.Date).Value = dtpOnce.Value;
                sqlAdapter.SelectCommand.Parameters.Add("@tarihSonra", SqlDbType.Date).Value = dtpSonra.Value;
                sqlAdapter.Fill(SatisTablo);
                dgwSatislar.DataSource = SatisTablo;
            }
            else
            {
                SepetTablo.Clear();
                dgwSepet.DataSource = SepetTablo;
                SatisTablo = new DataTable();
                string komut = "SELECT tc,adi,soyadi,telefon,borc,tarih,sepet FROM satis INNER JOIN musteri ON satis.musteri=musteri.tc WHERE tarih BETWEEN @tarihOnce AND @tarihSonra AND tc LIKE '%" + txtTc.Text + "%'";
                sqlAdapter = new SqlDataAdapter(komut, baglanti);
                sqlAdapter.SelectCommand.Parameters.Add("@tc", SqlDbType.Char).Value = txtTc.Text;
                sqlAdapter.SelectCommand.Parameters.Add("@tarihOnce", SqlDbType.Date).Value = dtpOnce.Value;
                sqlAdapter.SelectCommand.Parameters.Add("@tarihSonra", SqlDbType.Date).Value = dtpSonra.Value;
                sqlAdapter.Fill(SatisTablo);
                dgwSatislar.DataSource = SatisTablo;
            }
        }
    }
}
