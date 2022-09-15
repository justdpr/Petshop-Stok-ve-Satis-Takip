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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }
        public static string barkod;
        int islemDurumu = 0;
        SqlConnection baglanti = Ayarlar.baglanti;
        SqlCommand sqlcmd = new SqlCommand();
        DataTable UrunStokTablo;
        SqlDataAdapter sqlAdapter;
        private void UrunStokGetir()
        {
            if(barkod != null)
            {
                UrunStokTablo = new DataTable();
                string komut = "SELECT barkod,tanim,id,adet,alis,satis FROM urun INNER JOIN stok ON urun.stok=stok.id WHERE barkod LIKE '%" + barkod + "%'";
                sqlAdapter = new SqlDataAdapter(komut, baglanti);
                sqlAdapter.Fill(UrunStokTablo);

                txtUrun.Text = UrunStokTablo.Rows[0]["tanim"].ToString();
                nmrAdet.Value = Convert.ToInt32(UrunStokTablo.Rows[0]["adet"].ToString());
                txtAlis.Text = UrunStokTablo.Rows[0]["alis"].ToString();
                txtSatis.Text = UrunStokTablo.Rows[0]["satis"].ToString();
            }
        }

        private void StokGuncelle()
        {
            if (UrunStokTablo.Rows[0]["id"].ToString() != null && nmrAdet.Value >= 0 && txtAlis.Text != "" && txtSatis.Text != "")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    sqlcmd.Connection = baglanti;
                    sqlcmd.CommandText = "UPDATE stok SET adet=@adet,alis=@alis,satis=@satis WHERE id=@id";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = Guid.Parse(UrunStokTablo.Rows[0]["id"].ToString());
                    sqlcmd.Parameters.Add("@adet", SqlDbType.Int).Value = Convert.ToInt32(nmrAdet.Value);
                    sqlcmd.Parameters.Add("@alis", SqlDbType.Money).Value = txtAlis.Text;
                    sqlcmd.Parameters.Add("@satis", SqlDbType.Money).Value = txtSatis.Text;
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            StokGuncelle();
            if (islemDurumu == 1)
            {
                MessageBox.Show("İşlem başarı ile gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            UrunStokGetir();
        }
    }
}
