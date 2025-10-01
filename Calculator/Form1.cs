namespace Calculator
{
    public partial class form_calculator : Form
    {
        public form_calculator()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBox_firstNumber.Text);
            int secondNumber = int.Parse(textBox_secondNumber.Text);
            int sum = firstNumber + secondNumber;
            textBox_finalResult.Text = sum.ToString();
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBox_firstNumber.Text);
            int secondNumber = int.Parse(textBox_secondNumber.Text);
            int diff = firstNumber - secondNumber;
            textBox_finalResult.Text = diff.ToString();
        }
    }
}
