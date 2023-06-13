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

namespace HarmonyHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JCTQPOK\\SQLEXPRESS;Initial Catalog=HarmonyHotel;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblPersonelGiris where KullaniciAd=@KullaniciAd and Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAd", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                lblHata.Text = "Kullanıcı Adı veya Şifreniz Hatalı!";
                lblHata.Visible = true;
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                txtSifre.Text = "";
                txtKullaniciAdi.Text = "";
                txtKullaniciAdi.Focus();

            }
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcı adı: Admin, Şifre: Admin ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtKullaniciAdi.Focus();
        }
    }
}
