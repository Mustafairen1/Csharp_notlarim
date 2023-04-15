namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.yazi2 = new System.Windows.Forms.TextBox();
            this.adiniz = new System.Windows.Forms.Label();
            this.soyadiniz = new System.Windows.Forms.Label();
            this.yasiniz = new System.Windows.Forms.Label();
            this.mesleginiz = new System.Windows.Forms.Label();
            this.yazi1 = new System.Windows.Forms.TextBox();
            this.yazi4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.yazi3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Devam1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(9, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Site adınız.com Yetkilli alım formumuza hoşgeldiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.Location = new System.Drawing.Point(9, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yazi2
            // 
            this.yazi2.Location = new System.Drawing.Point(9, 407);
            this.yazi2.Name = "yazi2";
            this.yazi2.Size = new System.Drawing.Size(110, 20);
            this.yazi2.TabIndex = 7;
            // 
            // adiniz
            // 
            this.adiniz.AutoSize = true;
            this.adiniz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adiniz.Location = new System.Drawing.Point(125, 506);
            this.adiniz.Name = "adiniz";
            this.adiniz.Size = new System.Drawing.Size(133, 19);
            this.adiniz.TabIndex = 11;
            this.adiniz.Text = "Lütfen adınızı girin.";
            this.adiniz.Click += new System.EventHandler(this.label2_Click);
            // 
            // soyadiniz
            // 
            this.soyadiniz.AutoSize = true;
            this.soyadiniz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadiniz.Location = new System.Drawing.Point(125, 407);
            this.soyadiniz.Name = "soyadiniz";
            this.soyadiniz.Size = new System.Drawing.Size(159, 19);
            this.soyadiniz.TabIndex = 12;
            this.soyadiniz.Text = "Lütfen soy adınızı girin.";
            // 
            // yasiniz
            // 
            this.yasiniz.AutoSize = true;
            this.yasiniz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasiniz.Location = new System.Drawing.Point(125, 201);
            this.yasiniz.Name = "yasiniz";
            this.yasiniz.Size = new System.Drawing.Size(138, 19);
            this.yasiniz.TabIndex = 13;
            this.yasiniz.Text = "Lütfen yaşınızı girin.";
            this.yasiniz.Click += new System.EventHandler(this.label4_Click);
            // 
            // mesleginiz
            // 
            this.mesleginiz.AutoSize = true;
            this.mesleginiz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesleginiz.Location = new System.Drawing.Point(125, 298);
            this.mesleginiz.Name = "mesleginiz";
            this.mesleginiz.Size = new System.Drawing.Size(188, 19);
            this.mesleginiz.TabIndex = 14;
            this.mesleginiz.Text = "Lütfen mesleğinizi söyleyin.";
            this.mesleginiz.Click += new System.EventHandler(this.label5_Click);
            // 
            // yazi1
            // 
            this.yazi1.Location = new System.Drawing.Point(9, 507);
            this.yazi1.Name = "yazi1";
            this.yazi1.Size = new System.Drawing.Size(110, 20);
            this.yazi1.TabIndex = 16;
            // 
            // yazi4
            // 
            this.yazi4.Location = new System.Drawing.Point(9, 202);
            this.yazi4.Name = "yazi4";
            this.yazi4.Size = new System.Drawing.Size(110, 20);
            this.yazi4.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button3.Location = new System.Drawing.Point(9, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yazi3
            // 
            this.yazi3.Location = new System.Drawing.Point(9, 297);
            this.yazi3.Name = "yazi3";
            this.yazi3.Size = new System.Drawing.Size(110, 20);
            this.yazi3.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button4.Location = new System.Drawing.Point(9, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 35);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Devam1
            // 
            this.Devam1.BackColor = System.Drawing.SystemColors.Info;
            this.Devam1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Devam1.Location = new System.Drawing.Point(647, 542);
            this.Devam1.Name = "Devam1";
            this.Devam1.Size = new System.Drawing.Size(150, 44);
            this.Devam1.TabIndex = 21;
            this.Devam1.Text = "Devam etmek için tıklayın.";
            this.Devam1.UseVisualStyleBackColor = false;
            this.Devam1.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(6, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(666, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "Uyarı Siteadınız.com\'a kayıt olmak için doğru bilgilerinizi girmeye özen gösterin" +
    ", aksi halde başvurunuz iptal olacaktır.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Devam1);
            this.Controls.Add(this.yazi3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.yazi4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.yazi1);
            this.Controls.Add(this.mesleginiz);
            this.Controls.Add(this.yasiniz);
            this.Controls.Add(this.soyadiniz);
            this.Controls.Add(this.adiniz);
            this.Controls.Add(this.yazi2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "siteadınız.com yetkilli alım formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox yazi2;
        private System.Windows.Forms.Label adiniz;
        private System.Windows.Forms.Label soyadiniz;
        private System.Windows.Forms.Label yasiniz;
        private System.Windows.Forms.Label mesleginiz;
        private System.Windows.Forms.TextBox yazi1;
        private System.Windows.Forms.TextBox yazi4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox yazi3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Devam1;
        private System.Windows.Forms.Label label6;
    }
}

