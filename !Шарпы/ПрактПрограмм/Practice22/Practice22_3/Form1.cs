namespace Practice22_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double x0);
            double.TryParse(textBox2.Text, out double xk);
            double.TryParse(textBox3.Text, out double dx);
            double.TryParse(textBox4.Text, out double b);
            
            txtResults.Clear();

            txtResults.AppendText(" x\t\t y(x)\n");
            txtResults.AppendText("----------------------------\n");

            for (double x = x0; x <= xk; x += dx)
            {
                try
                {
                    double bb = Math.Pow(b, b);
                    double xPow = Math.Pow(x, bb);

                    double xPart = Math.Pow(x, 1.5);     
                    double bPart = Math.Pow(b, 0.75);    
                    double cosArg = xPart + bPart;

                    double y = xPow + Math.Cos(cosArg);

                    txtResults.AppendText($"{x:F2}\t\t{y:F2}\n");
                }
                catch (Exception ex)
                {
                    txtResults.AppendText($"{x:F2}\t\tÎøèáêà: {ex.Message}\n");
                }
            }
        }
    }
}
