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

namespace test_wpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = txtKyTu.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Nooo lapolizi","Loi",MessageBoxButton.OK);
            }
            StringBuilder result = new StringBuilder();
            foreach (char character in input)
            {
                int asciiValue = (int)character;
                result.Append(asciiValue);
                result.Append(" ");
            }
            string output = result.ToString().Trim();
            txtSo.Text = output;
        }
    }
}