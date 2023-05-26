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
            

        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Hide();
            fr.Show();

        }

       
    }
}
