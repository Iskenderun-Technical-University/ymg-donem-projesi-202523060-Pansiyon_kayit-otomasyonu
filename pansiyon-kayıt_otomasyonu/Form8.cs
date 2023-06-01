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


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_3 ([Ay],[Gıda],[içecek],[çerezler]) values('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Hide();
            fr.Show();
        }
    }
}
