namespace hesap_makinesi
{
    public partial class form1 : Form
    {
        char _islem;
        bool _ekrantemizle;
        int _iklsayi;
        public form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true)
            {
                ekran_label1.Text = "";
                _ekrantemizle = false;
            }

            if (ekran_label1.Text == "0") ekran_label1.Text = "";
            ekran_label1.Text += "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizle = true;
            _iklsayi = Convert.ToInt32(ekran_label1.Text);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizle = true;
            _iklsayi = Convert.ToInt32(ekran_label1.Text);
        }
        private void çarpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizle = true;
            _iklsayi = Convert.ToInt32(ekran_label1.Text);
        }

        private void bölme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizle = true;
            _iklsayi = Convert.ToInt32(ekran_label1.Text);
        }


        private void Eþittir_Click(object sender, EventArgs e)
        {
            int ikicisayi = Convert.ToInt32(ekran_label1.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _iklsayi + ikicisayi;
                    break;
                case '-':
                    sonuc = _iklsayi - ikicisayi;
                    break;
                case '*':
                    sonuc = _iklsayi * ikicisayi;
                    break;
                case '/':
                    sonuc = _iklsayi / ikicisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekran_label1.Text = Convert.ToString(sonuc);
        }

        private void c_Click(object sender, EventArgs e)
        {
            ekran_label1.Text = "0";
        }
    }
}