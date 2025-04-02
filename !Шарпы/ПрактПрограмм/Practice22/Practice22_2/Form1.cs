namespace Practice22_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateFx(double x, string functionType)
        {
            switch (functionType)
            {
                case "sh(x)": return Math.Sinh(x);
                case "x^2": return x * x;
                case "e^x": return Math.Exp(x);
                default: throw new ArgumentException("Неизвестная функция");
            }
        }

        private double CalculateGx(double x, double b, string functionType)
        {
            double fx = CalculateFx(x, functionType);
            double xb = x * b;

            if (xb > 0.5 && xb < 10)
            {
                return Math.Exp(fx - Math.Abs(b));
            }
            else if (xb > 0.1 && xb < 0.5)
            {
                return Math.Sqrt(Math.Abs(fx + b));  
            }
            else
            {
                return 2 * Math.Pow(fx, 2); 
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double b = double.Parse(textBoxB.Text);

                string functionType = "sh(x)";

                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        functionType = radioButton.Text;
                        break;
                    }
                }

                double result = CalculateGx(x, b, functionType);

                textBoxResult.Text += $"x = {x}\nb = {b}\n";
                textBoxResult.Text += $"\ng(x) = {result:F4}\n\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
            textBoxResult.Clear();
        }
    }
}
