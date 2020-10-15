using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPictureViewer
{
    public partial class Form1 : Form
    {
        string dirPath;
        static int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {   //showing the open file dialog
            //an image file load that file into the picture box
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dirPath = openFileDialog1.FileName;
                pictureBox1.Load(openFileDialog1.FileName);
            }
            else 
            { 

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {   //clear the picture
            
            pictureBox1.Image = null;

        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;//setting the user selected color and fixed it to picturebox
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();//close the form

        }

        private void stretchCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchCheckbox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            FileInfo fInfo = new FileInfo(dirPath);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lFiles = dInfo.GetFiles("*.png");
            if (i < lFiles.Length)
                pictureBox1.Load(lFiles[i++].FullName);
            else
                i = 0;
                 pictureBox1.Load(lFiles[i++].FullName);
                
        }

        private void previousButton_Click(object sender, EventArgs e)
        {   //TODO:-get the index of files.
            FileInfo fInfo = new FileInfo(dirPath);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lFiles = dInfo.GetFiles("*.png");
            if(nextButton.Click)
            if (i > 0)
                pictureBox1.Load(lFiles[i--].FullName);
            else
                this.Enabled = false;
            this.Controls.Add(previousButton);
        }
    }
}
