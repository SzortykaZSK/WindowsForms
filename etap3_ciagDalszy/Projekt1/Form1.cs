using Projekt1.Presenters;
using System.Text;

namespace Projekt1
{
    public partial class Form1 : Form
    {

        private TextAnalyzerDataPresenter textAnalyzerDataPresenter;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textBox1, textBox2, textBox3, textBox4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text = Encoding.UTF8.GetString(File.ReadAllBytes(openFileDialog1.FileName));
            }


            textAnalyzerDataPresenter.PerformTextAnalysis(richTextBox1.Text);
        }
    }
}