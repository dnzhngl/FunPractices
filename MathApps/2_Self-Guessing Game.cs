using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPractices
{
    public partial class SelfGuessing : Form
    {
        public SelfGuessing()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        int rndNum, guessNum;
        int x = 1;
        int y = 100;
        int counter = 0;


        /* Program açıldığında rndNum değişkeni oluşturulur ve 
           buna 1 ile 100 arasından random bir sayı atanır.
        */
        private void SelfGuessing_Load(object sender, EventArgs e)
        {
            rndNum = rnd.Next(1, 100);
            guessNum = rnd.Next(1, 100);

        }

        /*
         Tahmin et butonuna basılınca ikinci bir random sayı oluşturulur ve
         lblGuess'e yazdılır.
        */
        private void btnGuess_Click(object sender, EventArgs e)
        {
            lblGuess.Text = guessNum.ToString();

            counter++;
            lblCounter.Text = counter.ToString();

            // Eski tahminleri listeye ekleme.
            lvExGuess.Items.Add(guessNum.ToString());

            // if else ile tahminleri kıyaslama.
            if (rndNum > guessNum)
            {
                x = guessNum;
                x += 1;
                guessNum = rnd.Next(x, y);
            }
            else if (rndNum < guessNum)
            {
                y = guessNum;
                y -= 1;
                guessNum = rnd.Next(x, y);
            }
            else if (rndNum == guessNum)
            {
                MessageBox.Show("Number of try : " + counter.ToString());

                //Uygulamayı yeniden başlatır.
                Application.Restart();
            }

        }

    }
}
