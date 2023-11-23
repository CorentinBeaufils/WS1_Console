using System.Windows;

namespace Wpf_WS
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            DataContext = _viewModel;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Logique à exécuter lorsque le bouton est cliqué
            _viewModel.BlockText = Controleur.TraiterLadonnee(_viewModel.InputText);
        }



    }
}
