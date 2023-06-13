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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HarmonyHotel
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JCTQPOK\\SQLEXPRESS;Initial Catalog=HarmonyHotel;Integrated Security=True");


        List<string> doluOdalar = new List<string>();
        List<string> btnOdalar = new List<string>();
        Button btnOda = null;
        private void Rooms_Load(object sender, EventArgs e)
        {
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
                    groupBox1.Controls.Add(btnOda);
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
            foreach (Control control in groupBox1.Controls)
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
            
            if (clickedButton.BackColor == Color.Red)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM tblMusteriKayit WHERE MusOda=@MusOda", baglanti);
                komut.Parameters.AddWithValue("@MusOda", buttonText);
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    string kalanKisi = "";
                    string cikisTarih = "";
                    string odaNo = "";
                    while (reader.Read())
                    {
                        string ad = reader.GetString(reader.GetOrdinal("MusAd"));
                        string soyad = reader.GetString(reader.GetOrdinal("MusSoyad"));
                        DateTime cikis = reader.GetDateTime(reader.GetOrdinal("MusCikis"));
                        string oda = reader.GetString(reader.GetOrdinal("MusOda"));
                        kalanKisi += ad + " " + soyad + Environment.NewLine;
                        cikisTarih += cikis.ToString("dd/MM/yyyy") + Environment.NewLine;
                        odaNo += oda + Environment.NewLine;
                    }

                    lblAd.Text = kalanKisi;
                    lblCikis.Text = cikisTarih;
                    lblOda.Text = odaNo;
                    groupBox2.Visible = true;
                }
                else
                {
                    lblAd.Text = "Oda boş.";
                }

                reader.Close();
                baglanti.Close();
                return;
            }

            if (previousButton != null && previousButton != clickedButton)
            {
                previousButton.BackColor = SystemColors.Control;
               
            }

            clickedButton.BackColor = Color.Yellow;
            previousButton = clickedButton;
            MessageBox.Show("Seçilen Oda Boştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

