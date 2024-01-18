namespace ProjeOdev
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Evrak İşlemleri";
            // 
            // button1
            // 
            button1.Location = new Point(6, 128);
            button1.Name = "button1";
            button1.Size = new Size(263, 73);
            button1.TabIndex = 0;
            button1.Text = "Evrak Ekleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(button2);
            groupBox2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(409, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 317);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Emanet İşlemleri";
            // 
            // button2
            // 
            button2.Location = new Point(19, 128);
            button2.Name = "button2";
            button2.Size = new Size(255, 73);
            button2.TabIndex = 0;
            button2.Text = "Emanet Evrak Verme/Alma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(739, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form7";
            Text = "Personel Ana Sayfa";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
    }
}