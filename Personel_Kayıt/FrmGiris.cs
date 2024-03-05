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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=numantuncel\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True");// trust kısmını sildik
        private void buttongirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Yönetici where ad=@p1 and sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", textkullanıciad.Text);// komuta parametre olarak text deki değer ile ekle parametre(p1)
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())// okuma işlemi başarılıysa
            {
                MessageBox.Show("Giriş Başarlı.");
                FrmAnaForm fra = new FrmAnaForm();
                fra.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifre Hatalı.");
            }
            baglanti.Close();

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
