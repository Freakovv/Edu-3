using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task22_6
{
    public partial class MainForm : Form
    {
        private int[,] matrix15x15 = new int[15, 15];
        private int[,] matrix3x4 = new int[3, 4];
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }


        // Заполнение матрицы 3x4 случайными числами
        private void Fill3x4Matrix()
        {
            dataGridView3x4.Rows.Clear();
            dataGridView3x4.Columns.Clear();

            // Настройка datagrid
            dataGridView3x4.ColumnCount = 4;
            for (int i = 0; i < 3; i++)
            {
                dataGridView3x4.Rows.Add();
            }

            // Заполнение матрицы
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix3x4[i, j] = random.Next(1, 100);
                    dataGridView3x4.Rows[i].Cells[j].Value = matrix3x4[i, j];
                }
            }
        }

        // Поиск минимальных элементов в строках матрицы 3x4
        private int[] FindMinInRows()
        {
            int[] mins = new int[3];
            for (int i = 0; i < 3; i++)
            {
                mins[i] = matrix3x4[i, 0];
                for (int j = 1; j < 4; j++)
                {
                    if (matrix3x4[i, j] < mins[i])
                    {
                        mins[i] = matrix3x4[i, j];
                    }
                }
            }
            return mins;
        }


        private void btnFill3x4_Click(object sender, EventArgs e)
        {
            Fill3x4Matrix();
        }

        private void btnFindMinRows_Click(object sender, EventArgs e)
        {
            if (dataGridView3x4.Rows.Count == 0)
            {
                MessageBox.Show("Сначала заполните матрицу!");
                return;
            }

            int[] mins = FindMinInRows();
            txtResult3x4.Text = "Минимальные элементы в строках:\r\n";
            for (int i = 0; i < 3; i++)
            {
                txtResult3x4.Text += $"Строка {i + 1}: {mins[i]}\r\n";
            }
        }
    }
}
