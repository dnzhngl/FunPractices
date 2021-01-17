using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPractices
{
    public partial class GuessTheNumber : Form
    {
        public GuessTheNumber()
        {
            InitializeComponent();
        }

        // Globalde rndNum değişkenini oluşturur.
        int rndNum;

        // Program açıldığında random sayı yaratır ve rndNum değişkenine atar.
        private void GuessTheNumber_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            rndNum = random.Next(0, 100);
        }

        /*
          Guess butonuna basıldığında text boxa girilen tahmini sayıyı string'den 
          integer'a çevirir.
          try catch yardımıyla text boxa sayı haricinde bir giriş yapılırsa
          uyarı mesajının çıkması sağlanır.
          if else yardımıyla girilen sayı ile random sayının karşılaştırılması 
          yapılır ve geri dönüş sağlanır.
        */

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                int guessNum = Convert.ToInt32(txtGuess.Text);
                int counter = int.Parse(lblCounter.Text);
                counter++;
                lblCounter.Text = counter.ToString();

                if (guessNum > 100 | guessNum < 1)
                {
                    lblInstructions.Text = "Please enter a number between 1 and 100.";
                }
                else if (rndNum > guessNum)
                {
                    lblInstructions.Text = "Greater than " + txtGuess.Text;
                }
                else if (rndNum < guessNum)
                {
                    lblInstructions.Text = "Less than " + txtGuess.Text;
                }
                else if (rndNum == guessNum)
                {
                    lblInstructions.Text = "Congratulations! You won in " + counter.ToString() + " tries!";
                }

            }
            catch (FormatException)
            {
                lblInstructions.Text = "Please, enter a number.";
            }
        }

        private void txtGuess_MouseClick(object sender, MouseEventArgs e)
        {
            txtGuess.Clear();
        }
    }

}

