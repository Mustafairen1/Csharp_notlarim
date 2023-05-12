namespace Calisma6
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 21F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(75, 54);
            button1.Name = "button1";
            button1.Size = new Size(96, 40);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(225, 33);
            label1.TabIndex = 3;
            label1.Text = "000000000000000";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(118, 21);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(28, 33);
            textBox3.TabIndex = 4;
            textBox3.Text = "+";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 64);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sonuç:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GrayText;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(11, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(258, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlev";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 188);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 100);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nasıl kullanılır?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 23);
            label2.Name = "label2";
            label2.Size = new Size(235, 72);
            label2.TabIndex = 0;
            label2.Text = "\"+\" işareti toplama işlemi için kullanılır.\r\n\"-\" işareti çıkarma işlemi için kullanılır.\r\n\"*\" işareti çarpma işlemi için kullanılır.\r\n\"/\" işareti bölme işlemi için kullanılır.\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(281, 298);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Hesap Makinası v1.0";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
    }
}