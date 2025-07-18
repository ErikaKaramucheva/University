using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bOne_MouseClick(object sender, MouseEventArgs e)
        {
            bOne.Text = SetText();
            checkForWinner();
        }



        int counter = 1;
        public string SetText()
        {
            if (counter % 2 == 0)
            {
                counter++;
                return "O";
            }
            else
            {
                counter++;
                return "X";
            }
        }

        private void bTwo_Click(object sender, EventArgs e)
        {
            bTwo.Text = SetText();
            checkForWinner();
        }

        private void bThree_Click(object sender, EventArgs e)
        {
            bThree.Text = SetText();
            checkForWinner();
        }

        private void bFour_Click(object sender, EventArgs e)
        {
            bFour.Text = SetText();
            checkForWinner();
        }

        private void bFive_Click(object sender, EventArgs e)
        {
            bFive.Text = SetText();
            checkForWinner();
        }

        private void bSix_Click(object sender, EventArgs e)
        {
            bSix.Text = SetText();
            checkForWinner();
        }

        private void bSeven_Click(object sender, EventArgs e)
        {
            bSeven.Text = SetText();
            checkForWinner();
        }

        private void bEight_Click(object sender, EventArgs e)
        {
            bEight.Text = SetText();
            checkForWinner();
        }

        private void bNine_Click(object sender, EventArgs e)
        {
            bNine.Text = SetText();
            checkForWinner();
        }

        public void checkForWinner()
        {
            if ((bOne.Text == "X" && bTwo.Text == "X" && bThree.Text == "X") ||
                (bOne.Text == "X" && bFour.Text == "X" && bSeven.Text == "X") ||
                (bOne.Text == "X" && bFive.Text == "X" && bNine.Text == "X") ||
                (bFour.Text == "X" && bFive.Text == "X" && bSix.Text == "X") ||
                (bTwo.Text == "X" && bFive.Text == "X" && bEight.Text == "X") ||
                (bSeven.Text == "X" && bEight.Text == "X" && bNine.Text == "X") ||
                (bThree.Text == "X" && bFive.Text == "X" && bSeven.Text == "X") ||
                (bThree.Text == "X" && bSix.Text == "X" && bNine.Text == "X")

                )
            {
                MessageBox.Show("Winner: X");
                Clear();

            }
            else if ((bOne.Text == "O" && bTwo.Text == "O" && bThree.Text == "O") ||
               (bOne.Text == "O" && bFour.Text == "O" && bSeven.Text == "O") ||
               (bOne.Text == "O" && bFive.Text == "O" && bNine.Text == "O") ||
               (bFour.Text == "O" && bFive.Text == "O" && bSix.Text == "O") ||
               (bTwo.Text == "O" && bFive.Text == "O" && bEight.Text == "O") ||
               (bSeven.Text == "O" && bEight.Text == "O" && bNine.Text == "O") ||
               (bThree.Text == "O" && bFive.Text == "O" && bSeven.Text == "O") ||
               (bThree.Text == "O" && bSix.Text == "O" && bNine.Text == "O")


               )
            {
                
                MessageBox.Show("Winner: O");
                Clear();

            }
        }

        public void Clear()
        {
            bOne.Text = "";
            bTwo.Text = "";
            bThree.Text = "";
            bFour.Text = "";
            bFive.Text = "";
            bSix.Text = "";
            bSeven.Text = "";
            bEight.Text = "";
            bNine.Text = "";
        }
    }
}
