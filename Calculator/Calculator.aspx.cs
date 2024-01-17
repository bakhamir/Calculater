using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        public static char currentAction;
        public static int firstNumber;
        public static int secondNumber;
        public static bool beenSolved;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button1.Text;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button2.Text;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button3.Text;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button4.Text;
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button5.Text;

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button6.Text;
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button7.Text;
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button8.Text;
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            if (beenSolved == true)
            {
                display.Text = " ";
                beenSolved = false;
            }
            display.Text += Button9.Text;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            currentAction = '+';
            firstNumber = Int32.Parse(display.Text);
            display.Text = "";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            currentAction = '-';
            firstNumber = Int32.Parse(display.Text);
            display.Text = "";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            currentAction = '*';
            firstNumber = Int32.Parse(display.Text);
            display.Text = "";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            currentAction = '/';
            firstNumber = Int32.Parse(display.Text);
            display.Text = "";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            secondNumber = Int32.Parse(display.Text);
            switch (currentAction)
            {
                case '+':
                    {
                        display.Text = (firstNumber + secondNumber).ToString();
                        break;
                    }
                case '-':
                    {
                        display.Text = (firstNumber - secondNumber).ToString();
                        break;
                    }
                case '*':
                    {
                        display.Text = (firstNumber * secondNumber).ToString();
                        break;
                    }
                case '/':
                    {
                        display.Text = (firstNumber / secondNumber).ToString();
                        break;
                    }
            }
            currentAction = ' ';
            firstNumber = 0;
            secondNumber = 0;
            beenSolved = true;
        }
    }
}