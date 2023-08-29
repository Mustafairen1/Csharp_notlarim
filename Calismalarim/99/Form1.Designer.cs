using System;

namespace Adana_iş_ve_eleman_ilanları___Moderatör_başvuru_formu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.yasTextBox = new System.Windows.Forms.TextBox();
            this.GonderButton = new System.Windows.Forms.Button();
            this.CinsiyetBox = new System.Windows.Forms.ComboBox();
            this.temizleButton = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.telefonTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FacebookBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(2, 102);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 20);
            this.adTextBox.TabIndex = 0;
            // 
            // yasTextBox
            // 
            this.yasTextBox.Location = new System.Drawing.Point(233, 100);
            this.yasTextBox.Name = "yasTextBox";
            this.yasTextBox.Size = new System.Drawing.Size(19, 20);
            this.yasTextBox.TabIndex = 2;
            this.yasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yasTextBox_KeyPress);
            // 
            // GonderButton
            // 
            this.GonderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.GonderButton.Location = new System.Drawing.Point(467, 102);
            this.GonderButton.Name = "GonderButton";
            this.GonderButton.Size = new System.Drawing.Size(66, 23);
            this.GonderButton.TabIndex = 6;
            this.GonderButton.Text = "Başvur";
            this.GonderButton.UseVisualStyleBackColor = true;
            this.GonderButton.Click += new System.EventHandler(this.GonderButton_Click1);
            // 
            // CinsiyetBox
            // 
            this.CinsiyetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CinsiyetBox.FormattingEnabled = true;
            this.CinsiyetBox.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.CinsiyetBox.Location = new System.Drawing.Point(252, 100);
            this.CinsiyetBox.Name = "CinsiyetBox";
            this.CinsiyetBox.Size = new System.Drawing.Size(50, 21);
            this.CinsiyetBox.TabIndex = 99;
            // 
            // temizleButton
            // 
            this.temizleButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.temizleButton.Location = new System.Drawing.Point(232, 117);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(21, 20);
            this.temizleButton.TabIndex = 98;
            this.temizleButton.Text = "-";
            this.temizleButton.UseVisualStyleBackColor = true;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Location = new System.Drawing.Point(75, 21);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(0, 13);
            this.LogoLabel.TabIndex = 8;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(101, 102);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(110, 20);
            this.soyadTextBox.TabIndex = 1;
            this.soyadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Adana_iş_ve_eleman_ilanları___Moderatör_başvuru_formu.Properties.Resources.YaşCinsiyetTelefonGönder_Text1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(210, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(321, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Adana_iş_ve_eleman_ilanları___Moderatör_başvuru_formu.Properties.Resources.AdSoyad_Text;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(2, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(209, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Adana_iş_ve_eleman_ilanları___Moderatör_başvuru_formu.Properties.Resources.Cizgi;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(2, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(529, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Adana_iş_ve_eleman_ilanları___Moderatör_başvuru_formu.Properties.Resources.Facebook_Text;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(71, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LogoPic
            // 
            this.LogoPic.BackgroundImage = global::Adana_iş_ve_eleman_ilanları___Moderatör_başvuru_formu.Properties.Resources.Facebook_logo;
            this.LogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPic.Location = new System.Drawing.Point(2, 3);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(73, 52);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPic.TabIndex = 7;
            this.LogoPic.TabStop = false;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(370, 103);
            this.telefonTextBox.Mask = "(000) 000 00 00";
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 3;
            this.telefonTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.telefonTextBox_MouseClick);
            // 
            // FacebookBox
            // 
            this.FacebookBox.Location = new System.Drawing.Point(317, 142);
            this.FacebookBox.Name = "FacebookBox";
            this.FacebookBox.Size = new System.Drawing.Size(112, 20);
            this.FacebookBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.58F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(314, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Facebook Linkiniz               Epostanız";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(427, 142);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(106, 20);
            this.EmailBox.TabIndex = 5;
            this.EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.58F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-1, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "UYARI: Tüm alanları eksiksiz ve doğru şekilde giriniz, aksi halde redediliceksini" +
    "z.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.58F);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(-1, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "UYARI: Lütfen ciddi moderasyon yapacaklar başvursun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.58F);
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(-1, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "Bug veya sorular için iletişim numaram: 552 715 81 59";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(533, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacebookBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.CinsiyetBox);
            this.Controls.Add(this.GonderButton);
            this.Controls.Add(this.yasTextBox);
            this.Controls.Add(this.adTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Form yüklendiğinde tetiklenecek olay işleyicisi
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılması gereken işlemler burada yer alabilir
        }

        #endregion

        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox yasTextBox;
        private System.Windows.Forms.Button GonderButton;
        private System.Windows.Forms.ComboBox CinsiyetBox;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MaskedTextBox telefonTextBox;
        private System.Windows.Forms.TextBox FacebookBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
