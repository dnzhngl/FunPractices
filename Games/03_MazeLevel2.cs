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
    public partial class Maze2 : Form
    {
        public Maze2()
        {
            InitializeComponent();
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Well Done! You reached the exit. The game will close..");
            this.Close();
        }

        private void lblNext_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("The next level will be uploaded soon..");
        }


        private void Start_Mouse_Enter(object sender, EventArgs e)
        {
           Label lbl = (Label)sender;
           lbl.BackColor = Color.DarkOrange;

            Point startPoint = lblStart.Location;
            Cursor.Position = PointToScreen(startPoint);
        }
    }
}
