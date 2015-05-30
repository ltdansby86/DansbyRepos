using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
         double a;
         double b;
         string op;
        public Calculator()
        {
            InitializeComponent();
        }
            
         

        private void button1_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("7");
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("0");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            b = double.Parse(displyScreen.Text); 
            double result;

            if (op == "+")
            {
                result = a + b;
                displyScreen.Text = result.ToString();
            }
            else if (op == "-")
            {
                result = a - b;
                displyScreen.Text = result.ToString();
            }
            else if (op == "/")
            {
                result = a / b;
                displyScreen.Text = result.ToString();
            }
            else if (op =="*")
            {
                result = a * b;
                displyScreen.Text = result.ToString();
            }

        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            a = double.Parse(displyScreen.Text);
            op = "*";
            displyScreen.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displyScreen.AppendText("9");
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            displyScreen.Clear();
            a = 0;
            b = 0;
            op = "";
        }

        private void addBut_Click(object sender, EventArgs e)
        {
          a =  double.Parse(displyScreen.Text);
          op = "+";
          displyScreen.Clear();
        }

        private void subBut_Click(object sender, EventArgs e)
        {
            a = double.Parse(displyScreen.Text);
            op = "-";
            displyScreen.Clear();
        }

        private void devBut_Click(object sender, EventArgs e)
        {
            a = double.Parse(displyScreen.Text);
            op = "/";
            displyScreen.Clear();
        }
    }
}
