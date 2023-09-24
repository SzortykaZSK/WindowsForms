namespace Projekt01UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        static string ZnajdzLitery(string tekst)
        {
            string unikalneLitery = new string(tekst.ToLower().Where(char.IsLetter).Distinct().ToArray());

           

            return unikalneLitery;
        }

        static string ZnajdzUnikalneCyfry(string tekst)
        {
            string unikalneCyfry = new string(tekst.Where(char.IsDigit).Distinct().ToArray());

            return unikalneCyfry;
        }
        static string ZnajdzUnikalneZnakiSpecjalne(string tekst)
        {
            string unikalneZnakiSpecjalne = new string(tekst.Where(c => !char.IsLetterOrDigit(c)).Distinct().ToArray());

            return unikalneZnakiSpecjalne;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string value =  richTextBox1.Text;

            textBox1.Text = value.Length.ToString();

            if (ZnajdzLitery(value) != "" )
            {
                textBox2.Text = "TAK";
            }
            else
            {
                textBox2.Text = "NIE";

            }

            if (ZnajdzUnikalneCyfry(value) != "")
            {
                textBox3.Text = "TAK";
            }
            else
            {
                textBox3.Text = "NIE";

            }

            if (ZnajdzUnikalneZnakiSpecjalne(value) != "")
            {
                textBox4.Text = "TAK";
            }
            else
            {
                textBox4.Text = "NIE";

            }


        }
    }
}