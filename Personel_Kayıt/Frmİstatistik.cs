using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayıt
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=numantuncel\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True");// trust kısmını sildik
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            //// Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1= komut1.ExecuteReader();//execute reader select için sorguyu çalıştırır.
            while(dr1.Read())// dr1 komutu okuma işlemi yaptığı müddetçe
            {
                labelpersayisi.Text = dr1[0].ToString();// Select Count(*) From Tbl_Personel = okuduktan sonra bu komut çalıştığında sql de çıkan sonuç 0. indexde durur
                // bunun içi uygulma üzerinden çalıştır deneme için.
            }
            baglanti.Close();

            //// Evli Personel Sayisi
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where per_DURUM=1", baglanti);
            SqlDataReader dr2= komut2.ExecuteReader();
            while(dr2.Read())
            {
                labelevli.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //// Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where per_DURUM=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                labelbekar.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //// Farklı Şehir Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(Distinct per_SEHİR) From Tbl_Personel ", baglanti);// ya DISTINCT olacak yada distnict
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                labelfarklısehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            ///// Toplam Maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select SUM(per_MAAS) From Tbl_Personel ", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                labelmaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //// Ortalma Maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select AVG(per_MAAS) From Tbl_Personel ", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                labelortalmamaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
