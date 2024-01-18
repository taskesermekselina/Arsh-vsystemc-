namespace ProjeOdev
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(621, 382);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(23, 6);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 1;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = false;
          
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(481, 429);
            button2.Name = "button2";
            button2.Size = new Size(152, 49);
            button2.TabIndex = 2;
            button2.Text = "Emanet'i Al";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 148);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(639, 440);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(26, 27);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(12, 438);
            button3.Name = "button3";
            button3.Size = new Size(107, 29);
            button3.TabIndex = 5;
            button3.Text = "Geri dön";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(734, 490);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
    }
}