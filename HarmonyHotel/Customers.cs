using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HarmonyHotel
{
    public partial class Customers :Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JCTQPOK\\SQLEXPRESS;Initial Catalog=HarmonyHotel;Integrated Security=True");
        private void Customers_Load(object sender, EventArgs e)
        {
            this.tblMusteriKayitTableAdapter.Fill(this.harmonyHotelDataSet1.tblMusteriKayit);
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            label12.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtOda.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        

        private void label12_TextChanged(object sender, EventArgs e)
        {
            if (label12.Text == "Kadın")
            {
                RadioKadin.Checked = true;
            }
            if (label12.Text == "Erkek")
            {
                RadioErkek.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From tblMusteriKayit Where Musid=@id", baglanti);
            komutsil.Parameters.AddWithValue("@id", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblMusteriKayitTableAdapter.Fill(this.harmonyHotelDataSet1.tblMusteriKayit);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update tblMusteriKayit set MusAd=@a1, MusSoyad=@a2, MusTelefon=@a3, MusCinsiyet=@a4, MusTc=@a5, MusOda=@a6, MusUcret=@a7, MusGiris=@a8, MusCikis=@a9 where Musid=@a10", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", mskdTel.Text);
            komutguncelle.Parameters.AddWithValue("@a4", RadioErkek.Checked ? RadioErkek.Text : (RadioKadin.Checked ? RadioKadin.Text : ""));
            komutguncelle.Parameters.AddWithValue("@a5", txtTc.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtOda.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtUcret.Text);
            komutguncelle.Parameters.AddWithValue("@a8", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            komutguncelle.Parameters.AddWithValue("@a9", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            komutguncelle.Parameters.AddWithValue("@a10", txtid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            this.tblMusteriKayitTableAdapter.Fill(this.harmonyHotelDataSet1.tblMusteriKayit);
            MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
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
            MessageBox.Show("Form başarıyla temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            dataGridView1.DataSource = null; 
            dataGridView1.Rows.Clear(); 

            
            SqlCommand komutSearch = new SqlCommand("SELECT * FROM tblMusteriKayit WHERE MusAd LIKE '%" + txtSearch.Text + "%'", baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komutSearch);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
            



        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
