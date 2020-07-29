using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace Red_greenScreenChangeButton
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Background == Brushes.Red)
            {

                power.Margin = new Thickness(150, 0, 0, 0);
                (sender as Button).Background = Brushes.Green;
                this.SizeToContent = SizeToContent.Manual;
                this.WindowState = WindowState.Maximized;
                this.Width = 1920;
                this.Height = 1080;
            }

            else
            {
                this.WindowState = WindowState.Normal;
                power.Margin = new Thickness(-150, 0, 0, 0);
                (sender as Button).Background = Brushes.Red;
                this.SizeToContent = SizeToContent.WidthAndHeight;
            }
        }
    }
}