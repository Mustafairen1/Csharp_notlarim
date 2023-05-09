namespace Calisma5
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblSoruno = new Label();
            LblYanlis = new Label();
            LblDogru = new Label();
            BtnSonraki = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            BtnD = new Button();
            BtnC = new Button();
            BtnB = new Button();
            BtnA = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlDark;
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(330, 136);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Soru NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(14, 33);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 46);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // LblSoruno
            // 
            LblSoruno.AutoSize = true;
            LblSoruno.Location = new Point(57, 19);
            LblSoruno.Name = "LblSoruno";
            LblSoruno.Size = new Size(13, 15);
            LblSoruno.TabIndex = 10;
            LblSoruno.Text = "0";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new Point(57, 47);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new Size(13, 15);
            LblYanlis.TabIndex = 9;
            LblYanlis.Text = "0";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new Point(57, 34);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new Size(13, 15);
            LblDogru.TabIndex = 8;
            LblDogru.Text = "0";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(6, 22);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(118, 72);
            BtnSonraki.TabIndex = 4;
            BtnSonraki.Text = "Sonraki Soru";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += btnSonraki_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 279);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 279);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 271);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sorular";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveBorder;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(BtnSonraki);
            groupBox2.Location = new Point(6, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 100);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlem Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(230, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(LblSoruno);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(LblDogru);
            groupBox3.Controls.Add(LblYanlis);
            groupBox3.Location = new Point(218, 297);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(103, 75);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "İstatikler";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnD);
            groupBox4.Controls.Add(BtnC);
            groupBox4.Controls.Add(BtnB);
            groupBox4.Controls.Add(BtnA);
            groupBox4.Location = new Point(8, 297);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(204, 75);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Şıklar";
            // 
            // BtnD
            // 
            BtnD.Location = new Point(105, 46);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(93, 23);
            BtnD.TabIndex = 19;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(6, 46);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(93, 23);
            BtnC.TabIndex = 18;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(105, 15);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(92, 23);
            BtnB.TabIndex = 17;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnA
            // 
            BtnA.Location = new Point(6, 15);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(93, 23);
            BtnA.TabIndex = 16;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(545, 399);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblSoruno;
        private Label LblYanlis;
        private Label LblDogru;
        private Button BtnSonraki;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button BtnD;
        private Button BtnC;
        private Button BtnB;
        private Button BtnA;
    }
}