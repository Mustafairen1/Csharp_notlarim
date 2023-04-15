using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adiniz.Text = yazi1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba başvurunuz bize ulaştı, sizin başvurunuzu inceledikten sonra size ulaşmamız için gmail addressinizi gireceğiniz menüye sizi yönlendiriyorum");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            soyadiniz.Text = yazi2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mesleginiz.Text = yazi3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yasiniz.Text = yazi4.Text;
        }
    }
}
