using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Title = "Window 1",
                Width = 300,
                Height = 200,
                Content = new TextBlock { Text = "This is Window 1", FontSize = 20 }
            };
            window.Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Title = "Window 2",
                Width = 200,
                Height = 100,
                Content = new TextBlock { Text = "This is Window 2", FontSize = 15 }
            };
            window.Show();
        }
private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Title = "Window 3",
                Width = 300,
                Height = 200,
                Content = new TextBlock { Text = "This is Window 3", FontSize = 20 }
            };
            window.Show();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Title = "Window 4",
                Width = 200,
                Height = 100,
                Content = new TextBlock { Text = "This is Window 4", FontSize = 15 }
            };
            window.Show();
        }
    }
}