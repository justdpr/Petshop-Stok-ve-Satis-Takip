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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable MusteriTablo;
        DataTable UrunTablo;
        SqlDataAdapter sqlAdapter;
        int SatisEklemeDurumu = 0;
        int SepetEklemeDurumu = 0;
        int StokEksiltmeDurumu = 0;
        int BorcEklemeDurumu = 0;
        SqlCommand sqlcmd = new SqlCommand();
        public static string tc;
        int sepetsayi = 0;
        double sepettoplam = 0;
        double MusteriBorc;
        private void frmSatis_Load(object sender, EventArgs e)
        {
            txtBarkod.Focus();
        }

        private void UrunTemizle()
        {
            nmrAdet.Value = 1;
            txtUrun.Clear();
            txtStok.Clear();
            txtFiyat.Clear();
        }
        private void MusteriGetir()
        {
            MusteriTablo = new DataTable();
            string komut = "SELECT tc,adi,soyadi,telefon,borc FROM musteri WHERE tc='" + txtTc.Text + "'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(MusteriTablo);

            if (MusteriTablo.Rows.Count == 1)
            {
                txtAdi.Text = MusteriTablo.Rows[0]["adi"].ToString();
                txtSoyadi.Text = MusteriTablo.Rows[0]["soyadi"].ToString();
                txtTelefon.Text = MusteriTablo.Rows[0]["telefon"].ToString();
                MusteriBorc = Convert.ToDouble(MusteriTablo.Rows[0]["borc"].ToString());
            }
            else
            {
                txtAdi.Clear();
                txtSoyadi.Clear();
                txtTelefon.Clear();
                MusteriBorc = 0;
            }   
        }
        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            UrunTablo = new DataTable();
            string komut = "SELECT barkod,tanim,stok,adet,satis FROM urun INNER JOIN stok ON urun.stok=stok.id WHERE barkod='" + txtBarkod.Text + "'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(UrunTablo);

            if (UrunTablo.Rows.Count == 1)
            {
                txtUrun.Text = UrunTablo.Rows[0]["tanim"].ToString();
                txtStok.Text = UrunTablo.Rows[0]["adet"].ToString();
                txtFiyat.Text = UrunTablo.Rows[0]["satis"].ToString();
            }
            else
            {
                UrunTemizle();
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "")
            {
                if (UrunTablo.Rows.Count == 1)
                {
                    int adet = Convert.ToInt32(nmrAdet.Value);
                    int urunadet = Convert.ToInt32(txtStok.Text);
                    double fiyat = adet * Convert.ToDouble(txtFiyat.Text);
                    if((urunadet > 0) && (urunadet - adet > -1))
                    {
                        dgwSepet.Rows.Add(UrunTablo.Rows[0]["barkod"].ToString(), UrunTablo.Rows[0]["stok"].ToString(), UrunTablo.Rows[0]["adet"].ToString(), UrunTablo.Rows[0]["tanim"].ToString(), nmrAdet.Value.ToString(), fiyat.ToString());
                        UrunTemizle();
                        txtBarkod.Clear();
                        txtBarkod.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Stok yeterli değil.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün bilgisi bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriIslemleri musteriEkle = new frmMusteriIslemleri();
            musteriEkle.Text = "MÜŞTERİ EKLE";
            frmMusteriIslemleri.islem = "MÜŞTERİ EKLE SATIŞ";
            musteriEkle.ShowDialog();

            if (musteriEkle.DialogResult == DialogResult.OK)
            {
                txtTc.Text = tc;
                MusteriGetir();
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if(dgwSepet.Rows.Count > 0 && txtTc.Text != "" && txtToplam.Text != "" && txtOdenen.Text != "")
            {
                double toplam = Convert.ToDouble(txtToplam.Text);
                double odenen = Convert.ToDouble(txtOdenen.Text);
                double borc = toplam - odenen;

                if(borc >= 0)
                {
                    Guid satisid = Guid.NewGuid();
                    Guid sepetid = Guid.NewGuid();

                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        sqlcmd.Connection = baglanti;
                        sqlcmd.CommandText = "INSERT INTO satis (satisid,sepet,musteri,tarih,satisyapan) VALUES (@satisid,@sepet,@musteri,@tarih,@satisyapan)";
                        sqlcmd.Parameters.Clear();
                        sqlcmd.Parameters.Add("@satisid", SqlDbType.UniqueIdentifier).Value = satisid;
                        sqlcmd.Parameters.Add("@sepet", SqlDbType.UniqueIdentifier).Value = sepetid;
                        sqlcmd.Parameters.Add("@musteri", SqlDbType.Char).Value = txtTc.Text;
                        sqlcmd.Parameters.Add("@tarih", SqlDbType.Date).Value = DateTime.Now;
                        sqlcmd.Parameters.Add("@satisyapan", SqlDbType.VarChar).Value = Ayarlar.kullanici;
                        SatisEklemeDurumu = sqlcmd.ExecuteNonQuery();
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

                    if (SatisEklemeDurumu == 1)
                    {
                        for (int s = 0; s < dgwSepet.Rows.Count; s++)
                        {
                            string barkod = dgwSepet.Rows[s].Cells["dgbarkod"].Value.ToString();
                            Guid stokkod = Guid.Parse(dgwSepet.Rows[s].Cells["dgstok"].Value.ToString());
                            int stokadet = Convert.ToInt32(dgwSepet.Rows[s].Cells["dgadet"].Value.ToString());
                            int urunadet = Convert.ToInt32(dgwSepet.Rows[s].Cells["dgurunadet"].Value.ToString());
                            double fiyat = Convert.ToDouble(dgwSepet.Rows[s].Cells["dgfiyat"].Value.ToString());
                            int yeniadet = stokadet - urunadet;

                            if (barkod != null && stokkod != null && stokadet > 0 && urunadet > 0 && fiyat > 0)
                            {
                                try
                                {
                                    if (baglanti.State == ConnectionState.Closed)
                                        baglanti.Open();

                                    sqlcmd.Connection = baglanti;
                                    sqlcmd.CommandText = "INSERT INTO sepet (sepetid,urun,adet,fiyat) VALUES (@sepetid,@urun,@adet,@fiyat)";
                                    sqlcmd.Parameters.Clear();
                                    sqlcmd.Parameters.Add("@sepetid", SqlDbType.UniqueIdentifier).Value = sepetid;
                                    sqlcmd.Parameters.Add("@urun", SqlDbType.VarChar).Value = barkod;
                                    sqlcmd.Parameters.Add("@adet", SqlDbType.Int).Value = urunadet;
                                    sqlcmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = fiyat;
                                    SepetEklemeDurumu = sqlcmd.ExecuteNonQuery();
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

                                try
                                {
                                    if (baglanti.State == ConnectionState.Closed)
                                        baglanti.Open();

                                    sqlcmd.Connection = baglanti;
                                    sqlcmd.CommandText = "UPDATE stok SET adet=@adet WHERE id=@id";
                                    sqlcmd.Parameters.Clear();
                                    sqlcmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = stokkod;
                                    sqlcmd.Parameters.Add("@adet", SqlDbType.Int).Value = yeniadet;
                                    StokEksiltmeDurumu = sqlcmd.ExecuteNonQuery();
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
                        }
                        if (SepetEklemeDurumu == 1 && StokEksiltmeDurumu == 1)
                        {
                            try
                            {
                                if (baglanti.State == ConnectionState.Closed)
                                    baglanti.Open();

                                sqlcmd.Connection = baglanti;
                                sqlcmd.CommandText = "UPDATE musteri SET borc=@borc WHERE tc=@tc";
                                sqlcmd.Parameters.Clear();
                                sqlcmd.Parameters.Add("@tc", SqlDbType.Char).Value = txtTc.Text; ;
                                sqlcmd.Parameters.Add("@borc", SqlDbType.Money).Value = (borc + MusteriBorc);
                                BorcEklemeDurumu = sqlcmd.ExecuteNonQuery();
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

                            if (BorcEklemeDurumu == 1)
                            {
                                MessageBox.Show("Satış yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Satış yaparken hata oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Alanları kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgwSepet_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgwSepet.Rows[sepetsayi].Cells["dgfiyat"].Value.ToString() != null)
            {
                sepettoplam += Convert.ToDouble(dgwSepet.Rows[sepetsayi].Cells["dgfiyat"].Value.ToString());
                sepetsayi++;
                txtToplam.Text = sepettoplam.ToString();
            }
        }

        private void tmSil_Click(object sender, EventArgs e)
        {
            if (dgwSepet.SelectedRows.Count > 0)
            {
                sepettoplam -= Convert.ToDouble(dgwSepet.CurrentRow.Cells["dgfiyat"].Value.ToString());
                txtToplam.Text = sepettoplam.ToString();
                dgwSepet.Rows.RemoveAt(dgwSepet.SelectedRows[0].Index);
                sepetsayi--;
            }
        }
    }
}
