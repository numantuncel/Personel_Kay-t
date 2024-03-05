using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;// gerekli kütüphane

namespace Personel_Kayıt
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=numantuncel\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabani;Integrated Security=True");// trust kısmını sildik
        
        
        void temizle()//temizle methodu
        {
            textpersonelid.Clear();
            textpersonelad.Clear();//kutuyu temizler clear() methodu
            textpersonelsoyad.Clear();
            combosehir.Text = "";//items.clear tüm öğeleri siliyor en mantıklısı bu 
            maskedmaas.Clear();
            textmeslek.Clear();
            radioevli.Checked = false;
            radiobekar.Checked = false;
            textpersonelad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel); olması gereken yer buraydı biz listele butonu içine aldık

        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);// fill doldur demek datagriti doldurduk

        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (per_AD,per_SOYAD,per_SEHİR,per_MAAS,per_DURUM,per_MESLEK) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);//parametre(p) 1 ve 2
            komut.Parameters.AddWithValue("@p1", textpersonelad.Text);//parametre 1'i textpersonelad dan al 
            komut.Parameters.AddWithValue("@p2", textpersonelsoyad.Text);
            komut.Parameters.AddWithValue("@p3", combosehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedmaas.Text);
            if (radioevli.Checked)
            {
                komut.Parameters.AddWithValue("p5", true);
            }
            if(radiobekar.Checked)
            {
                komut.Parameters.AddWithValue("p5", false);
            }
            komut.Parameters.AddWithValue("@p6", textmeslek.Text);

            komut.ExecuteNonQuery();// sorguyu çalıştırır.(insert ,update ,delete de kullanılır.),tablo da etkilenme değişme durumu olursa
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            //seçilen datagridview hücresinin 0. indexini yani id sini secilendegere  değişkenine ata.(çok kolay burayı anla;

            textpersonelid.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            // datagridin seçilen satırın(id) 0. hücresinin değerini textpersonelid ye ata
            textpersonelad.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            // 1. hücresini ad a ata ... diye devam eder
            textpersonelsoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            combosehir.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            maskedmaas.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            if (Convert.ToBoolean(dataGridView1.Rows[secilendeger].Cells[5].Value) == true)
            {
                radioevli.Checked = true;
            }
            if(Convert.ToBoolean(dataGridView1.Rows[secilendeger].Cells[5].Value) == false)
            {
                radiobekar.Checked = true;
            }
            textmeslek.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();


        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where per_ID=@k1",baglanti);// k,a gibi değerler sadece veriyi tutar
            komutsil.Parameters.AddWithValue("@k1", textpersonelid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update Tbl_Personel Set per_AD=@a1,per_SOYAD=@a2,per_SEHİR=@a3,per_MAAS=@a4,per_DURUM=@a5,per_MESLEK=@a6 Where per_ID=@a7",baglanti);
            komutgüncelle.Parameters.AddWithValue("@a1", textpersonelad.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", textpersonelsoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", combosehir.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", maskedmaas.Text);
            if (radioevli.Checked)
            {
                komutgüncelle.Parameters.AddWithValue("@a5", true);
            }
            if (radiobekar.Checked)
            {
                komutgüncelle.Parameters.AddWithValue("@a5", false);//bekar seçiliyse veri tabanına false gitrcek
            }
            komutgüncelle.Parameters.AddWithValue("@a6", textmeslek.Text);
            komutgüncelle.Parameters.AddWithValue("@a7", textpersonelid.Text);// bura çok önemli asla unutma 
            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi.");

        }

        private void buttonistatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.Show();
            this.Hide();
        }

        private void buttongrafikler_Click(object sender, EventArgs e)
        {
            Frm_Grafikler frm_Grafikler = new Frm_Grafikler();
            frm_Grafikler.Show();
            this.Hide();
        }

        private void textpersonelid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
