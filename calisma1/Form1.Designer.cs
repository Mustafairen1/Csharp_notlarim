namespace Calisma1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            isim_text = new TextBox();
            ad = new Label();
            soy_isim_text = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            il_ilce_text = new TextBox();
            meslek_text = new TextBox();
            label7 = new Label();
            label8 = new Label();
            yas_text = new TextBox();
            il_ilce = new Label();
            Meslek = new Label();
            Yas = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            Dogrulandi = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 261);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 0;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 1;
            label1.Text = "İsim";
            label1.Click += label1_Click;
            // 
            // isim_text
            // 
            isim_text.Location = new Point(12, 75);
            isim_text.Name = "isim_text";
            isim_text.Size = new Size(132, 23);
            isim_text.TabIndex = 2;
            isim_text.TextChanged += textBox1_TextChanged;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ad.ForeColor = Color.LimeGreen;
            ad.Location = new Point(275, 78);
            ad.Name = "ad";
            ad.Size = new Size(0, 28);
            ad.TabIndex = 3;
            ad.Click += label2_Click;
            // 
            // soy_isim_text
            // 
            soy_isim_text.Location = new Point(12, 121);
            soy_isim_text.Name = "soy_isim_text";
            soy_isim_text.Size = new Size(132, 23);
            soy_isim_text.TabIndex = 4;
            soy_isim_text.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 5;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 7;
            label4.Text = "İl İlçe";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(1, -1);
            label5.Name = "label5";
            label5.Size = new Size(536, 32);
            label5.TabIndex = 8;
            label5.Text = "Siteadı.com Yetkilli alım formuna hoşgeldiniz.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(12, 31);
            label6.Name = "label6";
            label6.Size = new Size(738, 17);
            label6.TabIndex = 9;
            label6.Text = "Uyarı: Siteadı.com ekibine katılmak için, doğru bilgiler vermelisiniz, aksi halde başvuru formunuz kabul olmayacaktır.";
            // 
            // il_ilce_text
            // 
            il_ilce_text.Location = new Point(12, 169);
            il_ilce_text.Name = "il_ilce_text";
            il_ilce_text.Size = new Size(132, 23);
            il_ilce_text.TabIndex = 11;
            // 
            // meslek_text
            // 
            meslek_text.Location = new Point(12, 214);
            meslek_text.Name = "meslek_text";
            meslek_text.Size = new Size(132, 23);
            meslek_text.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(12, 192);
            label7.Name = "label7";
            label7.Size = new Size(56, 19);
            label7.TabIndex = 13;
            label7.Text = "Meslek";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(12, 239);
            label8.Name = "label8";
            label8.Size = new Size(30, 19);
            label8.TabIndex = 15;
            label8.Text = "Yaş";
            label8.Click += label8_Click;
            // 
            // yas_text
            // 
            yas_text.Location = new Point(12, 261);
            yas_text.Name = "yas_text";
            yas_text.Size = new Size(36, 23);
            yas_text.TabIndex = 14;
            // 
            // il_ilce
            // 
            il_ilce.AutoSize = true;
            il_ilce.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            il_ilce.ForeColor = Color.LimeGreen;
            il_ilce.Location = new Point(216, 149);
            il_ilce.Name = "il_ilce";
            il_ilce.Size = new Size(0, 30);
            il_ilce.TabIndex = 17;
            il_ilce.Click += il_ilce_Click;
            // 
            // Meslek
            // 
            Meslek.AutoSize = true;
            Meslek.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Meslek.ForeColor = Color.LimeGreen;
            Meslek.Location = new Point(237, 191);
            Meslek.Name = "Meslek";
            Meslek.Size = new Size(0, 30);
            Meslek.TabIndex = 18;
            // 
            // Yas
            // 
            Yas.AutoSize = true;
            Yas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Yas.ForeColor = Color.LimeGreen;
            Yas.Location = new Point(221, 117);
            Yas.Name = "Yas";
            Yas.Size = new Size(0, 25);
            Yas.TabIndex = 19;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 112);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 20;
            label2.Text = "Yaşınız:      ";
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(150, 75);
            label9.Name = "label9";
            label9.Size = new Size(415, 32);
            label9.TabIndex = 21;
            label9.Text = "İsim Soyad:                             ";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(150, 48);
            label10.Name = "label10";
            label10.Size = new Size(157, 26);
            label10.TabIndex = 22;
            label10.Text = "Başvuran bilgileri";
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(150, 147);
            label11.Name = "label11";
            label11.Size = new Size(389, 38);
            label11.TabIndex = 23;
            label11.Text = "İl ilçe:                             ";
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(150, 188);
            label12.Name = "label12";
            label12.Size = new Size(389, 38);
            label12.TabIndex = 24;
            label12.Text = "Meslek:                             ";
            // 
            // Dogrulandi
            // 
            Dogrulandi.AutoSize = true;
            Dogrulandi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Dogrulandi.ForeColor = Color.Lime;
            Dogrulandi.Location = new Point(346, 267);
            Dogrulandi.Name = "Dogrulandi";
            Dogrulandi.Size = new Size(0, 17);
            Dogrulandi.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(749, 286);
            Controls.Add(Dogrulandi);
            Controls.Add(label10);
            Controls.Add(Yas);
            Controls.Add(Meslek);
            Controls.Add(il_ilce);
            Controls.Add(label8);
            Controls.Add(yas_text);
            Controls.Add(label7);
            Controls.Add(meslek_text);
            Controls.Add(il_ilce_text);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(soy_isim_text);
            Controls.Add(ad);
            Controls.Add(isim_text);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Name = "Form1";
            Text = "Siteadı.com Yetkilli başvurusu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox isim_text;
        private Label ad;
        private TextBox soy_isim_text;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox il_ilce_text;
        private TextBox meslek_text;
        private Label label7;
        private Label label8;
        private TextBox yas_text;
        private Label il_ilce;
        private Label Meslek;
        private Label Yas;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label Dogrulandi;
    }
}