using System;
using System.Printing;
using System.Windows;

namespace Lab24_2
{
        public partial class ConverterWindow : Window
        {
            public ConverterWindow()
            {
                InitializeComponent();
            }

            private void Do_Click(object sender, RoutedEventArgs e)
            {
                if (!int.TryParse(InputBox.Text, out int number))
                {
                    ResultLabel.Content = "Ошибка: введите число!";
                    return;
                }

                if (BinaryRadio.IsChecked == true)
                    ResultLabel.Content = $"Результат: {Convert.ToString(number, 2)}";
                else if (OctalRadio.IsChecked == true)
                    ResultLabel.Content = $"Результат: {Convert.ToString(number, 8)}";
                else if (HexRadio.IsChecked == true)
                    ResultLabel.Content = $"Результат: {Convert.ToString(number, 16).ToUpper()}";
                else
                    ResultLabel.Content = "Выберите систему!";
            }

            private void OK_Click(object sender, RoutedEventArgs e)
            {
                Close();
            }
        }
}
