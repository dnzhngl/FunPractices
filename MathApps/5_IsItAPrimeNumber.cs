using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPractices
{
    public partial class PrimeNumber : Form
    {
        public PrimeNumber()
        {
            InitializeComponent();
        }

        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum.Clear();
            lstDivisors.Items.Clear();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {

            //SAYI ASAL MI DEĞİL Mİ PROGRAMI

            int num = int.Parse(txtNum.Text);
            bool isAPrimeNumber = true;

            if (num <= 0)
            {
                MessageBox.Show("Enter a positive number.");
            }
            else if (num == 1)
            {
                txtNum.Text += " is not a prime number.";
            }
            else
            {
                lstDivisors.Items.Add("1");

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        lstDivisors.Items.Add(i);
                        isAPrimeNumber = false;
                    }

                }
                lstDivisors.Items.Add(num.ToString());

                if (isAPrimeNumber)
                {
                    txtNum.Text += " is a prime number!";
                }
                else
                {
                    txtNum.Text += " is not a prime number!";
                }
            }
            







        }

    }
}



