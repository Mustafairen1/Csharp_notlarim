using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace Adana_iş_ve_eleman_ilanları___Moderatör_başvuru_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int basvuruSiraNumarasi = 0;
        private HashSet<string> applicantSet = new HashSet<string>();

        private void InitializeBrowser()
        {

        }


                private void MainForm_Load(object sender, EventArgs e)
        {


            // Gönder düğmesi özelleştirmeleri yaptım
            GonderButton.Text = "Başvuruyu Gönder";
            GonderButton.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            GonderButton.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); // Mavi renk
            GonderButton.ForeColor = System.Drawing.Color.White;
            GonderButton.FlatStyle = FlatStyle.Flat;
            GonderButton.FlatAppearance.BorderSize = 0;
        }
        private Dictionary<string, string> applicantData = new Dictionary<string, string>();

        private void GonderButton_Click1(object sender, EventArgs e)
        {
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string yas = yasTextBox.Text;
            string cinsiyet = CinsiyetBox.Text;
            string telefon = telefonTextBox.Text;
            string facebooklink = FacebookBox.Text;
            string e_mail = EmailBox.Text;
            string applicantKey = $"{ad} {soyad} {telefon}";

            if (applicantSet.Contains(applicantKey))
            {
                MessageBox.Show("Zaten başvurdunuz!");
                return;
            }

            try
            {
                string smtpHost = "smtp.yandex.com.tr"; // Yandex SMTP sunucusuna bağlan
                int smtpPort = 587; // Yandex SMTP port numarası
                string smtpUsername = "DestekAdana@yandex.com"; // Yandex e-posta adresini buraya giricez
                string smtpPassword = "fvuwpnxxfnoptful"; // Yandex e-posta şifremizi buraya giricez

                SmtpClient client = new SmtpClient(smtpHost, smtpPort);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(smtpUsername);
                mail.To.Add("jigmonetas@gmail.com"); // Alıcı e-posta adresini buraya giricez
                mail.Subject = $"Moderatör Başvurusu {basvuruSiraNumarasi}";
                mail.Body = $"\nAd Soyad: {ad} {soyad}\nYaş: {yas}\nCinsiyet: {cinsiyet}\n--------\nİletişim:\nTelefon: {telefon}\nFacebook: {facebooklink}\nE postası: {e_mail}";
                basvuruSiraNumarasi++;
                client.Send(mail);

                MessageBox.Show("Başvurunuz gönderildi. Teşekkür ederiz!");

                applicantSet.Add(applicantKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.ToString());
            }
        }

        private void yasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayıları ve kontrol tuşlarını kabul et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Girişi engelle
            }
            else
            {
                // Geçerli metin ile eklenecek metni birleştirerek yeni metin oluştur
                string newText = (sender as System.Windows.Forms.TextBox).Text + e.KeyChar;

                // Eğer metin sayıya dönüştürülebiliyorsa ve 0 ile 99 arasında ise işlemi kabul et, aksi halde engelle
                if (int.TryParse(newText, out int num) && num >= 0 && num <= 99)
                {
                    // İşlemi kabul et
                }
                else
                {
                    e.Handled = true; // İşlemi iptal et
                }
            }
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            yasTextBox.Text = ""; // TextBox içeriğini temizle
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void telefonTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            // İlk olarak, mevcut imleç pozisyonunu kaydedin
            int currentPosition = telefonTextBox.SelectionStart;

            // Maskenin başındaysa veya mevcut pozisyon 6. karakterden küçükse
            if (currentPosition <= 6)
            {
                // En başa odaklan
                telefonTextBox.SelectionStart = 0;
            }
            // İlk bloğun sonunda veya ikinci bloğun başındaysa
            else if (currentPosition > 6 && currentPosition <= 11)
            {
                // İkinci bloğun başına odaklan
                telefonTextBox.SelectionStart = 7;
            }
            // İkinci bloğun sonunda veya üçüncü bloğun başındaysa
            else if (currentPosition > 11 && currentPosition <= 14)
            {
                // Üçüncü bloğun başına odaklan
                telefonTextBox.SelectionStart = 12;
            }
            // Üçüncü bloğun sonundaysa veya dördüncü bloğun başındaysa
            else if (currentPosition > 14 && currentPosition <= 17)
            {
                // Dördüncü bloğun başına odaklan
                telefonTextBox.SelectionStart = 15;
            }
        }
    }

}


