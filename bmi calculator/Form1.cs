using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_calculator
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Kullanıcıdan kilo ve boy bilgilerini al
                    double kilo = double.Parse(textBox1.Text); // İlk textbox için
                    double boy = double.Parse(textBox2.Text); // İkinci textbox için

                    // Boyu metreye çevirme
                    double boyMetre = boy / 100;

                    // Vücut Kitle Endeksi hesaplama
                    double vke = kilo / (boyMetre * boyMetre);

                    // Kategori belirleme
                    string kategori;
                    if (vke < 18.5)
                    {
                        kategori = "Zayıf";
                    }
                    else if (vke < 24.9)
                    {
                        kategori = "Normal";
                    }
                    else if (vke < 29.9)
                    {
                        kategori = "Fazla Kilolu";
                    }
                    else if (vke < 39.9)
                    {
                        kategori = "Obez";
                    }
                    else
                    {
                        kategori = "Aşırı Obez";
                    }

                    // Sonucu göster
                    textBox3.Text = $"BMI: {vke:F2} \n {kategori}";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen geçerli sayılar giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Boy 0 olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
