using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 0;
        int situation;
        float num, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 1;
        }
        

        
        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 3;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 9;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Division_button_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            txtDisplay.Focus();
            count++;
            situation = 3;
        }
        private void Subtraction_button_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            txtDisplay.Focus();
            count++;
            situation = 2;
        }
        private void Multiply_button_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            txtDisplay.Focus();
            count++;
            situation = 4;
        }


        private void buttonDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + '.';
        }

        private void Addition_button_Click(object sender, EventArgs e)
        {
                num = float.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                txtDisplay.Focus();
                count++;
                situation = 1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDisplay_Enter(object sender, EventArgs e)
        {
            if(txtDisplay.Text == null)
            {
                txtDisplay.Text = "Enter Values";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch(situation)
            { 
            case 1:
                    result = num + float.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    break;
            case 2:
                    result = num - float.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    break;
                    
            case 3:
                    result = num / float.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    break;
                    
            case 4:
                    result = num * float.Parse(txtDisplay.Text);
                    txtDisplay.Text = result.ToString();
                    break;
                default:
                    txtDisplay.Text = "Input or Mathatical Error";
                    break;

            }

        }
    }
}
