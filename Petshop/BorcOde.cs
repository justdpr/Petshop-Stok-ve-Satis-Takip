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
    public partial class frmBorcOde : Form
    {
        public frmBorcOde()
        {
            InitializeComponent();
        }
        public static string tc;
        public static string musteri;
        public static string borc;
        int BorcOdemeDurumu = 0;
        int OdenenBorcEklemeDurumu = 0;
        SqlConnection baglanti = Ayarlar.baglanti;
        SqlCommand sqlcmd = new SqlCommand();
        double kalanborc;

        private void frmBorcOde_Load(object sender, EventArgs e)
        {
            txtMusteri.Text = musteri;
            txtBorc.Text = borc;
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if(tc != null && txtBorc.Text != "" && txtOdenen.Text != "")
            {
                double guncelborc = Convert.ToDouble(txtBorc.Text);
                double odenenborc=Convert.ToDouble(txtOdenen.Text);
                kalanborc = guncelborc - odenenborc;
                if (kalanborc >= 0)
                {
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();

                        sqlcmd.Connection = baglanti;
                        sqlcmd.CommandText = "UPDATE musteri SET borc=@borc WHERE tc=@tc";
                        sqlcmd.Parameters.Clear();
                        sqlcmd.Parameters.Add("@tc", SqlDbType.Char).Value = tc;
                        sqlcmd.Parameters.Add("@borc", SqlDbType.Money).Value = kalanborc;
                        BorcOdemeDurumu = sqlcmd.ExecuteNonQuery();
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

                    if (BorcOdemeDurumu == 1)
                    {
                        try
                        {
                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();

                            sqlcmd.Connection = baglanti;
                            sqlcmd.CommandText = "INSERT INTO odenenborc (tc,tarih,miktar) VALUES (@tc,@tarih,@miktar)";
                            sqlcmd.Parameters.Clear();
                            sqlcmd.Parameters.Add("@tc", SqlDbType.Char).Value = tc;
                            sqlcmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = DateTime.Now;
                            sqlcmd.Parameters.Add("@miktar", SqlDbType.Money).Value = txtOdenen.Text;
                            OdenenBorcEklemeDurumu = sqlcmd.ExecuteNonQuery();
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

                        if (OdenenBorcEklemeDurumu == 1)
                        {
                            MessageBox.Show("İşlem başarı ile gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        } 
                    }
                }
            }
        }
    }
}
