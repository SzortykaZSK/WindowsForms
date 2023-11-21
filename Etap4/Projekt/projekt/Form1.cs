using projekt.Presenters;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt
{
    public partial class Form1 : Form
    {

        TextAnalyzerDataPresenter textAnalyzerDataPresenter;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textBox1, textBox2, textBox4, textBox5, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPath = Environment.CurrentDirectory;
            openFileDialog1.InitialDirectory = currentPath;
            openFileDialog1.Filter = "Pliki tekstowe|*.txt";
            var result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string fileText = File.ReadAllText(openFileDialog1.FileName);

                richTextBox1.Text = fileText;

                textAnalyzerDataPresenter.PerformTextAnalysis(fileText);
            }
        }


    }
}