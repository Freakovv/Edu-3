using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practice23
{
    public partial class Task2 : Form
    {
        private Авто[] МД = new Авто[1000];
        private int КоличЭлем = 0;
        private bool isNewCar = false;

        // Список доступных цветов с их визуальным представлением
        private Dictionary<string, Color> colors = new Dictionary<string, Color>
        {
            {"Не выбран", Color.LightGray},
            {"Белый", Color.White},
            {"Красный", Color.Red},
            {"Синий", Color.Blue},
            {"Зеленый", Color.Green},
            {"Черный", Color.Black},
            {"Желтый", Color.Yellow},
            {"Серый", Color.Gray},
            {"Фиолетовый", Color.Purple}
        };

        public Task2()
        {
            InitializeComponent();
            InitializeData();
            ToggleDataFields(false);
        }

        private void InitializeData()
        {
            // Инициализация массива
            for (int i = 0; i < 1000; i++)
            {
                МД[i] = new Авто();
            }

            // Заполнение списка цветов
            foreach (var color in colors)
            {
                colorComboBox.Items.Add(color.Key);
            }
            colorComboBox.SelectedIndex = 0;
        }

        private void ToggleDataFields(bool visible)
        {
            labelModel.Visible = visible;
            textBoxModel.Visible = visible;
            labelColor.Visible = visible;
            colorComboBox.Visible = visible;
            labelOwner.Visible = visible;
            textBoxOwner.Visible = visible;
            buttonSave.Visible = visible;
            buttonCancel.Visible = visible;
            labelLicensePlate.Visible = visible;
            textBoxLicensePlate.Visible = visible;
        }

        private void ClearFields()
        {
            textBoxModel.Text = "";
            colorComboBox.SelectedIndex = 0;
            textBoxOwner.Text = "";
        }

        private void comboBoxLicensePlates_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (!string.IsNullOrWhiteSpace(comboBoxLicensePlates.Text))
                {
                    isNewCar = true;
                    textBoxLicensePlate.Text = comboBoxLicensePlates.Text;
                    ClearFields();
                    ToggleDataFields(true);
                    textBoxModel.Focus();
                }
            }
        }

        private void comboBoxLicensePlates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLicensePlates.SelectedIndex >= 0 && !isNewCar)
            {
                int index = comboBoxLicensePlates.SelectedIndex;
                textBoxLicensePlate.Text = МД[index].Госномер;
                textBoxModel.Text = МД[index].Модель;

                // Установка выбранного цвета
                int colorIndex = colorComboBox.FindStringExact(МД[index].Цвет);
                colorComboBox.SelectedIndex = colorIndex >= 0 ? colorIndex : 0;

                textBoxOwner.Text = МД[index].ФИО;
                ToggleDataFields(true);
            }
        }

        private void colorComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Отрисовка элементов списка цветов
            if (e.Index < 0) return;

            string colorName = colorComboBox.Items[e.Index].ToString();
            Color color = colors.ContainsKey(colorName) ? colors[colorName] : Color.LightGray;

            e.DrawBackground();

            // Рисуем прямоугольник с цветом
            Rectangle colorRect = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2,
                                              e.Bounds.Height - 4, e.Bounds.Height - 4);
            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, colorRect);
            }
            e.Graphics.DrawRectangle(Pens.Black, colorRect);

            // Рисуем текст
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(colorName, e.Font, textBrush,
                                     e.Bounds.X + colorRect.Width + 5, e.Bounds.Y);
            }

            e.DrawFocusRectangle();
        }

        private void colorComboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Устанавливаем высоту элементов списка
            e.ItemHeight = 20;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLicensePlate.Text))
            {
                MessageBox.Show("Введите государственный регистрационный номер!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedColor = colorComboBox.SelectedItem?.ToString() ?? "Не выбран";

            // Проверяем, существует ли уже автомобиль с таким номером
            int existingIndex = -1;
            for (int i = 0; i < КоличЭлем; i++)
            {
                if (МД[i].Госномер == textBoxLicensePlate.Text)
                {
                    existingIndex = i;
                    break;
                }
            }

            if (existingIndex >= 0)
            {
                // Обновляем существующую запись
                МД[existingIndex].Обновить(
                    textBoxLicensePlate.Text,
                    textBoxModel.Text,
                    selectedColor,
                    textBoxOwner.Text);
            }
            else
            {
                // Добавляем новую запись
                МД[КоличЭлем].Обновить(
                    textBoxLicensePlate.Text,
                    textBoxModel.Text,
                    selectedColor,
                    textBoxOwner.Text);
                КоличЭлем++;
            }

            // Обновляем список госномеров
            UpdateLicensePlatesList();

            // Сбрасываем состояние
            comboBoxLicensePlates.Text = "";
            ToggleDataFields(false);
            isNewCar = false;
        }

        private void UpdateLicensePlatesList()
        {
            comboBoxLicensePlates.Items.Clear();
            for (int i = 0; i < КоличЭлем; i++)
            {
                comboBoxLicensePlates.Items.Add(МД[i].Госномер);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            comboBoxLicensePlates.Text = "";
            ToggleDataFields(false);
            isNewCar = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxLicensePlates.SelectedIndex >= 0)
            {
                int index = comboBoxLicensePlates.SelectedIndex;

                // Удаляем элемент из массива
                for (int i = index; i < КоличЭлем - 1; i++)
                {
                    МД[i] = МД[i + 1];
                }
                КоличЭлем--;

                // Удаляем из списка
                comboBoxLicensePlates.Items.RemoveAt(index);
                ClearFields();
                ToggleDataFields(false);

                if (comboBoxLicensePlates.Items.Count > 0)
                {
                    comboBoxLicensePlates.SelectedIndex = Math.Min(index, comboBoxLicensePlates.Items.Count - 1);
                }
            }
        }
    }

    public class Авто
    {
        public string Госномер { get; private set; }
        public string Модель { get; private set; }
        public string Цвет { get; private set; }
        public string ФИО { get; private set; }

        public Авто()
        {
            Госномер = "";
            Модель = "";
            Цвет = "";
            ФИО = "";
        }

        public void Обновить(string госномер, string модель, string цвет, string фио)
        {
            Госномер = госномер;
            Модель = модель;
            Цвет = цвет;
            ФИО = фио;
        }

        // Свойства для доступа к полям
        public string Мод { get { return Модель; } }
        public string Цв { get { return Цвет; } }
        public string Фио { get { return ФИО; } }
    }
}