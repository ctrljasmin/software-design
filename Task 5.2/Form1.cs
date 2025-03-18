namespace Task_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class DescendingSorter
        {
            public int[] Sort(int[] numbers)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
                return numbers;
            }
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            DescendingSorter sorter = new DescendingSorter();
            int[] sortedNumbers = sorter.Sort(numbers);
            listBoxResults.DataSource = sortedNumbers;

        }
    }
}
