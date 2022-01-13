using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekmMi;
        private int _ilkSayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekmMi = true;
            _ilkSayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekmMi = true;
            _ilkSayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void Rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmMi == true)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artıButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekmMi = true;
            _ilkSayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void eşittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);

            int sonuc;

            switch(_islem)
            {
                
                case '+':
                    sonuc = _ilkSayı + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayı - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayı * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayı / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                        break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekmMi = true;
            _ilkSayı = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
