namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.label1.Text = textBox1.Text;
            form2.label4.Text = textBox2.Text;
            form2.label6.Text = "16:00";
            MessageBox.Show("Ba�ar�yla giri� yapt�n�z. iyi g�nler.");
            this.Hide();
            form2.Show();
        }
    }
}