using pansiyonkayıt_otomasyonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyonkayıt_otomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            this.Hide();
            fr.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 fr = new Form4();
            this.Hide();
            fr.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            this.Hide();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            this.Hide();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            this.Hide();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Hide();
            a.Show();
        }
    }
}
