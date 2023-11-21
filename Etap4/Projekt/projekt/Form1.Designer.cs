namespace projekt
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 65);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(954, 127);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1065, 499);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 69);
            button1.TabIndex = 1;
            button1.Text = "Analizuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1065, 137);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1065, 263);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 6;
            label1.Text = "Wpisz tekst";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1065, 113);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "Dlugosc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1064, 239);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 10;
            label5.Text = "Znaki specjalne";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1065, 445);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1065, 421);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 12;
            label6.Text = "czas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 197);
            label7.Name = "label7";
            label7.Size = new Size(161, 45);
            label7.TabIndex = 13;
            label7.Text = "Statystyka";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1065, 349);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1064, 325);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 16;
            label3.Text = "Entropia";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(14, 249);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(805, 335);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "Zapis binarny";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Zapis dziesiętny";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Symbol";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Częstość";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Prawdopodobieństwo";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ilość informacji";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 600);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}