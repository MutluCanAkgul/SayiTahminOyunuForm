namespace SayiTahminOyunuForm
{
    public partial class Form1 : Form
    {
        int sayi;
        int sayac = 0;
        int rastgeleSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sayac++;
                sayi = Convert.ToInt32(textBox1.Text);
                if (sayi < rastgeleSayi)
                {
                    label3.Text = "Yukar�";
                    textBox1.Clear();
                }
                else if (sayi > rastgeleSayi)
                {
                    label3.Text = "A��a��";
                    textBox1.Clear();
                }
                else
                {
                    label2.Text = "Tebrikler " + sayac + " tahminde do�ru cevaba ula�t�n�z";

                }
            }
            catch {
                label2.Text = "Sadece Say� Girin";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            rastgeleSayi = rastgele.Next(100);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}