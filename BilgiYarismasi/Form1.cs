namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        private void btn_basla_Click(object sender, EventArgs e)
        {

            soruNo++;
            label1.Text = soruNo.ToString();
            btn_basla.Text = "İleri ->";

            if (soruNo == 1)
            {
                richTextBox1.Text = "'Vatan Şairi' olarak bilinen şairimiz kimdir?";
                btn_a.Text = "A) Oğuz Atay";
                btn_b.Text = "B) Namık Kemal";
                btn_c.Text = "C) Fevzi Çakmak";
                btn_d.Text = "D) Ahmet Hamdi Tanpınar";
                lbl_dogru.Text = "B) Namık Kemal";

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Apple firmasının kurucularındandır?";
                btn_a.Text = "A) Mark Zuckerberg";
                btn_b.Text = "B) Elon Musk";
                btn_c.Text = "C) Nikola Tesla";
                btn_d.Text = "D) Steve Jobs";
                lbl_dogru.Text = "D) Steve Jobs";

            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "1919 yılında İstanbul halkını ülkenin işgaline karşı harekete geçirmek için yaptığı konuşmaları ile zihinlerde yer etmiş usta bir hatip olan, “Sinekli Bakkal” isimli romanın yazarı aşağıdakilerden hangisidir?";
                btn_a.Text = "A) Reşat Nuri Güntekin";
                btn_b.Text = "B) Halide Edip Adıvar";
                btn_c.Text = "C) Ziya Gökalp";
                btn_d.Text = "D) Ömer Seyfettin";
                lbl_dogru.Text = "B) Halide Edip Adıvar";

            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "İlk defa dünya haritasını kim çizmiştir?";
                btn_a.Text = "A) Piri Reis";
                btn_b.Text = "B) Oruç Reis";
                btn_c.Text = "C) Kemal Reis";
                btn_d.Text = "D) Ali Kuşçu";
                lbl_dogru.Text = "A) Piri Reis";

            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Rasulüllah (S.A.V.)’İn Veysel Karani’ye Hediye Olarak Bıraktığı, Hz. Ömer (R.A.) ve Hz. Ali (R.A.)’In Bu Vasiyeti Yerine Getirerek Ulaştırılan Hırkası Bu Gün Nerededir?";
                btn_a.Text = "A) Mekke";
                btn_b.Text = "B) Medine";
                btn_c.Text = "C) İstanbul";
                btn_d.Text = "D) Gaziantep";
                lbl_dogru.Text = "C) İstanbul";

                btn_basla.Text = "Sonuçlar";

            }
            btn_a.Enabled = true;
            btn_b.Enabled = true;
            btn_c.Enabled = true;
            btn_d.Enabled = true;
            btn_basla.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            if (soruNo > 5)
            {
                label1.Text = "5";
                int puan;
                puan = dogru * 20;
                MessageBox.Show("Yarışmamız sona ermiştir.\n" + dogru + " Doğrunuz" + yanlis + " Yanlışınız var \n Toplam puanınız: " + puan);

                btn_a.Enabled = false;
                btn_b.Enabled = false;
                btn_c.Enabled = false;
                btn_d.Enabled = false;
                btn_basla.Enabled = false;

            }

        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            lbl_cevap.Text = btn_a.Text;
            if (lbl_cevap.Text == lbl_dogru.Text)
            {
                dogru++;
                lbl_dogru_say.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis_say.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_basla.Enabled = true;

        }

        private void btn_b_Click(object sender, EventArgs e)
        {

            lbl_cevap.Text = btn_b.Text;
            if (lbl_cevap.Text == lbl_dogru.Text)
            {
                dogru++;
                lbl_dogru_say.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis_say.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_basla.Enabled = true;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            lbl_cevap.Text = btn_c.Text;
            if (lbl_cevap.Text == lbl_dogru.Text)
            {
                dogru++;
                lbl_dogru_say.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis_say.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_basla.Enabled = true;
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            lbl_cevap.Text = btn_d.Text;
            if (lbl_cevap.Text == lbl_dogru.Text)
            {
                dogru++;
                lbl_dogru_say.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis_say.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
            btn_basla.Enabled = true;

        }
    }
}