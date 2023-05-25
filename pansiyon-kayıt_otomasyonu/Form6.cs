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


namespace pansiyonkayıt_otomasyonu
{
    public partial class Form6 : Form
    {


        SqlConnection baglanti = new SqlConnection (@"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True");
        

        public Form6()
        {
            InitializeComponent();
        }

       

        private void Form6_Load(object sender, EventArgs e)
        {
            //oda101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101",baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                button1.Text = oku1["AdSoyad"].ToString();
            }
            baglanti.Close();
            if (button1.Text != "101")
            {
                button1.BackColor = Color.Red;
            }
            //oda102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                button1.Text = oku2["AdSoyad"].ToString();
            }
            baglanti.Close();
            if (button2.Text != "102")
            {
                button2.BackColor = Color.Red;
            }

            //oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                button3.Text = oku3["AdSoyad"].ToString();
            }
            baglanti.Close();
            if (button3.Text != "103")
            {
                button3.BackColor = Color.Red;
            }
            //oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                button4.Text = oku4["AdSoyad"].ToString();
            }
            baglanti.Close();
            if (button4.Text != "104")
            {
                button4.BackColor = Color.Red;
            }
            //oda105
            baglanti.Open();
            SqlCommand komut5= new SqlCommand("select * from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                button5.Text = oku5["AdSoyad"].ToString();
            }
            baglanti.Close();
            if (button5.Text != "105")
            {
                button5.BackColor = Color.Red;
            }
            //oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button6.Text = oku6["AdSoyad"].ToString();
            }
            baglanti.Close();
            if (button6.Text != "106")
            {
                button6.BackColor = Color.Red;
            }
            //oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                button7.Text = oku7["AdSoyad"].ToString();
            }
            baglanti.Close();
            if (button7.Text != "107")
            {
                button7.BackColor = Color.Red;
            }
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Hide();
            fr.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
