using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kisaKenar = Convert.ToDouble(textBox1.Text);
            double uzunKenar = Convert.ToDouble(textBox2.Text);

            double alan = kisaKenar * uzunKenar;
            double cevre = 2 * (kisaKenar + uzunKenar);
            textBox3.Text = $"Alan: {alan}\r\nÇevre: {cevre}";
        }
    }
}
