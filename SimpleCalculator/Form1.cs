namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string displayValue = "";
        private void Number0Button(object sender, EventArgs e)
        {
            display.Text += "0";
            displayValue += "0";          //                                       0
        }
        private void Number1Button(object sender, EventArgs e)
        {
            display.Text += "1";
            displayValue += "1";                 //                           1                      
        }
        private void Number2Button(object sender, EventArgs e)
        {
            display.Text += "2";
            displayValue += "2";                  //                            2
        }
        private void Number3Button(object sender, EventArgs e)
        {
            display.Text += "3";
            displayValue += "3";                                //                             3
        }
        private void Number4Button(object sender, EventArgs e)
        {
            display.Text += "4";
            displayValue += "4";                         //                         4
        }
        private void Number5Button(object sender, EventArgs e)
        {
            display.Text += "5";
            displayValue += "5";                            //                           5
        }
        private void Number6Button(object sender, EventArgs e)
        {
            display.Text += "6";
            displayValue += "6";                     //                                   6
        }
        private void Number7Button(object sender, EventArgs e)
        {
            display.Text += "7";
            displayValue += "7";                       //                                      7
        }
        private void Number8Button(object sender, EventArgs e)
        {
            display.Text += "8";
            displayValue += "8";                            //                                    8
        }
        private void Number9Button(object sender, EventArgs e)
        {
            display.Text += "9";
            displayValue += "9";                           //                                 9
        }
        private void DotButton(object sender, EventArgs e)
        {
            display.Text += ".";
            displayValue += ".";                          //                                             .
        }
        private void PlusButton(object sender, EventArgs e) //                              +
        {
            display.Text += "+";
            displayValue += "+";
        }
        private void SubtractButton(object sender, EventArgs e)  //                       -
        {
            display.Text += "-";
            displayValue += "-";
        }
        private void MultipleButton(object sender, EventArgs e) //                         x
        {
            display.Text += "*";
            displayValue += "*";
        }
        private void DivisionButton(object sender, EventArgs e) //                         /
        {
            display.Text += "/";
            displayValue += "/";
        }
        private void ResultButton(object sender, EventArgs e)  //                          =
        {
            double result = 0;
            if (displayValue.Contains("+"))
            {
                string[] numbers = displayValue.Split("+");
                result = double.Parse(numbers[0]) + double.Parse(numbers[1]);
            }
            else if (displayValue.Contains("-"))
            {
                string[] numbers = displayValue.Split("-");
                result = double.Parse(numbers[0]) - double.Parse(numbers[1]);
            }
            else if (displayValue.Contains("*"))
            {
                string[] numbers = displayValue.Split("*");
                result = double.Parse(numbers[0]) * double.Parse(numbers[1]);
            }
            else if (displayValue.Contains("/"))
            {
                string[] numbers = displayValue.Split("/");
                result = double.Parse(numbers[0]) / double.Parse(numbers[1]);
            }

            display.Text = result.ToString();
            displayValue = result.ToString();
        }

        private void ClearButton(object sender, EventArgs e)
        {
            display.Text = " ";
            displayValue = " ";
        }
    }
}
