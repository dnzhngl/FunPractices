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
    public partial class PalindromicNumber : Form
    {
        public PalindromicNumber()
        {
            InitializeComponent();
        }

        private void txtNum_MouseClick(object sender, MouseEventArgs e)
        {
            txtNum.Clear();
            lblResult.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtNum.Text);
                if (number < 0)
                {
                    lblResult.Text = "Lütfen pozitif bir sayı giriniz.";
                }
                else
                {
                    string num = txtNum.Text;
                    string reverseNum = "";

                    for (int i = num.Length - 1; i >= 0; i--)
                    {
                        reverseNum += num[i];
                    }

                    if (num == reverseNum)
                    {
                        lblResult.Text = num + " polidromik bir sayıdır. \n\nTersten yazılışı, sayının kendisine eşittir.";
                    }
                    else
                    {
                        lblResult.Text = num + " polidromik bir sayı değildir.";
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen bir sayı giriniz.");
            }
           
        }
    }
}
