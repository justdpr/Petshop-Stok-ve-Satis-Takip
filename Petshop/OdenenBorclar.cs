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
    public partial class frmOdenenBorclar : Form
    {
        public frmOdenenBorclar()
        {
            InitializeComponent();
        }
        public static string tc;
        public static string musteri;
        SqlConnection baglanti = Ayarlar.baglanti;
        DataTable OdenenBorcTablo;
        SqlDataAdapter sqlAdapter;

        private void BorcGetir()
        {
            OdenenBorcTablo = new DataTable();
            string komut = "SELECT tarih,miktar FROM odenenborc WHERE tc='" + tc + "'";
            sqlAdapter = new SqlDataAdapter(komut, baglanti);
            sqlAdapter.Fill(OdenenBorcTablo);
            dgwOdenenBorc.DataSource = OdenenBorcTablo;
        }

        private void frmOdenenBorclar_Load(object sender, EventArgs e)
        {
            txtMusteri.Text = musteri;
            BorcGetir();
        }
    }
}
