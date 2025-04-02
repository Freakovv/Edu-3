namespace Task22_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtNumbers.Text;
            int evenCount = 0;

            string[] numbers = input.Split(' ');

            foreach (string numStr in numbers)
            {
                if (string.IsNullOrEmpty(numStr))
                    continue;

                if (int.TryParse(numStr, out int number) && number % 2 == 0)
                {
                    evenCount++;
                }
            }

            lblResult.Text = $"Чётных чисел: {evenCount}";
        }
    }
}
