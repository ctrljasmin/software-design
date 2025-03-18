namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        public int RecursiveFibonacci(int n)
        {
            if (n <= 1) return n;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        public int RecursivePower(int x, int n)
        {
            if (n == 0) return 1;
            return x * RecursivePower(x, n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int number;
            if (int.TryParse(txtInput.Text, out number))
            {
                int result = RecursiveFactorial(number);
                lblResult.Text = $"Factorial: {result}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArrayInput.Text))
            {
                MessageBox.Show("Please enter an array of numbers separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
                int result = RecursiveSum(numbers, numbers.Length - 1);
                lblSumResult.Text = $"Sum: {result}";
            }
            catch
            {
                MessageBox.Show("Invalid input. Please enter a valid array of numbers separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFibonacciInput.Text))
            {
                MessageBox.Show("Please enter a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int number;
            if (int.TryParse(txtFibonacciInput.Text, out number))
            {
                int result = RecursiveFibonacci(number);
                lblFibonacciResult.Text = $"Fibonacci: {result}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaseInput.Text) || string.IsNullOrWhiteSpace(txtExponentInput.Text))
            {
                MessageBox.Show("Please enter both the base and exponent.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int baseNumber, exponent;
            if (int.TryParse(txtBaseInput.Text, out baseNumber) && int.TryParse(txtExponentInput.Text, out exponent))
            {
                int result = RecursivePower(baseNumber, exponent);
                lblPowerResult.Text = $"Power: {result}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers for both the base and exponent.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
