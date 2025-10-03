namespace Calculator
{
    public partial class form_calculator : Form
    {
        int firstNumber, secondNumber, result;
        public form_calculator()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(textBox_firstNumber.Text);
            secondNumber = int.Parse(textBox_secondNumber.Text);
            result = firstNumber + secondNumber;
            label_result.Text = result.ToString();
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(textBox_firstNumber.Text);
            secondNumber = int.Parse(textBox_secondNumber.Text);
            result = firstNumber - secondNumber;
            label_result.Text = result.ToString();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox_firstNumber.Text);
            secondNumber = Convert.ToInt32(textBox_secondNumber.Text);
            result = firstNumber * secondNumber;
            label_result.Text = result.ToString();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox_firstNumber.Text);
            secondNumber = Convert.ToInt32(textBox_secondNumber.Text);
            result = firstNumber / secondNumber;
            label_result.Text = result.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (textBox_firstNumber.Text != string.Empty)
            {
                textBox_firstNumber.Text = "";
            }
            if (textBox_secondNumber.Text != string.Empty)
            {
                textBox_secondNumber.Text = "";
            }
            if (label_result.Text != "Final Result will appear here...")
            {
                label_result.Text = "Final Result will appear here...";
            }
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if(textBox_firstNumber.Text != string.Empty)
            {
                int len = textBox_firstNumber.Text.Length;
                textBox_firstNumber.Text = textBox_firstNumber.Text.Remove(len - 1);
                len = textBox_firstNumber.Text.Length;
            }
        }
    }
}
