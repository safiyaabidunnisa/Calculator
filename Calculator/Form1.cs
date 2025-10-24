namespace Calculator
{
    public partial class form_calculator : Form
    {
        int firstNumber, secondNumber, result;
        public form_calculator()
        {
            InitializeComponent();
        }

        /*Commenting out the Basic way of performing Operation
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
        */

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text != string.Empty)
            {
                textBox_number.Text = "";
            }
            //if (textBox_secondNumber.Text != string.Empty)
            //{
            //    textBox_secondNumber.Text = "";
            //}
            //if (label_result.Text != "Final Result will appear here...")
            //{
            //    label_result.Text = "Final Result will appear here...";
            //}
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text != string.Empty)
            {
                int len = textBox_number.Text.Length;
                textBox_number.Text = textBox_number.Text.Remove(len - 1);
                len = textBox_number.Text.Length;
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            string text = textBox_number.Text;
            string[] addArray = text.Split('+');

            result = 0;
            for(int i=0;i<addArray.Length;i++)
            {
                result = result + int.Parse(addArray[i]);
            }
            textBox_number.Text = result.ToString();
        }
    }
}
