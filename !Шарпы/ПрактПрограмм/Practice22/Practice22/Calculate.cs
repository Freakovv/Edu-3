using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice22
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateB();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalculateB();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateB();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CalculateB();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateB();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateB();
        }

        private void CalculateB()
        {
            if (
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) || 
                string.IsNullOrWhiteSpace(textBox3.Text)
                )
            {
                textBox5.Text = "Введите все переменные";
                return;
            }

            if (!double.TryParse(textBox1.Text, out double x) ||
                !double.TryParse(textBox2.Text, out double y) ||
                !double.TryParse(textBox3.Text, out double z))
            {
                textBox5.Text = "Ошибка: введите числа во все поля";
                return;
            }

            if (z < -1 || z > 1)
            {
                textBox5.Text = "z должен быть от -1 до 1";
                return;
            }

            if (checkBox1.Checked) y = Math.Pow(x, -3);

            double B = (Math.Sqrt(10*(Math.Pow(x, 1.0/3)+Math.Pow(x, y+2))))*(Math.Pow(Math.Asin(z), 2) - Math.Abs(x-y));

            textBox5.Text = Convert.ToString(B);
        }

        private void Calculate_Load(object sender, EventArgs e)
        {
            CalculateB();
        }
    }
}
