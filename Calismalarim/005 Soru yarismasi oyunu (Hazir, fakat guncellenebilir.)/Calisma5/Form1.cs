using System.Reflection.Emit;
using System.Windows.Forms;

namespace Calisma5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnA.Enabled = false;
            BtnB.Enabled = false; //Burasý program baþlatýldýðýnda sonraki'e basmadýðým sürece butonlarý deaktif tutucak
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        int soruno = 0, dogru = 0, yanlis = 0; // Burasý Global Alandýr, buraya bu yazdýðým kodu yazmazsak doðru ve yanlýþ ayrýca soruno sayýsý kýsýr döngüye girer yani sürekli 1'de kalýr 2 3 4 5 olarak yükselmez

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            BtnSonraki.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            soruno++;
            LblSoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi þehir Ege bölgemizde bulunmaz?";
                BtnA.Text = "Ýzmir";
                BtnB.Text = "Balýkesir";
                BtnC.Text = "Aydýn";
                BtnD.Text = "Manisa";
                label4.Text = "Balýkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuþlar hangi yazara aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Attila Ýlhan";
                BtnD.Text = "Reþat Nuri";
                label4.Text = "Sait Faik";
            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;
                richTextBox1.Text = "";
                BtnA.Text = "???";
                BtnB.Text = "???";
                BtnC.Text = "???";
                BtnD.Text = "???";
                label4.Text = "???";
                BtnSonraki.Text = "Sonuçlar.";
                richTextBox1.Text = ("Doðru:" + dogru + "\n" + "Yanlýþ " + yanlis + "\n" + "Uygulama Sürümü: V0.0.1" + "\n" + "Uygulama Yapýmcýsý: Mustafa Ýren " + "\n" + "Oyunu Beðendiyseniz daha fazlasý Githubumda: https://github.com/Mustafairen1/Csharp_notlarim ");

            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }
    }
}