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
    public partial class WordOrNumber : Form
    {
        public WordOrNumber()
        {
            InitializeComponent();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtInput.Text);
                lstNumber.Items.Add(num);
            }
            catch
            {
                lstWord.Items.Add(txtInput.Text);
            }
            txtInput.Clear();

        }
    }
}
