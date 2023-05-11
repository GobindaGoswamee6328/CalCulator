using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "7";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "8";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "9";

        }

        private void btn13_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";

        }


        private void btn15_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear(); 
            count = 1; 
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
                num1 = float.Parse(txtResult.Text);
                txtResult.Clear();
                count = 2;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            count = 3;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
           count = 4;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 + float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 - float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = " ";

        }

       
    }
}
