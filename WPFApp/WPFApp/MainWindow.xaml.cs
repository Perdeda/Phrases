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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string textToShow = "XDD";
        ViewModel viewModel;
        public MainWindow()
        {
            viewModel = new ViewModel();
            DataContext = viewModel;
            Console.WriteLine("1");
            GrpcClient.Instance();
            Console.WriteLine("2");
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            GrpcClient.Instance().AddPhrase(viewModel.CurrPackage);
            MessageBox.Show(viewModel.CurrPackage.Phrase,"Message",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}