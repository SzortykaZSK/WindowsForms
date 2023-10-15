namespace Projekt1
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            richTextBox2 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 51);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(587, 82);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Tekst wejściowy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(666, 54);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 2;
            label2.Text = "Liczba wszystkich znaków";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(666, 129);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 3;
            label3.Text = "LIczba unikatowych znaków";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 226);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "Entropia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 385);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 5;
            label5.Text = "Czas wykonania";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(657, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(657, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(657, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(657, 419);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 27);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(657, 472);
            button1.Name = "button1";
            button1.Size = new Size(145, 57);
            button1.TabIndex = 10;
            button1.Text = "Analizuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 159);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 11;
            label6.Text = "Statystyka";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 203);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(587, 326);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 541);
            Controls.Add(richTextBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
        private RichTextBox richTextBox2;
        private OpenFileDialog openFileDialog1;
    }
}