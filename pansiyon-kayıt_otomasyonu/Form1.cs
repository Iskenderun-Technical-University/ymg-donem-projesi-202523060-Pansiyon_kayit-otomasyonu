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
    public partial class Form1 : System.Windows.Forms.Form
    {

        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;

        public static string SqlCon = @"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        public void Giris()
        {
            string sorgu = "select * from Table_1 where [AdminAD]=@user and [AdminSifre]=@pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Form3 fr = new Form3();
                this.Hide();
                fr.Show();

            }
            else
            {
                MessageBox.Show("kullanici adi veya sifre hatali");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
            con.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {


            Giris();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
