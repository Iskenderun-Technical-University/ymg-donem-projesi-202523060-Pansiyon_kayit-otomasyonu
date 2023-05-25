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
            string sql = "insert into oda101 ([AdSoyad]) values ('" + textBox1.Text + "')";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
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
            //oda101
            con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101", con);
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
            //oda102
            con.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", con);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                button3.Text = oku2["AdSoyad"].ToString();
            }
            con.Close();
            if (button3.Text != "102")
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }

            //oda103
            con.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda103", con);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                button4.Text = oku3["AdSoyad"].ToString();
            }
            con.Close();
            if (button4.Text != "103")
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            //oda104
            con.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda104", con);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                button5.Text = oku4["AdSoyad"].ToString();
            }
            con.Close();
            if (button5.Text != "104")
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            //oda105
            con.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda105", con);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                button6.Text = oku5["AdSoyad"].ToString();
            }
            con.Close();
            if (button6.Text != "105")
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            //oda106
            con.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda106", con);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button7.Text = oku6["AdSoyad"].ToString();
            }
            con.Close();
            if (button7.Text != "106")
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            //oda107
            con.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda107", con);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                button8.Text = oku7["AdSoyad"].ToString();
            }
            con.Close();
            if (button8.Text != "107")
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
        }

        
    }
}
