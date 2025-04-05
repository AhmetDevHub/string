namespace Değişkenler_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ad, soyad, meslek;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            meslek = textBox3.Text;
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + maskedTextBox1.Text + " " + textBox3.Text);
        }
    }
}
