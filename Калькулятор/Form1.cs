using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Калькулятор.Calc;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double tmp1, tmp2;
        ICalc Calc;

        public Form1()
        {
            InitializeComponent();
        }
        private void Number1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("1");
            }
            else
            {
                AddtoTextbox("1");
            }
        }
        private void Number2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {

                AddComma("2");
            }
            else
            {
                AddtoTextbox("2");
            }
        }
        private void Number3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("3");
            }
            else
            {
                AddtoTextbox("3");
            }
        }
        private void Number4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("4");
            }
            else
            {
                AddtoTextbox("4");
            }
        }
        private void Number5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("5");
            }
            else
            {
                AddtoTextbox("5");
            }
        }
        private void Number6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("6");
            }
            else
            {
                AddtoTextbox("6");
            }
        }
        private void Number7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("7");
            }
            else
            {
                AddtoTextbox("7");
            }
        }
        private void Number8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("8");
            }
            else
            {
                AddtoTextbox("8");
            }
        }
        private void Number9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("9");
            }
            else
            {
                AddtoTextbox("9");
            }
        }
        private void Number0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                AddComma("0");
            }
            else
            {
                AddtoTextbox("0");
            }
        }
        private void Sing_Click(object sender, EventArgs e) //изменение знака 
        {
            if (textBox1.Text != "")
            {
                double n = Convert.ToDouble(textBox1.Text);
                textBox1.Text = n * (-1) + "";
            }

        }
        private void Comma_Click(object sender, EventArgs e) //запятая 
        {
            if (textBox1.Text != "")
            {
                AddtoTextbox(",");
                Comma.Enabled = false;
            }
        }
        private void Addition_Click(object sender, EventArgs e)//сложение
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {

                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                textBox2.Text = tmp1 + "+";
                textBox1.Text = "";
                Calc = new Adder();
                Comma.Enabled = true;
            }
        }
        private void Subtraction_Click(object sender, EventArgs e)//вычитание
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {

                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                textBox2.Text = tmp1 + "-";
                textBox1.Text = "";
                Calc = new Substraction();
                Comma.Enabled = true;
            }
        }
        private void Multiplication_Click(object sender, EventArgs e)// умножение 
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {

                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                
                textBox2.Text = tmp1 + "*";
                textBox1.Text = "";
                Calc = new Multiplication();
                
               
                Comma.Enabled = true;
            }
        }
        private void Division_Click(object sender, EventArgs e) //деление вводимой строки
        {
            if (textBox1.Text != "")
            {
                if (Calc != null)
                {

                    tmp1 = Calc.DoMath(tmp1, Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    tmp1 = Convert.ToDouble(textBox1.Text);
                }
                if (tmp1 != 0)
                {
                    textBox2.Text = tmp1 + "/";
                    textBox1.Text = "";
                    Calc = new Division();
                }
                else
                {
                    textBox2.Text = "ОШИБКА";
                    textBox1.Text = "";
                }
                Comma.Enabled = true;
            }
        }
        private void DeletAll_Click(object sender, EventArgs e) //удаление всего 
        {
            tmp1 = 0;
            tmp2 = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            Calc = null;
            Comma.Enabled = true;
        }
        private void solution_Click(object sender, EventArgs e)// результат
        {
            if (textBox1.Text != "" && Calc != null)
            {

                tmp2 = Convert.ToDouble(textBox1.Text);
                
                    textBox2.Text = Calc.DoMath(tmp1, tmp2) + "";
                    textBox1.Text = "";
                    Comma.Enabled = true;
                
            }
            
        }
        public void AddtoTextbox(string a) //добавление
        {
            textBox1.Text += a;
        }
        public void AddComma(string a) //добавление запятой
        {
            textBox1.Text +=","+ a;
            Comma.Enabled = false;
        }
        private void Delet_Click(object sender, EventArgs e) //удаление 
        {

            tmp2 = 0;
            textBox1.Text = "";
            Comma.Enabled = true;


        }
        private void Form1_Load(object sender, EventArgs e)//исходное состояние 
        {
            tmp1 = 0;
            tmp2 = 0;
            Comma.Enabled = true;
        }

    }
}
