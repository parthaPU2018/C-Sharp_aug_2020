using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsClass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Visible = true;
                


            }
            else {
                groupBox1.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string value = showData();
                MessageBox.Show("you have applied/choosen " + value, "Congragulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked)
            {
                string value1 = showLawData();
                MessageBox.Show("you have applied/choosen " + value1, "Congragulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton3.Checked)
            {
                string value2 = showMbaData();
                MessageBox.Show("you have applied/choosen " + value2, "Congragulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton4.Checked)
            {
                string value3 = showBcadata();
                MessageBox.Show("you have applied/choosen " + value3, "Congragulations", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("No Branch Is Selected");
            }

        }

        private string showBcadata()
        {
            if (radioButton4.Checked)
            {
                if (obj_ds.Checked)
                    return "Data Science";

                else if (obj_pm.Checked)
                    return "Product Management";
                else if (obj_cys.Checked)
                    return "Cyber Security";
                else if (obj_bc.Checked)
                    return "Block Chain";
                else if (obj_dm.Checked)
                    return "Digital Marketing";
                else
                    return "No branch is selected";
            }
            else
                return "null";

        }

        private string showMbaData()
        {
            if (radioButton3.Checked)
            {
                if (radioButton5.Checked)
                    return "Marketing";

                else if (radioButton12.Checked)
                    return "Operation Manager";
                else if (radioButton6.Checked)
                    return "Corporate Manager";
                else if (radioButton14.Checked)
                    return "Healthcare Manager";
                else if (radioButton13.Checked)
                    return "Education Manager";
                else
                    return "No branch is selected";
            }
            else
                return "null";

        }

        private string showLawData()
        {
            if (radioButton2.Checked)
            {
                if (obj_cl.Checked)
                    return "CRIMINAL LAW";

                else if (obj_hl.Checked)
                    return "Health Law";
                else if (obj_cor.Checked)
                    return "Corporate Law";
                else if (obj_fl.Checked)
                    return "Family Law";
                else if (obj_el.Checked)
                    return "Education Law";
                else
                    return "No branch is selected";
            }
            else
                return "null";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox3.Visible = true;
            }
            else {
                groupBox3.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MbaField.Visible = true;
            }
            else
            {
                MbaField.Visible = false;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }
        }
        private string showData() {
            if (radioButton1.Checked)
            {
                if (obj_cse.Checked)
                    return "CSE";

                else if (obj_elec.Checked)
                    return "Electrical";
                else if (obj_civ.Checked)
                    return "CIVIL";
                else if (obj_mec.Checked)
                    return "Mechanical";
                else if (obj_pet.Checked)
                    return "Petroleum";
                else if (obj_it.Checked) {
                    return "Information Tecnology";
                }
                else
                    return "No branch is selected";
            }
            else
                return "null";
        }
    }
}
