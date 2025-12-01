namespace İkiByutluDiziÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*4 adet öğrenci isim girişi->*/
        string[] isim = new string[4];//Tek boyutlu yani bir boyutlu dizi tanımlaması
        /* 4 öğrenciden her biri için 4 not girişi yani(4,4)->*/
        int[,] notlar = new int[4, 4];//İki boyutlu dizi
        int index = 0;//-->yeni öğrencinin notlarını girmemiz için indexi 1+ Arttırmamız gerekir

        //Global Alanda gerekli değişkenler tanımlandı.

        private void button1_Click(object sender, EventArgs e)
        {
            isim[index] = textBox1.Text;
            notlar[index, 0] = Convert.ToInt32(textBox2.Text);
            notlar[index, 1] = Convert.ToInt32(textBox3.Text);
            notlar[index, 2] = Convert.ToInt32(textBox4.Text);
            notlar[index, 3] = Convert.ToInt32(textBox5.Text);
            index++;
            textBox1.Focus();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int x = 0; x < 4; x++)
            {
                toplam = 0;
                for (int y = 0; y < 4; y++)
                {
                    toplam += notlar[x, y];
                }
                listBox1.Items.Add(isim[x] + "=>" + toplam / 4);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
