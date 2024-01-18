namespace ProjeOdev
{
    partial class Form8
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            button5 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(401, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(639, 514);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(853, 19);
            button1.Name = "button1";
            button1.Size = new Size(187, 29);
            button1.TabIndex = 1;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Evrak Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Evrak Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Açıklama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 340);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Raf No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 286);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 6;
            label5.Text = "Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(-3, 388);
            label6.Name = "label6";
            label6.Size = new Size(166, 20);
            label6.TabIndex = 7;
            label6.Text = "Kaydeden Ünvan";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fakülte Sekreteri", "Memur(öğrenci işleri)", "Memur(muhasebe)", "Memur(öğretim görevlisi)" });
            comboBox1.Location = new Point(174, 385);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sınav Evrakları", "Öğrenci Evrakları", "Muhasebe Evrakları", "Personel Evrakları", "Bölüm Evrakları" });
            comboBox2.Location = new Point(164, 173);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 28);
            comboBox2.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 333);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(174, 450);
            button2.Name = "button2";
            button2.Size = new Size(110, 51);
            button2.TabIndex = 14;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 28);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 18;
            label7.Text = "Evrak Adı";
            // 
            // button5
            // 
            button5.Location = new Point(266, 28);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 20;
            button5.Text = "Ara";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 21;
            // 
            // button3
            // 
            button3.Location = new Point(11, 520);
            button3.Name = "button3";
            button3.Size = new Size(114, 29);
            button3.TabIndex = 22;
            button3.Text = "Geri dön";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1064, 594);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form8";
            Text = "Evrak Ekleme";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button button5;
        private TextBox textBox3;
        private Button button3;
    }
}