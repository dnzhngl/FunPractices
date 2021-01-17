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
    public partial class SmithNumbersCopy : Form
    {
        public SmithNumbersCopy()
        {
            InitializeComponent();
        }


        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum.Clear();
            lblResults.Text = "";
            lstPrimeFactors.Items.Clear();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            /*
           1. Girilen sayı 1'den büyük olacak  +
           2. Girilen sayı asal olmayacak +
           3. Girilen sayının rakamları toplamı bulunacak. +
           4. Girilen sayının asal çarpanları bulunacak. +
           5. Asal çarpanların rakamları toplamı bulunacak. ??--
           6. 3. ile 5. adımın sonuçları birbine eşit mi bakılacak. +
           7. Sonuçlar eşitse smith sayıdır yazdırılacak. +

           */

            try
            {
                int num = int.Parse(txtNum.Text);


                //  1. Girilen sayı 1'den büyük olacak.
                if (num > 1)
                {
                    int sumOfDigitsNum = 0;
                    int sumOfPrimeFactorsDigits = 0;
                    List<int> primeDivisors = new List<int>();


                    //  2. Girilen sayı asal olmayacak
                    #region
                    bool primeNumber = true;

                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            primeNumber = false;
                            break;
                        }

                    }
                    if (primeNumber)
                    {// "1. It is a prime number."
                        lblResults.Text = "1. " + num.ToString() + " is a prime number. \n  Prime numbers cannot be Smith numbers.\n  Please enter another number.";
                        txtNum.Clear();
                    }
                    else
                    {// "1. It is not a prime number."
                        lblResults.Text = "1. " + num.ToString() + " is not a prime number.";




                        // 3. Girilen sayı asal değilse, rakamları toplamı bulunacak.
                        #region
                        int numCopy = num;
                        // sumOfDigitsNum = 0;

                        while (numCopy > 0)
                        {
                            sumOfDigitsNum += numCopy % 10;
                            numCopy /= 10;
                        }

                        lblResults.Text += "\n\n2. The sum of the digits: " + sumOfDigitsNum.ToString();
                        #endregion




                        // 4. Girilen sayının asal çarpanları bulunacak.
                        #region
                        int numCopy1 = num;
                        while (numCopy1 % 2 == 0)
                        {
                            primeDivisors.Add(2);
                            lstPrimeFactors.Items.Add(2);
                            numCopy1 /= 2;
                        }
                        for (int i = 3; i <= numCopy1; i += 2)
                        {
                            while (numCopy1 % i == 0)
                            {
                                primeDivisors.Add(i);
                                lstPrimeFactors.Items.Add(i);
                                numCopy1 /= i;
                            }
                        }

                        lblResults.Text += "\n\n3. The prime factors are shown in the list on the left.";
                        #endregion




                        // 5. Girilen sayının asal çarpanlarının rakamları toplamı bulunacak.
                        #region
                        // sumOfPrimeFactorsDigits = 0;

                        foreach (int divisor in primeDivisors)
                        {
                            int clonedDivisor = divisor;
                            while (clonedDivisor > 0)
                            {
                                sumOfPrimeFactorsDigits += clonedDivisor % 10;
                                clonedDivisor /= 10;
                            }
                        }

                        lblResults.Text += "\n\n4. The sum of digits of prime factors : " + sumOfPrimeFactorsDigits.ToString();
                        #endregion


                        // 6. 4. ile 5.adımın sonuçları birbine eşit mi bakılacak ve sonuç yazdırılacak.
                        #region
                        if (sumOfDigitsNum == sumOfPrimeFactorsDigits)
                        {
                            lblResults.Text += "\n\n 5. Sum of digits : " + sumOfDigitsNum.ToString() + "\n = The sum of digits of prime factors : " + sumOfPrimeFactorsDigits.ToString() + "\n  is a SMITH NUMBER!";
                        }
                        else
                        {
                            lblResults.Text += "\n\n 5. Sum of digits = " + sumOfDigitsNum.ToString() + "\n != The sum of digits of prime factors : " + sumOfPrimeFactorsDigits.ToString() + "\n is NOT A SMITH NUMBER!";
                        }
                        #endregion
                    }
                    #endregion


                }
                else
                {
                    MessageBox.Show("Please enter a number greater than 1.");
                    txtNum.Clear();
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Please enter a number.");
                txtNum.Clear();
            }


            
        }


    }
}
