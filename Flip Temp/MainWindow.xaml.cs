using Flip_Temp.ViewModels;
using System.Windows;

namespace Flip_Temp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel viewModel = new MainWindowViewModel();
            DataContext = viewModel;

            UserInputTextBox.Focus();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if(SelectionArrowTextBlockCelsiusToFarenheit.Visibility == Visibility.Visible)
            {
                SelectionArrowTextBlockCelsiusToFarenheit.Visibility = Visibility.Collapsed;
                SelectionArrowTextBlockFarenheitToCelsius.Visibility = Visibility.Visible;
            }
            else
            {
                SelectionArrowTextBlockCelsiusToFarenheit.Visibility = Visibility.Visible;
                SelectionArrowTextBlockFarenheitToCelsius.Visibility = Visibility.Collapsed;
            }
        }
    }
}