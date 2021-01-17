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
    public partial class VowelOrConstant : Form
    {
        public VowelOrConstant()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string Letter = txtLetter.Text.ToUpper();

            switch (Letter)
            {
                case "A":
                    Vowels.Items.Add("A");
                    break;
                case "E":
                    Vowels.Items.Add("E");
                    break;
                case "I":
                    Vowels.Items.Add("I");
                    break;
                case "İ":
                    Vowels.Items.Add("İ");
                    break;
                case "O":
                    Vowels.Items.Add("O");
                    break;
                case "Ö":
                    Vowels.Items.Add("Ö");
                    break;
                case "U":
                    Vowels.Items.Add("U");
                    break;
                case "Ü":
                    Vowels.Items.Add("Ü");
                    break;
                default:
                    Consonants.Items.Add(Letter);
                    break;
            }

            txtLetter.Clear();
        }

        
    }
}
