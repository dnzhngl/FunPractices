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
    public partial class SumofDigits : Form
    {
        public SumofDigits()
        {
            InitializeComponent();
        }

        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum.Clear();
            lblSum.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sumOfDigits = 0;
            int num = int.Parse(txtNum.Text);
            int n = txtNum.Text.Length;

            while (n > 0)
            {
                sumOfDigits += num % 10;
                num /= 10;
                n--;
            }

            lblSum.Text = "Sum of digits of " + txtNum.Text + "\n= " + sumOfDigits;



            /*
             *** 2. YOL: 
             
                int sumOfDigits = 0;
                int unitsDigit = num % 10;
                int tensDigit = num / 10;
                int hundredsDigit = num / 100;
                int thousandsDigit = num / 1000;
                    
                if (num < 10)
                    {
                        sumOfDigitsNum = unitsDigit;
                    }
                else if (num >= 10 && num < 100)
                    {
                        sumOfDigitsNum = unitsDigit + tensDigit;
                    }
                else if (num >= 100 && num < 1000)
                    {
                        sumOfDigitsNum = unitsDigit + tensDigit + hundredsDigit;
                    }
                else if (num >= 1000)
                    {
                sumOfDigitsNum = unitsDigit + tensDigit + hundredsDigit + thousandsDigit;
                    }
                
                lblSum.Text += "Girilen sayının rakamları toplamı: " + sumOfDigits.ToString();

                
             
             
             */











        }




    }
}
