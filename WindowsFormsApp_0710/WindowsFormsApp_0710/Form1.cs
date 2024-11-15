using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp_0710
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //각종 위젯 초기화 건들지 말것.
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //double num1 = double.Parse(this.textNum1.Text);
                //double num2 = double.Parse(this.textNum2.Text);
                double result = Calculator(this.textNum1.Text, this.textNum2.Text, "+");

                this.textResult.Text = result.ToString();
                this.Resultlbl.Text = "+";
            }
            catch
            {

            }
        }

        void Clear()
        {
            this.textNum1.Text = string.Empty;
            this.textNum2.Text = string.Empty;
            this.textResult.Text = string.Empty;
            this.Readylbl.Text = "Ready!";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //double num1 = double.Parse(this.textNum1.Text);
                //double num2 = double.Parse(this.textNum2.Text);
                double result = Calculator(this.textNum1.Text, this.textNum2.Text, "-");

                this.textResult.Text = result.ToString();
                this.Resultlbl.Text = "-";
            }
            catch
            {
            }
        }

        private void ExBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //double num1 = double.Parse(this.textNum1.Text);
                //double num2 = double.Parse(this.textNum2.Text);
                double result = Calculator(this.textNum1.Text, this.textNum2.Text, "*");

                this.textResult.Text = result.ToString();
                this.Resultlbl.Text = "*";
            }
            catch
            {
            }
        }

        private void NaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //double num1 = double.Parse(this.textNum1.Text);
                //double num2 = double.Parse(this.textNum2.Text);
                double result = Calculator(this.textNum1.Text, this.textNum2.Text, "/");

                this.textResult.Text = result.ToString();
                this.Resultlbl.Text = "/";
            }
            catch
            {
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        double Calculator(string sx, string sy, string op)
        {
            if(string.IsNullOrEmpty(sx) || string.IsNullOrEmpty(sy))
            {//입력받은 문자열이 둘중에 하나라도 널이거나 공백이라면
                MessageBox.Show("공백이 입력 되었습니다. 다시 입력 해주세요.");//메세지 띄우기
                this.Clear();
                throw new Exception("공백 아무것도 입력되지 않았다. 다시입력하시오."); //예외 전달
            }
            try
            {
                double x = double.Parse(sx.Trim()); //Trim()함수는 양쪽의 공백을 제거하는 함수이다.
                double y = double.Parse(sy.Trim());
                double result = 0;
                switch(op)
                {
                    case "+":
                        result = x + y; break;
                    case "-":
                        result = x - y; break;
                    case "*":
                        result = x * y; break;
                    case "/":
                        result = x / y; break;
                }
                return result;
            }
            catch
            {
                MessageBox.Show("숫자를 입력하세요. 다시 입력하세요.");
                this.Clear();
                throw new Exception("숫자를 입력하시오. 다시 입력하시오.");
            }
        }
    }
}
