namespace Practice23.Task3
{
    public partial class StudentEditForm : Form
    {
        public STUDENT Student { get; private set; }

        public StudentEditForm()
        {
            InitializeComponent();
            Student = new STUDENT();
        }

        public StudentEditForm(STUDENT studentToEdit) : this()
        {
            Student = studentToEdit;
            txtFullName.Text = Student.FullName;
            txtGroupNumber.Text = Student.GroupNumber;

            for (int i = 0; i < Student.Grades.Length && i < 5; i++)
            {
                var gradeTextBox = Controls.Find($"txtGrade{i + 1}", true).FirstOrDefault() as TextBox;
                if (gradeTextBox != null)
                {
                    gradeTextBox.Text = Student.Grades[i].ToString();
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            Student.FullName = txtFullName.Text.Trim();
            Student.GroupNumber = txtGroupNumber.Text.Trim();

            for (int i = 0; i < 5; i++)
            {
                if (int.TryParse(Controls.Find($"txtGrade{i + 1}", true).FirstOrDefault()?.Text, out int grade))
                {
                    Student.Grades[i] = grade;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGroupNumber.Text))
            {
                MessageBox.Show("Введите номер группы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 1; i <= 5; i++)
            {
                var gradeTextBox = Controls.Find($"txtGrade{i}", true).FirstOrDefault() as TextBox;
                if (gradeTextBox == null || !int.TryParse(gradeTextBox.Text, out int grade) || grade < 2 || grade > 5)
                {
                    MessageBox.Show($"Введите корректную оценку (2-5) для оценки {i}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}