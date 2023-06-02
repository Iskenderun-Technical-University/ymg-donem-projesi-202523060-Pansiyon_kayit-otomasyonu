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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True");

       private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Table_3", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
               
                ekle.Text = oku["Ay"].ToString();
                ekle.SubItems.Add(oku["Gıda"].ToString());
                ekle.SubItems.Add(oku["içecek"].ToString());
                ekle.SubItems.Add(oku["çerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Table_4", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                ListViewItem ekle1 = new ListViewItem();

                ekle1.Text = oku1["Ay"].ToString();
                ekle1.SubItems.Add(oku1["elektrik"].ToString());
                ekle1.SubItems.Add(oku1["su"].ToString());
                ekle1.SubItems.Add(oku1["internet"].ToString());
                listView2.Items.Add(ekle1);
            }
            baglanti.Close();
        }



        private void Form8_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Hide();
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_3 ([Ay],[Gıda],[içecek],[çerezler]) values('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Table_4 ( [Ay],[elektrik],[su],[internet]) values('" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            veriler2();

        }
    }
}
