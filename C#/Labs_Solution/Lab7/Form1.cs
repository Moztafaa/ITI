namespace Lab7;

public partial class Form1 : Form
{
    // calculator
    string currentInput = "";
    double result = 0;
    private string operation = "";
    private bool operationPending = false;

    public Form1()
    {
        InitializeComponent();
    }

    private void button12_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button12_Click_1(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void button17_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button6_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button5_Click_1(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;

    }

    private void button4_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button9_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button8_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void button7_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        currentInput += button.Text;
        textBox1.Text = currentInput;
    }

    private void Calculate()
    {
        if (operationPending)
        {
            if (double.TryParse(currentInput, out var inputNumber))
            {
                switch (operation)
                {
                    case "+":
                        result += inputNumber;
                        break;
                    case "-":
                        result -= inputNumber;
                        break;
                    case "*":
                        result *= inputNumber;
                        break;
                    case "/":
                        if (inputNumber != 0)
                            result /= inputNumber;
                        else
                            MessageBox.Show("Cannot divide by zero");
                        break;
                }
                textBox1.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }

    private void button16_Click(object sender, EventArgs e)
    {
        if (operationPending)
        {
            Calculate();
        }
        Button button = (Button)sender;
        operation = button.Text;
        result = double.TryParse(currentInput, out var inputNumber) ? inputNumber : 0;
        currentInput = "";
        operationPending = true;
    }

    private void button10_Click(object sender, EventArgs e)
    {
        if (operationPending)
        {
            Calculate();
        }
        Button button = (Button)sender;
        operation = button.Text;
        result = double.TryParse(currentInput, out var inputNumber) ? inputNumber : 0;
        currentInput = "";
        operationPending = true;

    }

    private void button12_Click_2(object sender, EventArgs e)
    {
        if (operationPending)
        {
            Calculate();
        }
        Button button = (Button)sender;
        operation = button.Text;
        result = double.TryParse(currentInput, out var inputNumber) ? inputNumber : 0;
        currentInput = "";
        operationPending = true;

    }

    private void button11_Click(object sender, EventArgs e)
    {
        if (operationPending)
        {
            Calculate();
        }
        Button button = (Button)sender;
        operation = button.Text;
        result = double.TryParse(currentInput, out var inputNumber) ? inputNumber : 0;
        currentInput = "";
        operationPending = true;

    }

    private void button13_Click(object sender, EventArgs e)
    {
        // clear button
        currentInput = "";
        result = 0;
        operation = "";
        operationPending = false;
        textBox1.Text = "";
    }

    private void button18_Click(object sender, EventArgs e)
    {
        Calculate();
    }

    private void button14_Click(object sender, EventArgs e)
    {
        // . button
        if (!currentInput.Contains("."))
        {
            currentInput += ".";
            textBox1.Text = currentInput;
        }
        
    }
}
