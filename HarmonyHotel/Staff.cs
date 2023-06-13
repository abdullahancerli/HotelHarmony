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

namespace HarmonyHotel
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JCTQPOK\\SQLEXPRESS;Initial Catalog=HarmonyHotel;Integrated Security=True");

        private void Staff_Load(object sender, EventArgs e)
        {
            
            this.tblPersonelTableAdapter.Fill(this.harmonyHotelDataSet5.tblPersonel);
            //Toplam personel
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from tblPersonel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblPersonelSayi.Text = dr1[0].ToString();
            }
            baglanti.Close();

            // Kadın Personel
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from tblPersonel where PerCinsiyet= 'Kadın'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKadinSayi.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // Erkek Personel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from tblPersonel where PerCinsiyet= 'Erkek'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblErkekSayi.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // Görev Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerGorev)) from tblPersonel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblGörev.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // Aktif Personel
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select count(*) from tblPersonel where PerDurum= 'Aktif'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblAktifPersonel.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // Raorlu Personel
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select count(*) from tblPersonel where PerDurum= 'Raporlu'", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblRaporluPersonel.Text = dr6[0].ToString();
            }
            baglanti.Close();

            // İzinli Personel
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select count(*) from tblPersonel where PerDurum= 'İzinli'", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblIzinliPersonel.Text = dr7[0].ToString();
            }
            baglanti.Close();


        }

        private void btnIstatislik_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
