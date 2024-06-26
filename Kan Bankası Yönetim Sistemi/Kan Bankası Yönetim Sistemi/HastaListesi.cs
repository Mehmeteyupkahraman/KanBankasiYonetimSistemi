﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kan_Bankası_Yönetim_Sistemi
{
    public partial class HastaListesi : Form
    {
        public HastaListesi()
        {
            InitializeComponent();
            uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\KanBankasıDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from HastaTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            HastaDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void HastaListesi_Load(Object sender,DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }
        int key = 0;
        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HAdSoyadTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            HYasTb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            HTelefonTb.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            HCinsCb.Text = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            HKGrupCb.Text = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            HAdresTb.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (HAdSoyadTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            HAdSoyadTb.Text = "";
            HYasTb.Text = "";
            HCinsCb.SelectedIndex = -1;
            HTelefonTb.Text = "";
            HAdresTb.Text = "";
            HKGrupCb.SelectedIndex = -1;
            key = 0;
        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if(key== 0)
            {
                MessageBox.Show("Silinecek hastayı seçiniz");
            }
            else
            {
                try
                {
                    string query = "delete from HastaTbl where HNum=" + key + ";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Başarıyla Silindi");
                    baglanti.Close();
                    Reset();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HastaListesi dn = new HastaListesi();
            dn.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hasta dn = new Hasta();
            dn.Show();
            this.Hide();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (HAdSoyadTb.Text == "" || HYasTb.Text == "" || HCinsCb.SelectedIndex == -1 || HTelefonTb.Text == "" || HKGrupCb.SelectedIndex == -1 || HAdresTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "update HastaTbl set HAdSoyad='"+HAdSoyadTb.Text+"',HYas="+HYasTb.Text+",HTelefon='"+HTelefonTb.Text+"',HCinsiyet='"+HCinsCb.SelectedItem.ToString()+"',HKGrup='"+HKGrupCb.SelectedItem.ToString()+"',HAdres='"+HAdresTb.Text+"'where HNum="+key+";";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Başarıyla Güncellendi");
                    baglanti.Close();
                    Reset();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Donor dn = new Donor();
            dn.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            KanBagısı dn = new KanBagısı();
            dn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DonorListesi dn = new DonorListesi();
            dn.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            KanStoğu dn = new KanStoğu();
            dn.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            KanTransferi dn = new KanTransferi();
            dn.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            KontrolPaneli dn = new KontrolPaneli();
            dn.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
