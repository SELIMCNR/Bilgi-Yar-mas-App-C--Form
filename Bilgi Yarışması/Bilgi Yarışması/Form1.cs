namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblSoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = " Türkiye’de olan iki ilin harfleri aynıdır. Sizce hangileri? ";
                btnA.Text = "Ankara ve Antalya";
                btnB.Text = "Bursa ve Balıkesir";
                btnC.Text = "Aksaray ve Sakarya";
                btnD.Text = "Nevşehir ve Balıkesir ";
                label4.Text = "Aksaray ve Sakarya";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = " Chicago'dan hareket eden 43 yolculu bir otobüs kullanıyorsunuz. Pittsburgh´ da 7 yolcu binip, 5 yolcu indi. Cleveland´ da 8 yolcu indi, yolcu tuvalete gidip geldi ve 4 yeni yolcu bindi. 20 saat sonra Philadelphia´ ya vardığınızda şoförün adı neydi? ";
                btnA.Text = "Michael Fero";
                btnB.Text = "Alex Gutierez";
                btnC.Text = "Şoför sizsiniz. Cevap kendi adınız. ";
                btnD.Text = "Szymanski";
                label4.Text = "Şoför sizsiniz. Cevap kendi adınız. ";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = " Saatte 2 kere ama Saniyede 1 kere meydana gelen nedir? ";
                btnA.Text = "Bebek";
                btnB.Text = "A harfi";
                btnC.Text = "Meyve";
                btnD.Text = "Yumurta";
                label4.Text = "A harfi";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru:  " + dogru + "\n" + "Yanlış : " + yanlis);
                Application.Exit();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnB.Text;
            BtnSonraki.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnC.Text;
            BtnSonraki.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label5.Text = btnD.Text;
            BtnSonraki.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}