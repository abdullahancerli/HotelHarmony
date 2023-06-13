using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonyHotel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            CustomerRegistration frm = new CustomerRegistration();
            frm.Show();
            
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Customers frm = new Customers();
            frm.Show();
            
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Rooms frm = new Rooms();
            frm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff frm = new Staff();
            frm.Show();

        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            Stock frm = new Stock();
            frm.Show();
        }
    }
}
