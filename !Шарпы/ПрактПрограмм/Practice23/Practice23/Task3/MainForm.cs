using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Practice23.Task3
{
        public partial class MainForm : Form
        {
            private BindingList<STUDENT> students = new BindingList<STUDENT>();
            private string currentFilePath = string.Empty;

            public MainForm()
            {
                InitializeComponent();
                SetupDataGridView();
                students.ListChanged += Students_ListChanged;
                dataGridView.DataSource = students;
                UpdateStatusBar();
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

            string[] gradeProps = { "Grade1", "Grade2", "Grade3", "Grade4", "Grade5" };
            for (int i = 0; i < 5; i++)
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = gradeProps[i],
                    HeaderText = $"Оценка {i + 1}",
                    Name = $"colGrade{i}",
                    Width = 60
                });
            }


            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "AverageGrade",
                    HeaderText = "Средний балл",
                    Name = "colAverage",
                    Width = 90
                });
            }

            private void Students_ListChanged(object sender, ListChangedEventArgs e)
            {
                UpdateStatusBar();
            }

            private void UpdateStatusBar()
            {
                toolStripStatusLabel.Text = $"Количество студентов: {students.Count}";
            }

            private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
            {
                using (var form = new StudentEditForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        students.Add(form.Student);
                    }
                }
            }

            private void редактироватьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (dataGridView.SelectedRows.Count == 0) return;

                var selectedStudent = dataGridView.SelectedRows[0].DataBoundItem as STUDENT;
                if (selectedStudent == null) return;

                using (var form = new StudentEditForm(selectedStudent))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int index = students.IndexOf(selectedStudent);
                        students[index] = form.Student;
                    }
                }
            }

            private void удалитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (dataGridView.SelectedRows.Count == 0) return;

                var selectedStudent = dataGridView.SelectedRows[0].DataBoundItem as STUDENT;
                if (selectedStudent != null)
                {
                    students.Remove(selectedStudent);
                }
            }

            private void сортировкаПоГруппеToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var sortedList = new BindingList<STUDENT>(students.OrderBy(s => s.GroupNumber).ToList());
                students = sortedList;
                dataGridView.DataSource = students;
            }

            private void сортировкаПоСреднемуБаллуToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var sortedList = new BindingList<STUDENT>(students.OrderByDescending(s => s.AverageGrade).ToList());
                students = sortedList;
                dataGridView.DataSource = students;
            }

            private void сортировкаПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var sortedList = new BindingList<STUDENT>(students.OrderBy(s => s.FullName).ToList());
                students = sortedList;
                dataGridView.DataSource = students;
            }

            private void поискПоГруппеToolStripMenuItem_Click(object sender, EventArgs e)
            {
                string groupNumber = Microsoft.VisualBasic.Interaction.InputBox(
                    "Введите номер группы для поиска:", "Поиск по группе", "");

                if (!string.IsNullOrEmpty(groupNumber))
                {
                    var filtered = students.Where(s => s.GroupNumber.Equals(groupNumber, StringComparison.OrdinalIgnoreCase)).ToList();
                    ShowSearchResults(filtered, $"Студенты группы {groupNumber}");
                }
            }

            private void поискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
            {
                string name = Microsoft.VisualBasic.Interaction.InputBox(
                    "Введите ФИО или часть ФИО для поиска:", "Поиск по ФИО", "");

                if (!string.IsNullOrEmpty(name))
                {
                    var filtered = students.Where(s => s.FullName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                    ShowSearchResults(filtered, $"Студенты по запросу '{name}'");
                }
            }

            private void отличникиToolStripMenuItem_Click(object sender, EventArgs e)
            {
                var excellentStudents = students.Where(s => s.AverageGrade > 4.0).ToList();

                if (excellentStudents.Count == 0)
                {
                    MessageBox.Show("Нет студентов со средним баллом выше 4.0", "Отличники",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowSearchResults(excellentStudents, "Студенты со средним баллом > 4.0");
                }
            }

            private void ShowSearchResults(List<STUDENT> results, string title)
            {
                using (var form = new SearchResultsForm(results, title))
                {
                    form.ShowDialog();
                }
            }

            private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    сохранитьКакToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    SaveToFile(currentFilePath);
                }
            }

            private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
            {
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*";
                    saveDialog.FilterIndex = 1;
                    saveDialog.RestoreDirectory = true;

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentFilePath = saveDialog.FileName;
                        SaveToFile(currentFilePath);
                    }
                }
            }

            private void SaveToFile(string filePath)
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(BindingList<STUDENT>));
                    using (var writer = new StreamWriter(filePath))
                    {
                        serializer.Serialize(writer, students);
                    }
                    MessageBox.Show("Данные успешно сохранены", "Сохранение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                using (var openDialog = new OpenFileDialog())
                {
                    openDialog.Filter = "XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*";
                    openDialog.FilterIndex = 1;
                    openDialog.RestoreDirectory = true;

                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var serializer = new XmlSerializer(typeof(BindingList<STUDENT>));
                            using (var reader = new StreamReader(openDialog.FileName))
                            {
                                var loadedStudents = (BindingList<STUDENT>)serializer.Deserialize(reader);
                                students = loadedStudents;
                                dataGridView.DataSource = students;
                                currentFilePath = openDialog.FileName;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            private void выходToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Программа для учета успеваемости студентов\n\nВерсия 1.0", "О программе",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    public class STUDENT
    {
        public string FullName { get; set; }
        public string GroupNumber { get; set; }
        public int[] Grades { get; set; } = new int[5];

        [XmlIgnore]
        public double AverageGrade => Grades.Length > 0 ? Grades.Average() : 0;

        public int Grade1 { get => Grades.Length > 0 ? Grades[0] : 0; set => Grades[0] = value; }
        public int Grade2 { get => Grades.Length > 1 ? Grades[1] : 0; set => Grades[1] = value; }
        public int Grade3 { get => Grades.Length > 2 ? Grades[2] : 0; set => Grades[2] = value; }
        public int Grade4 { get => Grades.Length > 3 ? Grades[3] : 0; set => Grades[3] = value; }
        public int Grade5 { get => Grades.Length > 4 ? Grades[4] : 0; set => Grades[4] = value; }

        public STUDENT() { }

        public STUDENT(string fullName, string groupNumber, int[] grades)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            Grades = grades;
        }
    }
}
