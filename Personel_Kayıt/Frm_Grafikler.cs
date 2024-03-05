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
    public partial class Frm_Grafikler : Form
    {
        public Frm_Grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=numantuncel\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True");// trust kısmını sildik

        private void Frm_Grafikler_Load(object sender, EventArgs e)
        {
            // Grafik 1
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select per_SEHİR,COUNT(*) from Tbl_Personel Group By per_SEHİR",baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr1[0], dr1[1]);// points x ve y kordinatı için 
                // dr1[0] sql deki çalışma mantığına göre 0. indexde sehirler var 1 de de count var 
            }
            baglanti.Close();

            // Grafik 2
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select per_MESLEK ,Avg(per_MAAS) from Tbl_Personel group by per_MESLEK",baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek/Maaş"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();

        }

 
    }
}
