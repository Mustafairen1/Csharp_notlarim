using System.Windows.Forms;

namespace Calisma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.Transparent;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ad.Text = (isim_text.Text + " " + soy_isim_text.Text);
            Yas.Text = (yas_text.Text);
            il_ilce.Text = (il_text.Text);
            Meslek.Text = (Meslek_text.Text);
            e_mail.Text = (e_mail_text.Text);
            Dogrulandi.Text = "Baþvurunuz yönetime iletilmiþtir, e posta adresinize meþaj gelecektir.";
            System.Threading.Thread.Sleep(50);
            ad.Refresh();
            System.Threading.Thread.Sleep(50);
            Yas.Refresh();
            System.Threading.Thread.Sleep(50);
            il_ilce.Refresh();
            System.Threading.Thread.Sleep(50);
            Meslek.Refresh();
            System.Threading.Thread.Sleep(50);
            e_mail.Refresh();
            System.Threading.Thread.Sleep(4000);
            Dogrulandi.Refresh();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Meslek_Click(object sender, EventArgs e)
        {

        }

        private void il_ilce_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}