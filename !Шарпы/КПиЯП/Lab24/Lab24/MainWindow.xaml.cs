using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab24_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Логика изменения видимости кнопок
            switch (clickedButton.Name)
            {
                case "Button1":
                    ToggleVisibility(Button2);
                    ToggleVisibility(Button3);
                    break;
                case "Button2":
                    ToggleVisibility(Button1);
                    ToggleVisibility(Button4);
                    break;
                case "Button3":
                    ToggleVisibility(Button5);
                    break;
                case "Button4":
                    ToggleVisibility(Button2);
                    ToggleVisibility(Button5);
                    ToggleVisibility(Button4);
                    break;
                case "Button5":
                    ToggleVisibility(Button5);
                    break;
            }

            if (Button1.Visibility == Visibility.Hidden &&
                Button2.Visibility == Visibility.Hidden &&
                Button3.Visibility == Visibility.Hidden &&
                Button4.Visibility == Visibility.Hidden &&
                Button5.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("оу ес! все кнопки скрыты.");
            }
        }

        private void ToggleVisibility(Button button)
        {
            button.Visibility = button.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
