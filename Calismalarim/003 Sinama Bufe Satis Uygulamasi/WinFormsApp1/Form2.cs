using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        int Kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(Txtmisir.Text);


            bilet = Convert.ToInt16(TxtBilet.Text);


            su = Convert.ToInt16(TxtKola.Text);


            cay = Convert.ToInt16(TxtCay.Text);




            toplam = misir * 40 + cay * 16 + bilet * 80 + su * 8;

            lblToplam.Text = toplam.ToString() + " TL ";


            Kasatutar = Kasatutar + toplam;

            lblKasa.Text = Kasatutar.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "0";
            TxtCay.Text = "0";
            Txtmisir.Text = "0";
            TxtKola.Text = "0";
            TxtKola.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblKasa.Text = "0.00 TL";
            lblToplam.Text = "0.00 TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("Başarıyla çıkış yaptınız. iyi günler.");
            this.Hide();
            form1.Show();
 
        }
    }
}
