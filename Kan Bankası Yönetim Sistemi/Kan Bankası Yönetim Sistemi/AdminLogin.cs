using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kan_Bankası_Yönetim_Sistemi
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (AdminSifreTb.Text == "") 
            {
                MessageBox.Show("Admin Şifreni Giriniz");

            }else if(AdminSifreTb.Text == "0678")
            {
                     Calisan cal = new Calisan();
                     cal.Show();
                     this.Hide();
            }else
            {
                MessageBox.Show("Yanlış Şifre");
                AdminSifreTb.Text = "";
            }
            
             
        }
    }
}
