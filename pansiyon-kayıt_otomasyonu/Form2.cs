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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;

        public static string SqlCon = @"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True";

        public Form2()
        {
            InitializeComponent();
        }

        
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            //olusturdugumuz veri tabanına musteri ekleriz
            con = new SqlConnection(SqlCon);
            string sql = "insert into Table_2 ([AdSoyad],[TC],[Mail],[TelNo],[GirisTarihi],[CıkısTarihi],[Ucret],[OdaNo]) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox1.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Musteri kaydı olusturuldu...");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "101";
            con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand komut1 = new SqlCommand("insert into 101([AdSoyad]) values ('" + textBox1.Text + "')", con);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                button7.Text = oku1["AdSoyad"].ToString();
            }
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "102";
            con = new SqlConnection(SqlCon);
            con.Open();
            string sql = "insert into oda102 ([AdSoyad]) values ('" + textBox1.Text + "')";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "103";
            con = new SqlConnection(SqlCon);
            con.Open();
            string sql = "insert into oda103 ([AdSoyad]) values ('" + textBox1.Text + "')";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "104";
            
            con = new SqlConnection(SqlCon);
            con.Open();
            string sql = "insert into oda104 ([AdSoyad]) values ('" + textBox1.Text + "')";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "105";
            con = new SqlConnection(SqlCon);
            con.Open();
            string sql = "insert into oda105 ([AdSoyad]) values ('" + textBox1.Text + "')";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "106";
            con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand komut6 = new SqlCommand("insert into oda106 ([AdSoyad]) values ('" + textBox1.Text + "')", con);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button7.Text = oku6["AdSoyad"].ToString();
            }
            con.Close();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "107";
            con = new SqlConnection(SqlCon);
            con.Open();
            string sql = "insert into oda107 ([AdSoyad]) values ('" + textBox1.Text + "')";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
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

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Hide();
            fr.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand komut1 = new SqlCommand("select * from 101", con);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                button2.Text = oku1["AdSoyad"].ToString();
            }
            con.Close();
            if (button2.Text != "101")
            {
                button2.BackColor = Color.Red;
                button2.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
