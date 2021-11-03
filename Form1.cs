using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string islem = String.Empty;
        public double sayi1 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Butonların Click event "Ekle" metodu oluşturup buton içinde yazan rakamları textBox ımıza yazıyoruz.
        private void Ekle(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        //Butonların Click event "Islem" metodu oluşturuyoruz.
        private void Islem(object sender, EventArgs e)
        {
            islem = (sender as Button).Text;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }
        //C butonunun silme kodu.
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            islem = string.Empty;
        }
        //"=" butonunda Switch kullanarak sayi1 ve sayi2 de işlem yapıyoruz.
        private void button11_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(textBox1.Text);

            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 + sayi2;
                    break;
                case "*":
                    sonuc = sayi1 + sayi2;
                    break;
                case "/":
                    sonuc = sayi1 + sayi2;
                    break;
                default:
                    MessageBox.Show("İşlem Hatalı.", "Hata");
                    break;
            }
            textBox1.Text = sonuc.ToString();
        }
        //textBox1 de yazılan son rakamı siliyouz.
        private void button18_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            textBox1.Text = "";

            int i;

            for (i = 0;i<veri.Length -1; i++)
            {
                textBox1.Text += veri[i].ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BekirKayraCigdem");
        }
    }
}
