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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection.Emit;

namespace HarmonyHotel
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JCTQPOK\\SQLEXPRESS;Initial Catalog=HarmonyHotel;Integrated Security=True");
       
        private void clear()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            RadioKadin.Checked = false;
            RadioErkek.Checked = false;
            txtTc.Text = "";
            mskdTel.Text = "";
            txtOda.Text = "";
            txtUcret.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into tblMusteriKayit (MusAd, MusSoyad, MusTelefon, MusCinsiyet, MusTc, MusOda, MusUcret, MusGiris, MusCikis) values (@MusAd, @MusSoyad, @MusTelefon, @MusCinsiyet, @MusTc, @MusOda, @MusUcret, @GirisTarih, @CikisTarih)", baglanti);
            ekle.Parameters.AddWithValue("@MusAd", txtAd.Text);
            ekle.Parameters.AddWithValue("@MusSoyad", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@MusTelefon", mskdTel.Text);
            ekle.Parameters.AddWithValue("@MusCinsiyet", RadioErkek.Checked ? RadioErkek.Text : (RadioKadin.Checked ? RadioKadin.Text : ""));
            ekle.Parameters.AddWithValue("@MusTc", txtTc.Text);
            ekle.Parameters.AddWithValue("@MusOda", txtOda.Text);
            ekle.Parameters.AddWithValue("@MusUcret", txtUcret.Text);
            ekle.Parameters.AddWithValue("@GirisTarih", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            ekle.Parameters.AddWithValue("@CikisTarih", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            ekle.ExecuteNonQuery();
            baglanti.Close();
            this.tblMusteriKayitTableAdapter.Fill(this.harmonyHotelDataSet.tblMusteriKayit);
            MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clear();
            
        }

        List<string> doluOdalar = new List<string>();
        List<string> btnOdalar = new List<string>();
        Button btnOda = null;
        public void CustomerRegistration_Load(object sender, EventArgs e)
        {
            this.tblMusteriKayitTableAdapter.Fill(this.harmonyHotelDataSet.tblMusteriKayit);



            
            for (int j = 0; j < 4; j++)
            {
                int baslangicDegeri = 101 + j * 100;
                for (int i = baslangicDegeri; i < baslangicDegeri + 6; i++)
                {
                    btnOda = new Button();
                    Point btnOdaKnm = new Point(40 + (i - baslangicDegeri) * 70, 40 + j * 70);
                    btnOda.Location = btnOdaKnm;
                    btnOda.Height = 50;
                    btnOda.Width = 50;
                    btnOda.Text = Convert.ToString(i);
                    btnOda.Click += Button_Click;
                    groupBox2.Controls.Add(btnOda);
                    btnOdalar.Add(btnOda.Text);
                }
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblMusteriKayit MusOda", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                string odaNo = reader.GetString(reader.GetOrdinal("MusOda"));
                doluOdalar.Add(odaNo);
            }
            reader.Close();
            baglanti.Close();

            foreach (var item in doluOdalar)
            {
                Button button = FindButtonByNumber(item); // Yardımcı bir metod ile butonu bulabilirsiniz
                if (button != null)
                {
                    button.BackColor = Color.Red;
                }
            }


        }

        private Button FindButtonByNumber(string number)
        {
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Button button && button.Text == number)
                {
                    return button;
                }
            }
            return null;
        }

        


        private Button previousButton;
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            txtOda.Text = buttonText;

            if (clickedButton.BackColor == Color.Red)
            {
                txtOda.Text = "";
                MessageBox.Show("Seçilen Oda Dolu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (previousButton != null && previousButton != clickedButton)
            {
                previousButton.BackColor = SystemColors.Control;
            }

            clickedButton.BackColor = Color.Yellow;
            previousButton = clickedButton;


        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label10.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label10.Text) * 150;
            txtUcret.Text = Ucret.ToString();
        }

        
    }
}
