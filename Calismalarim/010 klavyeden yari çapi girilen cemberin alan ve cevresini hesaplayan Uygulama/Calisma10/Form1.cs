using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yaricap = Convert.ToDouble(textBox1.Text);
            double alan = 3.14159 * yaricap * yaricap;
            double cevre = 2 * 3.14159 * yaricap;
            label1.Text = "Alan: " + alan.ToString();
            label2.Text = "Çevre: " + cevre.ToString();
                }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "Çevre:";
            label2.Text = "Alan:";
        }
    }
}
