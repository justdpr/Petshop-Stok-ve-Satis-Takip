using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    internal class Ayarlar
    {
        static string BaglantiCumle = "Data Source=DPR; Initial Catalog=petshop; Integrated Security=True;";
        //static string BaglantiCumle = "Data Source=DPR; Initial Catalog=petshop; User ID=sa; Password=mmyo;";
        public static SqlConnection baglanti = new SqlConnection(BaglantiCumle);
        public static string yetki;
        public static string kullanici;
    }
}
