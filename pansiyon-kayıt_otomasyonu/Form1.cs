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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "sinem")
            {
                Form3 fr = new Form3();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giris hatalı...");
                textBox1.Clear();
                textBox2.Clear();
            }


        }
    }
}
