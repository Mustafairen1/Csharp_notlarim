using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calisma3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int urunFiyati;
            int indirimOrani;
            double kdvDahilFiyat;
            double kdvHaricFiyat;
            double kdvDahilindirimliFiyat;
            urunFiyati = Convert.ToInt16(textBox1.Text);
            indirimOrani = Convert.ToInt16(textBox2.Text);
            kdvDahilFiyat = (urunFiyati) * 1.18;
            kdvHaricFiyat = (urunFiyati);
            kdvDahilindirimliFiyat = ((urunFiyati / 100) * indirimOrani) * 1.18;
            listBox1.Items.Add(" KDV Dahil Fiyatı: " + kdvDahilFiyat);
            listBox1.Items.Add(" KDV Hariç Fiyatı: " + kdvHaricFiyat);
            listBox1.Items.Add(" KDV Dahil İndirimli Fiyat: " + kdvDahilindirimliFiyat);
        }
    }
}
