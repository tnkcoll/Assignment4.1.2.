using Assignment4._1._2_.Controls.Interfaces;

namespace Assignment4._1._2_
{
    public partial class Calculator : Form, ICalculator
    {
        //Declare and Initialize Variables
        double num1 = 0;
        string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        //Use the Add method from the ICalculator interface
        public void Add()
        {
            SetOperation("+");
        }

        //Use the Subtract method from the ICalculator interface
        public void Subtract()
        {
            SetOperation("-");
        }

        //Use the Multiply method from the ICalculator interface
        public void Multiply()
        {
            SetOperation("*");
        }

        //Use the Divide method from the ICalculator interface
        public void Divide()
        {
            SetOperation("/");
        }

        //Calls the Add method when the plus button is pressed
        private void PlusButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        //Calls the Subtract method when the plus button is pressed
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        //Calls the Multiply method when the plus button is pressed
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        //Calls the Divide method when the plus button is pressed
        private void DivideButton_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //Declare and Initialize variables
            double num2 = Convert.ToInt32(ResultTextBox.Text);
            double answer = 0;
            
            //Decide what to do based on the mathematical operater 
            switch (operation) 
            { 
                //Place the whole mathematical operation in the operation text box, perform the
                //add operation and place the result in the result text box
                case "+":
                    OperationTextBox.Text = OperationTextBox.Text +  " " + ResultTextBox.Text;
                    answer = num1 + num2;
                    ResultTextBox.Text = Convert.ToString(answer);
                    num1 = answer;
                    break;
                //Place the whole mathematical operation in the operation text box, perform the
                //subtraction operation and place the result in the result text box
                case "-":
                    OperationTextBox.Text = OperationTextBox.Text + " " + ResultTextBox.Text;
                    answer = num1 - num2;
                    ResultTextBox.Text = Convert.ToString(answer);
                    num1 = answer;
                    break;
                //Place the whole mathematical operation in the operation text box, perform the
                //mulitiplication operation and place the result in the result text box
                case "*":
                    OperationTextBox.Text = OperationTextBox.Text + " " + ResultTextBox.Text;
                    answer = num1 * num2;
                    ResultTextBox.Text = Convert.ToString(answer);
                    num1 = answer;
                    break;
                //Place the whole mathematical operation in the operation text box, perform the
                //division operation and place the result in the result text box
                case "/":
                    OperationTextBox.Text = OperationTextBox.Text + " " + ResultTextBox.Text;
                    if (num2 != 0)
                    {
                        answer = num1 + num2;
                        ResultTextBox.Text = Convert.ToString(answer);
                        num1 = answer;
                    }
                    else
                    {
                        ResultTextBox.Text = "Error!"; //results in error if user tries to divide by two
                    }
                    break;
            }
        }

        //The next eleven event handlers call the PrintResult method and passes the face value of the button when the button is pressed
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

        //This event handler clears the operations text box and sets the result text box to zero
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            OperationTextBox.Text = "";
        }


        //Gets the first number of the mathematical operation, resets the result output to zero and
        //places the first part of the mathematical operation in the operation text box
        private void SetOperation(string op)
        {
            num1 = Convert.ToInt32(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            operation = op;
            OperationTextBox.Text = num1 + " " + operation;
        }

        //Prints the number of the button hit into the result text box.
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
