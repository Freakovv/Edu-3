using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab24_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Begin_Click(object sender, RoutedEventArgs e)
        {
            ConverterWindow converter = new ConverterWindow();
            converter.ShowDialog();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Михаил Симанович\nУчебная группа: Т-295\nWPF-приложение для преобразования чисел", "About");
        }
    }
}