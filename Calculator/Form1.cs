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
            textBox_finalResult.Text = result.ToString();
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(textBox_firstNumber.Text);
            secondNumber = int.Parse(textBox_secondNumber.Text);
            result = firstNumber - secondNumber;
            textBox_finalResult.Text = result.ToString();
        }
    }
}
