using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private double firstNum = 0.0;
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            Correct();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            Correct();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            Correct();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            Correct();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            Correct();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            Correct();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
            Correct();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
            Correct();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
            Correct();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0")
                textBox1.AppendText("0");
            Correct();
        }

        private void button11_Click(object sender, EventArgs e) //,
        {
            if (!textBox1.Text.Contains(",") && textBox1.Text != "")
                textBox1.AppendText(",");
            label1.Focus();
        }

        /* private void button12_Click(object sender, EventArgs e) //=
       {
           if (textBox1.Text != "")
           {
               double result = 0;
               double secondNum = Double.Parse(textBox1.Text);

               switch (operation)
               {
                   case "+":
                       result = firstNum + secondNum;
                       break;
                   case "-":
                       result = firstNum - secondNum;
                       break;
                   case "*":
                       result = firstNum * secondNum;
                       break;
                   case "/":
                       if (secondNum != 0)
                           result = firstNum / secondNum;
                       else
                       {
                           firstNum = 0;
                           textBox1.Clear();
                           label1.Focus();
                           return;
                       }
                       break;
                   case "%":
                       if (secondNum == 0)
                           result = 0;
                       break;
               }
               operation = "";
               textBox1.Text = result.ToString();
               firstNum = 0.0; // 
           }
           label1.Focus();
       }*/

        private void button12_Click(object sender, EventArgs e) //=
        {
            if (textBox1.Text != "")
            { 
                double secondNum = Double.Parse(textBox1.Text);
                textBox1.Text = calculation(secondNum).ToString();
                operation = "";
                firstNum = 0.0; 
            }
            label1.Focus();
        }

      

        private double calculation(double secondNum, double result = 0)
        {
            switch (operation)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum != 0)
                        result = firstNum / secondNum;
                    else
                    {
                        firstNum = 0;
                        textBox1.Clear();
                    }
                    break;
                case "%":
                    if (secondNum == 0)
                        result = 0;
                    break;
            }
            return result;
        }

        private void button13_Click(object sender, EventArgs e) //+
        {
            if (textBox1.Text != "")
            {
                if (firstNum != 0.0 && operation != "")
                {
                    firstNum = calculation(Double.Parse(textBox1.Text));
                }
                else
                {
                    firstNum = Double.Parse(textBox1.Text);
                }
                textBox1.Clear();
                operation = "+";
            }
            label1.Focus();
        }

        private void button14_Click(object sender, EventArgs e) //-
        {
            if (textBox1.Text != "")
            {
                if (firstNum != 0.0 && operation != "")
                {
                    firstNum = calculation(Double.Parse(textBox1.Text));
                }
                else
                {
                    firstNum = Double.Parse(textBox1.Text);
                }
                textBox1.Clear();
                operation = "-";
            }
            label1.Focus();
        }

        private void button15_Click(object sender, EventArgs e) //  /
        {
            if (textBox1.Text != "")
            {
                if (firstNum != 0.0 && operation != "")
                {
                    firstNum = calculation(Double.Parse(textBox1.Text));
                }
                else
                {
                    firstNum = Double.Parse(textBox1.Text);
                }
                textBox1.Clear();
                operation = "/";
            }
            label1.Focus();
        }

        private void button16_Click(object sender, EventArgs e) //  *
        {
            if (textBox1.Text != "")
            {
                if (firstNum != 0.0 && operation != "")
                {
                    firstNum = calculation(Double.Parse(textBox1.Text));
                }
                else
                {
                    firstNum = Double.Parse(textBox1.Text);
                }
                textBox1.Clear();
                operation = "*";
            }
            label1.Focus();
        }

        private void button17_Click(object sender, EventArgs e) // %
        {
            if (textBox1.Text != "")
            {
                double secondNum = Double.Parse(textBox1.Text);
                double result = (firstNum / 100) * secondNum;

                textBox1.Text = result.ToString();
            }
            label1.Focus();
        }

        private void button18_Click(object sender, EventArgs e) //←
        {
            if (textBox1.Text != "")
            {
                string text = textBox1.Text;
                textBox1.Text = text.Remove(text.Length - 1, 1);
            }
            label1.Focus();
        }

        private void button19_Click(object sender, EventArgs e) //C
        {
            textBox1.Clear();
            firstNum = 0.0;
            label1.Focus();
            operation = "";
        }

        private void button20_Click(object sender, EventArgs e) //CE
        {
            textBox1.Clear();
            label1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e) //pow2
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                temp *= temp;
                textBox1.Text = temp.ToString();
            }
            label1.Focus();
        }

        private void button23_Click(object sender, EventArgs e) // sqrt
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                if(temp >= 0)
                    textBox1.Text = Math.Sqrt(temp).ToString();
            }
            label1.Focus();
        }

        private void button22_Click(object sender, EventArgs e) // +-
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                temp *= -1;
                textBox1.Text = temp.ToString();
            }
            label1.Focus();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                temp = 1 / temp;
                textBox1.Text = temp.ToString();
            }
            label1.Focus();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                if (temp >= 0 && !textBox1.Text.Contains(",")) // Только положительные целые числа 
                {
                    //temp = gamma(temp);
                    double res = 1.0;
                    for (int i = 1; i <= temp; i++)
                    {
                        res *= i;
                    }
                    temp = res;
                }
                else SystemSounds.Exclamation.Play();
                textBox1.Text = temp.ToString();
                
            }
            label1.Focus();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                temp = Math.Sin(temp/180 * Math.PI) ;
                textBox1.Text = temp.ToString();
            }
            label1.Focus();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                temp = Math.Cos(temp / 180 * Math.PI);
                textBox1.Text = temp.ToString();
            }
            label1.Focus();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                temp = Math.Tan(temp / 180 * Math.PI);
                textBox1.Text = temp.ToString();
            }
            label1.Focus();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double temp = Double.Parse(textBox1.Text);
                temp = 1/Math.Tan(temp / 180 * Math.PI);
                textBox1.Text = temp.ToString();
            }
            label1.Focus();
        }

        private void button7_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (char.IsDigit(e.KeyChar))
            {
                if (textBox1.Text == "0" && symbol == "0")
                {
                    Console.WriteLine("Error: 1");
                }
                else textBox1.AppendText(symbol);
            }

            if (e.KeyChar == (char)Keys.Back)
                button18_Click(sender, e);

            switch (symbol)
            {
                case "+":
                    button13_Click(sender, e);
                    break;
                case "-":
                    button14_Click(sender, e);
                    break;
                case "/":
                    button15_Click(sender, e);
                    break;
                case "*":
                    button16_Click(sender, e);
                    break;
                case "=":
                    button12_Click(sender, e);
                    break;
                case "\r":
                    button12_Click(sender, e);
                    break;
                case "%":
                    button17_Click(sender, e);
                    break;
                case ".":
                    button11_Click(sender, e);
                    break;
                case ",":
                    button11_Click(sender, e);
                    break;
                case "^":
                    button24_Click(sender, e);
                    break;
                case "//":
                    button23_Click(sender, e);
                    break;
                case "c":
                    button19_Click(sender, e);
                    break;
                case "C":
                    button19_Click(sender, e);
                    break;
            }
            Correct();
        }

        private void Correct() {
            string text = textBox1.Text;
            if (text.Length > 1 && !text.Contains(",") && text[0] == '0')
                text = text.Remove(0, 1);
            textBox1.Text = text;
            label1.Focus();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
