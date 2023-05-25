using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Girilen sayıları al
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sayi3 = Convert.ToInt32(txtSayi3.Text);

            //Toplama işlemi
            int toplam = sayi1 + sayi2 + sayi3;

            //Sonucu Görüntüle
            lblSonuc.Text = "Sonuç: " + toplam.ToString();
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Girilen sayıları al
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sayi3 = Convert.ToInt32(txtSayi3.Text);

            // Çıkarma işlemi
            int fark = sayi1 - sayi2 - sayi3;

            //Sonucu Görüntüle
            lblSonuc.Text = "Sonuç: " + fark.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Girilen sayıları al
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sayi3 = Convert.ToInt32(txtSayi3.Text);

            // Çarpma işlemi
            int carpim = sayi1 * sayi2 * sayi3;

            //Sonucu Görüntüle
            lblSonuc.Text = "Sonuç: " + carpim.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Girilen sayıları al
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int sayi3 = Convert.ToInt32(txtSayi3.Text);

            // Çarpma işlemi
            double bolum = (double)sayi1 / sayi2 / sayi3;

            //Sonucu Görüntüle
            lblSonuc.Text = "Sonuç: " + bolum.ToString();
        }
    }
}
