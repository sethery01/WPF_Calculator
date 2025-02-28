using System;
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
using System.Diagnostics;
using System.Data;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // C button
        private void clearOnClick(object sender, RoutedEventArgs e)
        {
            tb.Text = string.Empty;
        }

        // Calculate squareroot
        private void sqrtOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                tb.Text = (Math.Sqrt(float.Parse(tb.Text))).ToString();
            }
            catch
            {
                tb.Text = string.Empty;
            }
        }

        // Helper using recursion to calc factorial
        private int factorial(int number)
        {
            // Base case
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);
            }
        }

        // Calculate factorial of ints
        private void factOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Int32.Parse(tb.Text);
                tb.Text = factorial(n).ToString();
            }
            catch
            {
                tb.Text = "";
            }

        }

        // Handles = button
        private void evaluateOnClick(object sender, RoutedEventArgs e)
        {
            // Found here: https://stackoverflow.com/questions/333737/evaluating-string-342-yield-int-18
            DataTable dt = new DataTable();
            var v = dt.Compute(tb.Text,"");
            tb.Text = v.ToString();
        }

        // Handles string manipulating buttons
        private void addCharOnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            tb.Text += button.Content.ToString();
        }
    }
}