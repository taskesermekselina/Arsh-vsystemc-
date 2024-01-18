namespace ProjeOdev
{
    partial class Form9
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
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            raf2txt = new TextBox();
            aciklama2txt = new TextBox();
            evrktxt = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            mailtxt = new TextBox();
            teltxt = new TextBox();
            adstxt = new TextBox();
            tctxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btnAraEvrak = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtno = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateGray;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(raf2txt);
            groupBox1.Controls.Add(aciklama2txt);
            groupBox1.Controls.Add(evrktxt);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(mailtxt);
            groupBox1.Controls.Add(teltxt);
            groupBox1.Controls.Add(adstxt);
            groupBox1.Controls.Add(tctxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.Window;
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 470);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Emanet  Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(273, 425);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 27);
            dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(275, 363);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sınav Evrakları", "Öğrenci Evrakları", "Muhasebe Evrakları", "Personel Evrakları", "Bölüm Evrakları" });
            comboBox1.Location = new Point(273, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 28);
            comboBox1.TabIndex = 19;
            // 
            // raf2txt
            // 
            raf2txt.Location = new Point(273, 303);
            raf2txt.Name = "raf2txt";
            raf2txt.Size = new Size(197, 27);
            raf2txt.TabIndex = 18;
            // 
            // aciklama2txt
            // 
            aciklama2txt.Location = new Point(273, 240);
            aciklama2txt.Name = "aciklama2txt";
            aciklama2txt.Size = new Size(197, 27);
            aciklama2txt.TabIndex = 17;
            // 
            // evrktxt
            // 
            evrktxt.Location = new Point(273, 102);
            evrktxt.Name = "evrktxt";
            evrktxt.Size = new Size(197, 27);
            evrktxt.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(273, 393);
            label13.Name = "label13";
            label13.Size = new Size(112, 20);
            label13.TabIndex = 15;
            label13.Text = "İade Tarihi";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(273, 333);
            label12.Name = "label12";
            label12.Size = new Size(130, 20);
            label12.TabIndex = 14;
            label12.Text = "Teslim Tarihi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(273, 280);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 13;
            label11.Text = "Raf No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(273, 217);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 12;
            label10.Text = "Açıklama";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(273, 149);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 11;
            label9.Text = "Evrak Türü";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(273, 79);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 10;
            label8.Text = "Evrak Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(263, 52);
            label7.Name = "label7";
            label7.Size = new Size(142, 21);
            label7.TabIndex = 9;
            label7.Text = "Evrak Bilgileri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 52);
            label6.Name = "label6";
            label6.Size = new Size(169, 21);
            label6.TabIndex = 8;
            label6.Text = "Personel Bilgileri";
            // 
            // mailtxt
            // 
            mailtxt.Location = new Point(13, 365);
            mailtxt.Name = "mailtxt";
            mailtxt.Size = new Size(135, 27);
            mailtxt.TabIndex = 7;
            // 
            // teltxt
            // 
            teltxt.Location = new Point(13, 277);
            teltxt.Name = "teltxt";
            teltxt.Size = new Size(135, 27);
            teltxt.TabIndex = 6;
            // 
            // adstxt
            // 
            adstxt.Location = new Point(15, 190);
            adstxt.Name = "adstxt";
            adstxt.Size = new Size(135, 27);
            adstxt.TabIndex = 5;
            // 
            // tctxt
            // 
            tctxt.Location = new Point(18, 119);
            tctxt.Name = "tctxt";
            tctxt.Size = new Size(135, 27);
            tctxt.TabIndex = 4;
            tctxt.TextChanged += tctxt_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 333);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 247);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 2;
            label4.Text = "Telefon no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 167);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 1;
            label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(18, 96);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Tc Ara";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 33);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 27;
            label1.Text = "Evraklar";
            // 
            // btnAraEvrak
            // 
            btnAraEvrak.BackColor = SystemColors.ControlLight;
            btnAraEvrak.Font = new Font("Georgia", 9.55F, FontStyle.Regular, GraphicsUnit.Point);
            btnAraEvrak.Location = new Point(264, 33);
            btnAraEvrak.Margin = new Padding(3, 4, 3, 4);
            btnAraEvrak.Name = "btnAraEvrak";
            btnAraEvrak.Size = new Size(74, 31);
            btnAraEvrak.TabIndex = 28;
            btnAraEvrak.Text = "Ara";
            btnAraEvrak.UseVisualStyleBackColor = false;
            btnAraEvrak.Click += btnAraEvrak_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DarkSeaGreen;
            dataGridView1.Location = new Point(560, 61);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(553, 472);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // button5
            // 
            button5.BackColor = Color.Thistle;
            button5.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(946, 28);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(158, 28);
            button5.TabIndex = 30;
            button5.Text = "Listele";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Location = new Point(823, 551);
            button2.Name = "button2";
            button2.Size = new Size(142, 41);
            button2.TabIndex = 31;
            button2.Text = "Emanet Ver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(971, 551);
            button1.Name = "button1";
            button1.Size = new Size(142, 41);
            button1.TabIndex = 32;
            button1.Text = "Emanet'i Al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtno
            // 
            txtno.BackColor = SystemColors.ActiveCaption;
            txtno.Location = new Point(358, 37);
            txtno.Name = "txtno";
            txtno.Size = new Size(20, 27);
            txtno.TabIndex = 22;
            // 
            // button3
            // 
            button3.Location = new Point(24, 572);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 33;
            button3.Text = "Geri dön";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1163, 620);
            Controls.Add(button3);
            Controls.Add(txtno);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(btnAraEvrak);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form9";
            Text = "Emanet Al/Ver";
            Load += Form9_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox raf2txt;
        private TextBox aciklama2txt;
        private TextBox evrktxt;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox mailtxt;
        private TextBox teltxt;
        private TextBox adstxt;
        private TextBox tctxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnAraEvrak;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button2;
        private Button button1;
        private TextBox txtno;
        private Button button3;
    }
}