using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMatchingGame
{
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        public Form1()
        {
            InitializeComponent();
            AssighniconsToSquare();
        }
        //assidhning the 16 icons to the squares
        //on the table layout corner
        private void AssighniconsToSquare() {
            foreach (Control ctrl in tableLayoutPanel1.Controls) {
                Label cell = ctrl as Label;
                if (cell != null) {
                    int randomNumber = random.Next(icons.Count);
                    //assighn the text to the label
                    cell.Text = icons[randomNumber];
                    //set the fore ground color as background color
                    cell.ForeColor = cell.BackColor;
                    //remove the string from the list
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled ==true) {
                return;
            }
            if (secondClicked != null) {
                return;
            }
            Label clickedLabel = sender as Label;
            if (clickedLabel != null) {
                if (clickedLabel.ForeColor == Color.Black) {
                    return;
                }

                if (firstClicked == null) {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                checkForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                }

                timer1.Start();
            }
           /* Label cell = sender as Label;
            if (cell != null)
            {
                if (cell.ForeColor != Color.Black)
                {
                    if (firstClicked == null) {
                        firstClicked = cell;
                        firstClicked.ForeColor = Color.Black;
                    }
                    cell.ForeColor = Color.Black;
                }
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //stop the timer
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = firstClicked.BackColor;

            //reset the the first and second clicked label
            firstClicked = null;
            secondClicked = null;
        }
        private void checkForWinner() {
            foreach (Control ctrl in tableLayoutPanel1.Controls) {
                Label cell = ctrl as Label;
                if (cell != null)
                {
                    if (cell.ForeColor == Color.Black)
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("You have finished the game.You Won.Congratulation","Congratulation");
            Close();
        }
    }
}
