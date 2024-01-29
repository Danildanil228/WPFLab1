using System;
using System.Numerics;
using System.Windows;

namespace NumberConversionApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = inputTextBox.Text;

            if (int.TryParse(inputText, out int inputNumber))
            {
                DecimalNumber decimalNumber = new DecimalNumber(inputNumber);
                BinaryNumber binaryNumber = new BinaryNumber(inputNumber);

                decimalResultTextBox.Text = decimalNumber.ToString();
                binaryResultTextBox.Text = binaryNumber.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }
    }
}
