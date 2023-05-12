namespace Calisma6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            string sembol = textBox3.Text;

            switch (sembol)
            {
                case "+": sonuc = sayi1 + sayi2; break;
                case "-": sonuc = sayi1 - sayi2; break;
                case "*": sonuc = sayi1 * sayi2; break;
                case "/": sonuc = sayi1 / sayi2; break;
                default: sonuc = 0; break;
            }

            label1.Text = "Sonuç: " + sonuc.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}