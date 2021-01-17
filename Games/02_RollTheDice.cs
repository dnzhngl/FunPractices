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
    public partial class RollTheDice : Form
    {
        public RollTheDice()
        {
            InitializeComponent();
        }

        int turn = 1;
        int player1TotalScore, player2TotalScore;

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            while (turn < 11)
            {
                // Her iki zar değerine random olarak 1, 7 arasında birer sayı atanır.
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);

                // Resim Ekleme
                //picDice1 için resimler
                picDice1.ImageLocation = "../../MyResources/Dices/" + dice1 + ".png";
                // picDice2 için resimler
                picDice2.ImageLocation = "../../MyResources/Dices/" + dice2 + ".png";


                // Eğer turn yani sıra değeri tekse 1. oyuncunun skoruna, çiftse ikinci oyuncunun skoruna zarların toplamı yazılır.
                if (turn % 2 != 0)
                {
                    lblScore1.Text = Convert.ToString(dice1 + dice2);
                    lblPlayer1TotalScore.Text = (player1TotalScore += Convert.ToInt32(lblScore1.Text)).ToString();
                }
                else if (turn % 2 == 0)
                {
                    lblScore2.Text = Convert.ToString(dice1 + dice2);
                    lblPlayer2TotalScore.Text = (player2TotalScore += Convert.ToInt32(lblScore2.Text)).ToString();
                }

                // Sıranın değeri yazdılır sonra bir artırılır.
                lblTurn.Text = turn.ToString();
                turn++;

                break;

            }


            if (turn == 11)
            {
                // Her turn oyuncuların attıkları zarların o tura özel toplamınıveren labelları sıfırladım.
                lblScore1.Text = "";
                lblScore2.Text = "";

                // Total scoru büyük olan kazanır.
                if (player1TotalScore > player2TotalScore)
                {
                    lblWinner.Text = txtPlayer1.Text + " wins!";
                }
                else if (player1TotalScore < player2TotalScore)
                {
                    lblWinner.Text = txtPlayer2.Text + " wins!";
                }
                else if (player1TotalScore == player2TotalScore)
                {
                    lblWinner.Text = "DEAD HEAT";
                }

            }
        }
    }
}
