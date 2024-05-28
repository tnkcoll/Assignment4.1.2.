using Assignment4._1._2_.Controls.Interfaces;

namespace Assignment4._1._2_
{
    public partial class Calculator : Form, ICalculator
    {
        double num1 = 0;
        double num2 = 0;
        string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        public void Add()
        {
            SetOperation("+");
        }

        public void Subtract()
        {
            SetOperation("-");
        }

        public void Multiply()
        {
            SetOperation("*");
        }

        public void Divide()
        {
            SetOperation("/");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Add();
        }
        
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            Subtract();
        }
        
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(ResultTextBox.Text);
            double answer = 0;
            switch (operation) 
            { 
                case "+":
                    OperationTextBox.Text = OperationTextBox.Text +  " " + ResultTextBox.Text;
                    answer = num1 + num2;
                    ResultTextBox.Text = Convert.ToString(answer);
                    break;
                case "-":
                    OperationTextBox.Text = OperationTextBox.Text + " " + ResultTextBox.Text;
                    answer = num1 - num2;
                    ResultTextBox.Text = Convert.ToString(answer);
                    break;
                case "*":
                    OperationTextBox.Text = OperationTextBox.Text + " " + ResultTextBox.Text;
                    answer = num1 * num2;
                    ResultTextBox.Text = Convert.ToString(answer);
                    break;
                case "/":
                    OperationTextBox.Text = OperationTextBox.Text + " " + ResultTextBox.Text;
                    if (num2 != 0)
                    {
                        answer = num1 + num2;
                        ResultTextBox.Text = Convert.ToString(answer);
                    }
                    else
                    {
                        ResultTextBox.Text = "Error!"; 
                    }
                    break;
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            PrintResult("0");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            PrintResult("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            PrintResult("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            PrintResult("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            PrintResult("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            PrintResult("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            PrintResult("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            PrintResult("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            PrintResult("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            PrintResult("9");
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            PrintResult(".");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            OperationTextBox.Text = "";
        }

        private void SetOperation(string op)
        {
            num1 = Convert.ToInt32(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = op;
            OperationTextBox.Text = num1 + " " + operation;
        }

        private void PrintResult(string entry)
        {
            if (ResultTextBox.Text != null && ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = entry;
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + entry;
            }
        }
    }
}
