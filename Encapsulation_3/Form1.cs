using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.ad = textBox1.Text;
            k.soyad = textBox2.Text;
            k.dogum_tarih = dateTimePicker1.Value;
            string adsoyad = k.Bilgiler;
            // MessageBox.Show(adsoyad);
            Kisi_Bilgisi_Ekle(k);
        }

        void Kisi_Bilgisi_Ekle(Kisi eklenecek_kisi)
        {
            listBox1.Items.Add(eklenecek_kisi.Bilgiler);
            listBox1.Items.Add(eklenecek_kisi.yas);
        }
    }
}
