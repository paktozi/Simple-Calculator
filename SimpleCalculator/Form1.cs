namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator calculator = new();

        Dictionary<string, bool> buttonOperator = new()
        {
           { "plusButton", false },
           { "subtractButton", false } ,
           {"multipleButton",false },
           {"divisionButton",false }
        };

        private void Number0Button(object sender, EventArgs e)
        {
            NumberButtonPressed('0');                    //                                       0
        }

        private void Number1Button(object sender, EventArgs e)
        {
            NumberButtonPressed('1');                                 //                           1                      
        }

        private void Number2Button(object sender, EventArgs e)
        {
            NumberButtonPressed('2');                                //                            2
        }

        private void Number3Button(object sender, EventArgs e)
        {
            NumberButtonPressed('3');                               //                             3
        }
        private void Number4Button(object sender, EventArgs e)
        {
            NumberButtonPressed('4');                                   //                         4
        }

        private void Number5Button(object sender, EventArgs e)
        {
            NumberButtonPressed('5');                                  //                           5
        }

        private void Number6Button(object sender, EventArgs e)
        {
            NumberButtonPressed('6');                         //                                   6
        }

        private void Number7Button(object sender, EventArgs e)
        {
            NumberButtonPressed('7');                       //                                      7
        }

        private void Number8Button(object sender, EventArgs e)
        {
            NumberButtonPressed('8');                         //                                    8
        }

        private void Number9Button(object sender, EventArgs e)
        {
            NumberButtonPressed('9');                              //                                 9
        }



        private void DotButton(object sender, EventArgs e)
        {
            NumberButtonPressed('.');                //                                             .

        }

        private void PlusButton(object sender, EventArgs e) //                              +
        {
            OperatorButtonPressed('+', "plusButton");
        }

        private void SubtractButton(object sender, EventArgs e)  //                       -
        {
            OperatorButtonPressed('-', "subtractButton");
        }

        private void MultipleButton(object sender, EventArgs e) //                         x
        {
            OperatorButtonPressed('x', "multipleButton");
        }

        private void DivisionButton(object sender, EventArgs e) //                         /
        {
            OperatorButtonPressed('/', "divisionButton");
        }


        private void ResultButton(object sender, EventArgs e)  //                          =
        {
            calculator.AddNumberToListCollector(calculator.PrintAllCharToDisplay());    //add second number to collector list

            if (buttonOperator["subtractButton"])
            {
                display.Text = calculator.Subtract();
            }
            else if (buttonOperator["plusButton"])
            {
                display.Text = calculator.Addition();
            }
            else if (buttonOperator["multipleButton"])
            {
                display.Text = calculator.Multiple();
            }
            else if (buttonOperator["divisionButton"])
            {
                display.Text = calculator.Division();
            }
        }

        private void ClearButton(object sender, EventArgs e)
        {
            calculator.ClearCharList();
            calculator.ClearCollectorList();
            display.Text = "0";
            buttonOperator.Keys.ToList().ForEach(key => buttonOperator[key] = false);
        }

        private void NumberButtonPressed(char c)
        {
            display.Text = c.ToString();
            calculator.AddCharToList(c);
            display.Text = calculator.PrintAllCharToDisplay();
        }
        private void OperatorButtonPressed(char c, string operatorButton)
        {
            display.Text = c.ToString();
            calculator.AddNumberToListCollector(calculator.PrintAllCharToDisplay());
            calculator.ClearCharList();
            buttonOperator[operatorButton] = true;
        }
    }
}
