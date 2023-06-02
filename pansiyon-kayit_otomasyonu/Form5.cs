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
    
    

    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand cmd;
        DataSet ds;
        public static string SqlCon = @"Data Source=LAPTOP-EAS3BIR0\SQLEXPRESS;Initial Catalog = ymg; Integrated Security = True";
        public string SqlSorgu;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ymgDataSet4.Table_2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_2TableAdapter.Fill(this.ymgDataSet4.Table_2);
            // TODO: Bu kod satırı 'ymgDataSet3.Table_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_1TableAdapter.Fill(this.ymgDataSet3.Table_1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(SqlCon);
            string Sql = "update Table_2 set [AdSoyad]='" + textBox1.Text + "',[TC]='" + textBox2.Text + "',[Mail]='" + textBox3.Text + "',[TelNo]='" + maskedTextBox1.Text + "',[GirisTarihi]='" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',[CıkısTarihi]='" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',[Ucret]='" + textBox4.Text + "' ,[OdaNo]= '" + textBox5.Text + "'where [AdSoyad]='" + textBox1.Text + "'";
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = Sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text =="101")
            {
                con = new SqlConnection(SqlCon);
                con.Open();
                string sql = "delete from Table_101";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            if (textBox5.Text == "102")
            {
                con = new SqlConnection(SqlCon);
                con.Open();
                string sql = "delete from Table_102";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            if (textBox5.Text == "103")
            {
                con = new SqlConnection(SqlCon);
                con.Open();
                string sql = "delete from Table_103";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            if (textBox5.Text == "104")
            {
                con = new SqlConnection(SqlCon);
                con.Open();
                string sql = "delete from Table_104";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            if (textBox5.Text == "105")
            {
                con = new SqlConnection(SqlCon);
                con.Open();
                string sql = "delete from Table_105";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            if (textBox5.Text == "106")
            {
                con = new SqlConnection(SqlCon);
                con.Open();
                string sql = "delete from Table_106";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

            }
            if (textBox5.Text == "107")
            {
                con = new SqlConnection(SqlCon);
                con.Open();
                string sql = "delete from Table_107";
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                con.Close();

            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            textBox5.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        
    }
}
