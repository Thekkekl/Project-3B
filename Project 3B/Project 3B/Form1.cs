using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string x = txtWeight.Text;
            for (int i = 0; i <= x.Length; i++)
            {
                x = x.Replace("$", "");
                x = x.Replace("@", "");
                x = x.Replace("#", "");
                x = x.Replace("%", "");
                x = x.Replace("&", "");
                x = x.Replace("^", "");
                x = x.Replace("*", "");
                x = x.Replace("[", "");
                x = x.Replace("]", "");
                x = x.Replace("/", "");

            }
            txtWeight.Text = x;

            string y = txtFeet.Text;
            if (y.StartsWith(" ") || y.StartsWith("$") || y.StartsWith("@") || y.StartsWith("%") || y.StartsWith("#"))
            {
                MessageBox.Show("The string2 can't start with a space or $ or @ or % or #");
                txtFeet.Clear();
                txtFeet.Focus();
            }
            string z = txtInches.Text;
            if (z.EndsWith("0") || z.EndsWith("1") || z.EndsWith("2") || z.EndsWith("3"))
            {
                MessageBox.Show("The string3 can't End with 0, 1, 2, 3");
                txtInches.Clear();
                txtInches.Focus();
                double weight = Convert.ToDouble(txtWeight.Text);
                const double convertkg = 0.45;
                double weightkg = weight * convertkg;

                int feet = Convert.ToInt32(txtFeet.Text);
                int inch = Convert.ToInt32(txtInches.Text);
                int heightinch = (feet * 12) + inch;
                const double convertmtr = 0.025;
                double heightmtr = heightinch * convertmtr;
                double heightsqr = Math.Pow(heightmtr, 2);

                double bmi = weightkg / heightsqr;
                string textResult = " ";


                if (rbtnFemale.Checked)
                {
                    if (bmi < 18)
                    {
                        textResult = "Underweight";
                    }
                    else if (bmi >= 18 && bmi < 25)
                    {
                        textResult = "Normal";
                    }
                    else if (bmi >= 25 && bmi < 30)
                    {
                        textResult = "Overweight";
                    }
                    else if (bmi >= 30)
                    {
                        textResult = "Obese";
                    }

                }

                else if (rbtnMale.Checked)
                {
                    if (bmi < 19)
                    {
                        textResult = "Underweight";
                    }
                    else if (bmi >= 19 && bmi < 26)
                    {
                        textResult = "Normal";

                    }
                    else if (bmi >= 26 && bmi < 31)
                    {
                        textResult = "Overweight";
                    }
                    else if (bmi >= 31)
                    {
                        textResult = "Obese";
                    }
                }
                txtResult.Text = textResult;
                txtBody.Text = bmi.ToString("n2");


            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
