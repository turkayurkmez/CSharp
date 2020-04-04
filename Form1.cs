using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazirMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kelime = "bilgisayar";
        private void Form1_Load(object sender, EventArgs e)
        {
           
            string sonuc1 = kelime.Replace(" ", "");
            MessageBox.Show(sonuc1);

            for (int i = 1; i < 13; i++)
            {
                comboBoxTaksit.Items.Add(i);
            }

        }

        private void buttonSubString_Click(object sender, EventArgs e)
        {
            string isim = "türkay";
            string sonuc = kelime.Substring(3, 3);
            listBoxStringSonuc.Items.Add("Substring: " + sonuc);
            string ilkHarfiBuyuk = isim.Substring(0, 1).ToUpper() + isim.Substring(1);
            listBoxStringSonuc.Items.Add(ilkHarfiBuyuk);
        }

        private void buttonIndexOf_Click(object sender, EventArgs e)
        {
           // int sonuc = kelime.IndexOf('i', 2);
            int ilkAramaIndexi = 0;
            string sonuc = "";
            while (kelime.IndexOf('i',ilkAramaIndexi) != -1)
            {
                ilkAramaIndexi = kelime.IndexOf('i', ilkAramaIndexi);
                sonuc += ilkAramaIndexi.ToString() + ", ";
                ilkAramaIndexi++;
            }
            
            listBoxStringSonuc.Items.Add("i'nin indexOf sonucu: " + sonuc);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Türkay
            //ürkay T
            //rkay Tü
            //kay Tür
            string ilkHarf = labelKayanYazi.Text.Substring(0, 1);
            labelKayanYazi.Text = labelKayanYazi.Text.Substring (1) + ilkHarf;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        
        }

        private void buttonOdeme_Click(object sender, EventArgs e)
        {
            /*
             * 1. fiyatı, seçilen taksite böl.
             */
            decimal fiyat = Convert.ToDecimal(textBoxUrunFiyati.Text);
            int secilenTaksit = Convert.ToInt32(comboBoxTaksit.SelectedItem);
            decimal tutar = fiyat / secilenTaksit;
            for (int i = 1; i < secilenTaksit; i++)
            {
                DateTime odemeTarihi = DateTime.Now.AddMonths(i);
              
                switch (odemeTarihi.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        odemeTarihi = odemeTarihi.AddDays(1);
                        break;
                    case DayOfWeek.Saturday:
                        odemeTarihi = odemeTarihi.AddDays(2);
                        break;
                    default:
                        break;
                }

                listBoxTakvim.Items.Add(odemeTarihi.ToLongDateString() + " tarihindeki tutar: " + tutar.ToString("N2") + "TL");
            }
        }

        private void dateTimePickerGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark = DateTime.Now - dateTimePickerGirisTarihi.Value;
            labelGecenSure.Text = fark.Days + " gün " + fark.Hours + " saat " + fark.Minutes + " süre geçmiş"; 
        }
    }
}
