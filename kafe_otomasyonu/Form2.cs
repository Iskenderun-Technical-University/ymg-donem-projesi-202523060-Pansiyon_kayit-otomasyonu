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


namespace kafe_otomasyonu
{
    public partial class Form2 : Form

       
    {
        

        //public static string SqlCon = @"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True";

        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "101";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "102";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "103";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "104";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "105";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "106";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "107";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kırmızı renkli butonlar dolu odaları göstermektedir....");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gri renkli butonlar boş odaları göstermektedir....");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime kucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyukTarih = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan Sonuc = buyukTarih - kucukTarih;
            label9.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label9.Text) * 50;//gunluk pansiyon fiyatı 50 tl olsun.
            textBox4.Text = Ucret.ToString();
        }
    }
}
