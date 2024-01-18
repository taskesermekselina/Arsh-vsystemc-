namespace ProjeOdev
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label5 = new Label();
            isimAraTxt = new TextBox();
            evrakadıTxt = new TextBox();
            acıklamatxt = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            button4 = new Button();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            rafnotxt = new TextBox();
            buttonAra = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 414);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 4;
            label5.Text = "Tarih";
            // 
            // isimAraTxt
            // 
            isimAraTxt.Location = new Point(147, 64);
            isimAraTxt.Name = "isimAraTxt";
            isimAraTxt.Size = new Size(125, 27);
            isimAraTxt.TabIndex = 5;
            // 
            // evrakadıTxt
            // 
            evrakadıTxt.Location = new Point(184, 190);
            evrakadıTxt.Name = "evrakadıTxt";
            evrakadıTxt.Size = new Size(125, 27);
            evrakadıTxt.TabIndex = 7;
            // 
            // acıklamatxt
            // 
            acıklamatxt.Location = new Point(184, 295);
            acıklamatxt.Name = "acıklamatxt";
            acıklamatxt.Size = new Size(215, 27);
            acıklamatxt.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(184, 412);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(507, 471);
            button2.Name = "button2";
            button2.Size = new Size(143, 100);
            button2.TabIndex = 11;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(704, 472);
            button3.Name = "button3";
            button3.Size = new Size(143, 99);
            button3.TabIndex = 12;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.DarkSeaGreen;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = Color.DarkSeaGreen;
            dataGridView3.Location = new Point(473, 112);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(446, 325);
            dataGridView3.TabIndex = 13;
            dataGridView3.CellMouseClick += dataGridView3_CellMouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(792, 56);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(127, 31);
            button4.TabIndex = 16;
            button4.Text = "Listele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Evrak Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 299);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 3;
            label4.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 190);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 2;
            label3.Text = "Evrak Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 356);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 17;
            label6.Text = "Raf No";
            // 
            // rafnotxt
            // 
            rafnotxt.Location = new Point(184, 352);
            rafnotxt.Margin = new Padding(3, 4, 3, 4);
            rafnotxt.Name = "rafnotxt";
            rafnotxt.Size = new Size(125, 27);
            rafnotxt.TabIndex = 18;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(289, 64);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(94, 29);
            buttonAra.TabIndex = 20;
            buttonAra.Text = "ARA";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 246);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 21;
            label2.Text = "Evrak Türü";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sınav Evrakları", "Öğrenci Evrakları", "Muhasebe Evrakları", "Personel Evrakları", "Bölüm Evrakları" });
            comboBox1.Location = new Point(184, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 468);
            label7.Name = "label7";
            label7.Size = new Size(166, 20);
            label7.TabIndex = 23;
            label7.Text = "Kaydeden Ünvan";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Fakülte Sekreteri", "Memur(öğrenci işleri)", "Memur(muhasebe)", "Memur(öğretim görevlisi)" });
            comboBox2.Location = new Point(184, 465);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(391, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(10, 27);
            textBox1.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(31, 542);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 26;
            button1.Text = "Geri dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(960, 613);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(buttonAra);
            Controls.Add(rafnotxt);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(dataGridView3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(acıklamatxt);
            Controls.Add(evrakadıTxt);
            Controls.Add(isimAraTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evrak Listeleme";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox isimAraTxt;
        private TextBox evrakadıTxt;
        private TextBox acıklamatxt;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView3;
        private Button button4;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox rafnotxt;
        private Button buttonAra;
        private Label label2;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button button1;
    }
}