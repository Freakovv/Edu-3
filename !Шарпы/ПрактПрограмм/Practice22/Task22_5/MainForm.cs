namespace Task22_5
{
    public partial class MainForm : Form
    {
        private int[] Mas = new int[10]; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFillArray_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            txtOriginalArray.Clear();

            for (int i = 0; i < 10; i++)
            {
                Mas[i] = rand.Next(-9, 10);
                txtOriginalArray.AppendText($"Mas[{i}] = {Mas[i]}{Environment.NewLine}");
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            bool foundNegative = false;
            int product = 1;
            int firstNegativeIndex = -1;

            for (int i = 0; i < 10; i++)
            {
                if (Mas[i] < 0)
                {
                    firstNegativeIndex = i;
                    foundNegative = true;
                    break;
                }
            }

            if (!foundNegative)
            {
                txtResult.Text = "Отрицательных элементов не найдено!";
                return;
            }

            for (int i = firstNegativeIndex + 1; i < 10; i++)
            {
                product *= Mas[i];
            }

            txtResult.AppendText($"Первый отрицательный элемент: Mas[{firstNegativeIndex}] = {Mas[firstNegativeIndex]}{Environment.NewLine}");
            txtResult.AppendText($"Произведение последующих элементов: {product}{Environment.NewLine}");
        }
    }
}
