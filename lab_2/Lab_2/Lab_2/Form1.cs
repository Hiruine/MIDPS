using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //display dot(.) when press dot button in TextBox
            result.Text = result.Text + ".";
        }

        private void Text_Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;//convert sender object to the button b
            if(b.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)//to sum multiple numbers 
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";//reset it
            switch (operation)
            {
                case "+"://can store strings in text field
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                /*what he pressed and what value is stored in current text fild*/
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "^2":
                    result.Text = (value * value).ToString();
                    break;
                case "√":
                    result.Text = (System.Math.Sqrt(value)).ToString();
                    break;
                case "+/-":
                    result.Text = (-1 * value).ToString();
                    break;
                default:
                    break;
            }//end switch
            value = Double.Parse(result.Text);            //reset to whatever is showing
            operation = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "0";//clear text box
            value = 0; //if anything is stored 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
