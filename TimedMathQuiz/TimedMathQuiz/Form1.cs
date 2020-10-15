using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1;
        int addend2;//addition question
        int subend1;
        int subend2;//Substaction
        int mulend1, mulend2;
        int divend1, divend2;
        int timeleft;
        private Color timeLabelcolor;
        
        public Form1()
        {
            InitializeComponent();
            timeLabelcolor = timeLabel.BackColor;
        }
        //method gets called when user click on start the quiz
        public void startQuiz()
        {
           timeLabel.BackColor = timeLabelcolor;
            //Addition
            addend1 = randomizer.Next(50);
            addend2= randomizer.Next(50);
            //assighning the randomly generated value to the label text property
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            numericUpDown1.Value = 0;
            //Substaction

           subend1= randomizer.Next(50);
            subend2 = randomizer.Next(50);
            minusLeftLabel.Text = subend1.ToString();
            minusRightLabel.Text = subend2.ToString();
            numericUpDown2.Value = 0;
            //Multiplication
            mulend1 = randomizer.Next(20);
            mulend2 = randomizer.Next(10);
            multiplyLeftLabel.Text = mulend1.ToString();
            multiplyRightLabel.Text = mulend2.ToString();
            numericUpDown3.Value = 0;
            //Division
            divend1 = randomizer.Next(51,100);
            divend2 = randomizer.Next(50);
            divideLeftLabel.Text = divend1.ToString();
            divideRightLabel.Text = divend2.ToString();
            numericUpDown4.Value = 0;
            //set the time of the quiz and start
            timeleft = 30;
            timeLabel.Text = timeleft.ToString() + "Seconds";
            timer1.Start();
        }
        private bool checkTheAnswer() {
            if (addend1 + addend2 == numericUpDown1.Value)
            {
                if (subend1 - subend2 == numericUpDown2.Value) {
                    if (mulend1 * mulend2 == numericUpDown3.Value)
                    {
                        if (divend1 / divend2 == numericUpDown4.Value)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }

                else
                    return false;
            }
            else {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkTheAnswer()) {
                timer1.Stop();
                MessageBox.Show("You have answered right...Congrats!!");
                startButton.Enabled = true;
            }
            else if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                timeLabel.Text = timeleft.ToString();
                if (timeleft <= 8) {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time Up!!";
                MessageBox.Show("quiz time is finished");
                numericUpDown1.Value = addend1 + addend2;
                startButton.Enabled = true;
            }
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            NumericUpDown answer = sender as NumericUpDown;
            if (answer != null) {
                answer.Select(0, answer.Value.ToString().Length);
            }
        }
    }
}
