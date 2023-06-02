using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pansiyonkayıt_otomasyonu
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            label10.Text = (personel * 1500).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Hide();
            fr.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret)as toplam from Table_2", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label8.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //gıda giderleri
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Gıda)as toplam from Table_3", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                label9.Text = oku1["toplam"].ToString();
            }
            baglanti.Close();

            //icecek giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(içecek)as toplam from Table_3", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                label12.Text = oku2["toplam"].ToString();
            }
            baglanti.Close();

            //cerez giderleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(çerezler)as toplam from Table_3", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                label14.Text = oku3["toplam"].ToString();
            }
            baglanti.Close();

        }
    }
}
