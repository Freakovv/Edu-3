using Practice23.Task3;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practice23.Task3
{
    public partial class SearchResultsForm : Form
    {
        public SearchResultsForm(List<STUDENT> results, string title)
        {
            InitializeComponent();
            Text = title;
            SetupDataGridView();
            dataGridView.DataSource = results;
            lblResultsCount.Text = $"Найдено: {results.Count}";
        }

        private void SetupDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FullName",
                HeaderText = "ФИО",
                Name = "colFullName",
                Width = 150
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "GroupNumber",
                HeaderText = "Группа",
                Name = "colGroupNumber",
                Width = 80
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AverageGrade",
                HeaderText = "Средний балл",
                Name = "colAverage",
                Width = 90
            });
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}