using System;
using System.Windows;
using System.Windows.Controls;

namespace pz25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(FirstNumberTextBox.Text, out double firstNumber) ||
                !double.TryParse(SecondNumberTextBox.Text, out double secondNumber))
            {
                ((Button)sender).Content = "er37or";
                return;
            }

            double result = firstNumber + secondNumber;
            ((Button)sender).Content = result;
        }
    }
}
