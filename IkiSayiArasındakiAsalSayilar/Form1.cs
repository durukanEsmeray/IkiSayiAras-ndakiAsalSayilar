using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkiSayiArasındakiAsalSayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            for (int i = sayi1; i < sayi2; i++) //sayi1 ve sayi2 arasındaki sayıları dolaşacak.
            {
                int kontrol = 0; //asal sayı olup plmadığını kontrol edecek.
                for (int j = 2; j < i; j++) //i yi 1 den başlayarak kendisinden 1 eksik kadar dolaşacak.
                {
                    if (i % j == 0) //bölünürse asal değil
                    {
                        kontrol++;
                        break;
                    }
                }
                if (kontrol == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
