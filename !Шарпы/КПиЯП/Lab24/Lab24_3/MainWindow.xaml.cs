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

namespace Lab24_3
{
    public partial class MainWindow : Window
    {
        private readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            if (ResizableLabel.Width > this.Width)
            {
                MessageBox.Show("Label вышел за пределы окна!");
                return;
            }
            int change = random.Next(20, 100); // от 20 до 100
            ResizableLabel.Width += change;

            CheckBounds();
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            int change = random.Next(20, 100);

            if (ResizableLabel.Width - change <= 1) 
            {
                ResizableLabel.Width = 1;
                MessageBox.Show("Максимально минимальный размер достигнут", "Внимание");
                return;
            }

            ResizableLabel.Width -= change;
            CheckBounds();
        }


        private void CheckBounds()
        {
            if (ResizableLabel.Width <= 0)
            {
                ResizableLabel.Visibility = Visibility.Hidden;
            }
            else
            {
                ResizableLabel.Visibility = Visibility.Visible;
            }
        }
    }
}