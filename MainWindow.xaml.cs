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

namespace Prog122_S24_L2_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // William Cram
        // 4.8.24
        public MainWindow()
        {
            InitializeComponent();

            string userFirstName = txtFirstName.Text;

            // Message Box
            //MessageBox.Show(userFirstName);

        }

        private void btnPopUpMessage_Click(object sender, RoutedEventArgs e)
        {
            string userFirstName = txtFirstName.Text;

            int a = 5;
            int b = 5;
            int sum = a + b;

            MessageBox.Show(sum.ToString());
        }

        private void btnAddNumbers_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int sum = a + b;

            MessageBox.Show(sum.ToString());
        }
    }
}