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
    public partial class frmUrunIslemleri : Form
    {
        public frmUrunIslemleri()
        {
            InitializeComponent();
        }
        public static string islem;
        public static string barkod;
        public static string tanim;
        public static string firma;
        SqlConnection baglanti = Ayarlar.baglanti;
        SqlCommand sqlcmd = new SqlCommand();
        int StokEklemeDurumu = 0;
        int islemDurumu = 0;
        Guid StokKodu;

        private void UrunEkle()
        {
            StokKodu = Guid.NewGuid();
            if (nmrAdet.Value >= 0 && txtAlis.Text != "" && txtSatis.Text != "" && StokKodu != null)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    sqlcmd.Connection = baglanti;
                    sqlcmd.CommandText = "INSERT INTO stok (id,adet,alis,satis,tarih) VALUES (@id,@adet,@alis,@satis,@tarih)";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = StokKodu;
                    sqlcmd.Parameters.Add("@adet", SqlDbType.Int).Value = Convert.ToInt32(nmrAdet.Value);
                    sqlcmd.Parameters.Add("@alis", SqlDbType.Money).Value = txtAlis.Text;
                    sqlcmd.Parameters.Add("@satis", SqlDbType.Money).Value = txtSatis.Text;
                    sqlcmd.Parameters.Add("@tarih", SqlDbType.Date).Value = DateTime.Now;
                    StokEklemeDurumu = sqlcmd.ExecuteNonQuery();
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

                if (StokEklemeDurumu == 1)
                {
                    if (txtBarkod.Text != "" && txtTanim.Text != "" && txtFirma.Text != "" && StokKodu != null)
                    {
                        try
                        {
                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();

                            sqlcmd.Connection = baglanti;
                            sqlcmd.CommandText = "INSERT INTO urun (barkod,tanim,firma,stok) VALUES (@barkod,@tanim,@firma,@stok)";
                            sqlcmd.Parameters.Clear();
                            sqlcmd.Parameters.Add("@barkod", SqlDbType.VarChar).Value = txtBarkod.Text;
                            sqlcmd.Parameters.Add("@tanim", SqlDbType.VarChar).Value = txtTanim.Text;
                            sqlcmd.Parameters.Add("@firma", SqlDbType.VarChar).Value = txtFirma.Text;
                            sqlcmd.Parameters.Add("@stok", SqlDbType.UniqueIdentifier).Value = StokKodu;
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
            }
            else
            {
                MessageBox.Show("Alanları kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UrunDuzenle()
        {
            if (txtBarkod.Text != "" && txtTanim.Text != "" && txtFirma.Text != "")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    sqlcmd.Connection = baglanti;
                    sqlcmd.CommandText = "UPDATE urun SET tanim=@tanim,firma=@firma WHERE barkod=@barkod";
                    sqlcmd.Parameters.Clear();
                    sqlcmd.Parameters.Add("@barkod", SqlDbType.VarChar).Value = txtBarkod.Text;
                    sqlcmd.Parameters.Add("@tanim", SqlDbType.VarChar).Value = txtTanim.Text;
                    sqlcmd.Parameters.Add("@firma", SqlDbType.VarChar).Value = txtFirma.Text;
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

        private void frmUrunIslemleri_Load(object sender, EventArgs e)
        {
            if (islem == "ÜRÜN EKLE")
            {
                grpStok.Enabled = true;
            }
            else if (islem == "ÜRÜN DÜZENLE")
            {
                grpStok.Enabled = false;
                txtBarkod.Enabled = false;
                txtBarkod.Text = barkod;
                txtTanim.Text = tanim;
                txtFirma.Text = firma;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (islem == "ÜRÜN EKLE")
            {
                UrunEkle();
            }
            else if (islem == "ÜRÜN DÜZENLE")
            {
                UrunDuzenle();
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