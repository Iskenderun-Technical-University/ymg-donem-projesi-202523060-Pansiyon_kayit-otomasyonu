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

namespace pansiyonkayit_otomasyonu
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;

        public static string SqlCon = @"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True";
        public int denemesayisi = 0;
        

        public Form4()
        {
            InitializeComponent();
        }

        void GridDoldur()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("select * from Table_1", con);
            ds = new DataSet(); con.Open(); da.Fill(ds, "Table_1");
            con.Close();
        }
        public void eskisifrekontrol()
        {
            string sorgu = "select [AdminSifre] from Table_1 where [AdminSifre]=@pass";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            //cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox1.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (textBox2.Text == textBox3.Text)
                {
                    con = new SqlConnection(SqlCon);
                    string Sql = "update Table_1 set [AdminSifre]='" + textBox2.Text + "'";
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = Sql;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridDoldur();
                    MessageBox.Show("sifre basariyla degistirildi....");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    Form1 fr = new Form1();
                    this.Hide();
                    fr.Show();

                }
                else
                {
                    MessageBox.Show("yeni sifre ve tekrarİ uyusmuyor!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                

            }
            else
            {
                MessageBox.Show("eski sifreniz hatali girildi....");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
            }
            con.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            eskisifrekontrol();
        }

    }
}

