using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama ilk açıldığında çalışacak kod

            GenerateButtons();


            // [GetUpperBound(0),GetUpperBound(1)]
            //Hazır sınıfları kullanma - özelliklerine erişme
            // If
            // Döngüler
            // Değer atamaları

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            //butonları kaydırmak için top ve left adında iki değişken tanımlarız ve döngü içerisinde kaydırma işlemini yaparız.
            int top = 0;
            int left = 0;
            //Buttonları for döngüsü ile oluşturabiliriz fakat butonlara erişimde zorlanırız.
            // 8x8 lik 2 boyutlu bir matris oluşturmak bu ugulama için ideal.

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;

                    }
                    this.Controls.Add(buttons[i, j]); // 64 kere ÜST ÜSTE eklenmiş butonlar oluşturuldu.

                }
                top += 50;
                left = 0;
            }
        }
    }
}
