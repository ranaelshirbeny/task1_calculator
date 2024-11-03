using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace task_calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        int x = 0;
        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void MC_Click(object sender, EventArgs e)
        {
            x = 0;
            textBox1.Text = x.ToString();

        }

        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = x.ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            textBox1.Text = x.ToString();

        }

        private void MPLUS_Click(object sender, EventArgs e)
        {
            x += int.Parse(textBox1.Text);
            textBox1.Text = x.ToString();
        }

        private void numberbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;

        }

        double F_name = 0;
        double S_name = 0;
        string OP = "";

        private void ADD_Click(object sender, EventArgs e)
        {
            F_name = double.Parse(textBox1.Text);
            OP = "+";
            textBox1.Clear();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            F_name = double.Parse(textBox1.Text);
            OP = "-";
            textBox1.Clear();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            F_name = double.Parse(textBox1.Text);
            OP = "*";
            textBox1.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            F_name = double.Parse(textBox1.Text);
            OP = "/";
            textBox1.Clear();
        }

        private void EQU_Click(object sender, EventArgs e)
        {
            S_name = double.Parse(textBox1.Text);
            double Result = 0;

            if (OP == "+")
            {
                Result = F_name + S_name;
            }
            else if (OP == "-")
            {
                Result = F_name - S_name;
            }
            else if (OP == "*")
            {
                Result = F_name * S_name;
            }
            else
            {
                Result = F_name / S_name;

            }
            textBox1.Text = Result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            double Result = Math.Sqrt(num);
            textBox1.Text = Result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            double Result = num / 100 ;
            textBox1.Text = Result.ToString();
        }
    }
}
