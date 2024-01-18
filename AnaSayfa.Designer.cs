namespace ProjeOdev
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox4 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            button5 = new Button();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(318, 260);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Evrak İşlemleri";
            // 
            // button4
            // 
            button4.Location = new Point(28, 151);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(241, 70);
            button4.TabIndex = 1;
            button4.Text = "Evrak Listeleme İşlemi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 60);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(241, 71);
            button3.TabIndex = 0;
            button3.Text = "Evrak Ekleme İşlemi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkSeaGreen;
            groupBox4.Controls.Add(button9);
            groupBox4.Controls.Add(button8);
            groupBox4.Controls.Add(button7);
            groupBox4.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(455, 13);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(320, 260);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Emanet İşlemleri";
            // 
            // button9
            // 
            button9.Location = new Point(23, 176);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(286, 62);
            button9.TabIndex = 2;
            button9.Text = "Emanet Evrak Geri Alma İşlemi";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(23, 100);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(286, 58);
            button8.TabIndex = 1;
            button8.Text = "Emanet Evrak Listeleme İşlemi";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(23, 38);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(286, 54);
            button7.TabIndex = 0;
            button7.Text = "Emanet Evrak Verme İşlemi";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(455, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 258);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel İşlemleri";
            // 
            // button1
            // 
            button1.Location = new Point(23, 91);
            button1.Name = "button1";
            button1.Size = new Size(286, 104);
            button1.TabIndex = 0;
            button1.Text = "Yeni Personel Ekleme/Listeleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSeaGreen;
            groupBox3.Controls.Add(button5);
            groupBox3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(318, 258);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dökümantasyon ";
            // 
            // button5
            // 
            button5.Location = new Point(6, 91);
            button5.Name = "button5";
            button5.Size = new Size(301, 104);
            button5.TabIndex = 0;
            button5.Text = "Dökümantasyon Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(817, 621);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Sekreter Ana Sayfa";
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button button4;
        private Button button3;
        private Button button8;
        private Button button7;
        private Button button9;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox3;
        private Button button5;
    }
}