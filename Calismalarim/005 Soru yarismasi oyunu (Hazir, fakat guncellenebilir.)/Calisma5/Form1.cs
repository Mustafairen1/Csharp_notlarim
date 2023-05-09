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
            BtnB.Enabled = false; //Buras� program ba�lat�ld���nda sonraki'e basmad���m s�rece butonlar� deaktif tutucak
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        int soruno = 0, dogru = 0, yanlis = 0; // Buras� Global Aland�r, buraya bu yazd���m kodu yazmazsak do�ru ve yanl�� ayr�ca soruno say�s� k�s�r d�ng�ye girer yani s�rekli 1'de kal�r 2 3 4 5 olarak y�kselmez

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
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi �ehir Ege b�lgemizde bulunmaz?";
                BtnA.Text = "�zmir";
                BtnB.Text = "Bal�kesir";
                BtnC.Text = "Ayd�n";
                BtnD.Text = "Manisa";
                label4.Text = "Bal�kesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son ku�lar hangi yazara aittir?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal S�reya";
                BtnC.Text = "Attila �lhan";
                BtnD.Text = "Re�at Nuri";
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
                BtnSonraki.Text = "Sonu�lar.";
                richTextBox1.Text = ("Do�ru:" + dogru + "\n" + "Yanl�� " + yanlis + "\n" + "Uygulama S�r�m�: V0.0.1" + "\n" + "Uygulama Yap�mc�s�: Mustafa �ren " + "\n" + "Oyunu Be�endiyseniz daha fazlas� Githubumda: https://github.com/Mustafairen1/Csharp_notlarim ");

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