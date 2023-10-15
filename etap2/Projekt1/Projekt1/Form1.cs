using Projekt1.Presenters;

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
            textAnalyzerDataPresenter = new TextAnalyzerDataPresenter(textBox1, textBox2, textBox3, textBox4, textBox5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textAnalyzerDataPresenter.PerformTextAnalysis(richTextBox1.Text);
        }
    }
}