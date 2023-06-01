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
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            label10.Text = (personel * 1500).ToString();
        }
    }
}
