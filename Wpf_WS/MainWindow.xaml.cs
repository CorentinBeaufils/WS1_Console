using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
