namespace ProjeOdev
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEkle = new Button();
            acıklamatext = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            evraktext = new TextBox();
            raftext = new TextBox();
            button1 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(528, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(499, 544);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 141);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Evrak Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 308);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "Tarih";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 357);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Raf No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 225);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 5;
            label5.Text = "Açıklama";
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(246, 441);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 83);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // acıklamatext
            // 
            acıklamatext.Location = new Point(246, 187);
            acıklamatext.Multiline = true;
            acıklamatext.Name = "acıklamatext";
            acıklamatext.Size = new Size(250, 100);
            acıklamatext.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sınav Evrakları", "Öğrenci Evrakları", "Muhasebe Evrakları", "Personel Evrakları", "Bölüm Evrakları" });
            comboBox1.Location = new Point(246, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 303);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 81);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 14;
            label6.Text = "Evrak Adı";
            // 
            // evraktext
            // 
            evraktext.Location = new Point(246, 73);
            evraktext.Name = "evraktext";
            evraktext.Size = new Size(250, 27);
            evraktext.TabIndex = 15;
            // 
            // raftext
            // 
            raftext.Location = new Point(246, 357);
            raftext.Name = "raftext";
            raftext.Size = new Size(250, 27);
            raftext.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(82, 456);
            button1.Name = "button1";
            button1.Size = new Size(116, 52);
            button1.TabIndex = 17;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(31, 407);
            label7.Name = "label7";
            label7.Size = new Size(166, 20);
            label7.TabIndex = 18;
            label7.Text = "Kaydeden Ünvan";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Fakülte Sekreteri", "Memur(öğrenci işleri)", "Memur(muhasebe)", "Memur(öğretim görevlisi)" });
            comboBox2.Location = new Point(246, 407);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 19;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1046, 595);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(raftext);
            Controls.Add(evraktext);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(acıklamatext);
            Controls.Add(btnEkle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Evrak Ekleme";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEkle;
        private TextBox acıklamatext;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox evraktext;
        private TextBox raftext;
        private Button button1;
        private Label label7;
        private ComboBox comboBox2;
    }
}